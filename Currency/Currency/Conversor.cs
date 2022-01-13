using System;
using System.Collections.Generic;
using System.Text;

namespace Currency
{
    class Conversor
    {
        public static double Dollar;
        public static double Total(double q)
        {
            return (q * Dollar) + (((q * Dollar) * 6) / 100);
        }

    }
}
