using System;
using System.Windows.Forms;

using Passkeeper.View.Interfaces;

namespace Passkeeper.View.Forms
{
	public partial class SettingsForm : Form, ISettingsForm
	{
		//---------------------------------------------------------------------

		public SettingsForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------

		public TextBox CentralTextBox => MainTextBox;
		public TextBox NewPassword => NewPasswordTextBox;
		public TextBox ConfirmPassword => ConfirmTextBox;

		public Label CentralLabel => MainLabel;

		public string ChangeModeButtonText
		{
			get => ChangeModeButton.Text;
			set => ChangeModeButton.Text = value;
		}
		public bool NewPasswordLabelVisible
		{
			get => NewPasswordLabel.Visible;
			set => NewPasswordLabel.Visible = value;
		}
		public bool ConfirmPasswordLabelVisible
		{
			get => ConfirmPasswordLabel.Visible;
			set => ConfirmPasswordLabel.Visible = value;
		}

		//---------------------------------------------------------------------

		public event EventHandler ApplyButton_Clicked;
		public event EventHandler CancelButton_Clicked;
		public event EventHandler ChangeModeButton_Clicked;

		//---------------------------------------------------------------------

		private void ApplyButton_Click( object _sender, EventArgs _e )
		{
			ApplyButton_Clicked?.Invoke( _sender, _e );
		}
		private void CancelButton_Click( object _sender, EventArgs _e )
		{
			CancelButton_Clicked?.Invoke( _sender, _e );
		}
		private void ChangeModeButton_Click( object _sender, EventArgs _e )
		{
			ChangeModeButton_Clicked?.Invoke( _sender, _e );
		}

		//---------------------------------------------------------------------
	}
}
