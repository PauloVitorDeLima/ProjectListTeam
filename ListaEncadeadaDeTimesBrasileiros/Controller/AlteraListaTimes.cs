using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaEncadeadaDeTimesBrasileiros.Model;

namespace ListaEncadeadaDeTimesBrasileiros.Controller
{
    class AlteraListaTimes
    {
        public bool InsereInicio(NodeTime time, NodeTime Head, NodeTime Tail )
        {

            if (Head == null)
            {
                Head = time;
                Head.Proximo = null;
                Tail = time;
                return true;
            }

            Tail.Proximo = time;
            Tail = time;
            Tail.Proximo = null;
            return true;
        }
    }
}
