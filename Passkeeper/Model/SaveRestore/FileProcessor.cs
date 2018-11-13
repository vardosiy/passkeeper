using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Passkeeper.Model.SaveRestore
{
	public static class FileProcessor
	{
		//---------------------------------------------------------------------

		public static void SaveWithSerialization( object _object, string _path )
		{
			using ( MemoryStream memoryStream = new MemoryStream() )
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize( memoryStream, _object );

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

		public static object RestoreWithDeserialization( string _path )
		{
			byte[] fileContent = ReadFromFile( _path );
			if ( fileContent == null )
				return null;

			byte[] decrypted = AesCrypter.Decrypt( fileContent );

			MemoryStream memoryStream = new MemoryStream( decrypted );
			BinaryFormatter binaryFormatter = new BinaryFormatter();

			return binaryFormatter.Deserialize( memoryStream );
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
	}
}
