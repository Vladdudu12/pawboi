using System;
using System.Collections.Generic;
using System.Text;

namespace pawboi
{
    class User : Register, ILogin
    {
        public void Login()
        {
            //implement login
            //cautare in db dupa user si apoi dupa parola
            throw new NotImplementedException();
        }

        public override void registerUser()
        {
            //implement signup
            //add user and pass from form into database user table
            throw new NotImplementedException();
        }
    }
}
