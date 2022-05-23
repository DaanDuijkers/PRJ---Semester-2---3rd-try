using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class LoginManager
    {
        private ILogin dbConnection;

        public LoginManager (ILogin login)
        {
            this.dbConnection = login;
        }

        public Employee Login(Employee employee)
        {
            return this.dbConnection.Login(employee);
        }
    }
}