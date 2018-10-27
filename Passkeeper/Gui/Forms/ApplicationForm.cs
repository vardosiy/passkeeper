using System;
using System.Windows.Forms;
using Passkeeper.Core;
using Passkeeper.Types;
using Passkeeper.Gui.Forms;

namespace Passkeeper
{
	public partial class ApplicationForm : Form
	{
		private Controller m_controller = new Controller();

		public ApplicationForm()
		{
			InitializeComponent();
		}

		#region Add* Remove* resource button handlers

		private void AddResourceButton_Click( object _sender, EventArgs _e )
		{
			AddResourceForm form = new AddResourceForm();
			form.ShowDialog();

			if ( form.Result != DialogResult.OK )
				return;

			Resource resource = new Resource( form.ResourceName );

			m_controller.AddResource( resource );
			m_controller.BindTo( ResourceList );
		}

		private void RemoveResourceButton_Click( object _sender, EventArgs _e )
		{
			if ( ResourceList.SelectedItem == null )
				return;

			DialogResult result = Gui.GuiUtils.ShowWarning(
				"Are you sure, you want to remove data about all accounts asociated with this resource?"
			);

			if ( result != DialogResult.OK )
				return;

			m_controller.RemoveResource( ResourceList.SelectedItem as Resource );
		}

		private void ResourceList_SelectedIndexChanged( object _sender, EventArgs _e )
		{
			if ( !( ResourceList.SelectedItem is Resource selectedResource ) )
				return;

			selectedResource.BindTo( ResourceAccountsComboBox );

			if ( selectedResource.AccountsCount != 0 )
				ResourceAccountsComboBox.SelectedIndex = 0;
		}

		#endregion

		#region Handlers for buttons controlling account

		private void AddAccountButton_Click( object _sender, EventArgs _e )
		{
			if ( ResourceList.SelectedItem == null )
				return;

			AddAccountForm form = new AddAccountForm();
			form.ShowDialog();

			if ( form.Result != DialogResult.OK )
				return;

			Account account = new Account( form.Email, form.Login, form.Password );
			( ResourceList.SelectedItem as Resource ).AddAccount( account );

			ResourceAccountsComboBox_SelectedIndexChanged( _sender, _e );
		}

		private void EditAccountButton_Click( object _sender, EventArgs _e )
		{
			if (	ResourceList.SelectedItem == null
				||	ResourceAccountsComboBox.SelectedItem == null
			)
			{
				return;
			}

			EditAccountForm form = new EditAccountForm(
				ResourceAccountsComboBox.SelectedItem as Account
			);
			form.ShowDialog();

			ResourceAccountsComboBox_SelectedIndexChanged( _sender, _e );
			ResourceAccountsComboBox.Text =
				( ResourceAccountsComboBox.SelectedItem as Account ).ToString();
		}

		private void ClearHistoryButton_Click( object _sender, EventArgs _e )
		{
			DialogResult result = Gui.GuiUtils.ShowWarning(
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
			{
				return;
			}

			DialogResult result = Gui.GuiUtils.ShowWarning(
				"Are you sure, you want to remove data about all accounts asociated with this resource?"
			);

			if ( result != DialogResult.OK )
				return;

			Resource selectedResource = ResourceList.SelectedItem as Resource;
			selectedResource.RemoveAccount( ResourceAccountsComboBox.SelectedItem as Account );
		}

		private void ResourceAccountsComboBox_SelectedIndexChanged( object _sender, EventArgs _e )
		{
			Account selectedAccout = ResourceAccountsComboBox.SelectedItem as Account;

			EmailTextBox.Text = selectedAccout.Email;
			LoginTextBox.Text = selectedAccout.Login;
			PasswordTextBox.Text = selectedAccout.Password;
		}

		#endregion
	}
}
