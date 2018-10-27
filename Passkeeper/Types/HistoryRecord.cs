using System;

namespace Passkeeper.Types
{
	public class HistoryRecord : Account
	{
		public DateTime ChangeTime { get; set; }

		public HistoryRecord( Account _account, DateTime _changeTime )
			:	base( _account )
		{
			ChangeTime = _changeTime;
		}
	}
}
