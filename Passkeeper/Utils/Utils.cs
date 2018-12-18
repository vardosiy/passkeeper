using System;
using System.Windows.Forms;

namespace Passkeeper
{
	//-------------------------------------------------------------------------

	static class MessageUtils
	{
		static public DialogResult ShowWarning( string _message )
		{
			return MessageBox.Show(
					_message
				,	"Warning"
				,	MessageBoxButtons.OKCancel
				,	MessageBoxIcon.Warning
			);
		}

		static public DialogResult ShowError( string _message )
		{
			return MessageBox.Show(
					_message
				,	"Error"
				,	MessageBoxButtons.OK
				,	MessageBoxIcon.Error
			);
		}

		static public DialogResult ShowInfo( string _message )
		{
			return MessageBox.Show(
					_message
				,	"Info"
				,	MessageBoxButtons.OK
				,	MessageBoxIcon.Information
			);
		}
	}

	//-------------------------------------------------------------------------

	public static class ExtHashAsString
	{
		public static string GetHashAsString( this object _obj )
		{
			return _obj.GetHashCode().ToString();
		}
	}

	//-------------------------------------------------------------------------

	class MaxAmountOfAccounts : Exception
	{
	}

	//-------------------------------------------------------------------------

	struct UserData
	{
		string Password { get; set; }
		CryptoData CryptoData { get; set; }
	}

	struct CryptoData
	{
		string IV { get; set; }
		string Key { get; set; }
	}

	//-------------------------------------------------------------------------
}
