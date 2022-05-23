using MediaBazaarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MediaBazaarUnitTests
{
    [TestClass]
    public class PositionUnitTests
    {
        [TestMethod]
        public void TestAddPosition()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            bool add = positionManager.Add(new Position("test"));

            Assert.IsTrue(add);
        }

        [TestMethod]
        public void TestRemovePosition()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            positionManager.Add(new Position("test"));
            bool remove = positionManager.Remove(1);

            Assert.IsTrue(remove);
        }

        [TestMethod]
        public void TestUpdatePosition()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            positionManager.Add(new Position("test"));
            bool update = positionManager.Update(new Position(1, "update", true));

            Assert.IsTrue(update);
        }

        [TestMethod]
        public void TestGetPosition()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            positionManager.Add(new Position("test"));
            Position position = positionManager.Get(1);

            Assert.AreEqual(position.Name, "test");
        }

        [TestMethod]
        public void TestGetAllPositions()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            positionManager.Add(new Position("test"));
            positionManager.Add(new Position("test2"));
            positionManager.Add(new Position("test3"));
            List<Position> positions = positionManager.GetAll();

            Assert.AreEqual(positions.Count, 3);
        }

        [TestMethod]
        public void TestGetUpdatePosition()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            positionManager.Add(new Position("test"));
            positionManager.Update(new Position(1, "update", true));
            Position position = positionManager.Get(1);

            Assert.AreEqual(position.Name, "update");
        }

        [TestMethod]
        public void TestAddSamePositionTwice()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            positionManager.Add(new Position("test"));
            bool add = positionManager.Add(new Position("test"));

            Assert.IsFalse(add);
        }

        [TestMethod]
        public void TestRemoveNonExistingPosition()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            bool remove = positionManager.Remove(1);

            Assert.IsFalse(remove);
        }

        [TestMethod]
        public void TestUpdateNonExistingPosition()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            bool update = positionManager.Update(new Position(1, "update", true));

            Assert.IsFalse(update);
        }

        [TestMethod]
        public void TestGetRemovedEmployee()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            positionManager.Add(new Position("test"));
            positionManager.Remove(1);
            Position position = positionManager.Get(1);

            Assert.IsFalse(position.IsActive);
        }

        [TestMethod]
        public void TestReAddEmployee()
        {
            PositionManager positionManager = new PositionManager(new PositionTest());

            positionManager.Add(new Position("test"));
            positionManager.Remove(1);
            positionManager.Add(new Position("test"));
            Position position = positionManager.Get(1);

            Assert.IsTrue(position.IsActive);
        }
    }
}