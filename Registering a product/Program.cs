using System;
using System.Globalization;

namespace Exercicios_com_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Product product = new Product();

            Console.Write("Type the product name: ");
            product.name = Console.ReadLine();
            Console.Write("Type the product price: ");
            product.price = double.Parse(Console.ReadLine(), CI);
            Console.Write("Type the product quantity: ");
            product.quant = int.Parse(Console.ReadLine());
            // DATA INSERT OF THE PRODUCT

            Console.WriteLine("\n" + product);

            // ADDING A PRODUCT
            Console.Write("\nType quantity to be add: ");
            product.Addproducts();
            Console.WriteLine("\n " + product);

            // REMOVING A PRODUCT
           
            Console.Write("\nType quantity to be remove: ");
            product.Removeproducts();
            Console.WriteLine("\n" + product);

        }
    }
}
