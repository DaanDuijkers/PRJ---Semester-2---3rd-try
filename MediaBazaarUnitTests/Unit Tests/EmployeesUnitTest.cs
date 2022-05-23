using MediaBazaarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MediaBazaarUnitTests
{
    [TestClass]
    public class EmployeesUnitTest
    {
        [TestMethod]
        public void TestAddEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee employee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            bool add = employeeManager.Add(new EmployeeGetAdd(employee));

            Assert.IsTrue(add);
        }

        [TestMethod]
        public void TestRemoveEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee employee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Add(new EmployeeGetAdd(employee));
            bool remove = employeeManager.Remove(1);

            Assert.IsTrue(remove);
        }

        [TestMethod]
        public void TestUpdateEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee oldEmployee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Add(new EmployeeGetAdd(oldEmployee));
            Employee newEmployee = new Employee(1, 1234, 40, new Position(4, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "daan", "test2", "test2", "test2", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            bool update = employeeManager.Update(new EmployeeGetEdit(oldEmployee, newEmployee));

            Assert.IsTrue(update);
        }

        [TestMethod]
        public void TestAddGetEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee employee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Add(new EmployeeGetAdd(employee));
            Employee getEmployee = employeeManager.Get(new EmployeeGetByID(1));

            Assert.AreEqual(employee.FirstName, getEmployee.FirstName);
        }

        [TestMethod]
        public void TestRemoveGetEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee employee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Add(new EmployeeGetAdd(employee));
            employeeManager.Remove(1);
            Employee getEmployee = employeeManager.Get(new EmployeeGetByID(1));

            Assert.IsFalse(getEmployee.IsActive);
        }

        [TestMethod]
        public void TestUpdateGetEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee oldEmployee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Add(new EmployeeGetAdd(oldEmployee));
            Employee newEmployee = new Employee(1, 1234, 40, new Position(4, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "daan", "test2", "test2", "test2", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Update(new EmployeeGetEdit(oldEmployee, newEmployee));
            Employee getEmployee = employeeManager.Get(new EmployeeGetByID(1));

            Assert.AreEqual(getEmployee.Username, "daa01");
        }

        [TestMethod]
        public void TestGetAllEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee employee1 = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Add(new EmployeeGetAdd(employee1));
            Employee employee2 = new Employee(2, 2345, 40, new Position(4, "test", true), 11.15, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "daan", "test2", "test2", "test2", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Add(new EmployeeGetAdd(employee2));
            List<Employee> getAll = employeeManager.GetAll(new EmployeeFilterNone());

            Assert.AreEqual(getAll.Count, 2);
        }

        [TestMethod]
        public void TestAddSameEmployeeTwice()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee employee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            employeeManager.Add(new EmployeeGetAdd(employee));
            bool add = employeeManager.Add(new EmployeeGetAdd(employee));

            Assert.IsFalse(add);
        }

        [TestMethod]
        public void TestRemoveNonExistingEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            bool remove = employeeManager.Remove(1);

            Assert.IsFalse(remove);
        }

        [TestMethod]
        public void TestUpdateNonExistingEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());

            Employee oldEmployee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            Employee newEmployee = new Employee(2, 1234, 40, new Position(4, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "daan", "test2", "test2", "test2", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");
            bool update = employeeManager.Update(new EmployeeGetEdit(oldEmployee, newEmployee));

            Assert.IsFalse(update);
        }

        [TestMethod]
        public void TestFilterEmployeeAvailability()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));
            shiftManager.Add(new Shift(new Position(2, "test", true), new List<Employee>(), Time.Afternoon, new DateTime(2022, 1, 20)));
            shiftManager.Add(new Shift(new Position(3, "test", true), new List<Employee>(), Time.Evening, new DateTime(2022, 1, 20)));
            List<Shift> shifts = shiftManager.GetAll(new ShiftsFilterNone());
            Employee employee1 = new Employee(1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), new DateTime(2022, 1, 20), Gender.Male, "test", "test", "test", "test", "511963", "test@gmail.com", "secret", "contact", "584364");
            Employee employee2 = new Employee(5678, 20, new Position(1, "test", true), 10.15, true, new DateTime(1997, 07, 18), new DateTime(2022, 1, 20), Gender.Male, "test2", "test2", "test2", "test2", "584364", "test2@gmail.com", "secret", "contact", "511963");
            employeeManager.Add(new EmployeeGetAdd(employee1));
            employeeManager.Add(new EmployeeGetAdd(employee2));
            List<Employee> employees = employeeManager.GetAll(new EmployeeFilterAvailability(new Position(1, "test", true), new List<Employee> { new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), new DateTime(2022, 1, 20), Gender.Male, "test", "test", "test", "test", "511963", "test@gmail.com", "secret", "contact", "584364") }, new DateTime(2022, 1, 20), shifts));

            Assert.AreEqual(employees.Count, 1);
        }

        [TestMethod]
        public void TestNoAvailableEmployees()
        {
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeTest());
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));
            shiftManager.Add(new Shift(new Position(2, "test", true), new List<Employee>(), Time.Afternoon, new DateTime(2022, 1, 20)));
            shiftManager.Add(new Shift(new Position(3, "test", true), new List<Employee>(), Time.Evening, new DateTime(2022, 1, 20)));
            List<Shift> shifts = shiftManager.GetAll(new ShiftsFilterNone());
            Employee employee1 = new Employee(1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), new DateTime(2022, 1, 20), Gender.Male, "test", "test", "test", "test", "511963", "test@gmail.com", "secret", "contact", "584364");
            Employee employee2 = new Employee(5678, 20, new Position(1, "test", true), 10.15, true, new DateTime(1997, 07, 18), new DateTime(2022, 1, 20), Gender.Male, "test2", "test2", "test2", "test2", "584364", "test2@gmail.com", "secret", "contact", "511963");
            employeeManager.Add(new EmployeeGetAdd(employee1));
            employeeManager.Add(new EmployeeGetAdd(employee2));
            List<Employee> employees = employeeManager.GetAll(new EmployeeFilterAvailability(new Position(1, "test", true), new List<Employee> { new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), new DateTime(2022, 1, 20), Gender.Male, "test", "test", "test", "test", "511963", "test@gmail.com", "secret", "contact", "584364"), new Employee(2, 5678, 20, new Position(1, "test", true), 10.15, true, new DateTime(1997, 07, 18), new DateTime(2022, 1, 20), Gender.Male, "test2", "test2", "test2", "test2", "584364", "test2@gmail.com", "secret", "contact", "511963") }, new DateTime(2022, 1, 20), shifts));

            Assert.AreEqual(employees.Count, 0);
        }
    }
}