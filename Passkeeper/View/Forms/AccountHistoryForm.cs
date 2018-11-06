using System;
using System.Windows.Forms;

using Passkeeper.View.Interfaces;

namespace Passkeeper.View.Forms
{
	public partial class AccountHistoryForm : Form, IAccountHistoryForm
	{
		//---------------------------------------------------------------------

		public TextBox TextBox => ContentTextBox;

		public event EventHandler OKButton_Clicked;

		//---------------------------------------------------------------------

		public AccountHistoryForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------

		private void OKButton_Click( object _sender, EventArgs _e )
		{
			OKButton_Clicked?.Invoke( _sender, _e );
		}

		//---------------------------------------------------------------------
	}
}
