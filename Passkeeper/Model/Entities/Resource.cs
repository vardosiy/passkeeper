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

		uint m_currentAccountInternalIndex = uint.MinValue;

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
			RemoveAccountHistory( _account );

			Account lastAddedAcc = m_accounts[m_accounts.Count - 1];
			FileProcessor.MoveAccountSaveDirectory( this, _account, lastAddedAcc );

			lastAddedAcc.InternalIndex = _account.InternalIndex;
			--m_currentAccountInternalIndex;

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
				throw new MaxAmountOfAccounts();

			return ++m_currentAccountInternalIndex;
		}

		//---------------------------------------------------------------------

		public void AddAccountHistoryRecord( HistoryRecord _record )
		{
			var currentHistory = GetAccountHistory( _record );
			currentHistory.Add( _record );

			FileProcessor.Save(
					InternalNames.GetAccountSavePath( this, _record ) 
				,	currentHistory
			);
		}

		public void RemoveAccountHistory( Account _account )
		{
			string savePath = InternalNames.GetAccountSavePath( this, _account );

			if ( File.Exists( savePath ) )
				File.Delete( savePath );
		}

		public List< HistoryRecord > GetAccountHistory( Account _account )
		{
			var history = FileProcessor.Restore(
					InternalNames.GetAccountSavePath( this, _account )
			);

			return	history != null
				?	history[0] as List< HistoryRecord >
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
