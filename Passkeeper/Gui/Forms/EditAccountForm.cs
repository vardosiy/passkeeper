using System;
using System.Windows.Forms;

using Passkeeper.Types;

namespace Passkeeper.Gui.Forms
{
	public partial class EditAccountForm : Form
	{
		public Account Account { get; set; }

		public DialogResult Result { get; set; }

		public EditAccountForm( Account _account )
		{
			InitializeComponent();

			Account = _account;

			EmailTextBox.Text = _account.Email;
			LoginTextBox.Text = _account.Login;
			PasswordTextBox.Text = _account.Password;
		}

		#region Button click handlers

		private void OkButton_Click( object _sender, EventArgs _e )
		{
			if (	EmailTextBox.Text == ""
				||	LoginTextBox.Text == ""
				||	PasswordTextBox.Text == ""
			)
			{
				GuiUtils.ShowWarning(
					"You have cleared some field(s), changes will not be applied."
				);

				Result = DialogResult.Cancel;
				Close();
			}

			Account.Email = EmailTextBox.Text;
			Account.Login = LoginTextBox.Text;
			Account.Password = PasswordTextBox.Text;

			Result = DialogResult.OK;

			Close();
		}

		private void CancelButton_Click( object _sender, EventArgs _e )
		{
			Result = DialogResult.Cancel;
			Close();
		}

		#endregion
	}
}