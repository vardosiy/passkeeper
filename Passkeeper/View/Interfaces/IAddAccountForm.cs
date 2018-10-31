using System;

namespace Passkeeper.View.Interfaces
{
	public interface IAddAccountForm
	{
		string Email { get; }
		string Login { get; }
		string Password { get; }

		event EventHandler OKButton_Clicked;
		event EventHandler CancelButton_Clicked;

		void Close();
	}
}
