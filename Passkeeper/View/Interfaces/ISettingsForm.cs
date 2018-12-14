using System;
using System.Windows.Forms;

namespace Passkeeper.View.Interfaces
{
	public interface ISettingsForm : IView
	{
		TextBox CentralTextBox { get; }
		TextBox NewPassword { get; }
		TextBox ConfirmPassword { get; }

		Label CentralLabel { get; }

		string ChangeModeButtonText { get; set; }
		bool NewPasswordLabelVisible { get; set; }
		bool ConfirmPasswordLabelVisible { get; set; }

		uint BackupPeriod { get; set; }
		string BackupPath { get; set; }

		event EventHandler ApplyButton_Clicked;
		event EventHandler CancelButton_Clicked;
		event EventHandler ChangeModeButton_Clicked;
	}
}
