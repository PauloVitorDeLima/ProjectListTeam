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
        private static AlteraListaTimes alteraListaTimes = new AlteraListaTimes();

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void BtAdicionarInicio_Click(object sender, EventArgs e)
        {
            if (validateField())
            {
                //Popular as variaveis
                String Time = txtBxNomeTime.ToString();
                String Estadio = TxtBxEstadio.ToString();
                String Treinador = TxtBxTreinador.ToString();
                int Jogador = Convert.ToInt32(numericJogadores.Value);
                Time timeNovo;

                //Insere Valores ao Time
                timeNovo = new Time() {nomeTime = Time, nomeEstadio = Estadio, nomeTreinador = Treinador, quantJogador = Jogador};
                //Insere o time na lista
                alteraListaTimes.InsereInicio(timeNovo);

                RichTextBox.Clear();
                RichTextBox.AppendText("NOVO TIME CADASTRADO: \n ");
            }
        }

        private void BtAdicionarFinal_Click(object sender, EventArgs e)
        {
            if (validateField())
            {
                //Popular as variaveis
                String Time = txtBxNomeTime.ToString();
                String Estadio = TxtBxEstadio.ToString();
                String Treinador = TxtBxTreinador.ToString();
                int Jogador = Convert.ToInt32(numericJogadores.Value);
                Time timeNovo;

                //Insere Valores ao Time
                timeNovo = new Time() { nomeTime = Time, nomeEstadio = Estadio, nomeTreinador = Treinador, quantJogador = Jogador };
                //Insere o time na lista
                alteraListaTimes.InsereFim(timeNovo);

                RichTextBox.Clear();
                RichTextBox.AppendText("NOVO TIME CADASTRADO: \n ");
            }
        }

        private void BtListar_Click(object sender, EventArgs e)
        {
            
            alteraListaTimes.Listar();
        }
        public bool validateField()
        {
            if (txtBxNomeTime != null &&
                TxtBxEstadio != null &&
                TxtBxTreinador != null &&
                numericJogadores != null)
            {
                return true;
            }
            return false;
        }

    }
}
