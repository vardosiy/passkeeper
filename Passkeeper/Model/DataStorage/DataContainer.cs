using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

using Passkeeper.Model.SaveRestore;
using Passkeeper.Model.Entities;

namespace Passkeeper.Model
{
	public class DataContainer : Storable
	{
		//---------------------------------------------------------------------

		BindingList< Resource > m_data;

		//---------------------------------------------------------------------

		public DataContainer()
		{
			LoadData();
		}

		~DataContainer()
		{
			SaveToFile();
		}

		//---------------------------------------------------------------------

		public void AddResource( Resource _resource )
		{
			if ( m_data.Contains( _resource ) )
			{
				MessageUtils.ShowError( "Resource with such name already exists" );
				return;
			}

			m_data.Add( _resource );
		}

		public void RemoveResource( Resource _resource )
		{
			string savePath = InternalNames.GetResourceSavePath( _resource );

			if ( Directory.Exists( savePath ) )
				Directory.Delete( savePath );

			m_data.Remove( _resource );
		}

		public Resource GetResource( int _index )
		{
			return m_data[_index];
		}

		public int ResourcesCount => m_data.Count;

		//---------------------------------------------------------------------

		public void BindTo( ListControl _listControl )
		{
			_listControl.DataSource = m_data;
		}

		//---------------------------------------------------------------------

		protected override void LoadData()
		{
			var data = FileProcessor.Restore( InternalNames.DataContainerSavePath );

			if ( data == null )
				m_data = new BindingList< Resource >();
			else
				m_data = data[0] as BindingList< Resource >;
		}

		protected override void SaveToFile()
		{
			FileProcessor.Save(
					InternalNames.DataContainerSavePath
				,	m_data
			);
		}

		//---------------------------------------------------------------------
	}
}
