﻿using System;

using Passkeeper.Model.Entities;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class AddAccountPresetner : IPresenter
	{
		//---------------------------------------------------------------------

		readonly IAddAccountForm m_form;
		Resource m_selectedResource;

		//---------------------------------------------------------------------

		public AddAccountPresetner(
				Resource _selectedResource
			,	IAddAccountForm _form
		)
		{
			m_form = _form;
			m_selectedResource = _selectedResource;

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
				||	m_form.Email == string.Empty && m_form.Login == string.Empty
			)
			{
				m_form.Close();
				return;
			}

			Account account = new Account( m_form.Email, m_form.Login, m_form.Password );
			m_selectedResource.AddAccount( account );

			m_form.Close();
		}

		private void CancelButton_Clicked( object _sender, EventArgs _e )
		{
			m_form.Close();
		}

		//---------------------------------------------------------------------
	}
}
