using System;

namespace Hotel_Renting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int N = int.Parse(Console.ReadLine());

            Room[] room = new Room[10];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\nRent #" + (i+1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                room[number] = new Room(name, email);
            }

            Console.WriteLine("\nOccupied room: ");

            for (int i = 0; i < room.Length; i++)
            {
                if (room[i] != null)
                {
                    Console.WriteLine(i + ": " + room[i].Name +
                        ", " + room[i].Email);
                }
            }
        }
    }
}
