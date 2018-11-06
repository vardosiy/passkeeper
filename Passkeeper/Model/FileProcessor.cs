using System.IO;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model
{
	public static class FileProcessor
	{
		//---------------------------------------------------------------------

		public static void SaveResources( BindingList< Resource > _resources, string _path )
		{
			using ( MemoryStream memoryStream = new MemoryStream() )
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize( memoryStream, _resources );

				SaveToFile( _path, AesCrypter.Encrypt( memoryStream.ToArray() ) );
			}
		}

		public static void SavePassword( string _password, string _path )
		{
			byte[] str = Encoding.ASCII.GetBytes( _path );

			SaveToFile( _path, AesCrypter.Encrypt( str ) );
		}

		public static void SaveToFile( string _path, byte[] _data )
		{
			Directory.CreateDirectory( Path.GetDirectoryName( _path ) );

			using ( FileStream stream = new FileStream( _path, FileMode.Create ) )
				stream.Write( _data, 0, _data.Length );
		}

		//---------------------------------------------------------------------

		public static BindingList< Resource > RestoreResources( string _path )
		{
			byte[] fileContent = ReadFromFile( _path );
			if ( fileContent == null )
				return null;

			byte[] decrypted = AesCrypter.Decrypt( fileContent );

			MemoryStream memoryStream = new MemoryStream( decrypted );
			BinaryFormatter binaryFormatter = new BinaryFormatter();

			object deserealized = binaryFormatter.Deserialize( memoryStream );
			return deserealized as BindingList< Resource >;
		}

		public static string LoadPassword( string _path )
		{
			byte[] fileContent = ReadFromFile( _path );
			if ( fileContent == null )
				return null;

			byte[] decrypted = AesCrypter.Decrypt( fileContent );

			return Encoding.ASCII.GetString( decrypted );
		}

		public static byte[] ReadFromFile( string _path )
		{
			if ( !Directory.Exists( Path.GetDirectoryName( _path ) ) )
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
