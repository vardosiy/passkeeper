using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model
{
	public class Controller
	{
		private BindingList< Resource > m_resources = new BindingList< Resource >();
		private SortedSet< Resource > m_register = new SortedSet< Resource >();

		//---------------------------------------------------------------------

		public Controller()
		{
			// LoadDAta;
		}

		public void LoadData()
		{
			throw new NotImplementedException();
		}

		//---------------------------------------------------------------------

		public void AddResource( Resource _resource )
		{
			if ( m_register.Contains( _resource ) )
			{
				Utils.MessageUtils.ShowError( "Resource with such name already exists" );
				return;
			}

			m_register.Add( _resource );
			m_resources.Add( _resource );
		}

		public int ResourcesCount => m_resources.Count;

		public Resource GetResource( int _index )
		{
			return m_resources[ _index ];
		}

		public void RemoveResource( Resource _resource )
		{
			m_resources.Remove( _resource );
			m_register.Remove( _resource );
		}

		public void BindTo( ListControl _listControl )
		{
			_listControl.DataSource = m_resources;
		}

		//---------------------------------------------------------------------
	}
}
