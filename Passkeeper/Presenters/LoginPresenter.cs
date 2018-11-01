using System;

using Passkeeper.Model;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class LoginPresenter : IPresenter
	{
		private UserManager m_userManager = new UserManager();
		private readonly ILoginForm m_form;

		public event Action CorrectPasswordEntered;

		public LoginPresenter( ILoginForm _form )
		{
			m_form = _form;

			m_form.OKButton_Clicked += OKButton_Clicked;
		}

		public void Run()
		{
			m_form.ShowDialog();
		}

		private void OKButton_Clicked( object _sender, EventArgs _e )
		{
			if ( m_userManager.CheckPassword( m_form.Username, m_form.Password ) )
				CorrectPasswordEntered?.Invoke();
			else
				Utils.MessageUtils.ShowError( "Invalid password!" );
		}
	}
}
