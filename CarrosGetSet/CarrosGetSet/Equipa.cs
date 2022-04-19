using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosGetSet
{
    internal class Equipa
    {

        private Carro[] C;


        public Equipa(int n) //Funçao para criar e popular array com objetos
        {
            C = new Carro[n];           //Cria array com "n" desejados carros
            for (int i = 0; i < 3; i++) 
            {
                C[i] = new Carro("", 0);    //Popula cada index com uma instância de objeto "Carro"
            }
        }



        public Carro this[int index] 
        {
            get { return C[index]; }
            set { C[index] = value; }
        }



    }
}
