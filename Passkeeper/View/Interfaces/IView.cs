using System.Windows.Forms;

namespace Passkeeper.View.Interfaces
{
	public interface IView
	{
		DialogResult ShowDialog();

		void Close();
	}
}
