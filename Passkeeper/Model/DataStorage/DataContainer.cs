using System;
using System.ComponentModel;
using System.Windows.Forms;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model
{
	public class DataContainer : IStorable
	{
		//---------------------------------------------------------------------

		private BindingList< Resource > m_data;

		//---------------------------------------------------------------------

		public DataContainer()
		{
			LoadData();
		}

		//---------------------------------------------------------------------

		public void AddResource( Resource _resource )
		{
			if ( m_data.Contains( _resource ) )
			{
				Utils.MessageUtils.ShowError( "Resource with such name already exists" );
				return;
			}

			m_data.Add( _resource );
		}

		public int ResourcesCount => m_data.Count;

		public Resource GetResource( int _index )
		{
			return m_data[_index];
		}

		public void RemoveResource( Resource _resource )
		{
			m_data.Remove( _resource );
		}

		//---------------------------------------------------------------------

		public void BindTo( ListControl _listControl )
		{
			_listControl.DataSource = m_data;
		}

		//---------------------------------------------------------------------

		public void LoadData()
		{
			m_data = new BindingList< Resource >();
		}

		public void SaveToFile()
		{
			throw new NotImplementedException();
		}

		//---------------------------------------------------------------------
	}
}
