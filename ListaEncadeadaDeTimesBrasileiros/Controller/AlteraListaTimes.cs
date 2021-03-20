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
        NodeTime Head, Tail;



        public void InsereFim(Time time)
        {
            NodeTime nodeTime = new NodeTime() { dados = time};

            if (Head == null)
            {
                Head = nodeTime;
            }
            else
            {
                Tail.Proximo = nodeTime;
            }
            Tail = nodeTime;
        }
        public void InsereInicio(Time time)
        {
            NodeTime nodeTime = new NodeTime() { dados = time };

            if (Head == null)
            {
                Head = nodeTime;
                Tail = nodeTime;
            }
            else
            {
                nodeTime.Proximo = Head;
            }
            Head = nodeTime;
        }
        public void Listar()
        {

            if (Head != null)
            {
                NodeTime temp = Head;
                while (temp != null)
                {
                    Console.Write(temp.dados + " ");
                    temp = temp.Proximo;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nLista vazia");
            }
        }
    }
}
