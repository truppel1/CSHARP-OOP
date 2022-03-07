using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Tax_Payers.Entities
{
    internal class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualincome) : base(name, anualincome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            
            if (AnualIncome >= 20000)
            {
                if (HealthExpenditures > 0)
                {
                    return (AnualIncome * 0.25) - (HealthExpenditures / 2);
                }
                return AnualIncome * 0.25;
            }
            else 
            {
                return (AnualIncome * 0.15);
            }

        }

        public override string ToString()
        {
            return name + ": U$ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
