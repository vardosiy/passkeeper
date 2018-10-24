using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passkeeper.Core
{
	interface IPasskeeper
	{
		void Load();

		NamePassword GetCurrentData( string _resourceName );

		void GetPasswordHistory( string _resourceName );

		void Access();
	}
}
