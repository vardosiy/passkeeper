using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model
{
	public class Controller
	{
		//---------------------------------------------------------------------

		private BindingList< Resource > m_resources;

		//---------------------------------------------------------------------

		public Controller()
		{
			LoadData();
		}

		public void LoadData()
		{
			m_resources	=	FileProcessor.RestoreResources( Path.Combine( "data", "1234567piu" ) )
						??	new BindingList< Resource >();
		}

		//---------------------------------------------------------------------

		public void AddResource( Resource _resource )
		{
			if ( m_resources.Contains( _resource ) )
			{
				Utils.MessageUtils.ShowError( "Resource with such name already exists" );
				return;
			}
			
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

		//---------------------------------------------------------------------

		public void BindTo( ListControl _listControl )
		{
			_listControl.DataSource = m_resources;
		}

		public void SaveToFile()
		{
			FileProcessor.SaveResources( m_resources, Path.Combine( "data", "1234567piu" ) );
		}

		//---------------------------------------------------------------------
	}
}
