using System;
using System.Windows.Forms;

namespace Passkeeper.Gui.Forms
{
	public partial class AddResourceForm : Form
	{
		public string ResourceName { get; set; }

		public DialogResult Result { get; set; }

		public AddResourceForm()
		{
			InitializeComponent();
		}

		private void OkButton_Click( object _sender, EventArgs _e )
		{
			if ( ResourceNameTextBox.Text == "" )
			{
				Result = DialogResult.Cancel;
				Close();
			}

			ResourceName = ResourceNameTextBox.Text;
			Result = DialogResult.OK;

			Close();
		}

		private void CancelButton_Click( object _sender, EventArgs _e )
		{
			Result = DialogResult.Cancel;
			Close();
		}
	}
}
