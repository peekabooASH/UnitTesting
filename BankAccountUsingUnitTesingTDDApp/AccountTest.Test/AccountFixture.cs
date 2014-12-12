using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountUsingUnitTesingApp;
using NUnit.Framework;

namespace AccountTest.Test
{
      [TestFixture]
    public class AccountFixture
    {
        private Account anAccount;

        [SetUp]
        public void Init()
        {
            anAccount=new Account();
        }
        [Test]
        public void InitialBalanceTest()
        {
            double initialBalance = anAccount.Balance;
            Assert.AreEqual(0, initialBalance, 0.01);
        }
        [Test]
        public void AccountPropertyTest()
        {
            anAccount = new Account("Sv-001", "Hemel");
            Assert.AreEqual("Sv-001", anAccount.AccountNo);
            Assert.AreEqual("Hemel", anAccount.Name);
        }

        [Test]
        public void DepositTest()
        {
            anAccount = new Account();
            anAccount.Deposit(1000);
            Assert.AreEqual(1000, anAccount.Balance);
        }

        [Test]
        public void WithdrawnTest()
        {
            anAccount = new Account();
            anAccount.Withdraw(100);
            Assert.AreEqual(-100, anAccount.Balance);
        }
        [TearDown]
        public void End()
        {
            anAccount = null;
        }

    }
}
