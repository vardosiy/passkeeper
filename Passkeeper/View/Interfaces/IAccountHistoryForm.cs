using System;
using System.Windows.Forms;

namespace Passkeeper.View.Interfaces
{
	public interface IAccountHistoryForm : IView
	{
		TextBox TextBox { get; }

		event EventHandler OKButton_Clicked;
	}
}
