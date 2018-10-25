using System;
using System.Windows.Forms;
using Passkeeper.Gui.Forms;

namespace Passkeeper
{
	public partial class ApplicationForm : Form
	{
		//---------------------------------------------------------------------

		public ApplicationForm()
		{
			InitializeComponent();
		}

		//---------------------------------------------------------------------

		private void AddResourceButton_Click( object sender, EventArgs e )
		{
			ResourceList.Items.Add( "item_0" );
			ResourceList.Items.Add( "item_1" );
			ResourceList.Items.Add( "item_2" );
			ResourceList.Items.Add( "item_3" );

			AddResourceForm form = new AddResourceForm();
			DialogResult result = form.ShowDialog();

			if ( result != DialogResult.OK )
				return;
		}

		//---------------------------------------------------------------------

		private void RemoveResourceButton_Click( object sender, EventArgs e )
		{
			if ( ResourceList.SelectedItem == null )
				return;

			bool isUserSure = Gui.GuiUtils.ShowWarning(
					"Are you sure, you want to remove data about all account asociated with this resource?"
			);

			if ( !isUserSure )
				return;

			// TODO...
		}

		//---------------------------------------------------------------------

		private void AddAccountButton_Click( object sender, EventArgs e )
		{
			AddAccountForm form = new AddAccountForm();
			DialogResult result = form.ShowDialog();

			if ( result != DialogResult.OK )
				return;
		}

		//---------------------------------------------------------------------

		private void ClearHistoryButton_Click( object sender, EventArgs e )
		{
			bool isUserSure = Gui.GuiUtils.ShowWarning(
					"Are you sure, you want to clear history for this account?"
			);

			if ( !isUserSure )
				return;

			// TODO...
		}

		//---------------------------------------------------------------------
	}
}
