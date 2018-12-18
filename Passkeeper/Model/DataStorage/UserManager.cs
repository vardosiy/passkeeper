﻿using System;
using System.Collections.Generic;
using System.Linq;

using Passkeeper.Model.SaveRestore;

namespace Passkeeper.Model
{
	public class UserManager : Storable
	{
		//---------------------------------------------------------------------

		Dictionary< string, string > m_users; // K - Username, V - Password

		bool m_modified = false;

		public string CurrentUser { get; set; }

		//---------------------------------------------------------------------

		public UserManager()
		{
			LoadData();
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
		
		public void ChangePassword( string _newPassword )
		{
			m_users[CurrentUser] = _newPassword;

			m_modified = true;
		}

		public void ChangeUsername( string _newUsername )
		{
			string password = m_users[CurrentUser];

			m_users.Remove( CurrentUser );
			m_users.Add( _newUsername, password );

			m_modified = true;
		}

		//---------------------------------------------------------------------

		public override void Save()
		{
			if ( m_modified )
				SaveToFile();
		}

		protected override void LoadData()
		{
			var data = FileProcessor.Restore( InternalNames.UserManagerSavePath );

			if ( data == null )
				m_users = new Dictionary< string, string >();
			else
				m_users = data[0] as Dictionary< string, string >;
		}

		protected override void SaveToFile()
		{
			FileProcessor.Save(
					InternalNames.UserManagerSavePath
				,	m_users
			);
		}

		//---------------------------------------------------------------------
	}
}
