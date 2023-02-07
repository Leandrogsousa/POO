using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pneu pneu1 = new Pneu(16,150, "carro de passeio", false);
            //Pneu pneu2 = new Pneu(16,70,"Pneu de estepe", false);
            //Carro corcel = new Carro("Toro","Fiat",2022,180,"WEF-2134");

            Carro fusca = new Carro("Volkswagen", "Itamar Franco", 1994, 120, "SWK-1234");
            
            fusca.Abastecer(80);
            fusca.Ligar();
            fusca.Acelerar(15);
            fusca.Acelerar(5);
            fusca.Acelerar(22);
            fusca.Frear(8);
            fusca.Acelerar(3);
            fusca.Frear(4);
            fusca.Desligar();
            fusca.PneuDianteiroEsquerdo = fusca.PneuEstepe;
            fusca.Ligar();
            fusca.Acelerar(15);
            fusca.Acelerar(5);
            fusca.Acelerar(22);
            fusca.Frear(8);
            fusca.Acelerar(3);
            fusca.Frear(4);
            fusca.Acelerar(60);
            fusca.Acelerar(8);
            fusca.Acelerar(29);

           fusca.Exibir();

        }
       
    }
}