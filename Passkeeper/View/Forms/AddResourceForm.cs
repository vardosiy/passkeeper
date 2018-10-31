using System;
using System.Windows.Forms;

namespace Passkeeper.View.Forms
{
	public partial class AddResourceForm : Form, Interfaces.IAddResourceForm
	{
		public string ResourceName => ResourceNameTextBox.Text;

		public event EventHandler OKButton_Clicked;
		public event EventHandler CancelButton_Clicked;

		public AddResourceForm()
		{
			InitializeComponent();
		}

		private void OkButton_Click( object _sender, EventArgs _e )
		{
			OKButton_Clicked?.Invoke( _sender, _e );
		}

		private void CancelButton_Click( object _sender, EventArgs _e )
		{
			CancelButton_Clicked?.Invoke( _sender, _e );
		}
	}
}
