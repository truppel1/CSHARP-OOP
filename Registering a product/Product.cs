using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicios_com_classe
{
    internal class Product
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string name;
        public double price;
        public int quant;

        public double Totalvaluestok()
        {
            return price * quant;
        }

        public void Addproducts()
        {
            int add = int.Parse(Console.ReadLine());
            quant = quant + add;

        }
        public void Removeproducts()
        {
            int addI = int.Parse(Console.ReadLine());
            quant = quant + addI;
        }

        public override string ToString()
        {
            return "Product " + name + ", price " + price
                + "U$, quantity in stok " + quant +
                ", Total value in stok " + Totalvaluestok().ToString("F2", CI) + "U$.";
        }

    }
}
