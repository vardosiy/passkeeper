using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Passkeeper.Model;
using Passkeeper.Model.Entities;
using Passkeeper.View.Forms;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class ApplicationPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		private Controller m_controller;
		private IApplicationForm m_form;

		//---------------------------------------------------------------------

		public ApplicationPresenter( IApplicationForm _form, Controller _controller )
		{
			m_controller = _controller;
			m_form = _form;

			m_form.Load += Form_Load;

			m_form.AddAccountButton_Clicked += AddAccountButton_Clicked;
			m_form.RemoveResourceButton_Clicked += RemoveResourceButton_Clicked;
			m_form.SelectedResourceChanged += SelectedResourceChanged;

			m_form.AddResourceButton_Clicked += AddResourceButton_Clicked;
			m_form.EditAccountButton_Clicked += EditAccountButton_Clicked;
			m_form.RemoveAccount_Clicked += RemoveAccount_Clicked;

			m_form.ShowAccountHistory_Clicked += ShowAccountHistory_Clicked;
			m_form.DeleteAccountHistory_Clicked += DeleteAccountHistory_Clicked;
		}

		public void Run()
		{
			m_form.ShowDialog();
		}

		//---------------------------------------------------------------------

		private void Form_Load( object _sender, EventArgs _e )
		{
			LoginPresenter presenter = new LoginPresenter(
					new LoginForm()
				,	( _presenter ) =>
					{
						if ( !_presenter.LogedIn )
							m_form.Close();

						return true;
					}
			);

			presenter.Run();
			
			m_controller.BindTo( m_form.ResourcesList );
		}

		//---------------------------------------------------------------------

		private void AddResourceButton_Clicked( object _sender, EventArgs _e )
		{
			AddResourcePresenter presetner = new AddResourcePresenter( m_controller, new AddResourceForm() );
			presetner.Run();

			m_controller.BindTo( m_form.ResourcesList );
		}

		private void RemoveResourceButton_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
				"Are you sure, you want to remove data about all accounts asociated with this resource?"
			);

			if ( result != DialogResult.OK )
				return;

			m_controller.RemoveResource( m_form.SelectedResource as Resource );
		}

		private void SelectedResourceChanged( object _sender, EventArgs _e )
		{
			if ( m_form.SelectedResource == null )
				return;

			Resource selectedResource = m_form.SelectedResource as Resource;
			selectedResource.BindTo( m_form.AccountsList );

			if ( selectedResource.AccountsCount > 0 )
				m_form.AccountsList.SelectedIndex = 0;
			else
				m_form.AccountsList.Text = string.Empty;
		}

		//---------------------------------------------------------------------

		private void AddAccountButton_Clicked( object _sender, EventArgs _e )
		{
			AddAccountPresetner presetner = new AddAccountPresetner(
					m_form.SelectedResource as Resource
				,	new AddAccountForm()
			);

			presetner.Run();
		}

		private void EditAccountButton_Clicked( object _sender, EventArgs _e )
		{
			Account selectedAccount = m_form.SelectedAccount as Account;
			EditAccountForm form = new EditAccountForm(
					selectedAccount.Email
				,	selectedAccount.Login
				,	selectedAccount.Password
			);
			EditAccountPresenter presenter = new EditAccountPresenter( selectedAccount, form );

			presenter.Run();

			if ( object.ReferenceEquals( presenter.Result, selectedAccount ) )
				return;

			Resource selectedResource = m_form.SelectedResource as Resource;

			selectedResource.RemoveAccount( selectedAccount );
			selectedResource.AddAccount( presenter.Result );

			selectedResource.AddAccountHistoryRecord( new HistoryRecord( selectedAccount, DateTime.Now ) );
		}

		private void RemoveAccount_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
				"Are you sure, you want to remove data about all accounts asociated with this resource?"
			);

			if ( result != DialogResult.OK )
				return;

			Resource selectedResource = m_form.SelectedResource as Resource;
			selectedResource.RemoveAccount( m_form.SelectedAccount as Account );
		}

		//---------------------------------------------------------------------

		private void ShowAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			//Account selectedAccount = m_form.SelectedAccount as Account;
			//Resource selectedResource = m_form.SelectedResource as Resource;

			//List<HistoryRecord> list = new List<HistoryRecord>();
			//list.Add( new HistoryRecord( "email0", "login0", "pass0", DateTime.Now ) );
			//list.Add( new HistoryRecord( "email1", "login1", "pass1", DateTime.Now.AddHours( 1.0 ) ) );
			//list.Add( new HistoryRecord( "email2", "login2", "pass2", DateTime.Now.AddHours( 2.0 ) ) );
			//list.Add( new HistoryRecord( "email3", "login3", "pass3", DateTime.Now.AddHours( 3.0 ) ) );
			//list.Add( new HistoryRecord( "email4", "login4", "pass4", DateTime.Now.AddHours( 4.0 ) ) );
			//list.Add( new HistoryRecord( "email5", "login5", "pass5", DateTime.Now.AddHours( 5.0 ) ) );

			//AccountHistoryPresenter presenter = new AccountHistoryPresenter(
			//		new AccountHistoryForm()
			//	,	list /*selectedResource.GetAccountHistory( selectedAccount )*/
			//);

			//presenter.Run();

			m_controller.SaveToFile();
		}

		private void DeleteAccountHistory_Clicked( object _sender, EventArgs _e )
		{
			DialogResult result = Utils.MessageUtils.ShowWarning(
				"Are you sure, you want to clear history for this account?"
			);

			if ( result != DialogResult.OK )
				return;

			Account selectedAccount = m_form.SelectedAccount as Account;
			Resource selectedResource = m_form.SelectedResource as Resource;

			selectedResource.DeleteAccountHistory( selectedAccount );
		}

		//---------------------------------------------------------------------
	}
}
