using System;

using Passkeeper.Model.Entities;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class EditAccountPresenter : IPresenter
	{
		//---------------------------------------------------------------------

		readonly IEditAccountForm m_form;
		Account m_selectedAccount;

		//---------------------------------------------------------------------

		public EditAccountPresenter(
				Account _selectedAccount
			,	IEditAccountForm _form
		)
		{
			m_form = _form;
			m_selectedAccount = _selectedAccount;

			m_form.OKButton_Clicked += OKButton_Clicked;
			m_form.CancelButton_Clicked += CancelButton_Clicked;
		}

		public void Run()
		{
			m_form.ShowDialog();
		}

		//---------------------------------------------------------------------

		private void OKButton_Clicked( object _sender, EventArgs _e )
		{
			if (	m_form.Password == string.Empty
				||	m_form.Email == string.Empty && m_selectedAccount.Email != string.Empty
				||	m_form.Login == string.Empty && m_selectedAccount.Login != string.Empty
			)
			{
				Utils.MessageUtils.ShowWarning(
						"You have cleared some field(s), changes will not be applied."
				);

				m_form.Close();
				return;
			}

			m_selectedAccount.Email = m_form.Email;
			m_selectedAccount.Login = m_form.Login;
			m_selectedAccount.Password = m_form.Password;

			m_form.Close();
		}
		private void CancelButton_Clicked( object _sender, EventArgs _e )
		{
			m_form.Close();
		}

		//---------------------------------------------------------------------
	}
}
