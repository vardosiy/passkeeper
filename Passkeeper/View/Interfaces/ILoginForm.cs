using System;

namespace Passkeeper.View.Interfaces
{
	public interface ILoginForm : IView
	{
		string Password { get; }

		event System.Windows.Forms.FormClosedEventHandler FormClosed;
		event EventHandler OKButton_Clicked;
	}
}
