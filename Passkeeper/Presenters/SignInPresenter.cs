using System;
using System.Windows.Forms;

using Passkeeper.Model;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class SignInPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		enum WorkMode { SignIn, Create }

		readonly ISignInForm m_form;
		UserManager m_userManager;
		WorkMode m_workMode = WorkMode.SignIn;

		//---------------------------------------------------------------------

		public SignInPresenter(
				ISignInForm _form
			,	UserManager _userManager
		)
		{
			m_form = _form;
			m_userManager = _userManager;

			m_form.OKButton_Clicked += OKButton_Clicked;
			m_form.CreateUserButton_Clicked += CreateUserButton_Clicked;
		}

		public void Run()
		{
			m_form.ShowDialog();
		}

		//---------------------------------------------------------------------

		private void OKButton_Clicked( object _sender, EventArgs _e )
		{
			switch ( m_workMode )
			{
				case WorkMode.SignIn:
					OKButtonLoginMode_Clicked();
					break;

				case WorkMode.Create:
					OKButtonCreateMode_Clicked();
					break;
			}
		}
		private void CreateUserButton_Clicked( object _sender, EventArgs _e )
		{
			m_workMode = m_workMode == WorkMode.SignIn
				?	WorkMode.Create
				:	WorkMode.SignIn;

			switch ( m_workMode )
			{
				case WorkMode.SignIn:
					(_sender as Button).Text = "Create User";
					m_form.ConfirmTextBoxVisible = false;
					m_form.ConfirmLabelVisible = false;
					break;

				case WorkMode.Create:
					( _sender as Button ).Text = "Sign In";
					m_form.ConfirmTextBoxVisible = true;
					m_form.ConfirmLabelVisible = true;
					break;
			}
		}

		//---------------------------------------------------------------------\
		
		private void OKButtonLoginMode_Clicked()
		{
			if ( !m_userManager.IsUserExists( m_form.Username ) )
			{
				Utils.MessageUtils.ShowError( "User with such name does not exist." );
				return;
			}

			if ( m_userManager.TryLogin( m_form.Username, m_form.Password ) )
			{
				m_userManager.CurrentUser = m_form.Username;
				m_form.Close();
			}
			else
			{
				Utils.MessageUtils.ShowError( "Invalid password!" );
			}
		}
		private void OKButtonCreateMode_Clicked()
		{
			if (	m_form.Username == string.Empty
				||	m_form.Password == string.Empty
				||	m_form.Confirmation == string.Empty
			)
			{
				Utils.MessageUtils.ShowError( "Invalid input." );
				return;
			}

			if ( m_userManager.IsUserExists( m_form.Username ) )
			{
				Utils.MessageUtils.ShowError( "User with such name already exists." );
				return;
			}

			if ( m_form.Password != m_form.Confirmation )
			{
				Utils.MessageUtils.ShowError( "Passwords not matching." );
				return;
			}

			m_userManager.AddUser( m_form.Username, m_form.Password );
			m_userManager.CurrentUser = m_form.Username;
			m_form.Close();
		}

		//---------------------------------------------------------------------
	}
}
