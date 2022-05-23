using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class EmployeeTest : GlobalDBMediator, IEmployee
    {
        private List<Employee> employees;

        public EmployeeTest ()
        {
            this.employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            this.employees.Add(new Employee(this.employees.Count + 1,
                employee.BSN,
                employee.WorkingHours,
                employee.Position,
                employee.Salary,
                employee.IsActive,
                employee.BirthDate,
                employee.HireDate,
                employee.Gender,
                employee.FirstName,
                employee.LastName,
                employee.Username,
                employee.Password,
                employee.Phone,
                employee.Email,
                employee.Postal,
                employee.ContactName,
                employee.ContactPhone
                ));
        }

        public List<Employee> GetAll()
        {
            return this.employees;
        }

        public void ReHire(Employee employee)
        {
            for (int i = 0; i < this.employees.Count(); i++)
            {
                if (this.employees[i].BSN == employee.BSN)
                {
                    this.employees[i] = new Employee(this.employees[i].ID,
                        this.employees[i].BSN,
                        this.employees[i].WorkingHours,
                        this.employees[i].Position,
                        this.employees[i].Salary,
                        true,
                        this.employees[i].BirthDate,
                        this.employees[i].HireDate,
                        this.employees[i].Gender,
                        this.employees[i].FirstName,
                        this.employees[i].LastName,
                        this.employees[i].Username,
                        this.employees[i].Password,
                        this.employees[i].Phone,
                        this.employees[i].Email,
                        this.employees[i].Postal,
                        this.employees[i].ContactName,
                        this.employees[i].ContactPhone
                        );
                    break;
                }
            }
        }

        public void Remove(int id)
        {
            for (int i = 0; i < this.employees.Count; i++)
            {
                if (this.employees[i].ID == id)
                {
                    this.employees[i] = new Employee(this.employees[i].ID,
                        this.employees[i].BSN,
                        this.employees[i].WorkingHours,
                        this.employees[i].Position,
                        this.employees[i].Salary,
                        false,
                        this.employees[i].BirthDate,
                        this.employees[i].HireDate,
                        this.employees[i].Gender,
                        this.employees[i].FirstName,
                        this.employees[i].LastName,
                        this.employees[i].Username,
                        this.employees[i].Password,
                        this.employees[i].Phone,
                        this.employees[i].Email,
                        this.employees[i].Postal,
                        this.employees[i].ContactName,
                        this.employees[i].ContactPhone
                        );
                    break;
                }
            }
        }

        public void Update(Employee employee)
        {
            for (int i = 0; i < this.employees.Count; i++)
            {
                if (this.employees[i].ID == employee.ID)
                {
                    this.employees[i] = new Employee(employee.ID,
                        employee.BSN,
                        employee.WorkingHours,
                        employee.Position,
                        employee.Salary,
                        employee.IsActive,
                        employee.BirthDate,
                        employee.HireDate,
                        employee.Gender,
                        employee.FirstName,
                        employee.LastName,
                        employee.Username,
                        employee.Password,
                        employee.Phone,
                        employee.Email,
                        employee.Postal,
                        employee.ContactName,
                        employee.ContactPhone
                        );
                    break;
                }
            }
        }
    }
}