using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Passkeeper.Gui.Forms;

namespace Passkeeper
{
	public partial class ApplicationForm : Form
	{
		public ApplicationForm()
		{
			InitializeComponent();
		}

		private void AddResourceButton_Click( object sender, EventArgs e )
		{
			AddResourceForm form = new AddResourceForm();
			DialogResult result = form.ShowDialog();

			if ( result != DialogResult.OK )
				return;
		}
	}
}
