using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarClassLibrary
{
    public class EmployeeManager
    {
        public List<Employee> employees;
        private IEmployee dbConnection;

        public EmployeeManager (IEmployee employee)
        {
            this.dbConnection = employee;
            this.employees = this.dbConnection.GetAll();
        }

        public Employee Get(IGetEmployee getEmployee)
        {
            return getEmployee.Get(this.employees);
        }

        public List<Employee> GetAll (IFilterEmployee filter)
        {
            return filter.Filter(this.employees);
        }

        public bool Add(IGetEmployee getEmployee)
        {
            Employee employee = getEmployee.Get(this.employees);

            foreach (Employee e in this.employees)
            {
                if (e.BSN == employee.BSN)
                {
                    this.dbConnection.ReHire(employee);
                    return false;
                }
            }

            this.dbConnection.Add(employee);
            this.employees = this.dbConnection.GetAll();
            return true;
        }

        public bool Update(IGetEmployee getEmployee)
        {
            Employee employee = getEmployee.Get(this.employees);

            foreach (Employee e in this.employees)
            {
                if (e.BSN == employee.BSN)
                {
                    this.dbConnection.Update(employee);
                    this.employees = this.dbConnection.GetAll();
                    return true;
                }
            }

            return false;
        }

        public bool Remove(int id)
        {
            foreach (Employee e in this.employees)
            {
                if (e.ID == id)
                {
                    this.dbConnection.Remove(id);
                    this.employees = this.dbConnection.GetAll();
                    return true;
                }
            }

            return false;
        }
    }
}