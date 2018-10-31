using System;
using System.Windows.Forms;

namespace Passkeeper.View.Interfaces
{
	public interface IApplicationForm
	{
		object SelectedResource { get; }
		object SelectedAccount { get; }

		ListBox ResourceDisplayingContainer { get; }

		event EventHandler AddResourceButton_Clicked;
		event EventHandler RemoveResourceButton_Clicked;

		event EventHandler AddAccountButton_Clicked;
		event EventHandler EditAccountButton_Clicked;
		event EventHandler ShowAccountHistory_Clicked;
		event EventHandler DeleteAccountHistory_Clicked;
		event EventHandler RemoveAccount_Clicked;
	}
}
