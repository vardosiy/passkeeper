using System;

namespace Passkeeper.Model
{
	public class Model
	{
		//---------------------------------------------------------------------

		public DataContainer DataContainer { get; private set; }
		public UserManager UserManager { get; private set; }
		public BackupManager BackupManager { get; private set; }

		//---------------------------------------------------------------------

		public Model()
		{
			LoadUserManager();
		}
		
		//---------------------------------------------------------------------

		public void LoadData()
		{
			if ( DataContainer != null || BackupManager != null )
				throw new Exception( "DataContainer or BackupManager was already loaded." );

			DataContainer = new DataContainer();
			BackupManager = new BackupManager();
		}

		public void LoadUserManager()
		{
			if ( UserManager != null )
				throw new Exception( "UserManager was already loaded." );

			UserManager = new UserManager();
			SaveRestore.InternalNames.UserManager = UserManager;
		}

		//---------------------------------------------------------------------
	}
}
