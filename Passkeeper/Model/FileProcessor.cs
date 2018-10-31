using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

using Passkeeper.Model.Entities;

namespace Passkeeper.Model
{
	public class FileProcessor
	{
		public static void SaveToFile( List< HistoryRecord > _historyRecords)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();

			DateTime dateTime = new DateTime( 2018, 10, 29, 19, 43, 20 );
			HistoryRecord record = new HistoryRecord( "aa", "bb", "cc", dateTime );

			using ( FileStream fs = new FileStream( "temp.dat", FileMode.OpenOrCreate ) )
			{
				binaryFormatter.Serialize( fs, record );
			}

			using ( FileStream fs = new FileStream( "temp.dat", FileMode.OpenOrCreate ) )
			{
				HistoryRecord newPerson = (HistoryRecord)binaryFormatter.Deserialize( fs );
			}
		}
	}
}
