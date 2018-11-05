using System;

namespace Passkeeper.View.Interfaces
{
	public interface ILoginForm : IView
	{
		string Password { get; }

		event EventHandler OKButton_Clicked;
		event System.Windows.Forms.FormClosedEventHandler FormClosed;
	}
}
