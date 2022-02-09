using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Bank_Deposits
{
    internal class Account
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public int Number { get; private set; }
        public double Balance { get; private set; }
        public string Name;

        public Account(int number, string name)
        {
            Number = number;
            Name = name;
            Balance = 0.0;
        }
        public Account(int number, string name, double deposit)
        {
            Number = number;
            Name = name;
            Balance = deposit;
        }

        public void DepositValue(double deposit)
        {
            Balance = Balance + deposit;
        }

        public void Withdraw(double withdraw)
        {
            Balance = Balance - withdraw - 5;
        }

        public override string ToString()
        {
            return "Account Data Update: " +
                   "\nAccount " + Number + ", Owner: " + Name
                + "  Balance: U$" + Balance.ToString("F2", CI);
        }
    }
}
