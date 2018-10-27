using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using Passkeeper.Types;

namespace Passkeeper.Core
{
	public class Resource
	{
		public string Name { get; set; }

		private BindingList< Account > m_accounts = new BindingList< Account >();

		public Resource( string _name )
		{
			Name = _name;
		}

		public void BindTo( ComboBox _comboBox )
		{
			_comboBox.DataSource = m_accounts;
		}

		public void AddAccount( Account _account )
		{
			m_accounts.Add( _account );
		}

		public int AccountsCount
		{
			get => m_accounts.Count;
		}

		public Account GetAccount( int _index )
		{
			return m_accounts[ _index ];
		}

		public void RemoveAccount( Account _account )
		{
			m_accounts.Remove( _account );
		}

		public List< HistoryRecord > GetAccountHistory( int _index )
		{
			return null;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
