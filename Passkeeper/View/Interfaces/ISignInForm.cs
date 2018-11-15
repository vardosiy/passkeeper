using System;

namespace Passkeeper.View.Interfaces
{
	public interface ISignInForm : IView
	{
		string Username { get; }
		string Password { get; }
		string Confirmation { get; }

		bool ConfirmTextBoxVisible { get; set; }
		bool ConfirmLabelVisible { get; set; }

		event EventHandler OKButton_Clicked;
		event EventHandler CreateUserButton_Clicked;
	}
}
