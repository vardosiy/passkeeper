using System;
using System.Collections.Generic;

namespace Passkeeper.Model
{
	public class UserManager
	{
		private Dictionary< string, string > m_users =
			new Dictionary< string, string >();

		public UserManager()
		{
			// LoadUsers();

			m_users.Add( "test", "test" );
		}

		public bool CheckPassword( string _username, string _password )
		{
			if ( !m_users.ContainsKey( _username ) )
				return false;

			return m_users[ _username ] == _password;
		}

		private void LoadUsers()
		{
			throw new NotImplementedException();
		}
	}
}
