// Cameron Stapp
// CIS150 Bank Register App
// 4-15-2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRegisterApp
{
    class Customer
    {
        // set Properties
        public double Deposit { get; set; }
        public double Withdraw { get; set; }
        public string Name { get; set; }
        public double InitialDeposit { get; set; }
        public int AccountNumber { get; set; }

        // method for formatting deposit amount
        public string convertDeposit()
        {
            string convertedDeposit = string.Format("{0:c}", InitialDeposit);
            return convertedDeposit;
        }

        // Generates account number of customer object
        public void accountNumberGenerate()
        {
            Random r = new Random();
            AccountNumber = r.Next(10000, 11000);
        }

        // calculates deposits and withdraws
        public double SubsequentExchange()
        {
            InitialDeposit = InitialDeposit + Deposit;
            InitialDeposit = InitialDeposit - Withdraw;
            Deposit = 0;
            Withdraw = 0;
            return InitialDeposit;
        }
    }
}
