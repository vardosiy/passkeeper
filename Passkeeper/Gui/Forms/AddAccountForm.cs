using System;
using System.Windows.Forms;

namespace Passkeeper.Gui.Forms
{
	public partial class AddAccountForm : Form
	{
		//---------------------------------------------------------------------

		public string Email { get; set; }

		public string Login { get; set; }

		public string Password { get; set; }

		public DialogResult Result { get; set; }

		//---------------------------------------------------------------------

		public AddAccountForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------

		private void OkButton_Click( object sender, EventArgs e )
		{
			if (	EmailTextBox.Text == ""
				||	LoginTextBox.Text == ""
				||	PasswordTextBox.Text == ""
			)
			{
				Result = DialogResult.Cancel;
				Close();
			}

			Email = EmailTextBox.Text;
			Login = LoginTextBox.Text;
			Password = PasswordTextBox.Text;

			Result = DialogResult.OK;

			Close();
		}

		//---------------------------------------------------------------------

		private void CancelButton_Click( object sender, EventArgs e )
		{
			Result = DialogResult.Cancel;
			Close();
		}

		//---------------------------------------------------------------------
	}
}
