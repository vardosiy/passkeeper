using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Passkeeper.Model.Entities;
using Passkeeper.View.Forms;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class ApplicationPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		private IApplicationForm m_form;
		private Model.Model m_model;

		//---------------------------------------------------------------------

		public ApplicationPresenter( IApplicationForm _form, Model.Model _model )
		{
			m_form = _form;
			m_model = _model;

			m_form.Load += Form_Load;

			m_form.AddAccountButton_Clicked += AddAccountButton_Clicked;
			m_form.RemoveResourceButton_Clicked += RemoveResourceButton_Clicked;
			m_form.SelectedResourceChanged += SelectedResourceChanged;

			m_form.AddResourceButton_Clicked += AddResourceButton_Clicked;
			m_form.EditAccountButton_Clicked += EditAccountButton_Clicked;
			m_form.RemoveAccount_Clicked += RemoveAccount_Clicked;

			m_form.ShowAccountHistory_Clicked += ShowAccountHistory_Clicked;
			m_form.DeleteAccountHistory_Clicked += DeleteAccountHistory_Clicked;
		}

		public void Run()
		{
			m_form.ShowDialog();
		}

		//---------------------------------------------------------------------

		private void Form_Load( object _sender, EventArgs _e )
		{
			SignInPresenter presenter = new SignInPresenter(
					new SignInForm()
				,	m_model.UserManager
			);

			presenter.Run();

			if ( m_model.UserManager.CurrentUser == null )
				m_form.Close();

			m_model.LoadData();
			m_model.DataContainer.BindTo( m_form.ResourcesList );
		}

		//---------------------------------------------------------------------

		private void AddResourceButton_Clicked( object _sender, EventArgs _e )
		{
			AddResourcePresenter presetner = new AddResourcePresenter( m_model, new AddResourceForm() );
			presetner.Run();

			m_model.DataContainer.BindTo( m_form.ResourcesList );
		}

		private void RemoveResourceButton_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
				"Are you sure, you want to remove data about all accounts asociated with this resource?"
			);

			if ( result != DialogResult.OK )
				return;

			m_model.DataContainer.RemoveResource( m_form.SelectedResource as Resource );
		}

		private void SelectedResourceChanged( object _sender, EventArgs _e )
		{
			if ( m_form.SelectedResource == null )
				return;

			Resource selectedResource = m_form.SelectedResource as Resource;
			selectedResource.BindTo( m_form.AccountsList );

			if ( selectedResource.AccountsCount > 0 )
				m_form.AccountsList.SelectedIndex = 0;
			else
				m_form.AccountsList.Text = string.Empty;
		}

		//---------------------------------------------------------------------

		private void AddAccountButton_Clicked( object _sender, EventArgs _e )
		{
			AddAccountPresetner presetner = new AddAccountPresetner(
					m_form.SelectedResource as Resource
				,	new AddAccountForm()
			);

			presetner.Run();
		}

		private void EditAccountButton_Clicked( object _sender, EventArgs _e )
		{
			Account selectedAccount = m_form.SelectedAccount as Account;
			Account nonchanged = new Account( selectedAccount );
			EditAccountForm form = new EditAccountForm(
					selectedAccount.Email
				,	selectedAccount.Login
				,	selectedAccount.Password
			);

			EditAccountPresenter presenter = new EditAccountPresenter( selectedAccount, form );

			presenter.Run();

			if (	selectedAccount.Email != nonchanged.Email
				||	selectedAccount.Login != nonchanged.Login
				||	selectedAccount.Password != nonchanged.Password
			)
			{
				Resource selectedResource = m_form.SelectedResource as Resource;
				selectedResource.AddAccountHistoryRecord(
					new HistoryRecord( nonchanged, DateTime.Now )
				);
			}
		}

		private void RemoveAccount_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
				"Are you sure, you want to remove data about all accounts asociated with this resource?"
			);

			if ( result != DialogResult.OK )
				return;

			Resource selectedResource = m_form.SelectedResource as Resource;
			selectedResource.RemoveAccount( m_form.SelectedAccount as Account );
		}

		//---------------------------------------------------------------------

		private void ShowAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			Account selectedAccount = m_form.SelectedAccount as Account;
			Resource selectedResource = m_form.SelectedResource as Resource;

			AccountHistoryPresenter presenter = new AccountHistoryPresenter(
					new AccountHistoryForm()
				,	selectedResource.GetAccountHistory( selectedAccount )
			);

			presenter.Run();
		}

		private void DeleteAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
					"Are you sure, you want to clear history for this account?"
			);

			if ( result != DialogResult.OK )
				return;

			Account selectedAccount = m_form.SelectedAccount as Account;
			Resource selectedResource = m_form.SelectedResource as Resource;

			selectedResource.RemoveAccountHistory( selectedAccount );
		}

		//---------------------------------------------------------------------
	}
}
