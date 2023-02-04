using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16,150, "carro de passeio", false);
            
            Pneu pneu2 = new Pneu(16,70,"Pneu de estepe", false);
            
            Carro corcel = new Carro("Toro","Fiat",2022,180,"WEF-2134");







            corcel.Abastecer();
            pneu1.Girar(6);
            pneu2.Girar(6);
            pneu2.Girar(15);
            pneu2.Girar(10);
            pneu2.Freiar(5);
            pneu2.Girar(20);
            pneu2.Girar(20);
            pneu2.Girar(5);
            pneu1.Exibir();
            Console.WriteLine();
            pneu2.Exibir();
        }
       
    }
}