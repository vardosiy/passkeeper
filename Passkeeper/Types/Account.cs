using System;

namespace Passkeeper.Types
{
	class Account
	{
		public string Email { get; set; }

		public string Login { get; set; }

		public string Password { get; set; }

		public Account( string _email, string _login, string _password )
		{
			if (	string.IsNullOrWhiteSpace( _email )
				||	string.IsNullOrWhiteSpace( _login )
				||	string.IsNullOrWhiteSpace( _password )
			)
				throw new Exception( "Invalid data received while creating account" );

			Email = _email;
			Login = _login;
			Password = _password;
		}
	}
}
