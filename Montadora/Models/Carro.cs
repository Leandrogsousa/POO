using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Carro
    {   //Atributos
        /// <summary>
        /// Aqui onde se coloca o modelo do carro.
        /// </summary>
        public string? Modelo { get; set; }
        public string? Tipo { get; set; }
        public int Ano { get; set; }
        public int Combustivel { get; set; }
        public int CapacidadeTanque { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public string? Marca { get; set; }
        public string? Cor { get; set; }
        public string? Placa { get; set; }
        public int Odometro { get; set; }
        public bool Ligado { get; set; }
        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTraseiroEsquerdo { get; set; }
        public Pneu PneuTraseiroDireito { get; set; }
        public Pneu PneuEstepe { get; set; }

        //Construtor
        public Carro(string _modelo, string _marca, int _ano, int _velocidademaxima, string _placa)
        {
            Modelo = _modelo;
            Marca = _marca;
            Ano = _ano;
            VelocidadeMaxima = _velocidademaxima;
            VelocidadeAtual = 0;
            Placa = _placa;
            Odometro = 0;
            Ligado = false;
            Combustivel = 0;
            PneuDianteiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuDianteiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuTraseiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuTraseiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuEstepe = new Pneu(16, 70, "Estepe", true);

        }
        public void Ligar()
        {
            if (Combustivel > 0)
            {
                Combustivel -= 3;
                Ligado = true;

                if (Combustivel <=0)
                {
                    Combustivel = 0;
                    Desligar();
                }
            }
           


        }
        public void Desligar()
        {
            Ligado = false;
            Parar();
        }

        public void Acelerar(int _impulso)
        {
            if (Ligado == true && _impulso > 0)
            {
                Odometro += 18;
                Combustivel -= 8;

                if (Combustivel <= 0)
                {
                    Combustivel = 0;
                    Desligar();
                    return;
                    
                }


                VelocidadeAtual = VelocidadeAtual + _impulso;
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTraseiroDireito.Girar(_impulso);
                PneuTraseiroEsquerdo.Girar(_impulso);
                if (PneuDianteiroDireito.Estourado || PneuDianteiroDireito.Estourado ||PneuTraseiroDireito.Estourado || PneuTraseiroEsquerdo.Estourado)
                {
                    Parar();
                }
            }

        }
        private void Parar()
        {
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
            PneuTraseiroEsquerdo.VelocidadeAtual = 0;
        }
        public void Frear(int _reduzir)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzir;

            if (VelocidadeAtual <= 0)
                VelocidadeAtual = 0;
            PneuDianteiroDireito.Freiar(_reduzir);
            PneuDianteiroEsquerdo.Freiar(_reduzir);
            PneuTraseiroDireito.Freiar(_reduzir);
            PneuTraseiroEsquerdo.Freiar(_reduzir);


        }
        /// <summary>
        /// Este método vao abastecer o carro.
        /// </summary>
        /// <param name="_quantidadeCombustivel">Informe o percentual de combustível que deseja abastecer, caso informe 0,
        /// o método irá completar o tanque. O valor não pode ser superior a 100.</param>
        public void Abastecer(int _quantidadeCombustivel = 0)
        {
            if (_quantidadeCombustivel == 0)
                _quantidadeCombustivel = 100 - Combustivel;



            if (Combustivel + _quantidadeCombustivel > 100)
            {
                Console.WriteLine("A quantidade de combustível ultrapassa o limite de capacidade");
                return;
            }
            Combustivel += _quantidadeCombustivel;
        }
        public void Exibir()
        {
            Console.Clear();
            Console.WriteLine("Marca:" + Modelo);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("COmbustível: " + Combustivel);
            Console.WriteLine("Capacidade do Tanque: " + CapacidadeTanque);
            Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima);
            Console.WriteLine("Velocidade Atual: " + VelocidadeAtual);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Ligado: " + Ligado);

            Console.WriteLine("\nPneuDianteiroEsquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuDianteiroDireito");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneuTraseiroEsquerdo");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuTraseiroDireito");
            PneuTraseiroDireito.Exibir();
            Console.WriteLine("\nPneuEstepe");
            PneuEstepe.Exibir();    
        }
    }

}
