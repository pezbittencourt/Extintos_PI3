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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Extintos
{
    public partial class FormPartida : Form
    {
        public FormPartida()
        {
            InitializeComponent();
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.WindowState = FormWindowState.Maximized;
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

            string nomeJogador = txtNomeJogador.Text;
            string idDaPartida = txtIDdaPartida.Text;
            string senhaDaPartida = txtSenhaPartida.Text;


            if (string.IsNullOrEmpty(nomeJogador) ||
                string.IsNullOrEmpty(senhaDaPartida) ||
                string.IsNullOrEmpty(idDaPartida))
            {
                MessageBox.Show("Todos os campos devem ser preechidos!!\n\n", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(idDaPartida);


            string DadosJogados = Jogo.Entrar(id, nomeJogador, senhaDaPartida);
            string IdJogador = DadosJogados.Substring(DadosJogados.IndexOf(',') + 1);
            string SenhaJogador = DadosJogados.Substring(0, DadosJogados.IndexOf(','));

            lblSenhaGeradaJogador.Text = SenhaJogador;
            lblIdGeradoJogador.Text = IdJogador;


         
            Forms.FormJogadores.Show();
            this.Hide();

        }

    
        }
    }

