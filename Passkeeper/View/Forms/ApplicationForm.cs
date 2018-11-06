using System;
using System.Windows.Forms;

using Passkeeper.Model.Entities;

namespace Passkeeper.View.Forms
{
	public partial class ApplicationForm : Form, Interfaces.IApplicationForm
	{
		//---------------------------------------------------------------------

		public object SelectedResource => ResourceList.SelectedItem;
		public object SelectedAccount => ResourceAccountsComboBox.SelectedItem;
		
		public ListControl ResourcesList => ResourceList;
		public ListControl AccountsList => ResourceAccountsComboBox;

		//---------------------------------------------------------------------

		public event EventHandler AddResourceButton_Clicked;
		public event EventHandler RemoveResourceButton_Clicked;
		public event EventHandler SelectedResourceChanged;

		public event EventHandler AddAccountButton_Clicked;
		public event EventHandler EditAccountButton_Clicked;
		public event EventHandler RemoveAccount_Clicked;

		public event EventHandler ShowAccountHistory_Clicked;
		public event EventHandler DeleteAccountHistory_Clicked;

		//---------------------------------------------------------------------

		public ApplicationForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------

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
			SelectedResourceChanged?.Invoke( _sender, _e );

			if ( ResourceAccountsComboBox.Text == string.Empty )
			{
				EmailTextBox.Text = string.Empty;
				LoginTextBox.Text = string.Empty;
				PasswordTextBox.Text = string.Empty;
			}
		}

		//---------------------------------------------------------------------

		private void AddAccountButton_Click( object _sender, EventArgs _e )
		{
			if ( ResourceList.SelectedItem == null )
				return;

			AddAccountButton_Clicked?.Invoke( _sender, _e );

			if ( SelectedAccount != null )
				ResourceAccountsComboBox_SelectedIndexChanged( _sender, _e );
		}

		private void EditAccountButton_Click( object _sender, EventArgs _e )
		{
			if ( SelectedResource == null || SelectedAccount == null )
				return;

			EditAccountButton_Clicked?.Invoke( _sender, _e );

			ResourceAccountsComboBox_SelectedIndexChanged( _sender, _e );
			ResourceAccountsComboBox.Text = SelectedAccount.ToString();
		}

		private void RemoveAccountButton_Click( object _sender, EventArgs _e )
		{
			if ( SelectedResource == null || SelectedAccount == null )
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

		//---------------------------------------------------------------------

		private void ShowHistoryButton_Click( object _sender, EventArgs _e )
		{
			ShowAccountHistory_Clicked?.Invoke( _sender, _e );
		}

		private void ClearHistoryButton_Click( object _sender, EventArgs _e )
		{
			DeleteAccountHistory_Clicked?.Invoke( _sender, _e );
		}

		//---------------------------------------------------------------------

		public new DialogResult ShowDialog()
		{
			Application.Run( this );

			return DialogResult.OK;
		}

		//---------------------------------------------------------------------
	}
}
