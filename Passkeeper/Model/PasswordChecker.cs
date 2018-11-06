using System.IO;

namespace Passkeeper.Model
{
	public class PasswordChecker
	{
		//---------------------------------------------------------------------

		private string m_password;

		//---------------------------------------------------------------------

		public PasswordChecker()
		{
			LoadPassword();
		}

		private void LoadPassword()
		{
			m_password = FileProcessor.LoadPassword(
					Path.Combine( "data", "password".GetHashCode().ToString() )
			);
		}

		//---------------------------------------------------------------------

		public bool CheckPassword( string _password )
		{
			return m_password == _password;
		}

		//---------------------------------------------------------------------
	}
}
