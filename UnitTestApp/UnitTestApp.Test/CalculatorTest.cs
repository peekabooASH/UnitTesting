using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTestApp.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator aCalculator;

        [SetUp]
        public void Start()
        {
            aCalculator = new Calculator();
        }

        [Test]
        public void AddTest_Check_If_Can_Add_Two_Numbers()
        {
            int expectedValue = 9;

            Assert.AreEqual(expectedValue,aCalculator.Add(4,5));
            Assert.AreEqual(-13, aCalculator.Add(-6,-7));
        }

        [Test]
        public void AddTest_Check_If_Can_Add_Two_Negative_Numbers()
        {
            Assert.AreEqual(-5, aCalculator.Add(-3, -2));
        }

        [TearDown]
        public void End()
        {
            aCalculator = null;
        }
    }
}
