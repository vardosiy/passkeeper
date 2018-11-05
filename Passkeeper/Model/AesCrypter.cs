using System;

using System.Text;
using System.Security.Cryptography;

namespace Passkeeper.Model
{
	public class AesCrypter
	{
		private const string IV = "qo1lc3sjd8zpt9cx"; // 128 bytes
		private const string Key = "ow7dxys8glfor9tnc2ansdfo1etkfjcv"; // 256 bytes

		//---------------------------------------------------------------------

		public static byte[] Encrypt( byte[] _data )
		{
			var cryptoProvider = EnsureCryptoProvider();
			byte[] ecrypted;

			using ( ICryptoTransform icrypt = cryptoProvider.CreateEncryptor( cryptoProvider.Key, cryptoProvider.IV ) )
				ecrypted = icrypt.TransformFinalBlock( _data, 0, _data.Length );

			return ecrypted;
		}

		public static byte[] Decrypt( byte[] _data )
		{
			var cryptoProvider = EnsureCryptoProvider();
			byte[] decrypted;

			using ( ICryptoTransform icrypt = cryptoProvider.CreateDecryptor( cryptoProvider.Key, cryptoProvider.IV ) )
				decrypted = icrypt.TransformFinalBlock( _data, 0, _data.Length );

			return decrypted;
		}

		//---------------------------------------------------------------------

		private static AesCryptoServiceProvider EnsureCryptoProvider()
		{
			AesCryptoServiceProvider cryptoProvider = new AesCryptoServiceProvider();
			cryptoProvider.BlockSize = 128;
			cryptoProvider.KeySize = 256;
			cryptoProvider.Key = Encoding.ASCII.GetBytes( Key );
			cryptoProvider.IV = Encoding.ASCII.GetBytes( IV );
			cryptoProvider.Padding = PaddingMode.PKCS7;
			cryptoProvider.Mode = CipherMode.CBC;

			return cryptoProvider;
		}

		//---------------------------------------------------------------------
	}
}
