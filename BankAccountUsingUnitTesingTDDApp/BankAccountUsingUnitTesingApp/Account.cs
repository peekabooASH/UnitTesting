using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountUsingUnitTesingApp
{
  public class Account
    {
      public Account(string accNo, string name):this()
      {
          AccountNo = accNo;
          Name = name;
      }
      public Account()
      {
      }

      public double Balance { get;private set; }
      public string AccountNo { get; set; }
      public string Name { get; set; }

      public void Deposit(double amount)
      {
          Balance += amount;
      }

      public void Withdraw(double amount)
      {
          Balance -= amount;
      }

      public string GetReport()
      {
          string msg = Name + " your account no : " + AccountNo + " and it's balance is : " + Balance;
          return msg;
      }
    }
}
