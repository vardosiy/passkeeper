﻿using System;

using Passkeeper.Model;
using Passkeeper.Model.Entities;
using Passkeeper.View.Interfaces;

namespace Passkeeper.Presenters
{
	public class AddResourcePresenter : IPresenter
	{
		//---------------------------------------------------------------------

		readonly private IAddResourceForm m_form;
		private Model.Model m_model;

		//---------------------------------------------------------------------

		public AddResourcePresenter(
				Model.Model _model
			,	IAddResourceForm _form
		)
		{
			m_form = _form;
			m_model = _model;

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
			if ( m_form.ResourceName == string.Empty )
			{
				m_form.Close();
				return;
			}

			Resource resource = new Resource( m_form.ResourceName );

			m_model.DataContainer.AddResource( resource );
			m_form.Close();
		}

		private void CancelButton_Clicked( object _sender, EventArgs _e )
		{
			m_form.Close();
		}

		//---------------------------------------------------------------------
	}
}
