using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passkeeper.Core
{
	public interface IPasskeeper
	{
		void AddAccount( Types.Account _account );

		void Load();

		void GetPasswordHistory( string _resourceName );

		void Access();

		Types.Account GetCurrentData( string _resourceName );
	}
}
