using System;

namespace ATMSimulator
{
    public class Account
    {
        private double balance;

        public Account(double balance)
        {
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            lock (this)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
            }
        }

        public void Withdraw(double amount)
        {
            lock (this)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
                }
                else
                {
                    Console.WriteLine($"Insufficient funds for withdrawal of: {amount}");
                }
            }
        }

        public double GetBalance()
        {
            lock (this)
            {
                return balance;
            }
        }
    }
}