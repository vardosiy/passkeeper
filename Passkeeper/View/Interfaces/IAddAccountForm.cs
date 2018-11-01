using System;

namespace Passkeeper.View.Interfaces
{
	public interface IAddAccountForm : IView
	{
		string Email { get; }
		string Login { get; }
		string Password { get; }

		event EventHandler OKButton_Clicked;
		event EventHandler CancelButton_Clicked;
	}
}
