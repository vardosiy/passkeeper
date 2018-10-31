using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

			Model.Controller controller = new Model.Controller();
			View.Forms.ApplicationForm mainForm = new View.Forms.ApplicationForm();

			Presenters.ApplicationPresenter presenter =
				new Presenters.ApplicationPresenter( mainForm, controller );

			Application.Run( mainForm );
		}
	}
}
