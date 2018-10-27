using System.ComponentModel;
using System.Windows.Forms;

namespace Passkeeper.Core
{
	public class Controller
	{
		private BindingList< Resource > m_resources = new BindingList< Resource >();

		public void BindTo( ListBox _listBox )
		{
			_listBox.DataSource = m_resources;
		}

		public void LoadData()
		{

		}

		public void AddResource( Resource _resource )
		{
			m_resources.Add( _resource );
		}

		public int ResourcesCount
		{
			get => m_resources.Count;
		}

		public Resource GetResource( int _index )
		{
			return m_resources[ _index ];
		}

		public void RemoveResource( Resource _resource )
		{
			m_resources.Remove( _resource );
		}
	}
}