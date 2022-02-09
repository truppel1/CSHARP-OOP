using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    internal class Convert
    {

        public static double ConvertC(double dolar, double _price)
        {
            return (((dolar * _price) * 6) / 100) + (dolar * _price);
        }

    }
}
