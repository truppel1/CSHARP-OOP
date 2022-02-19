using Contract_Workers.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Contract_Workers.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Wlevel { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();


        public Worker() { }
        public Worker(Department department, string name, WorkerLevel wlevel, double basesalary)
        {
            Department = department;
            Name = name;
            Wlevel = wlevel;
            BaseSalary = basesalary;
        }

        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income(int month, int year )
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contract)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }


    }
}
