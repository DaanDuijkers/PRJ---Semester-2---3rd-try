using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class LoginTest : ILogin
    {
        public List<Employee> employees;

        public LoginTest ()
        {
            this.employees = new List<Employee>() { new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364"), new Employee(2, 1234, 40, new Position(4, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "testNonAdmin", "testNonAdmin", "testNonAdmin", "testNonAdmin", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364") };
        }

        public Employee Login(Employee employee)
        {
            foreach (Employee e in this.employees)
            {
                if (e.Username == employee.Username && e.Password == employee.Password)
                {
                    if (e.Position.ID == 1 || e.Position.ID == 2 || e.Position.ID == 3)
                    {
                        return e;
                    }
                }
            }

            return null;
        }
    }
}