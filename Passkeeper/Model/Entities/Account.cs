using System;

namespace Passkeeper.Model.Entities
{
	[Serializable]
	public class Account
	{
		//---------------------------------------------------------------------

		public string Email { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		//---------------------------------------------------------------------

		public Account( string _email, string _login, string _password )
		{
			Email = _email;
			Login = _login;
			Password = _password;
		}

		public Account( Account _account )
		{
			Email = _account.Email;
			Login = _account.Login;
			Password = _account.Password;
		}

		//---------------------------------------------------------------------

		public override string ToString()
		{
			if ( Email == string.Empty )
				return Login;
			else if ( Login == string.Empty )
				return Email;

			return Email + " " + Login;
		}

		//---------------------------------------------------------------------
	}
}
