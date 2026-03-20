using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace Extintos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.versao;
        }

        private void btnPartidas_Click(object sender, EventArgs e)
        {
            string retornoPartida = Jogo.ListarPartidas("T");

            retornoPartida = retornoPartida.Replace("\r", "");
            retornoPartida = retornoPartida.Substring(0, retornoPartida.Length - 1);
            string[] partidas = retornoPartida.Split('\n');

            lstPartidas.Items.Clear();
            for (int i = 0; i < partidas.Length; i++)
            {
                lstPartidas.Items.Add(partidas[i]);

            }

        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecaoPartida = lstPartidas.SelectedItem.ToString(); // **
            string[] dadosPartida = selecaoPartida.Split(',');

            int idPartida = Convert.ToInt32(dadosPartida[0]); //Conversão para int devido os dados das partidas estarem em string. **
            string nomePartida = dadosPartida[1];
            string dataPartida = dadosPartida[2];

            lblPartida.Text = idPartida.ToString();
            lblNomePartida.Text = nomePartida;
            lblDataPartida.Text = dataPartida;

            string retornoJogadores = Jogo.ListarJogadores(idPartida);
            if (retornoJogadores.StartsWith ("ERRO"))
            {
                MessageBox.Show("OCORREU UM ERRO: \n\n" + retornoJogadores.Substring(5), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            retornoJogadores = retornoJogadores.Replace("\r", "");
            string[] jogadores = retornoJogadores.Split('\n');

            lstJogadores.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            txtNomedoGrupo.Text = "Extintos";
            string nomePartida = txtNomedaPartida.Text;
            string senhaPartida = txtSenhadaPartida.Text;
            string nomeGrupo = txtNomedoGrupo.Text;

            if (string.IsNullOrEmpty(nomePartida) ||
                string.IsNullOrEmpty(senhaPartida) ||
                string.IsNullOrEmpty(nomeGrupo))
            {
                MessageBox.Show("Todos os campos devem ser preechidos!!\n\n", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblIdGerado.Text = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);

            //Referenciando o próximo formulário
            FormPartida indoPartidas = new FormPartida();
            indoPartidas.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {





































        }
    }
}
