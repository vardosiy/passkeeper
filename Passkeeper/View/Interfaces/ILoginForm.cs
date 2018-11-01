using System;

namespace Passkeeper.View.Interfaces
{
	public interface ILoginForm : IView
	{
		string Username { get; }
		string Password { get; }

		event EventHandler OKButton_Clicked;
	}
}
