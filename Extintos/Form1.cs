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
            this.his.WindowState = FormWindowState.Normal; 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable; 
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
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
            Forms.FormPartida.Show();
            this.Hide();
        }

       





































        }
    }

