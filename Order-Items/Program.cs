using Store.Entities.Enums;
using Store.Entities;
using System;
using System.Globalization;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, dateTime); // CLIENT INSTANCED

            Console.WriteLine("Enter order data: ");
            DateTime moment = DateTime.Now;   // ORDER MOMENT
            Console.Write("Status: ");
            string stats = Console.ReadLine();
            OrderStatus status = Enum.Parse<OrderStatus>(stats);  //ENUM GENERATED

            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            Order order = new Order(moment, status, client); // Order created

            for (int i = 0; i < items; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter #" + (i + 1) + " item data:");
                Console.Write("Product name: ");
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double pprice = double.Parse(Console.ReadLine(), CI);
                Product product = new Product(pname, pprice);
                Console.Write("Quantity: ");
                int pquantity = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(pquantity, product);
                order.AddItem(item);
            }
            // ORDER CREATED

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);


        }
    }
}