using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Register_Employee
{
    internal class Employee
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double Salary { get; private set; }
        public int ID = 0;
        public string Name;

        public Employee(int id, string name, double salary)
        {
            Salary = salary;
            ID = id;
            Name = name;
        }

        public void Increase(double percent)
        {
            Salary += ((Salary * percent) / 100);
        }
        public override string ToString()
        {
            return ID + ", " + Name + ", " + Salary.ToString("F2", CI);
        }
    }
}
