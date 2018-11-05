using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model
{
	public class FileProcessor
	{
		//public static void SaveResources( List< Resource > _resource )
		//{
		//	MemoryStream memoryStream = new MemoryStream();
		//	BinaryFormatter binaryFormatter = new BinaryFormatter();

		//	binaryFormatter.Serialize( memoryStream, _resource );
		//	memoryStream.Position = 0;
			
		//	byte[] encrypted = AesCrypter.Encrypt( memoryStream.ToArray() );
			
		//	string savePath = Path.Combine( "data", _resource.Name.GetHashCode().ToString() );

		//	using ( FileStream stream = new FileStream( savePath, FileMode.Truncate ) )
		//		stream.Write( encrypted, 0, encrypted.Length );
		//}
	}
}
