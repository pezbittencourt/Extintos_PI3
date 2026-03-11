namespace Extintos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPartidas = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.lblTituloIdPartida = new System.Windows.Forms.Label();
            this.lblTituloNomePartida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblTituloJogadoresPartida = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblNomedaPartida = new System.Windows.Forms.Label();
            this.txtNomedaPartida = new System.Windows.Forms.TextBox();
            this.lblSenhadaPartida = new System.Windows.Forms.Label();
            this.txtSenhadaPartida = new System.Windows.Forms.TextBox();
            this.lblNomedoGrupo = new System.Windows.Forms.Label();
            this.txtNomedoGrupo = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblIdDaPartida = new System.Windows.Forms.Label();
            this.lblIdGerado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPartidas
            // 
            this.btnPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidas.Location = new System.Drawing.Point(79, 237);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(165, 40);
            this.btnPartidas.TabIndex = 0;
            this.btnPartidas.Text = "Listar Partidas";
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(26, 282);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(258, 244);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartida.Location = new System.Drawing.Point(398, 316);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(0, 23);
            this.lblPartida.TabIndex = 3;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.Location = new System.Drawing.Point(398, 400);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 23);
            this.lblNomePartida.TabIndex = 4;
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartida.Location = new System.Drawing.Point(398, 490);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 23);
            this.lblDataPartida.TabIndex = 5;
            // 
            // lblTituloIdPartida
            // 
            this.lblTituloIdPartida.AutoSize = true;
            this.lblTituloIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIdPartida.Location = new System.Drawing.Point(398, 280);
            this.lblTituloIdPartida.Name = "lblTituloIdPartida";
            this.lblTituloIdPartida.Size = new System.Drawing.Size(126, 20);
            this.lblTituloIdPartida.TabIndex = 6;
            this.lblTituloIdPartida.Text = "Id da partida: ";
            // 
            // lblTituloNomePartida
            // 
            this.lblTituloNomePartida.AutoSize = true;
            this.lblTituloNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNomePartida.Location = new System.Drawing.Point(398, 369);
            this.lblTituloNomePartida.Name = "lblTituloNomePartida";
            this.lblTituloNomePartida.Size = new System.Drawing.Size(155, 20);
            this.lblTituloNomePartida.TabIndex = 7;
            this.lblTituloNomePartida.Text = "Nome da Partida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data da Partida:";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 16;
            this.lstJogadores.Location = new System.Drawing.Point(664, 280);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(247, 244);
            this.lstJogadores.TabIndex = 9;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(881, 571);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 16);
            this.lblVersao.TabIndex = 10;
            // 
            // lblTituloJogadoresPartida
            // 
            this.lblTituloJogadoresPartida.AutoSize = true;
            this.lblTituloJogadoresPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloJogadoresPartida.Location = new System.Drawing.Point(729, 242);
            this.lblTituloJogadoresPartida.Name = "lblTituloJogadoresPartida";
            this.lblTituloJogadoresPartida.Size = new System.Drawing.Size(121, 25);
            this.lblTituloJogadoresPartida.TabIndex = 11;
            this.lblTituloJogadoresPartida.Text = "Jogadores:";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.Location = new System.Drawing.Point(432, 91);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(82, 22);
            this.lblNomeGrupo.TabIndex = 12;
            this.lblNomeGrupo.Text = "Extintos";
            // 
            // lblNomedaPartida
            // 
            this.lblNomedaPartida.AutoSize = true;
            this.lblNomedaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomedaPartida.Location = new System.Drawing.Point(26, 25);
            this.lblNomedaPartida.Name = "lblNomedaPartida";
            this.lblNomedaPartida.Size = new System.Drawing.Size(134, 18);
            this.lblNomedaPartida.TabIndex = 13;
            this.lblNomedaPartida.Text = "Nome da Partida";
            // 
            // txtNomedaPartida
            // 
            this.txtNomedaPartida.Location = new System.Drawing.Point(26, 56);
            this.txtNomedaPartida.Name = "txtNomedaPartida";
            this.txtNomedaPartida.Size = new System.Drawing.Size(134, 22);
            this.txtNomedaPartida.TabIndex = 14;
            // 
            // lblSenhadaPartida
            // 
            this.lblSenhadaPartida.AutoSize = true;
            this.lblSenhadaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhadaPartida.Location = new System.Drawing.Point(26, 99);
            this.lblSenhadaPartida.Name = "lblSenhadaPartida";
            this.lblSenhadaPartida.Size = new System.Drawing.Size(136, 18);
            this.lblSenhadaPartida.TabIndex = 15;
            this.lblSenhadaPartida.Text = "Senha da Partida";
            // 
            // txtSenhadaPartida
            // 
            this.txtSenhadaPartida.Location = new System.Drawing.Point(26, 130);
            this.txtSenhadaPartida.Name = "txtSenhadaPartida";
            this.txtSenhadaPartida.Size = new System.Drawing.Size(134, 22);
            this.txtSenhadaPartida.TabIndex = 16;
            // 
            // lblNomedoGrupo
            // 
            this.lblNomedoGrupo.AutoSize = true;
            this.lblNomedoGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomedoGrupo.Location = new System.Drawing.Point(31, 172);
            this.lblNomedoGrupo.Name = "lblNomedoGrupo";
            this.lblNomedoGrupo.Size = new System.Drawing.Size(129, 18);
            this.lblNomedoGrupo.TabIndex = 17;
            this.lblNomedoGrupo.Text = "Nome do Grupo";
            // 
            // txtNomedoGrupo
            // 
            this.txtNomedoGrupo.Location = new System.Drawing.Point(26, 198);
            this.txtNomedoGrupo.Name = "txtNomedoGrupo";
            this.txtNomedoGrupo.Size = new System.Drawing.Size(134, 22);
            this.txtNomedoGrupo.TabIndex = 18;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(189, 57);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(114, 95);
            this.btnCriarPartida.TabIndex = 19;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblIdDaPartida
            // 
            this.lblIdDaPartida.AutoSize = true;
            this.lblIdDaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDaPartida.Location = new System.Drawing.Point(191, 172);
            this.lblIdDaPartida.Name = "lblIdDaPartida";
            this.lblIdDaPartida.Size = new System.Drawing.Size(112, 18);
            this.lblIdDaPartida.TabIndex = 20;
            this.lblIdDaPartida.Text = "Id da Partida: ";
            // 
            // lblIdGerado
            // 
            this.lblIdGerado.AutoSize = true;
            this.lblIdGerado.Location = new System.Drawing.Point(218, 198);
            this.lblIdGerado.Name = "lblIdGerado";
            this.lblIdGerado.Size = new System.Drawing.Size(0, 16);
            this.lblIdGerado.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 616);
            this.Controls.Add(this.lblIdGerado);
            this.Controls.Add(this.lblIdDaPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtNomedoGrupo);
            this.Controls.Add(this.lblNomedoGrupo);
            this.Controls.Add(this.txtSenhadaPartida);
            this.Controls.Add(this.lblSenhadaPartida);
            this.Controls.Add(this.txtNomedaPartida);
            this.Controls.Add(this.lblNomedaPartida);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblTituloJogadoresPartida);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloNomePartida);
            this.Controls.Add(this.lblTituloIdPartida);
            this.Controls.Add(this.lblDataPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnPartidas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.Label lblTituloIdPartida;
        private System.Windows.Forms.Label lblTituloNomePartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblTituloJogadoresPartida;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblNomedaPartida;
        private System.Windows.Forms.TextBox txtNomedaPartida;
        private System.Windows.Forms.Label lblSenhadaPartida;
        private System.Windows.Forms.TextBox txtSenhadaPartida;
        private System.Windows.Forms.Label lblNomedoGrupo;
        private System.Windows.Forms.TextBox txtNomedoGrupo;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblIdDaPartida;
        private System.Windows.Forms.Label lblIdGerado;
    }
}

