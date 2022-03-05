using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Customs_Products.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) +
                $" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }



    }
}
