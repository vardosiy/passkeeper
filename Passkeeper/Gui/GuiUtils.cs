using System.Windows.Forms;

namespace Passkeeper.Gui
{
	static class GuiUtils
	{
		static public bool ShowWarning( string _message )
		{
			DialogResult result = MessageBox.Show(
					_message
				,	"Warning"
				,	MessageBoxButtons.OKCancel
				,	MessageBoxIcon.Warning
			);

			return result == DialogResult.OK;
		}
	}
}
