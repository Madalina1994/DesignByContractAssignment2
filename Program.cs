using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace designByContractAssignment2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Bank
    {
        private String name;
        public void move(double amount, Account source, Account target)
        {
            Contra
            source.balance -= amount;
            target.balance += amount;
        }

        public void makeStatement(Customer cust, Account account)
        {
            cust.accounts.Add(account);
        }
    }

    class Customer
    {
        private String id { get; set; }
        private String name{get; set;}
        public List<Account> accounts { get; set; }
    }

    class Account
    {
        private String number;
        public double balance;
    }

    class Movement
    {
        private DateTime date;
        double amount;
    }
}
