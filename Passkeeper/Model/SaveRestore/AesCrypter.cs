using System.Text;
using System.Security.Cryptography;

namespace Passkeeper.Model.SaveRestore
{
	public static class AesCrypter
	{
		//---------------------------------------------------------------------

		const string IV = "qo1lc3sjd8zpt9cx";
		const string Key = "ow7dxys8glfor9tnc2ansdfo1etkfjcv";

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
			const int bitsInByte = 8;

			AesCryptoServiceProvider cryptoProvider = new AesCryptoServiceProvider
			{
				BlockSize = IV.Length * bitsInByte,
				KeySize = Key.Length * bitsInByte,
				Key = Encoding.ASCII.GetBytes( Key ),
				IV = Encoding.ASCII.GetBytes( IV ),
				Padding = PaddingMode.PKCS7,
				Mode = CipherMode.CBC
			};

			return cryptoProvider;
		}

		//---------------------------------------------------------------------
	}
}
