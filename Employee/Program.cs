using System;
using System.Globalization;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            string name;
            double salary, tax;
            double percent;

            Employee X = new Employee();

            Console.Write("Name: ");
            X.name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            X.salary = double.Parse(Console.ReadLine(), CI);
            Console.Write("Taxes: ");
            X.tax = double.Parse(Console.ReadLine(), CI);
            //DATA COLLECTED

            Console.WriteLine("\n" + X + "\n");

            Console.Write("Enter the percentage to be increse at the salary: ");
            percent = double.Parse(Console.ReadLine(), CI);
            X.IncreaseSalary(percent);
            // INCREASE SALARY

            Console.WriteLine("\n" + X);












        }
    }
}
