using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosGetSet
{
    internal class Carro
    {
        //Variaveis privadas internas
        private string _marcaCarro;
        private double _velocidadeCarro;

        //Construtor
        public Carro(string Marca, double Velocidade ) 
        {
            this.MarcaCarro = Marca;
            this.VelocidadeCarro = Velocidade;
        }


        //Encapsulamento dos atributos
        public string MarcaCarro
        {
            get { return _marcaCarro; }
            set { _marcaCarro = value; }
        
        }
        public double VelocidadeCarro 
        {
            get { return _velocidadeCarro; }
            set { _velocidadeCarro = value; }

        }




    }
}
