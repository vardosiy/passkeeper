using System;
using System.Collections.Generic;
using System.Text;
using Passkeeper.Model.Entities;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class AccountHistoryPresenter : IPresenter
	{
		private readonly IAccountHistoryForm m_form;

		//---------------------------------------------------------------------

		public AccountHistoryPresenter( IAccountHistoryForm _form, List< HistoryRecord > _history )
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

		private string[] ConvertToStringArray( List< HistoryRecord > _convertable )
		{
			int linesRequiredForEachRecord = 5;
			string[] result = new string[ _convertable.Capacity * linesRequiredForEachRecord ];

			for ( int i = 0; i < _convertable.Capacity; i += linesRequiredForEachRecord )
			{
				result[i] = "Change time: " + _convertable[i].ChangeTime.ToString();

				result[i + 1] = "Email: " + _convertable[i].Email;
				result[i + 2] = "Email: " + _convertable[i].Login;
				result[i + 3] = "Email: " + _convertable[i].Password;

				result[i + 4] = string.Empty;
			}

			return result;
		}

		//---------------------------------------------------------------------
	}
}
