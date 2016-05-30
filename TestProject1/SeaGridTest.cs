using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for SeaGridTest and is intended
    ///to contain all SeaGridTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SeaGridTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for HitTile
        ///</summary>

        /// <summary>
        ///A test for HitTile
        ///</summary>
        [TestMethod()]
        public void MissTileTest()
        {
            Dictionary<ShipName, Ship> ships = null; // TODO: Initialize to an appropriate value
            SeaGrid target = new SeaGrid(ships); // TODO: Initialize to an appropriate value
            int row = 0; // TODO: Initialize to an appropriate value
            int col = 0; // TODO: Initialize to an appropriate value
            AttackResult expected = new AttackResult(ResultOfAttack.Miss, "something", 0, 0); // TODO: Initialize to an appropriate value
            AttackResult actual;
            actual = target.HitTile(row, col);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        /*public void HitTileTest()
        {
            Dictionary<ShipName, Ship> ships = null; // TODO: Initialize to an appropriate value
            SeaGrid target = new SeaGrid(ships); // TODO: Initialize to an appropriate value
            Ship ship = new Ship(ShipName.Submarine);
            target.AddShip(0, 0, Direction.LeftRight, ship);
            int row = 0; // TODO: Initialize to an appropriate value
            int col = 0; // TODO: Initialize to an appropriate value
            AttackResult expected = new AttackResult(ResultOfAttack.Hit, "something", 0, 0); // TODO: Initialize to an appropriate value
            AttackResult actual;
            actual = target.HitTile(row, col);
            Assert.AreEqual(expected.Value, actual.Value);
        }*/
    }
}
