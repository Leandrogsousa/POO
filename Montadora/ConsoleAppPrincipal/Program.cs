using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16,"Carro de passeio","Firestone",false,150);

            
            Pneu pneu2 = new Pneu(15,"Pneu de estepe","Pirelli",false,70);
            

            pneu1.Girar(5);
            pneu1.Exibir();
            Console.WriteLine("");
            pneu2.Girar(5);
            pneu2.Exibir();
            

            

        }
    }
}