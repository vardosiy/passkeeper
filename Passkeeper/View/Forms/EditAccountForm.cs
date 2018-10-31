using System;
using System.Windows.Forms;

namespace Passkeeper.View.Forms
{
	public partial class EditAccountForm : Form, Interfaces.IEditAccountForm
	{
		public string Email => EmailTextBox.Text;
		public string Login => LoginTextBox.Text;
		public string Password => PasswordTextBox.Text;

		public event EventHandler OKButton_Clicked;
		public event EventHandler CancelButton_Clicked;

		public EditAccountForm( string _email, string _login, string _password )
		{
			InitializeComponent();

			EmailTextBox.Text = _email;
			LoginTextBox.Text = _login;
			PasswordTextBox.Text = _password;
		}

		private void OkButton_Click( object _sender, EventArgs _e )
		{
			OKButton_Clicked?.Invoke( _sender, _e );
		}

		private void CancelButton_Click( object _sender, EventArgs _e )
		{
			CancelButton_Clicked?.Invoke( _sender, _e );
		}
	}
}