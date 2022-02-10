using System;
using System.Collections.Generic;
using System.Globalization;

namespace Register_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());
            List<Employee> employee = new List<Employee>();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CI);
                employee.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee ID that will be increased: ");
            int Id = int.Parse(Console.ReadLine());

            Employee Id1 = employee.Find(x => x.ID == Id); // Find ID

            while (Id1 == null)
            {
                Console.Write("This ID does not exist, try again: "); // Check ID
                Id = int.Parse(Console.ReadLine());
                Id1 = employee.Find(x => x.ID == Id);
            }

            
            Console.Write("Enter the percentage: ");  // Increase Salary
            double percent = double.Parse(Console.ReadLine(), CI);
            Id1.Increase(percent);

            
            Console.WriteLine("\nUpdated list of employees: "); // Updated List
            foreach (Employee obj in employee)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
