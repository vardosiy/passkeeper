using System;

namespace Passkeeper.View.Interfaces
{
	public interface IAddResourceForm : IView
	{
		string ResourceName { get; }

		event EventHandler OKButton_Clicked;
		event EventHandler CancelButton_Clicked;
	}
}
