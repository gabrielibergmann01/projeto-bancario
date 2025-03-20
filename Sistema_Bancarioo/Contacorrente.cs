namespace Sistema_Bancarioo
{

    public class Contacorrente : Contabancaria
    {
        public Contacorrente(int numeroconta, string titular, double saldo) : base(numeroconta, saldo,titular)
        { 
           taxafixa = 5.00;
            
        }

    }

}
