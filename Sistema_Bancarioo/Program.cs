using System.Security.Cryptography.X509Certificates;

namespace Sistema_Bancarioo
{
        public class Program
        {
            static void Main(string[] args)
            {

                Contabancaria contanova = new Contabancaria();
                Console.WriteLine("Digite o número da conta");
                contanova.numeroconta = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do titular:");
                contanova.titular = Console.ReadLine(); 
                Console.WriteLine("Digite seu saldo:");
                contanova.saldo = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tipo da conta\n" +
                    "1 - Conta corrente\n" +
                    "2 - Conta poupança");
                int tipoconta = int.Parse(Console.ReadLine());
                
                switch (tipoconta)
                {
                    case 1:
                        contanova = new Contacorrente(contanova.numeroconta, contanova.titular, contanova.saldo);
                        break;
                    case 2:
                        contanova = new Contapoupança(contanova.numeroconta, contanova.titular, contanova.saldo);
                        break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
                }   
                Console.Clear(); 
                Console.WriteLine($"{contanova.tipoconta}");
                Console.WriteLine("Digite a operação que deseja :\n" +
                    "1 - Depositar\n" +
                    "2 - Sacar");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
            {
                case 1:
                    
                    contanova.Saque();
                    break;
            }



            /*Contacorrente cc = new Contacorrente(12345678911, "Gabrieli", 5528.80);
                cc.Deposito(600);
                cc.Saque(200);
                cc.Exibirsaldo();

            Contapoupança cp = new Contapoupança(32543546, "Gabriel", 1000);
                cp.Deposito(1000);
                cp.Saque(450.25);
                cp.Exibirsaldo();
            */
        }
        }
}