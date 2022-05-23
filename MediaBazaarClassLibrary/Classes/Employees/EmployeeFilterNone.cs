using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class EmployeeFilterNone : IFilterEmployee
    {
        public EmployeeFilterNone() { }

        public List<Employee> Filter(List<Employee> employees)
        {
            return employees;
        }
    }
}