using System;

namespace Passkeeper.Model.Entities
{
	[Serializable]
	public class HistoryRecord : Account
	{
		//---------------------------------------------------------------------

		public DateTime ChangeTime { get; private set; }

		//---------------------------------------------------------------------

		public HistoryRecord( Account _account, DateTime _changeTime )
			:	base( _account )
		{
			ChangeTime = _changeTime;
		}

		//---------------------------------------------------------------------
	}
}
