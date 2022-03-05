using Customs_Products.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Customs_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i < N + 1; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                string tag = Console.ReadLine();
                if (tag == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CI);
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CI);
                    list.Add(new ImportedProduct(fee, name, price));
                }
                else if (tag == "u")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CI);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(date, name, price));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CI);
                    list.Add(new Product(name, price));
                }

            }
         

            Console.WriteLine("\nPRICE TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }


        }
    }
}
