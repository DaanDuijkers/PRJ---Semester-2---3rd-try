using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class EmployeeGetAdd : IGetEmployee 
    {
        private Employee employee;

        public EmployeeGetAdd (Employee employee)
        {
            this.employee = employee;
        }

        public Employee Get(List<Employee> employees)
        {
            int number = 1;
            string name = this.employee.FirstName.Substring(0, 3);
            string username = "";
            foreach (Employee e in employees)
            {
                if (number < 10)
                {
                    username = name + "0" + number;
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
                username = name + "0" + number;
            }
            else
            {
                username = name + number.ToString();
            }

            string password = "";
            bool hasPassword = false;
            while (hasPassword == false)
            {
                char[] characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    password += characters[random.Next(0, characters.Length)].ToString();
                }

                hasPassword = true;
                foreach (Employee e in employees)
                {
                    if (e.Password == password)
                    {
                        hasPassword = false;
                    }
                }
            }

            return new Employee(this.employee.BSN,
                this.employee.WorkingHours,
                this.employee.Position,
                this.employee.Salary,
                this.employee.IsActive,
                this.employee.BirthDate,
                this.employee.HireDate,
                this.employee.Gender,
                this.employee.FirstName,
                this.employee.LastName,
                username,
                password,
                this.employee.Phone,
                this.employee.Email,
                this.employee.Postal,
                this.employee.ContactName,
                this.employee.ContactPhone
                );
        }
    }
}