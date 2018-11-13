using System;
using System.Collections.Generic;
using System.Linq;

namespace Passkeeper.Model
{
	public class UserManager : Storable
	{
		//---------------------------------------------------------------------

		private Dictionary< string, string > m_users; // K - Username, V - Password

		private bool m_modified = false;

		public string CurrentUser { get; set; }

		//---------------------------------------------------------------------

		public UserManager()
		{
			LoadData();
		}

		~UserManager()
		{
			if ( m_modified )
				SaveToFile();
		}

		//---------------------------------------------------------------------

		public void AddUser( string _username, string _password )
		{
			if ( IsUserExists( _username ) )
				throw new Exception( "User already exists" );

			m_users.Add( _username, _password );
			m_modified = true;
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

		protected override void LoadData()
		{
			object data = SaveRestore.FileProcessor.RestoreWithDeserialization(
					SaveRestore.InternalNames.GetUserManagerSavePath()
			);

			m_users = data as Dictionary<string, string>
				??	new Dictionary<string, string>()
			;
		}

		protected override void SaveToFile()
		{
			SaveRestore.FileProcessor.SaveWithSerialization(
					m_users
				,	SaveRestore.InternalNames.GetUserManagerSavePath()
			);
		}

		//---------------------------------------------------------------------
	}
}
