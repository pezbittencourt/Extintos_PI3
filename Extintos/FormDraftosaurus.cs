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
    public partial class FormDraftosaurus : Form
    {
        public FormDraftosaurus()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.WindowState = FormWindowState.Maximized;
        }

        public void bntEntrar_Click(object sender, EventArgs e)
        {
            string idJogador = lblDjogador.Text;
             int id = int.Parse(idJogador);
            string senhaJogador = lblSenhaJogador.Text;

            string retornoEntrar = Jogo.Iniciar(id, senhaJogador);

            lblJogadorEscolhido.Text = retornoEntrar.Substring(0,retornoEntrar.IndexOf(','));
            lblFaceDado.Text = retornoEntrar.Substring(retornoEntrar.IndexOf(',') + 1);


           





        }

        private void bntExibirMao_Click(object sender, EventArgs e)
        {
            string idJogador = lblDjogador.Text;
            int id = int.Parse(idJogador);
            string senhaJogador = lblSenhaJogador.Text;

            string retornoMao = Jogo.ExibirMao(id,senhaJogador);

            lblCodDinossauro.Text = retornoMao.Substring(0, retornoMao.IndexOf(','));
            lblQuantidadeDino.Text = retornoMao.Substring(retornoMao.IndexOf(',') + 1);
        }
    }
}
