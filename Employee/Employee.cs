using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicios
{
    internal class Employee
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public string name;
        public double salary;
        public double tax;
        public double percent;


        public double NetSalary()
        {
            return salary - tax + percent;
        }
        public void IncreaseSalary(double _percent)
        {
            percent = (salary * _percent) / 100;
        }
        public override string ToString()
        {
            return "Employee: " + name + ", U$" +
                NetSalary().ToString("F2", CI);
        }


    }
}
