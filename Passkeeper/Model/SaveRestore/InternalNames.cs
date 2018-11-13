using System.IO;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model.SaveRestore
{
	public static class InternalNames
	{
		//---------------------------------------------------------------------

		static public string CurrentUser { get; set; }

		//---------------------------------------------------------------------

		public static string GetSavePathForAccount( Resource _resource, Account _account )
		{
			return Path.Combine(
					"data"
				,	CurrentUser
				,	_resource.Name.GetHashCode().ToString()
				,	_account.InternalIndex.GetHashCode().ToString()
			);
		}

		//---------------------------------------------------------------------
	}
}
