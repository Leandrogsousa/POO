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
            PneuEstepe = new Pneu(16,70,"Estepe",true);

        }
        public void Ligar()
        {
                if (Combustivel < 0)
                {
                    Ligado = true;
                }
            
        }
        public void Desligar()
        {
            Ligado = false;
            VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
            PneuTraseiroEsquerdo.VelocidadeAtual = 0;
        }
        public void Abastecer()
        {

        }

        public void Acelerar()
        {

        }
        public void Frear()
        {

        }
    }

}
