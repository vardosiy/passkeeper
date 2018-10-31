using System;
using System.Windows.Forms;

using Passkeeper.Model;
using Passkeeper.Model.Entities;
using Passkeeper.View.Forms;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class ApplicationPresenter
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

			m_form.AddAccountButton_Clicked += AddAccountButton_Clicked;
			m_form.RemoveResourceButton_Clicked += RemoveResourceButton_Clicked;

			m_form.AddResourceButton_Clicked += AddResourceButton_Clicked;
			m_form.EditAccountButton_Clicked += EditAccountButton_Clicked;
			m_form.ShowAccountHistory_Clicked += ShowAccountHistory_Clicked;
			m_form.DeleteAccountHistory_Clicked += DeleteAccountHistory_Clicked;
			m_form.RemoveAccount_Clicked += RemoveAccount_Clicked;
		}

		private void AddResourceButton_Clicked( object _sender, EventArgs _e )
		{
			AddResourceForm addResourceForm = new AddResourceForm();
			AddResourcePresenter presetner = new AddResourcePresenter( m_controller, addResourceForm );

			addResourceForm.ShowDialog();

			//fix
			m_controller.BindTo( m_form.ResourceDisplayingContainer );
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

		private void AddAccountButton_Clicked( object _sender, EventArgs _e )
		{
			AddAccountForm addAccountForm = new AddAccountForm();
			AddAccountPresetner presetner = new AddAccountPresetner(
					m_form.SelectedResource as Resource
				,	addAccountForm 
			);

			addAccountForm.ShowDialog();
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
			// FIX

			form.ShowDialog();
		}

		private void ShowAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			throw new NotImplementedException();
		}

		private void DeleteAccountHistory_Clicked( object _sender, EventArgs _e )
		{
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
