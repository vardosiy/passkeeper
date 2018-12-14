using System;
using System.Windows.Forms;

using Passkeeper.Model.Entities;
using Passkeeper.View.Forms;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class ApplicationPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		readonly IApplicationForm m_form;
		Model.Model m_model;

		//---------------------------------------------------------------------

		public ApplicationPresenter( IApplicationForm _form, Model.Model _model )
		{
			m_form = _form;
			m_model = _model;

			m_form.Load += Form_Load;
			m_form.Closed += Form_Closed;

			m_form.AddAccountButton_Clicked += AddAccountButton_Clicked;
			m_form.RemoveResourceButton_Clicked += RemoveResourceButton_Clicked;
			m_form.SelectedResourceChanged += SelectedResourceChanged;

			m_form.AddResourceButton_Clicked += AddResourceButton_Clicked;
			m_form.EditAccountButton_Clicked += EditAccountButton_Clicked;
			m_form.RemoveAccount_Clicked += RemoveAccount_Clicked;
			m_form.SelectedAccountChanged += SelectedAccountChanged;

			m_form.ShowAccountHistory_Clicked += ShowAccountHistory_Clicked;
			m_form.DeleteAccountHistory_Clicked += DeleteAccountHistory_Clicked;
			m_form.SettingsButton_Clicked += SettingsButton_Clicked;
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
			{
				m_form.Close();
				return;
			}

			m_model.LoadData();
			m_model.DataContainer.BindTo( m_form.ResourcesList );
		}

		private void Form_Closed( object sender, EventArgs e )
		{
			m_model.BackupManager.Run();
		}

		//---------------------------------------------------------------------

		private void AddResourceButton_Clicked( object _sender, EventArgs _e )
		{
			AddResourcePresenter presetner = new AddResourcePresenter( m_model, new AddResourceForm() );
			presetner.Run();
		}

		private void RemoveResourceButton_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = MessageUtils.ShowWarning(
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
			Resource selectedResource = m_form.SelectedResource as Resource;

			AddAccountPresetner presetner = new AddAccountPresetner(
					selectedResource
				,	new AddAccountForm()
			);

			presetner.Run();

			if ( selectedResource.AccountsCount == 1 )
				SelectedResourceChanged( null, EventArgs.Empty );
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
			DialogResult result = MessageUtils.ShowWarning(
				"Are you sure, you want to remove this accounts and it's history?"
			);

			if ( result != DialogResult.OK )
				return;

			Resource selectedResource = m_form.SelectedResource as Resource;
			selectedResource.RemoveAccount( m_form.SelectedAccount as Account );

			m_form.AccountsList.SelectedIndex = selectedResource.AccountsCount != 0 ? 0 : -1;
		}

		private void SelectedAccountChanged( object _sender, EventArgs _e )
		{
			if ( m_form.SelectedAccount is Account selectedAccount )
			{
				m_form.CurrentAccountEmail = selectedAccount.Email;
				m_form.CurrentAccountLogin = selectedAccount.Login;
				m_form.CurrentAccountPassword = selectedAccount.Password;
			}
			else
			{
				m_form.CurrentAccountEmail = string.Empty;
				m_form.CurrentAccountLogin = string.Empty;
				m_form.CurrentAccountPassword = string.Empty;
			}
		}

		//---------------------------------------------------------------------

		private void ShowAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			Account selectedAccount = m_form.SelectedAccount as Account;
			Resource selectedResource = m_form.SelectedResource as Resource;

			if ( selectedAccount == null )
				return;

			AccountHistoryPresenter presenter = new AccountHistoryPresenter(
					new AccountHistoryForm()
				,	selectedResource.GetAccountHistory( selectedAccount )
			);

			presenter.Run();
		}

		private void DeleteAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = MessageUtils.ShowWarning(
					"Are you sure, you want to clear history for this account?"
			);

			if ( result != DialogResult.OK )
				return;

			Account selectedAccount = m_form.SelectedAccount as Account;
			Resource selectedResource = m_form.SelectedResource as Resource;

			selectedResource.RemoveAccountHistory( selectedAccount );
		}

		private void SettingsButton_Clicked( object _sender, EventArgs _e )
		{
			SettingsPresenter presetner = new SettingsPresenter(
					m_model.UserManager
				,	m_model.BackupManager
				,	new SettingsForm()
			);

			presetner.Run();
		}

		//---------------------------------------------------------------------
	}
}
