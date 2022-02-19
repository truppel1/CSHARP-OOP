using Contract_Workers.Entities;
using System;
using System.Globalization;
using Contract_Workers.Entities.Enums;
using System.Collections.Generic;

namespace Contract_Workers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Department department = new Department();
            Console.Write("Enter the department's name: ");
            department.Name = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            string wLEVEL = Console.ReadLine();  // RECIEVE THE ANWSER
            WorkerLevel wlevel = Enum.Parse<WorkerLevel>(wLEVEL);  //CHECK IN TO THE ENUMS
            Console.Write("Base Salary: ");
            double bsalary = double.Parse(Console.ReadLine(), CI);

            Worker worker = new Worker(department, name, wlevel, bsalary);  //WORKER CREATED  

            Console.Write("How many contracts to this worker? ");
            int N = int.Parse(Console.ReadLine());    // NUMBER OF CONTRACTS

            DateTime date = DateTime.Now;
            double value = 0;
            int hours = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\nEnter " + (i+1) + "# contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                string[] dt1 = Console.ReadLine().Split('/');
                int day = int.Parse(dt1[0]);
                int montH = int.Parse(dt1[1]);
                int yeaR = int.Parse(dt1[2]);
                date = new DateTime(yeaR, montH, day); // DATE CONVERTED
                Console.Write("Value per hour: ");
                value = double.Parse(Console.ReadLine(), CI);
                Console.Write("Duration (hours): ");
                hours = int.Parse(Console.ReadLine(), CI);

                HourContract x = new HourContract(date, value, hours); // CONTRACT CREATED
                worker.AddContract(x);  // ADD CONTRACT METHOD

            }
            Console.WriteLine();

            Console.Write("Enter a month and year to calculate income (MM/YYYY): ");
            string[] my = Console.ReadLine().Split('/');
            int month = int.Parse(my[0]);
            int year = int.Parse(my[1]);
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + department.Name);
            Console.WriteLine("Income for " + month + "/" + year + ": " + worker.Income(month, year).ToString("F2", CI));
        }
    }
}
