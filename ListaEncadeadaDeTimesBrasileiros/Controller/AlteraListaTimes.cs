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
        public void removerInicio()
        {

            if (Head != null)
            {
                Head = Head.Proximo;
            }
        }
        public void removerFinal()
        {

            if (Head == null)
                return;

            if (Head.Proximo == null)
            {
                Head = null;
            }
            else
            {
                NodeTime ultimo = Head.Proximo;
                NodeTime penultimo = Head;

                while (ultimo.Proximo != null)
                {
                    penultimo = ultimo;
                    ultimo = ultimo.Proximo;
                }
                penultimo.Proximo = null;
            }
        }
        public String Listar()
        {
            String lista = null;
            
            if (Head != null)
            {
                NodeTime temp = Head;
                while (temp != null)
                {
                    lista += " \n NOVO CONJUNTO DE DADOS";
                    lista += "\n Nome do Time: " +temp.dados.nomeTime;
                    lista += "\n Nome do estadio: " + temp.dados.nomeEstadio;
                    lista += "\n Nome do Treinador: " + temp.dados.nomeTreinador;
                    lista += "\n Quantidade de Jogadores: " + temp.dados.quantJogador.ToString();
                    temp = temp.Proximo;
                }
                return lista;
            }
            else
            {
                return lista = "Nenhum dado encontrado";
            }
        }
    }
}
