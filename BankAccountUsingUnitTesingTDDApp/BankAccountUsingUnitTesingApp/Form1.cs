using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountUsingUnitTesingApp
{
    public partial class Form1 : Form
    {
        private Account anAccount;

        private double amount;
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account(accountNumberTextBox.Text, customerNameTextBox.Text);
            MessageBox.Show(@"Account has been created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.Deposit(amount);
                MessageBox.Show(@"Amount has been deposited");
            }
            else
            {
                MessageBox.Show("Please create an account first");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            anAccount.Withdraw(amount);
            MessageBox.Show(@"Amount has been withdrawn");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.GetReport());
        }
    }
}
