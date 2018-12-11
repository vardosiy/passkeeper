using System;
using System.Windows.Forms;

namespace Passkeeper
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			Model.SaveRestore.InternalNames.SaveDirectory = "data";
			Presenters.ApplicationPresenter presenter = new Presenters.ApplicationPresenter(
					new View.Forms.ApplicationForm()
				,	new Model.Model()
			);

			presenter.Run();
		}
	}
}
