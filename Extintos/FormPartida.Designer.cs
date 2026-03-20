namespace Extintos
{
    partial class FormPartida
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
            this.lblDraftosaurus = new System.Windows.Forms.Label();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.lblTituloIdPartida = new System.Windows.Forms.Label();
            this.lblTituloNomePartida = new System.Windows.Forms.Label();
            this.lblTituloDataPartida = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblSenhadaPartida = new System.Windows.Forms.Label();
            this.txtIDdaPartida = new System.Windows.Forms.TextBox();
            this.lblIddaPartida = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblIdGeradoJogador = new System.Windows.Forms.Label();
            this.lblSenhaGeradaJogador = new System.Windows.Forms.Label();
            this.lblSenhaDoJogador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDraftosaurus
            // 
            this.lblDraftosaurus.AutoSize = true;
            this.lblDraftosaurus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraftosaurus.Location = new System.Drawing.Point(167, 19);
            this.lblDraftosaurus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDraftosaurus.Name = "lblDraftosaurus";
            this.lblDraftosaurus.Size = new System.Drawing.Size(269, 26);
            this.lblDraftosaurus.TabIndex = 23;
            this.lblDraftosaurus.Text = "Selecione a sua partida!";
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.Location = new System.Drawing.Point(221, 56);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(122, 23);
            this.btnListarPartidas.TabIndex = 24;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(322, 103);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(2);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(114, 173);
            this.lstPartidas.TabIndex = 25;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblTituloIdPartida
            // 
            this.lblTituloIdPartida.AutoSize = true;
            this.lblTituloIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIdPartida.Location = new System.Drawing.Point(440, 116);
            this.lblTituloIdPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloIdPartida.Name = "lblTituloIdPartida";
            this.lblTituloIdPartida.Size = new System.Drawing.Size(106, 17);
            this.lblTituloIdPartida.TabIndex = 26;
            this.lblTituloIdPartida.Text = "Id da Partida:";
            // 
            // lblTituloNomePartida
            // 
            this.lblTituloNomePartida.AutoSize = true;
            this.lblTituloNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNomePartida.Location = new System.Drawing.Point(440, 172);
            this.lblTituloNomePartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloNomePartida.Name = "lblTituloNomePartida";
            this.lblTituloNomePartida.Size = new System.Drawing.Size(134, 17);
            this.lblTituloNomePartida.TabIndex = 27;
            this.lblTituloNomePartida.Text = "Nome da Partida:";
            // 
            // lblTituloDataPartida
            // 
            this.lblTituloDataPartida.AutoSize = true;
            this.lblTituloDataPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDataPartida.Location = new System.Drawing.Point(440, 229);
            this.lblTituloDataPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloDataPartida.Name = "lblTituloDataPartida";
            this.lblTituloDataPartida.Size = new System.Drawing.Size(127, 17);
            this.lblTituloDataPartida.TabIndex = 28;
            this.lblTituloDataPartida.Text = "Data da Partida:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.Location = new System.Drawing.Point(11, 257);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(145, 50);
            this.btnEntrarPartida.TabIndex = 29;
            this.btnEntrarPartida.Text = "Entrar na partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(441, 146);
            this.lblPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(0, 13);
            this.lblPartida.TabIndex = 30;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(441, 202);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 13);
            this.lblNomePartida.TabIndex = 31;
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(441, 257);
            this.lblDataPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 13);
            this.lblDataPartida.TabIndex = 32;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(11, 203);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(125, 20);
            this.txtSenhaPartida.TabIndex = 37;
            // 
            // lblSenhadaPartida
            // 
            this.lblSenhadaPartida.AutoSize = true;
            this.lblSenhadaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhadaPartida.Location = new System.Drawing.Point(11, 178);
            this.lblSenhadaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhadaPartida.Name = "lblSenhadaPartida";
            this.lblSenhadaPartida.Size = new System.Drawing.Size(122, 15);
            this.lblSenhadaPartida.TabIndex = 36;
            this.lblSenhadaPartida.Text = "Senha da Partida:";
            // 
            // txtIDdaPartida
            // 
            this.txtIDdaPartida.Location = new System.Drawing.Point(11, 143);
            this.txtIDdaPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDdaPartida.Name = "txtIDdaPartida";
            this.txtIDdaPartida.Size = new System.Drawing.Size(125, 20);
            this.txtIDdaPartida.TabIndex = 35;
            // 
            // lblIddaPartida
            // 
            this.lblIddaPartida.AutoSize = true;
            this.lblIddaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIddaPartida.Location = new System.Drawing.Point(11, 118);
            this.lblIddaPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIddaPartida.Name = "lblIddaPartida";
            this.lblIddaPartida.Size = new System.Drawing.Size(95, 15);
            this.lblIddaPartida.TabIndex = 34;
            this.lblIddaPartida.Text = "ID da Partida:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(11, 85);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(122, 20);
            this.txtNomeJogador.TabIndex = 39;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(11, 60);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(125, 15);
            this.lblNomeJogador.TabIndex = 38;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogador.Location = new System.Drawing.Point(160, 259);
            this.lblIdJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(113, 17);
            this.lblIdJogador.TabIndex = 40;
            this.lblIdJogador.Text = "Id do Jogador:";
            // 
            // lblIdGeradoJogador
            // 
            this.lblIdGeradoJogador.AutoSize = true;
            this.lblIdGeradoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGeradoJogador.Location = new System.Drawing.Point(178, 281);
            this.lblIdGeradoJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdGeradoJogador.Name = "lblIdGeradoJogador";
            this.lblIdGeradoJogador.Size = new System.Drawing.Size(0, 17);
            this.lblIdGeradoJogador.TabIndex = 41;
            // 
            // lblSenhaGeradaJogador
            // 
            this.lblSenhaGeradaJogador.AutoSize = true;
            this.lblSenhaGeradaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaGeradaJogador.Location = new System.Drawing.Point(142, 307);
            this.lblSenhaGeradaJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaGeradaJogador.Name = "lblSenhaGeradaJogador";
            this.lblSenhaGeradaJogador.Size = new System.Drawing.Size(178, 15);
            this.lblSenhaGeradaJogador.TabIndex = 42;
            this.lblSenhaGeradaJogador.Text = "Senha da Partida Jogador:";
            // 
            // lblSenhaDoJogador
            // 
            this.lblSenhaDoJogador.AutoSize = true;
            this.lblSenhaDoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaDoJogador.Location = new System.Drawing.Point(178, 340);
            this.lblSenhaDoJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaDoJogador.Name = "lblSenhaDoJogador";
            this.lblSenhaDoJogador.Size = new System.Drawing.Size(0, 17);
            this.lblSenhaDoJogador.TabIndex = 43;
            // 
            // FormPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblSenhaDoJogador);
            this.Controls.Add(this.lblSenhaGeradaJogador);
            this.Controls.Add(this.lblIdGeradoJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhadaPartida);
            this.Controls.Add(this.txtIDdaPartida);
            this.Controls.Add(this.lblIddaPartida);
            this.Controls.Add(this.lblDataPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblTituloDataPartida);
            this.Controls.Add(this.lblTituloNomePartida);
            this.Controls.Add(this.lblTituloIdPartida);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.lblDraftosaurus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPartida";
            this.Text = "FormPartida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDraftosaurus;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Label lblTituloIdPartida;
        private System.Windows.Forms.Label lblTituloNomePartida;
        private System.Windows.Forms.Label lblTituloDataPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblSenhadaPartida;
        private System.Windows.Forms.TextBox txtIDdaPartida;
        private System.Windows.Forms.Label lblIddaPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblIdGeradoJogador;
        private System.Windows.Forms.Label lblSenhaGeradaJogador;
        private System.Windows.Forms.Label lblSenhaDoJogador;
    }
}