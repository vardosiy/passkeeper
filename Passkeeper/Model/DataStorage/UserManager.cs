using System;
using System.Collections.Generic;
using System.Linq;

namespace Passkeeper.Model
{
	[Serializable]
	public class UserManager : IStorable
	{
		//---------------------------------------------------------------------

		private Dictionary< string, string > m_users; // K - Username, V - Password

		public string CurrentUser { get; set; }

		//---------------------------------------------------------------------

		public UserManager()
		{
			LoadData();
			CurrentUser = null;
		}

		//---------------------------------------------------------------------

		public void AddUser( string _username, string _password )
		{
			if ( IsUserExists( _username ) )
				throw new Exception( "User already exists" );

			m_users.Add( _username, _password );
		}

		public bool IsUserExists( string _username )
		{
			return m_users.ContainsKey( _username );
		}

		public bool TryLogin( string _username, string _password )
		{
			return m_users.Contains( new KeyValuePair< string, string >( _username, _password ) );
		}

		//---------------------------------------------------------------------

		public void LoadData()
		{
			m_users = new Dictionary< string, string >();
		}

		public void SaveToFile()
		{
			//FileSystem.FileProcessor.SaveWithSerialization( this )
		}

		//---------------------------------------------------------------------
	}
}
