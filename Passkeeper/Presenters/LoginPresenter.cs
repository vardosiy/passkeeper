using System;

using Passkeeper.Model;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class LoginPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		private readonly Func< LoginPresenter, bool > m_formClosedCallback;
		private readonly ILoginForm m_form;

		private PasswordChecker m_passwordChecker = new PasswordChecker();

		public bool LogedIn { get; private set; }

		//---------------------------------------------------------------------

		public LoginPresenter( ILoginForm _form, Func< LoginPresenter, bool > _callback )
		{
			m_form = _form;
			m_formClosedCallback = _callback;

			LogedIn = false;

			m_form.OKButton_Clicked += OKButton_Clicked;
			m_form.FormClosed += FormClosed;
		}

		public void Run()
		{
			m_form.ShowDialog();
		}

		//---------------------------------------------------------------------

		private void OKButton_Clicked( object _sender, EventArgs _e )
		{
			if ( m_passwordChecker.CheckPassword( m_form.Password ) )
			{
				LogedIn = true;
				m_form.Close();
			}
			else
				Utils.MessageUtils.ShowError( "Invalid password!" );
		}

		//---------------------------------------------------------------------

		private void FormClosed( object _sender, System.Windows.Forms.FormClosedEventArgs _e )
		{
			m_formClosedCallback( this );
		}

		//---------------------------------------------------------------------
	}
}
