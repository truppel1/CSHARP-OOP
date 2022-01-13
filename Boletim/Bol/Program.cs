using System;
using System.Globalization;

namespace Bol
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Student Aluno = new Student();

            Console.Write("Name of the student: ");
            Aluno.Name = Console.ReadLine();
            Console.WriteLine("Type the three grades of the student: ");
            Aluno.Grade1 = double.Parse(Console.ReadLine(), CI);
            Aluno.Grade2 = double.Parse(Console.ReadLine(), CI);
            Aluno.Grade3 = double.Parse(Console.ReadLine(), CI);

            if (Aluno.FinalGrade() > 60)
            {
                Console.WriteLine(Aluno + "\nAPROVADO(A)");
            }
            else
            {
                double Reprovado = 60 - Aluno.FinalGrade();
                Console.WriteLine(Aluno + "\nREPROVADO(A)");
                Console.Write("MISSING " + Reprovado.ToString("F2", CI) + " POINTS");
            }
        }
    }
}
