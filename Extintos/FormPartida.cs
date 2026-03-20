using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extintos
{
    public partial class FormPartida : Form
    {
        public FormPartida()
        {
            InitializeComponent();
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
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
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            FormJogadores indoJogadores = new FormJogadores();
            indoJogadores.Show();
        }
    }
}
