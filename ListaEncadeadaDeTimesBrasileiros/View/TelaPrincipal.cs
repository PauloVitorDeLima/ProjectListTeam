using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListaEncadeadaDeTimesBrasileiros.Model;
using ListaEncadeadaDeTimesBrasileiros.Controller;

namespace ListaEncadeadaDeTimesBrasileiros
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void BtAdicionarInicio_Click(object sender, EventArgs e)
        {
            if (txtBxNomeTime != null &&
                TxtBxEstadio != null &&
                TxtBxTreinador != null &&
                numericJogadores != null)
            {
                //Popular as variaveis
                String Time = txtBxNomeTime.ToString();
                String Estadio = TxtBxEstadio.ToString();
                String Treinador = TxtBxTreinador.ToString();
                int Jogador = Convert.ToInt32(numericJogadores.Value);

                NodeTime times, head, tail;
                times = new NodeTime();
                Time time;
                
                //Inserir Valor
                time = new Time() {nomeTime = Time, nomeEstadio = Estadio, nomeTreinador = Treinador, quantJogador = Jogador};
                AlteraListaTimes alteraListaTimes = new AlteraListaTimes();
                tail = head = new NodeTime() { dados = time, Anterior = null, Proximo = null};
                alteraListaTimes.InsereInicio(times, head, tail);


                    RichTextBox.AppendText("LISTA DE TIMES CADASTRADOS");
                    RichTextBox.AppendText("Nome do time: " + time.nomeTime);
            }
        }

        private void BtListar_Click(object sender, EventArgs e)
        {

            
        }
    }
}
