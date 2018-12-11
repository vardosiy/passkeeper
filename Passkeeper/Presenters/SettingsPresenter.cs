using System;

using Passkeeper.Model;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class SettingsPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		enum WorkMode { ChangePassword, ChangeUsername }

		ISettingsForm m_form;
		UserManager m_userManager;
		WorkMode m_workMode = WorkMode.ChangeUsername;

		//---------------------------------------------------------------------

		public SettingsPresenter(
				UserManager _userManager
			,	ISettingsForm _form
		)
		{
			m_form = _form;
			m_userManager = _userManager;

			m_form.ApplyButton_Clicked += OKButton_Clicked;
			m_form.CancelButton_Clicked += CancelButton_Clicked;
			m_form.ChangeModeButton_Clicked += ChangeModeButton_Clicked;
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
				case WorkMode.ChangePassword:
					OKButtonChangePasswordMode_Clicked();
					break;

				case WorkMode.ChangeUsername:
					OKButtonChangeUsernameMode_Clicked();
					break;
			}
		}
		private void CancelButton_Clicked( object _sender, EventArgs _e )
		{
			m_form.Close();
		}
		private void ChangeModeButton_Clicked( object _sender, EventArgs _e )
		{
			switch ( m_workMode )
			{
				case WorkMode.ChangeUsername:
				{
					m_workMode = WorkMode.ChangePassword;

					m_form.CentralLabel.Text = "Password:";
					m_form.ChangeModeButtonText = "Change Username";

					m_form.NewPassword.Visible = true;
					m_form.NewPasswordLabelVisible = true;
					m_form.ConfirmPassword.Visible = true;
					m_form.ConfirmPasswordLabelVisible = true;

					m_form.CentralTextBox.PasswordChar = '*';
					m_form.CentralTextBox.Text = string.Empty;

					break;
				}

				case WorkMode.ChangePassword:
				{
					m_workMode = WorkMode.ChangeUsername;

					m_form.CentralLabel.Text = "Username:";
					m_form.ChangeModeButtonText = "Change Password";

					m_form.NewPassword.Visible = false;
					m_form.NewPasswordLabelVisible = false;
					m_form.ConfirmPassword.Visible = false;
					m_form.ConfirmPasswordLabelVisible = false;

					m_form.CentralTextBox.PasswordChar = '\0';
					m_form.CentralTextBox.Text = string.Empty;
					m_form.NewPassword.Text = string.Empty;
					m_form.ConfirmPassword.Text = string.Empty;

					break;
				}
			}
		}

		//---------------------------------------------------------------------

		private void OKButtonChangePasswordMode_Clicked()
		{
			if ( !m_userManager.TryLogin( m_userManager.CurrentUser, m_form.CentralLabel.Text ) )
			{
				Utils.MessageUtils.ShowError( "Invalid current password." );
				return;
			}

			if ( m_form.NewPassword.Text != m_form.ConfirmPassword.Text )
			{
				Utils.MessageUtils.ShowError( "Passwords not matching." );
				return;
			}

			m_userManager.ChangePassword( m_form.NewPassword.Text );

			Utils.MessageUtils.ShowInfo( "Password changed successfully." );
		}
		private void OKButtonChangeUsernameMode_Clicked()
		{
			if ( m_form.CentralTextBox.Text == string.Empty )
			{
				Utils.MessageUtils.ShowError( "Invalid input." );
				return;
			}

			m_userManager.ChangeUsername( m_form.CentralTextBox.Text );
			m_userManager.CurrentUser = m_form.CentralTextBox.Text;

			Utils.MessageUtils.ShowInfo( "Username changed successfully." );
		}

		//---------------------------------------------------------------------
	}
}
