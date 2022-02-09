using System;
using System.Globalization;

namespace Currency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("What's the current dolar coin: ");
            double price = double.Parse(Console.ReadLine(), CI);
            Console.Write("How much Dolars youre going to buy: ");
            double dolar = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Total value to be payed in R$ = " +
                Convert.ConvertC(dolar, price).ToString("F2", CI));

        }
    }
}
