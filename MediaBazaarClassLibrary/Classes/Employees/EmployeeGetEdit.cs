using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class EmployeeGetEdit : IGetEmployee
    {
        private Employee oldEmployee;
        private Employee newEmployee;

        public EmployeeGetEdit(Employee oldEmployee, Employee newEmployee)
        {
            this.oldEmployee = oldEmployee;
            this.newEmployee = newEmployee;
        }

        public Employee Get(List<Employee> employees)
        {
            if (oldEmployee.FirstName.Substring(0, 3) != newEmployee.FirstName.Substring(0, 3))
            {
                int number = 1;
                string name = this.newEmployee.FirstName.Substring(0, 3);
                string username = "";
                foreach (Employee e in employees)
                {
                    if (number < 10)
                    {
                        username = name + "0" + number.ToString();
                    }
                    else
                    {
                        username = name + number.ToString();
                    }

                    if (e.Username == username)
                    {
                        number++;
                    }
                }
                if (number < 10)
                {
                    username = name + "0" + number.ToString();
                }
                else
                {
                    username = name + number.ToString();
                }

                return new Employee(this.newEmployee.ID,
                    this.newEmployee.BSN,
                    this.newEmployee.WorkingHours,
                    this.newEmployee.Position,
                    this.newEmployee.Salary,
                    this.newEmployee.IsActive,
                    this.newEmployee.BirthDate,
                    this.newEmployee.HireDate,
                    this.newEmployee.Gender,
                    this.newEmployee.FirstName,
                    this.newEmployee.LastName,
                    username,
                    this.newEmployee.Password,
                    this.newEmployee.Phone,
                    this.newEmployee.Email,
                    this.newEmployee.Postal,
                    this.newEmployee.ContactName,
                    this.newEmployee.ContactPhone
                    );
            }
            else
            {
                return new Employee(this.newEmployee.ID,
                    this.newEmployee.BSN,
                    this.newEmployee.WorkingHours,
                    this.newEmployee.Position,
                    this.newEmployee.Salary,
                    this.newEmployee.IsActive,
                    this.newEmployee.BirthDate,
                    this.newEmployee.HireDate,
                    this.newEmployee.Gender,
                    this.newEmployee.FirstName,
                    this.newEmployee.LastName,
                    this.oldEmployee.Username,
                    this.newEmployee.Password,
                    this.newEmployee.Phone,
                    this.newEmployee.Email,
                    this.newEmployee.Postal,
                    this.newEmployee.ContactName,
                    this.newEmployee.ContactPhone
                    );
            }
        }
    }
}