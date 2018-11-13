using System;

using Passkeeper.Model;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class SignInPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		private ISignInForm m_form;
		private UserManager m_userManager;

		private WorkMode m_workMode = WorkMode.SignIn;

		//---------------------------------------------------------------------

		private enum WorkMode { SignIn, Create }

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
					ProcessOKButtonLoginMode();
					break;

				case WorkMode.Create:
					ProcessOKButtonCreateMode();
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
					m_form.ChangeModeButtonText = "Create User";
					m_form.ConfirmTextBoxVisible = false;
					m_form.ConfirmLabelVisible = false;
					break;

				case WorkMode.Create:
					m_form.ChangeModeButtonText = "Sign In";
					m_form.ConfirmTextBoxVisible = true;
					m_form.ConfirmLabelVisible = true;
					break;
			}
		}

		//---------------------------------------------------------------------\
		
		private void ProcessOKButtonLoginMode()
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

		private void ProcessOKButtonCreateMode()
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
