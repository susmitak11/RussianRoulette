using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RRUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RussianRoulette.LogicClass test = new RussianRoulette.LogicClass();

            int testResult = test.SpinLogic();

            Assert.IsTrue(testResult < 7 && testResult > 0);

        }

        [TestMethod]
        public void TestMethod2()
        {
            RussianRoulette.LogicClass testshoot = new RussianRoulette.LogicClass();

            int testResultshoot = testshoot.ShootLogic();

            Assert.IsTrue(testResultshoot <= 4 && testResultshoot > 0);

        }
        [TestMethod]
        public void TestMethod3()
        {
            RussianRoulette.LogicClass testShootAway = new RussianRoulette.LogicClass();

            int testResultShootAway = testShootAway.SpinLogic();

            Assert.IsTrue(testResultShootAway < 7 && testResultShootAway > 0);

        }
    }
}
