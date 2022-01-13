using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Bol
{
    class Student
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public string Name;
        public double Grade1;
        public double Grade2;
        public double Grade3;

        public double FinalGrade()
        {
            return Grade1 + Grade2 + Grade3; 
        }
        public override string ToString()
        {
            return "NOTA FINAL = " + FinalGrade().ToString("F2", CI);
        }

    }
}
