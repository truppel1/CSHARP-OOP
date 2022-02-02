using System;
using System.Globalization;

namespace Exercicio_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int rooms = 10;
            Console.WriteLine("\nAvaliable rooms: ");
            for (int i = 0; i < rooms; i++)
            {
                
                    Console.WriteLine("ROOM " + (i+1) + " AVALIABLE.");
            }

            Console.Write("\nType How many rooms will be rented: ");
            int N = int.Parse(Console.ReadLine());

            Rooms[] Rent = new Rooms[15];

            for ( int i = 1; i <= N; i++)
            {
                Console.WriteLine("\nRent #" + (i) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Rent[room] = new Rooms(name, email, room);
            }

            Console.WriteLine("\nBusy rooms: ");
            
            for (int i = 0; i < Rent.Length; i++)
            {
                if (Rent[i] != null)
                {
                    Console.WriteLine(Rent[i]);
                }
            }

        }
    }
}
