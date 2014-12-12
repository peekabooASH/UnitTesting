using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryUsingTddApp;
using NUnit.Framework;

namespace SalaryUnitTestingTDD.Test
{
     [TestFixture]
    public class SalaryFixture
    {
        private Salary aSalary;

        [SetUp]
        public void Init()
        {
            aSalary=new Salary();

        }
        [Test]
        public void InitialTotalTest()
        {
            Assert.AreEqual(0, aSalary.Total, 0.01);
        }
        [Test]
        public void CreateASalary()
        {
            aSalary = new Salary(5000, 20, 15) { Basic = 5000, Medical = 20, Conyeance =15};
            Assert.AreEqual(5000, aSalary.Basic);
            Assert.AreEqual(1000, aSalary.GetMedicalAmount());
            Assert.AreEqual(750, aSalary.GetConyeanceAmount());
            Assert.AreEqual(6750, aSalary.GetTotal());

        }
         [Test]
        public void CreateASalaryWithIncrement()
        {
            aSalary = new Salary(5000, 20, 15);
            Assert.AreEqual(6000, aSalary.Increase(20));
            Assert.AreEqual(1200, aSalary.GetMedicalAmount());
            Assert.AreEqual(900, aSalary.GetConyeanceAmount());
            Assert.AreEqual(8100, aSalary.GetTotal());
           
        }
        
    }

   
}
