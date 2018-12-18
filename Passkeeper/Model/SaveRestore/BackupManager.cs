using System;
using System.IO;
using System.IO.Compression;
using static System.Environment;

using Passkeeper.Model.SaveRestore;

namespace Passkeeper.Model
{
	public class BackupManager : Storable
	{
		//---------------------------------------------------------------------

		DateTime m_lastBackupTime;

		public uint BackupPeriod { get; set; }
		public string BackupPath { get; set; }

		//---------------------------------------------------------------------

		public BackupManager()
		{
			LoadData();
		}

		//---------------------------------------------------------------------

		public void Run()
		{
			DateTime current = DateTime.Now;
			if ( current.Subtract( m_lastBackupTime ).TotalDays < BackupPeriod )
				return;

			if ( BackupPeriod == 0 )
				return;

			string data = Path.GetFullPath( InternalNames.SaveDirectory );
			string savePath = Path.Combine(
					BackupPath
				,	InternalNames.CurrentUser + '_' + current.ToString( "yyyy_MM_dd" ) + ".zip"
			);

			Directory.CreateDirectory( Path.GetDirectoryName( savePath ) );

			if ( Directory.Exists( data ) )
			{
				ZipFile.CreateFromDirectory( data, savePath );
				m_lastBackupTime = current;
			}
		}

		//---------------------------------------------------------------------

		public override void Save()
		{
			SaveToFile();
		}

		protected override void LoadData()
		{
			var data = FileProcessor.Restore(
					InternalNames.BackupManagerSavePath
			);

			if( data == null )
			{
				m_lastBackupTime	= new DateTime();
				BackupPeriod		= 0u;
				BackupPath			= Path.Combine( GetFolderPath( SpecialFolder.MyDocuments ), "Passkeeper_Backups" );
			}
			else
			{
				m_lastBackupTime	= (DateTime) data[0];
				BackupPeriod		= (uint) data[1];
				BackupPath			= (string) data[2];
			}
		}

		protected override void SaveToFile()
		{
			FileProcessor.Save(
					InternalNames.BackupManagerSavePath
				,	m_lastBackupTime
				,	BackupPeriod
				,	BackupPath
			);
		}

		//---------------------------------------------------------------------
	}
}