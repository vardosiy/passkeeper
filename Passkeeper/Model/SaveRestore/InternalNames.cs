using System.IO;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model.SaveRestore
{
	public static class InternalNames
	{
		//---------------------------------------------------------------------

		static public string DefaultSaveDirectory { get; set; } = "data";
		static public string CurrentUser { get; set; }

		//---------------------------------------------------------------------

		public static string GetUserManagerSavePath()
		{
			return Path.Combine(
					DefaultSaveDirectory
				,	"user_manager".GetHashCode().ToString()
			);
		}
		public static string GetDataContainerSavePath()
		{
			return Path.Combine(
					DefaultSaveDirectory
				,	CurrentUser.GetHashCode().ToString()
				,	"data_container".GetHashCode().ToString()
			);
		}

		//---------------------------------------------------------------------

		public static string GetAccountSavePath(
				Resource _resource
			,	Account _account
		)
		{
			return Path.Combine(
					DefaultSaveDirectory
				,	CurrentUser.GetHashCode().ToString()
				,	_resource.Name.GetHashCode().ToString()
				,	_account.InternalIndex.GetHashCode().ToString()
			);
		}
		public static string GetResourceSavePath(
				Resource _resource
		)
		{
			return Path.Combine(
					DefaultSaveDirectory
				,	CurrentUser.GetHashCode().ToString()
				,	_resource.Name.GetHashCode().ToString()
			);
		}

		//---------------------------------------------------------------------
	}
}
