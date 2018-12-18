using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model.SaveRestore
{
	public static class FileProcessor
	{
		//---------------------------------------------------------------------

		public static void Save( string _path, params object[] _objects )
		{
			using ( MemoryStream memoryStream = new MemoryStream() )
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();

				foreach ( object obj in _objects )
					binaryFormatter.Serialize( memoryStream, obj );

				SaveToFile( _path, AesCrypter.Encrypt( memoryStream.ToArray() ) );
			}
		}

		private static void SaveToFile( string _path, byte[] _data )
		{
			Directory.CreateDirectory( Path.GetDirectoryName( _path ) );

			using ( FileStream stream = new FileStream( _path, FileMode.Create ) )
				stream.Write( _data, 0, _data.Length );
		}

		//---------------------------------------------------------------------

		public static List< object > Restore( string _path )
		{
			byte[] fileContent = ReadFromFile( _path );
			if ( fileContent == null )
				return null;

			byte[] decrypted = AesCrypter.Decrypt( fileContent );

			MemoryStream memoryStream = new MemoryStream( decrypted );
			BinaryFormatter binaryFormatter = new BinaryFormatter();

			List< object > result = new List< object >();

			while( memoryStream.Position != memoryStream.Length )
				result.Add( binaryFormatter.Deserialize( memoryStream ) );

			return result;
		}

		private static byte[] ReadFromFile( string _path )
		{
			if ( !File.Exists( _path ) )
				return null;

			using ( FileStream stream = new FileStream( _path, FileMode.Open ) )
			{
				byte[] content = new byte[ stream.Length ];
				stream.Read( content, 0, (int)( stream.Length ) );

				return content;
			}
		}

		//---------------------------------------------------------------------

		public static void RenameCurrentUserDirectory( string _newUsername )
		{
			string oldPath = InternalNames.GetUserSavePath();
			if ( !Directory.Exists( oldPath ) )
				return;

			string newPath = Path.Combine( InternalNames.SaveDirectory, _newUsername.GetHashAsString() );
			Directory.Move( oldPath, newPath );
		}

		public static void MoveAccountSaveDirectory(
				Resource _resource
			,	Account _deletedAcc
			,	Account _movebleAcc
		)
		{
			string deletedAccPath = InternalNames.GetAccountSavePath( _resource, _deletedAcc );

			if ( Directory.Exists( deletedAccPath ) )
				Directory.Delete( deletedAccPath );

			string oldAccPath = InternalNames.GetAccountSavePath( _resource, _movebleAcc );

			if ( Directory.Exists( oldAccPath ) )
				Directory.Move( oldAccPath, deletedAccPath );
		}

		//---------------------------------------------------------------------
	}
}
