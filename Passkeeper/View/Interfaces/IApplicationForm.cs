using System;
using System.Windows.Forms;

namespace Passkeeper.View.Interfaces
{
	public interface IApplicationForm : IView
	{
		object SelectedResource { get; }
		object SelectedAccount { get; }

		ListControl ResourcesList { get; }
		ListControl AccountsList { get; }

		string CurrentAccountEmail { get; set; }
		string CurrentAccountLogin { get; set; }
		string CurrentAccountPassword { get; set; }

		event EventHandler Load;
		event EventHandler Closed;

		event EventHandler AddResourceButton_Clicked;
		event EventHandler RemoveResourceButton_Clicked;
		event EventHandler SelectedResourceChanged;

		event EventHandler AddAccountButton_Clicked;
		event EventHandler EditAccountButton_Clicked;
		event EventHandler RemoveAccount_Clicked;
		event EventHandler SelectedAccountChanged;

		event EventHandler ShowAccountHistory_Clicked;
		event EventHandler DeleteAccountHistory_Clicked;
		event EventHandler SettingsButton_Clicked;
	}
}
