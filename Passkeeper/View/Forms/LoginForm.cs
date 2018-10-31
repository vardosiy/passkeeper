using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passkeeper.Gui.Forms
{
	public partial class LoginForm : Form
	{
		Func< string, bool > OKClickHandler;

		public LoginForm( Func< string, bool > _handler )
		{
			InitializeComponent();

			OKClickHandler = _handler;
		}

		private void OKButton_Click( object _sender, EventArgs _e )
		{
			OKClickHandler( InputTextBox.Text );
		}
	}
}
