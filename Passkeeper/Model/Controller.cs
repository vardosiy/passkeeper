using System;
using System.ComponentModel;
using System.Windows.Forms;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model
{
	public class Controller
	{
		private BindingList< Resource > m_resources = new BindingList< Resource >();

		private string Username { get; set; }

		public void LoadData( string _username )
		{
			throw new NotImplementedException();
		}

		public object DataContainer => m_resources;

		public void AddResource( Resource _resource )
		{
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
		}

		public void BindTo( ListControl _listControl )
		{
			_listControl.DataSource = m_resources;
		}
	}
}
