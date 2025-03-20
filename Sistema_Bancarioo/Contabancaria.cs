using System.ComponentModel.Design;
using System.Net.WebSockets;

namespace Sistema_Bancarioo
{
    public class Contabancaria
    {
        private int _numeroconta;
        private string _titular;
        private double _saldo;
        protected double taxafixa;
        protected double bonus;
        private int _tipo1;
        private int _tipo2;
        private int _tipoconta;
        public Contabancaria()
        {
        }
        public Contabancaria(int numeroconta, double saldo, string titular)
        {
            this._numeroconta = numeroconta;
            this._titular = titular;
            this._saldo = saldo;
        }
        
        public int numeroconta
        {
            get
            {
                return _numeroconta;
            }
            set
            {
                _numeroconta = value;
            }
        }

        public string titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public double saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        protected double Taxafixa
        {
            get { return taxafixa;  }
            set { taxafixa = value; }
        }

        protected double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

       
        public int tipoconta
        {
            get { return _tipoconta; }
            set { _tipoconta = value; }
        }

        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                saldo += valor * (1 + bonus/100);
                Console.WriteLine($"Depósito de {valor} finalizado!");

            }
            else
            {
                Console.WriteLine("Depósito invalido");
            }
        }

        public  void Saque(double valor)
        {
            Console.WriteLine("Qual valor do saque?");
            valor = double.Parse(Console.ReadLine());
            if (this is Contacorrente)
            {
                saldo -= valor;
                Console.WriteLine("Saque finalizado!");


            }
            else if (this is Contapoupança)
            {
                Console.WriteLine("Saque finalizado!");
            }
            
        }

        public void Exibirsaldo()
        {
            Console.WriteLine($"O saldo é de: {saldo}");
        }
    }
}