using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Bank_Of_Brazil
{
    class Conta
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public int Nconta { get; private set; }   //  
        public string _nome { get; set; }
        public double saldo = 0;
        public Conta(int nconta, string nome)
        {
            Nconta = nconta;
            _nome = nome;
        }
            
        public void Saldo(double valorI)
        {
            saldo = saldo + valorI;
        }
        public void Saldo(double valorI, double deposito)
        {
            saldo = valorI + deposito;
        }
        public void Saldo(double valorI, double deposito, double saque)
        {
            saldo = (((valorI + deposito) - saque) - 5);
        }


        public override string ToString()
        {
            return  "Conta " + Nconta + ", Titular: " +
                _nome + ", Saldo: $ " + saldo.ToString("F2", CI);
        }

    }

}

