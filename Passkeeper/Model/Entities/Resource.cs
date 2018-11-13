using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Passkeeper.Model.Entities
{
	[Serializable]
	public class Resource : IComparable< Resource >
	{
		//---------------------------------------------------------------------

		private BindingList< Account > m_accounts = new BindingList< Account >();
		private int m_currentAccountInternalIndex = -1;

		public string Name { get; private set; }

		//---------------------------------------------------------------------

		public Resource( string _name )
		{
			Name = _name;
		}

		//---------------------------------------------------------------------

		public void AddAccount( Account _account )
		{
			_account.InternalIndex = ++m_currentAccountInternalIndex;
			m_accounts.Add( _account );
		}

		public int AccountsCount => m_accounts.Count;

		public Account GetAccount( int _index )
		{
			return m_accounts[ _index ];
		}

		public void RemoveAccount( Account _account )
		{
			m_accounts.Remove( _account );
		}

		//---------------------------------------------------------------------

		// TODO
		public void AddAccountHistoryRecord( HistoryRecord _record )
		{
			return;
		}

		// TODO
		public List<HistoryRecord> GetAccountHistory( Account _account )
		{
			SaveRestore.InternalNames.GetSavePathForAccount( this, _account );

			return null;
		}

		// TODO
		public void DeleteAccountHistory( Account _account )
		{
			return;
		}

		//---------------------------------------------------------------------

		public void BindTo( ListControl _listControl )
		{
			_listControl.DataSource = m_accounts;
		}

		public int CompareTo( Resource _other )
		{
			return string.Compare( Name, _other.Name );
		}

		public override string ToString()
		{
			return Name;
		}

		//---------------------------------------------------------------------
	}
}
