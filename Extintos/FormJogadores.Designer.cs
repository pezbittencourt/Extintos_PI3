namespace Extintos
{
    partial class FormJogadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.latJogadores = new System.Windows.Forms.ListBox();
            this.lblSenhaGeradaJogador = new System.Windows.Forms.Label();
            this.lblIDJogadorGerado = new System.Windows.Forms.Label();
            this.bntListaJogadores = new System.Windows.Forms.Button();
            this.lblSenhaGeradaa = new System.Windows.Forms.Label();
            this.btnNão = new System.Windows.Forms.Button();
            this.lblCadastroJogador = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.lblIdGeradoJogador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // latJogadores
            // 
            this.latJogadores.FormattingEnabled = true;
            this.latJogadores.Location = new System.Drawing.Point(23, 120);
            this.latJogadores.Name = "latJogadores";
            this.latJogadores.Size = new System.Drawing.Size(180, 290);
            this.latJogadores.TabIndex = 0;
            // 
            // lblSenhaGeradaJogador
            // 
            this.lblSenhaGeradaJogador.AutoSize = true;
            this.lblSenhaGeradaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaGeradaJogador.Location = new System.Drawing.Point(298, 120);
            this.lblSenhaGeradaJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaGeradaJogador.Name = "lblSenhaGeradaJogador";
            this.lblSenhaGeradaJogador.Size = new System.Drawing.Size(178, 15);
            this.lblSenhaGeradaJogador.TabIndex = 44;
            this.lblSenhaGeradaJogador.Text = "Senha da Partida Jogador:";
            // 
            // lblIDJogadorGerado
            // 
            this.lblIDJogadorGerado.AutoSize = true;
            this.lblIDJogadorGerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDJogadorGerado.Location = new System.Drawing.Point(298, 56);
            this.lblIDJogadorGerado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDJogadorGerado.Name = "lblIDJogadorGerado";
            this.lblIDJogadorGerado.Size = new System.Drawing.Size(99, 15);
            this.lblIDJogadorGerado.TabIndex = 45;
            this.lblIDJogadorGerado.Text = "Id do Jogador:";
            // 
            // bntListaJogadores
            // 
            this.bntListaJogadores.Location = new System.Drawing.Point(45, 61);
            this.bntListaJogadores.Name = "bntListaJogadores";
            this.bntListaJogadores.Size = new System.Drawing.Size(111, 31);
            this.bntListaJogadores.TabIndex = 46;
            this.bntListaJogadores.Text = "Listar Jogadores";
            this.bntListaJogadores.UseVisualStyleBackColor = true;
            this.bntListaJogadores.Click += new System.EventHandler(this.bntListaJogadores_Click);
            // 
            // lblSenhaGeradaa
            // 
            this.lblSenhaGeradaa.AutoSize = true;
            this.lblSenhaGeradaa.Location = new System.Drawing.Point(301, 161);
            this.lblSenhaGeradaa.Name = "lblSenhaGeradaa";
            this.lblSenhaGeradaa.Size = new System.Drawing.Size(0, 13);
            this.lblSenhaGeradaa.TabIndex = 47;
            // 
            // btnNão
            // 
            this.btnNão.Location = new System.Drawing.Point(408, 306);
            this.btnNão.Name = "btnNão";
            this.btnNão.Size = new System.Drawing.Size(68, 26);
            this.btnNão.TabIndex = 49;
            this.btnNão.Text = "Não";
            this.btnNão.UseVisualStyleBackColor = true;
            this.btnNão.Click += new System.EventHandler(this.btnNão_Click);
            // 
            // lblCadastroJogador
            // 
            this.lblCadastroJogador.AutoSize = true;
            this.lblCadastroJogador.Location = new System.Drawing.Point(303, 262);
            this.lblCadastroJogador.Name = "lblCadastroJogador";
            this.lblCadastroJogador.Size = new System.Drawing.Size(161, 13);
            this.lblCadastroJogador.TabIndex = 50;
            this.lblCadastroJogador.Text = "Deseja cadastrar outro jogador ?";
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(306, 306);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(68, 26);
            this.btnSim.TabIndex = 51;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // lblIdGeradoJogador
            // 
            this.lblIdGeradoJogador.AutoSize = true;
            this.lblIdGeradoJogador.Location = new System.Drawing.Point(304, 84);
            this.lblIdGeradoJogador.Name = "lblIdGeradoJogador";
            this.lblIdGeradoJogador.Size = new System.Drawing.Size(0, 13);
            this.lblIdGeradoJogador.TabIndex = 52;
            // 
            // FormJogadores
            // 
            this.ClientSize = new System.Drawing.Size(677, 488);
            this.Controls.Add(this.lblIdGeradoJogador);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lblCadastroJogador);
            this.Controls.Add(this.btnNão);
            this.Controls.Add(this.lblSenhaGeradaa);
            this.Controls.Add(this.bntListaJogadores);
            this.Controls.Add(this.lblIDJogadorGerado);
            this.Controls.Add(this.lblSenhaGeradaJogador);
            this.Controls.Add(this.latJogadores);
            this.Name = "FormJogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntIniciar;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.ListBox latJogadores;
        private System.Windows.Forms.Label lblSenhaGeradaJogador;
        private System.Windows.Forms.Label lblIDJogadorGerado;
        private System.Windows.Forms.Button bntListaJogadores;
        private System.Windows.Forms.Label lblSenhaGeradaa;
        private System.Windows.Forms.Label lblIdGeradoJogado;
        private System.Windows.Forms.Button btnNão;
        private System.Windows.Forms.Label lblCadastroJogador;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Label lblIdGeradoJogador;
    }
}