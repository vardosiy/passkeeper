using System;
using System.Windows.Forms;

namespace Passkeeper.View.Forms
{
	public partial class LoginForm : Form, Interfaces.ILoginForm
	{
		public string Username => UsernameTextBox.Text;
		public string Password => PasswordTextBox.Text;

		public event EventHandler OKButton_Clicked;

		public LoginForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click( object _sender, EventArgs _e )
		{
			OKButton_Clicked?.Invoke( _sender, _e );
		}
	}
}
