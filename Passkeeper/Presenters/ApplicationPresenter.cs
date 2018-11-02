using System;
using System.Windows.Forms;

using Passkeeper.Model;
using Passkeeper.Model.Entities;
using Passkeeper.View.Forms;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class ApplicationPresenter : IPresenter
	{
		private Controller m_controller;
		private IApplicationForm m_form;
		
		public ApplicationPresenter(
				IApplicationForm _form
			,	Controller _controller
		)
		{
			m_controller = _controller;
			m_form = _form;

			m_form.Load += Form_Load;

			m_form.AddAccountButton_Clicked += AddAccountButton_Clicked;
			m_form.RemoveResourceButton_Clicked += RemoveResourceButton_Clicked;
			m_form.SelectedResourceChanged += SelectedResourceChanged;

			m_form.AddResourceButton_Clicked += AddResourceButton_Clicked;
			m_form.EditAccountButton_Clicked += EditAccountButton_Clicked;
			m_form.ShowAccountHistory_Clicked += ShowAccountHistory_Clicked;
			m_form.DeleteAccountHistory_Clicked += DeleteAccountHistory_Clicked;
			m_form.RemoveAccount_Clicked += RemoveAccount_Clicked;
		}

		public void Run()
		{
			m_form.ShowDialog();
		}

		private void Form_Load( object _sender, EventArgs _e )
		{
			LoginPresenter presenter = new LoginPresenter(
					new LoginForm()
				,	( _presenter ) =>
					{
						if ( !_presenter.LogedIn )
							m_form.Close();

						return true;
					}
			);

			presenter.Run();
		}

		private void AddResourceButton_Clicked( object _sender, EventArgs _e )
		{
			AddResourcePresenter presetner = new AddResourcePresenter( m_controller, new AddResourceForm() );
			presetner.Run();

			m_controller.BindTo( m_form.ResourcesList ); // TODO test once
		}

		private void RemoveResourceButton_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
				"Are you sure, you want to remove data about all accounts asociated with this resource?"
			);

			if ( result != DialogResult.OK )
				return;

			m_controller.RemoveResource( m_form.SelectedResource as Resource );
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
			EditAccountForm form = new EditAccountForm(
					selectedAccount.Email
				,	selectedAccount.Login
				,	selectedAccount.Password
			);
			EditAccountPresenter presenter = new EditAccountPresenter( selectedAccount, form );

			presenter.Run();
		}

		private void ShowAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			throw new NotImplementedException();
		}

		private void DeleteAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
				"Are you sure, you want to clear history for this account?"
			);

			if ( result != DialogResult.OK )
				return;

			throw new NotImplementedException();
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
	}
}
