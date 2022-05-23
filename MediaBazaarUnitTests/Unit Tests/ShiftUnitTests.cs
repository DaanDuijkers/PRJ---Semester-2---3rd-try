using MediaBazaarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MediaBazaarUnitTests
{
    [TestClass]
    public class ShiftUnitTests
    {
        [TestMethod]
        public void TestGetShift()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1,
                "test",
                true
                ),
                new List<Employee>(),
                Time.Morning,
                new DateTime(2022, 1, 20)
                ));
            Shift shift = shiftManager.Get(new ShiftFilterByID(1));

            Assert.AreEqual(shift.ID, 1);
        }

        [TestMethod]
        public void TestGetAllShifts()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));
            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Afternoon, new DateTime(2022, 1, 20)));
            List<Shift> shifts = shiftManager.GetAll(new ShiftsFilterNone());

            Assert.AreEqual(shifts.Count, 2);
        }

        [TestMethod]
        public void TestAddShift()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            bool add = shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));

            Assert.IsTrue(add);
        }

        [TestMethod]
        public void TestRemoveShift()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1,
                "test",
                true
                ),
                new List<Employee>(),
                Time.Morning,
                new DateTime(2022, 1, 20)
                ));
            bool remove = shiftManager.Remove(1);

            Assert.IsTrue(remove);
        }

        [TestMethod]
        public void TestUpdateShift()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));
            bool update = shiftManager.Update(new Shift(1, new Position(1, "test", true), new List<Employee>() { new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), DateTime.Now, Gender.Male, "test", "test", "test", "test", "511963", "daanduijkers@gmail.com", "secret", "contact", "584364") }, Time.Morning, new DateTime(2022, 1, 20)));

            Assert.IsTrue(update);
        }

        [TestMethod]
        public void TestAddTwoShiftsWithTheSameDate()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));
            bool addSecond = shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));

            Assert.IsFalse(addSecond);
        }

        [TestMethod]
        public void TestUpdateShiftThatAlreadyExists()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));
            shiftManager.Add(new Shift(new Position(2, "test", true), new List<Employee>(), Time.Afternoon, new DateTime(2022, 1, 20)));
            shiftManager.Add(new Shift(new Position(3, "test", true), new List<Employee>(), Time.Evening, new DateTime(2022, 1, 20)));
            bool update = shiftManager.Update(new Shift(2, new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));

            Assert.IsFalse(update);
        }

        [TestMethod]
        public void TestAddShiftDuringWeekend()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            bool add = shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 22)));

            Assert.IsFalse(add);
        }

        [TestMethod]
        public void TestUpdateShiftDuringWeekend()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 20)));
            bool update = shiftManager.Update(new Shift(1, new Position(1, "test", true), new List<Employee>(), Time.Morning, new DateTime(2022, 1, 22)));

            Assert.IsFalse(update);
        }

        [TestMethod]
        public void TestRemoveNonExistantShift()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            bool remove = shiftManager.Remove(1);

            Assert.IsFalse(remove);
        }

        [TestMethod]
        public void TestGetNonExistantShift()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            Shift shift = shiftManager.Get(new ShiftFilterByID(1));

            Assert.AreEqual(shift, null);
        }

        [TestMethod]
        public void TestGetNonExistantShifts()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            List<Shift> shifts = shiftManager.GetAll(new ShiftsFilterNone());

            Assert.AreEqual(shifts.Count, 0);
        }

        [TestMethod]
        public void TestFilterShiftTime()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>() { new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), new DateTime(2022, 1, 20), Gender.Male, "test", "test", "test", "test", "511963", "test@gmail.com", "secret", "contact", "584364") }, Time.Morning, new DateTime(2022, 1, 20)));
            Shift shift = shiftManager.Get(new ShiftFilterEmployeeDateTime(1, new DateTime(2022, 1, 20), Time.Morning));

            Assert.AreEqual(shift.ID, 1);
        }

        [TestMethod]
        public void TestFilterNonExistantShiftTime()
        {
            ShiftManager shiftManager = new ShiftManager(new ShiftTest());

            shiftManager.Add(new Shift(new Position(1, "test", true), new List<Employee>() { new Employee(1, 1234, 40, new Position(1, "test", true), 10.05, true, new DateTime(1995, 11, 08), new DateTime(2022, 1, 20), Gender.Male, "test", "test", "test", "test", "511963", "test@gmail.com", "secret", "contact", "584364") }, Time.Morning, new DateTime(2022, 1, 20)));
            Shift shift = shiftManager.Get(new ShiftFilterEmployeeDateTime(1, new DateTime(2022, 1, 20), Time.Afternoon));

            Assert.AreEqual(shift, null);
        }
    }
}