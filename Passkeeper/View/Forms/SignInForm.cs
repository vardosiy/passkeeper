using System;
using System.Windows.Forms;

namespace Passkeeper.View.Forms
{
	public partial class SignInForm : Form, Interfaces.ISignInForm
	{
		//---------------------------------------------------------------------

		public string Username => UsernameTextBox.Text;
		public string Password => PasswordTextBox.Text;
		public string Confirmation => ConfirmTextBox.Text;

		//---------------------------------------------------------------------

		public string ChangeModeButtonText
		{
			get => CreateUserButton.Text;
			set => CreateUserButton.Text = value;
		}
		public bool ConfirmTextBoxVisible
		{
			get => ConfirmTextBox.Visible;
			set => ConfirmTextBox.Visible = value;
		}
		public bool ConfirmLabelVisible
		{
			get => ConfirmLabel.Visible;
			set => ConfirmLabel.Visible = value;
		}

		//---------------------------------------------------------------------

		public event EventHandler OKButton_Clicked;
		public event EventHandler CreateUserButton_Clicked;

		//---------------------------------------------------------------------

		public SignInForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------

		private void OKButton_Click( object _sender, EventArgs _e )
		{
			OKButton_Clicked?.Invoke( _sender, _e );
		}

		private void CreateUserButton_Click( object _sender, EventArgs _e )
		{
			CreateUserButton_Clicked?.Invoke( _sender, _e );
		}

		//---------------------------------------------------------------------
	}
}
