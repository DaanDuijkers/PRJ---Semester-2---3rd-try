using MediaBazaarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MediaBazaarUnitTests
{
    [TestClass]
    public class LoginUnitTests
    {
        [TestMethod]
        public void TestLogin()
        {
            LoginManager loginManager = new LoginManager(new LoginTest());

            Employee login = new Employee("test", "test");
            Employee employee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");

            Employee responce = loginManager.Login(login);
            Assert.AreEqual(employee.ID, responce.ID);
        }

        [TestMethod]
        public void TestLoginFalseCredentials()
        {
            LoginManager loginManager = new LoginManager(new LoginTest());

            Employee login = new Employee("testFalse", "testFalse");
            Employee employee = new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364");

            Employee responce = loginManager.Login(login);
            Assert.AreEqual(responce, null);
        }

        [TestMethod]
        public void TestLoginNonAdminAccount()
        {
            LoginManager loginManager = new LoginManager(new LoginTest());

            Employee login = new Employee("testNonAdmin", "testNonAdmin");

            Employee responce = loginManager.Login(login);
            Assert.AreEqual(responce, null);
        }
    }
}