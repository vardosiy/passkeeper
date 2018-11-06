﻿using System.Windows.Forms;

namespace Passkeeper.Utils
{
	static class MessageUtils
	{
		//---------------------------------------------------------------------

		static public DialogResult ShowWarning( string _message )
		{
			return MessageBox.Show(
					_message
				,	"Warning"
				,	MessageBoxButtons.OKCancel
				,	MessageBoxIcon.Warning
			);
		}

		//---------------------------------------------------------------------

		static public DialogResult ShowError( string _message )
		{
			return MessageBox.Show(
					_message
				,	"Error"
				,	MessageBoxButtons.OK
				,	MessageBoxIcon.Error
			);
		}

		//---------------------------------------------------------------------
	}
}
