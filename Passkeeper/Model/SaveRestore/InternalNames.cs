using System.IO;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model.SaveRestore
{
	public static class InternalNames
	{
		//---------------------------------------------------------------------

		static public string SaveDirectory { get; set; }
		static public UserManager UserManager { get; set; }

		public static string CurrentUser => UserManager.CurrentUser;

		public static string BackupManagerSavePath
		{
			get
			{
				return Path.Combine(
						SaveDirectory
					,	CurrentUser.GetHashAsString()
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
					,	CurrentUser.GetHashAsString()
					,	"data_container".GetHashAsString()
				);
			}
		}

		//---------------------------------------------------------------------

		public static string GetAccountSavePath(
				Resource _resource
			,	Account _account
		)
		{
			return Path.Combine(
					SaveDirectory
				,	CurrentUser.GetHashAsString()
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
				,	CurrentUser.GetHashAsString()
				,	_resource.Name.GetHashAsString()
			);
		}

		public static string GetUserSavePath()
		{
			return Path.Combine(
					SaveDirectory
				,	CurrentUser.GetHashAsString()
			);
		}

		//---------------------------------------------------------------------
	}
}
