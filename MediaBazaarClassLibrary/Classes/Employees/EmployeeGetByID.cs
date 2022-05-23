using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class EmployeeGetByID : IGetEmployee
    {
        private int id;

        public EmployeeGetByID(int id)
        {
            this.id = id;
        }

        public Employee Get(List<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                if (e.ID == this.id)
                {
                    return e;
                }
            }

            return null;
        }
    }
}