using System.Collections.Generic;
using System.Security.Claims;

namespace MediaBazaarClassLibrary
{
    public interface ILogin
    {
        Employee Login(Employee employee);
    }
}