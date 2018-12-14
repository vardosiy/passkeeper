using System.IO;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model.SaveRestore
{
	public static class InternalNames
	{
		//---------------------------------------------------------------------

		static public string SaveDirectory { get; set; }
		static public UserManager UserManager { get; set; }

		public static string BackupManagerSavePath
		{
			get
			{
				return Path.Combine(
						SaveDirectory
					,	"backup_manager".GetHashAsString()
				);
			}
		}
		public static string UserManagerSavePath
		{
			get
			{
				return Path.Combine(
						SaveDirectory
					,	"user_manager".GetHashAsString()
				);
			}
		}
		public static string DataContainerSavePath
		{
			get
			{
				return Path.Combine(
						SaveDirectory
					,	UserManager.CurrentUser.GetHashAsString()
					,	"data_container".GetHashAsString()
				);
			}
		}

		//---------------------------------------------------------------------

		public static void RenameCurrentUserDirectory( string _newUsername )
		{
			string oldPath = Path.Combine( SaveDirectory, UserManager.GetHashAsString() );
			if ( !Directory.Exists( oldPath ) )
				return;

			string newPath = Path.Combine( SaveDirectory, _newUsername.GetHashAsString() );
			Directory.Move( oldPath, newPath );
		}

		//---------------------------------------------------------------------

		public static string GetAccountSavePath(
				Resource _resource
			,	Account _account
		)
		{
			return Path.Combine(
					SaveDirectory
				,	UserManager.CurrentUser.GetHashAsString()
				,	_resource.Name.GetHashAsString()
				,	_account.InternalIndex.GetHashAsString()
			);
		}

		public static string GetResourceSavePath(
				Resource _resource
		)
		{
			return Path.Combine(
					SaveDirectory
				,	UserManager.CurrentUser.GetHashAsString()
				,	_resource.Name.GetHashAsString()
			);
		}

		//---------------------------------------------------------------------
	}
}
