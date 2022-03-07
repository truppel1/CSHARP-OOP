using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Tax_Payers.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualincome) : base(name, anualincome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }

        public override string ToString()
        {
            return name + ": U$ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
