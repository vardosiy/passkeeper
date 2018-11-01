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

			Presenters.ApplicationPresenter presenter = new Presenters.ApplicationPresenter(
					new View.Forms.ApplicationForm()
				,	new Model.Controller()
			);

			presenter.Run();
		}
	}
}
