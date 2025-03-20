namespace Sistema_Bancarioo
{

    public class Contapoupança : Contabancaria
    {

        public Contapoupança(int numeroconta, string titular, double saldo) : base(numeroconta, saldo, titular)
        {
            Bonus = 0.5;
            
        }
    }
        
    
}
