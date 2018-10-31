using System;
using System.Windows.Forms;

namespace Passkeeper.View.Forms
{
	public partial class ApplicationForm : Form, Interfaces.IApplicationForm
	{
		public object SelectedResource => ResourceList.SelectedItem;
		public object SelectedAccount => ResourceAccountsComboBox.SelectedItem;

		public ListBox ResourceDisplayingContainer => ResourceList;

		public event EventHandler AddResourceButton_Clicked;
		public event EventHandler RemoveResourceButton_Clicked;

		public event EventHandler AddAccountButton_Clicked;
		public event EventHandler EditAccountButton_Clicked;
		public event EventHandler ShowAccountHistory_Clicked;
		public event EventHandler DeleteAccountHistory_Clicked;
		public event EventHandler RemoveAccount_Clicked;

		public ApplicationForm()
		{
			InitializeComponent();
			
			//this.Visible = false;
			//PasswordChecker checker = new PasswordChecker();
		}

		private void AddResourceButton_Click( object _sender, EventArgs _e )
		{
			AddResourceButton_Clicked?.Invoke( _sender, _e );
		}

		private void RemoveResourceButton_Click( object _sender, EventArgs _e )
		{
			if ( ResourceList.SelectedItem == null )
				return;

			RemoveResourceButton_Clicked?.Invoke( _sender, _e );
		}

		private void ResourceList_SelectedIndexChanged( object _sender, EventArgs _e )
		{
			if ( SelectedResource == null )
				return;

			SelectedResource.BindTo( ResourceAccountsComboBox );

			if ( SelectedResource.AccountsCount != 0 )
				ResourceAccountsComboBox.SelectedIndex = 0;
		}

		private void AddAccountButton_Click( object _sender, EventArgs _e )
		{
			if ( ResourceList.SelectedItem == null )
				return;

			AddAccountButton_Clicked?.Invoke( _sender, _e );

			ResourceAccountsComboBox_SelectedIndexChanged( _sender, _e );
		}

		private void EditAccountButton_Click( object _sender, EventArgs _e )
		{
			if (	ResourceList.SelectedItem == null
				||	ResourceAccountsComboBox.SelectedItem == null
			)
				return;

			EditAccountButton_Clicked?.Invoke( _sender, _e );

			ResourceAccountsComboBox_SelectedIndexChanged( _sender, _e );
			ResourceAccountsComboBox.Text =
				( ResourceAccountsComboBox.SelectedItem as Account ).ToString();
		}

		private void ClearHistoryButton_Click( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
				"Are you sure, you want to clear history for this account?"
			);

			if ( result != DialogResult.OK )
				return;

			// TODO...
		}

		private void RemoveAccountButton_Click( object _sender, EventArgs _e )
		{
			if (	ResourceList.SelectedItem == null
				||	ResourceAccountsComboBox.SelectedItem == null
			)
				return;

			RemoveAccount_Clicked?.Invoke( _sender, _e );
		}

		private void ResourceAccountsComboBox_SelectedIndexChanged( object _sender, EventArgs _e )
		{
			Account selectedAccout = ResourceAccountsComboBox.SelectedItem as Account;

			EmailTextBox.Text = selectedAccout.Email;
			LoginTextBox.Text = selectedAccout.Login;
			PasswordTextBox.Text = selectedAccout.Password;
		}
	}
}
