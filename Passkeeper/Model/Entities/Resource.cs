using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using Passkeeper.Model.SaveRestore;

namespace Passkeeper.Model.Entities
{
	[Serializable]
	public class Resource
	{
		//---------------------------------------------------------------------

		BindingList< Account > m_accounts = new BindingList< Account >();

		uint m_currentAccountInternalIndex = uint.MinValue + 1; // min value reserved as default value

		public string Name { get; private set; }

		//---------------------------------------------------------------------

		public Resource( string _name )
		{
			Name = _name;
		}

		//---------------------------------------------------------------------

		public void AddAccount( Account _account )
		{
			_account.InternalIndex = GetInternalIndexForAccount();
			m_accounts.Add( _account );
		}

		public void RemoveAccount( Account _account )
		{
			m_accounts.Remove( _account );
		}

		public Account GetAccount( int _index )
		{
			return m_accounts[ _index ];
		}

		public int AccountsCount => m_accounts.Count;

		private uint GetInternalIndexForAccount()
		{
			if ( m_currentAccountInternalIndex == uint.MaxValue )
			{
				uint result = 0;
				foreach ( var item in m_accounts )
				{
					if ( item.InternalIndex - result > 1 )
					return result;

					result = item.InternalIndex;
				}
			}

			return ++m_currentAccountInternalIndex;
		}

		//---------------------------------------------------------------------

		public void AddAccountHistoryRecord( HistoryRecord _record )
		{
			var currentHistory = GetAccountHistory( _record );
			currentHistory.Add( _record );

			FileProcessor.SaveWithSerialization( 
					currentHistory
				,	InternalNames.GetAccountSavePath( this, _record ) 
			);
		}

		public void RemoveAccountHistory( Account _account )
		{
			File.Delete( InternalNames.GetAccountSavePath( this, _account ) );
		}

		public List< HistoryRecord > GetAccountHistory( Account _account )
		{
			object history = FileProcessor.RestoreWithDeserialization(
					InternalNames.GetAccountSavePath( this, _account )
			);

			return	history != null
				?	history as List< HistoryRecord >
				:	new List< HistoryRecord >()
			;
		}

		//---------------------------------------------------------------------

		public void BindTo( ListControl _listControl )
		{
			_listControl.DataSource = m_accounts;
		}

		public override string ToString()
		{
			return Name;
		}

		//---------------------------------------------------------------------
	}
}
