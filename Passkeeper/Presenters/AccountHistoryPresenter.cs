using System;
using System.Collections.Generic;
using System.Text;
using Passkeeper.Model.Entities;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class AccountHistoryPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		readonly IAccountHistoryForm m_form;

		//---------------------------------------------------------------------
		
		public AccountHistoryPresenter( IAccountHistoryForm _form, IList< HistoryRecord > _history )
		{
			m_form = _form;

			m_form.OKButton_Clicked += OKButton_Clicked;

			m_form.TextBox.Lines = ConvertToStringArray( _history );
		}

		public void Run()
		{
			m_form.ShowDialog();
		}

		//---------------------------------------------------------------------

		private void OKButton_Clicked( object _sender, EventArgs _e )
		{
			m_form.Close();
		}

		//---------------------------------------------------------------------

		private string[] ConvertToStringArray( IList< HistoryRecord > _convertable )
		{
			int linesPerRecord = 5; // lines required for each record
			string[] result = new string[ _convertable.Count * linesPerRecord ];
			
			for ( int i = 0; i < _convertable.Count; ++i )
			{
				result[i * linesPerRecord + 0] = "Change time: " + _convertable[i].ChangeTime.ToString();
				result[i * linesPerRecord + 1] = "Email: " + _convertable[i].Email;
				result[i * linesPerRecord + 2] = "Login: " + _convertable[i].Login;
				result[i * linesPerRecord + 3] = "Password: " + _convertable[i].Password;
				result[i * linesPerRecord + 4] = string.Empty;
			}

			return result;
		}

		//---------------------------------------------------------------------
	}
}
