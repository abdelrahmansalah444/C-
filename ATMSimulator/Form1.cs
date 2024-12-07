using System;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class Form1 : Form
    {
        private Account account;

        public Form1()
        {
            InitializeComponent();
            account = new Account(1000);
            balanceLabel.Text = $"Balance: {account.GetBalance()}";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(amountField.Text);
            account.Deposit(amount);
            balanceLabel.Text = $"Balance: {account.GetBalance()}";
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(amountField.Text);
            account.Withdraw(amount);
            balanceLabel.Text = $"Balance: {account.GetBalance()}";
        }
    }
}