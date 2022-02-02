using System;
using System.Globalization;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("What is the current dollar exchange rate? ");
            Conversor.Dollar = double.Parse(Console.ReadLine(), CI);

            Console.Write("How much dollars do you going to buy? ");
            double quant = double.Parse(Console.ReadLine(), CI);
            double Topay = Conversor.Total(quant);

            Console.WriteLine("Total to be payed in R$ = " + Topay.ToString("F2", CI));
            
        }
    }
}
