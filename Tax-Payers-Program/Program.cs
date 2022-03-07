using System;
using System.Collections.Generic;
using System.Globalization;
using Tax_Payers.Entities;

namespace Tax_Payers
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter the number of payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> List = new List<TaxPayer>();

            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine($"Tax payer {i}# data: ");
                Console.Write("Individual or Company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualincome = double.Parse(Console.ReadLine(), CI);

                if (c ==  'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthexp = double.Parse(Console.ReadLine(), CI);
                    List.Add(new Individual(healthexp, name, anualincome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int x = int.Parse(Console.ReadLine());
                    List.Add(new Company(x, name, anualincome));
                }

            }

            Console.WriteLine("\nTAXES PAID: ");
            
            foreach (TaxPayer obj in List)
            {
                Console.WriteLine(obj);
            }

            double total = 0;

            foreach (TaxPayer obj in List)
            {
                total += obj.Tax();
            }

            Console.Write("TOTAL TAXES: $" + total.ToString("F2", CI));


        }
    }
}
