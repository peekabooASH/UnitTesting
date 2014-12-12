using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace AccountTest
{
     [TestFixture]
    class AccountTest
    {
         private Account anAccount;
         [SetUp]
         public void Init()
         {
            anAccount=new Account();
         }
    }
}
