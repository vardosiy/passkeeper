using System;

namespace Passkeeper.Model
{
	public class PasswordChecker
	{
		private readonly string m_password;

		public PasswordChecker()
		{
			// LoadPassword();

			m_password = "";
		}

		public bool CheckPassword( string _password )
		{
			return m_password == _password;
		}

		private void LoadPassword()
		{
			throw new NotImplementedException();
		}
	}
}
