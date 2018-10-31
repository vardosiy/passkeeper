using System;
using System.Threading;
using System.Windows.Forms;

namespace Passkeeper.Core
{
	class PasswordChecker
	{
		private string ExpectedPassword { get; set; }

		Gui.Forms.LoginForm m_form;

		public void Init()
		{
			m_form = new Gui.Forms.LoginForm(
				( string _input ) =>
				{
					return CheckPassword( _input );
				}
			);

			m_form.ShowDialog();
		}

		private void ProcessInput( string _input )
		{
			if ( !CheckPassword( _input ) )
				return;

			m_form.Close();
		}

		public static bool CheckPassword( string _input )
		{
			return true;
		}
	}
}
