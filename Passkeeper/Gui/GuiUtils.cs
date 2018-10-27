using System.Windows.Forms;

namespace Passkeeper.Gui
{
	static class GuiUtils
	{
		static public DialogResult ShowWarning( string _message )
		{
			return MessageBox.Show(
					_message
				,	"Warning"
				,	MessageBoxButtons.OKCancel
				,	MessageBoxIcon.Warning
			);
		}
	}
}
