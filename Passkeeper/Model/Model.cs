﻿using System;

namespace Passkeeper.Model
{
	public class Model
	{
		//---------------------------------------------------------------------

		public DataContainer DataContainer { get; private set; }

		public UserManager UserManager { get; private set; }

		//---------------------------------------------------------------------

		public Model()
		{
			LoadUserManager();
		}
		
		//---------------------------------------------------------------------

		public void LoadData()
		{
			if ( DataContainer != null )
				throw new Exception( "DataContainer was already loaded." );

			DataContainer = new DataContainer();
			SaveRestore.InternalNames.CurrentUser = UserManager.CurrentUser;
		}

		public void LoadUserManager()
		{
			if ( UserManager != null )
				throw new Exception( "UserManager was already loaded." );

			UserManager = new UserManager();
		}

		//---------------------------------------------------------------------
	}
}
