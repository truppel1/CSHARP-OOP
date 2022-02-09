using System;
using System.Globalization;

namespace Bank_Deposits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double deposit = 0;

            Console.Write("Enter the account number: ");
            int acc = int.Parse(Console.ReadLine());
            Console.Write("Enter the owner full name: ");
            string name = Console.ReadLine();
            Console.Write("Would you like to do the first deposit (Y/N): ");
            string x = Console.ReadLine();
            if (x == "Y" || x == "y")
            {
                Console.Write("Enter the initial amount: ");
                deposit = double.Parse(Console.ReadLine(), CI);
            }

            Account X = new Account(acc, name, deposit); //ACCOUNT CREATED
            Console.WriteLine();
            Console.WriteLine(X);

            Console.Write("\nEnter a value to deposit: ");
            deposit = double.Parse(Console.ReadLine(), CI);
            X.DepositValue(deposit);

            Console.Write(X);

            Console.WriteLine();
            Console.Write("\nEnter a value to withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CI);
            X.Withdraw(withdraw);
            Console.WriteLine(X);
        }
    }
}
