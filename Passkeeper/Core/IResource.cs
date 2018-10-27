using System.Collections.Generic;
using System.Windows.Forms;

namespace Passkeeper.Core
{
	public interface IResource
	{
		string Name { get; set; }

		int AccountsCount { get; }

		void BindTo( ComboBox _comboBox );

		Types.Account GetAccount( int _index );

		List<Types.HistoryRecord> GetAccountHistory( int _index );
	}
}
