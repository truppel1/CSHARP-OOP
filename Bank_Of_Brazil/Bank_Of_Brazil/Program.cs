using System;
using System.Globalization;

namespace Bank_Of_Brazil
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Entre o número da conta: ");
            int nconta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = (Console.ReadLine());

            Conta X = new Conta(nconta, nome);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string D = Console.ReadLine();
            double valorI = 0;
            if (D == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valorI = double.Parse(Console.ReadLine(), CI);
            }
            X.Saldo(valorI);
            Console.WriteLine("\nDados da conta: \n" + X + "\n");

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CI);
            X.Saldo(valorI, deposito);
            Console.WriteLine("Dados da conta atualizados: \n" + X);
            
          
            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CI);
            X.Saldo(valorI, deposito, saque);
            Console.WriteLine("Dados da conta atualizados:\n" + X + "\n");
        
        }
    }
}
