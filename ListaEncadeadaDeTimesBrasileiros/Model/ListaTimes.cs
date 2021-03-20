using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeadaDeTimesBrasileiros.Model
{
    class Time
    {
        public string nomeTime { get; set; }

        public string nomeEstadio { get; set; }

        public string nomeTreinador { get; set; }

        public int quantJogador { get; set; }

    }
    class NodeTime
    {
        public Time dados;
        public NodeTime Proximo;
        public NodeTime Anterior;

    }
}
