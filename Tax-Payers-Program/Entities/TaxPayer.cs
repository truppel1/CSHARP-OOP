using System;
using System.Collections.Generic;
using System.Text;

namespace Tax_Payers.Entities
{
    abstract class TaxPayer
    {
        public string name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualIncome)
        {
            this.name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();


    }
}
