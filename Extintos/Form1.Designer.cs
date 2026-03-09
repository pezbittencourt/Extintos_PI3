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
            this.txtPartidas = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // btnPartidas
            // 
            this.btnPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidas.Location = new System.Drawing.Point(183, 41);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(165, 61);
            this.btnPartidas.TabIndex = 0;
            this.btnPartidas.Text = "Ver Partidas";
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // txtPartidas
            // 
            this.txtPartidas.Location = new System.Drawing.Point(40, 147);
            this.txtPartidas.Multiline = true;
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(206, 308);
            this.txtPartidas.TabIndex = 1;
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(290, 147);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(206, 308);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartida.Location = new System.Drawing.Point(502, 218);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(0, 23);
            this.lblPartida.TabIndex = 3;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.Location = new System.Drawing.Point(502, 302);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 23);
            this.lblNomePartida.TabIndex = 4;
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartida.Location = new System.Drawing.Point(502, 392);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 23);
            this.lblDataPartida.TabIndex = 5;
            // 
            // lblTituloIdPartida
            // 
            this.lblTituloIdPartida.AutoSize = true;
            this.lblTituloIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIdPartida.Location = new System.Drawing.Point(502, 182);
            this.lblTituloIdPartida.Name = "lblTituloIdPartida";
            this.lblTituloIdPartida.Size = new System.Drawing.Size(126, 20);
            this.lblTituloIdPartida.TabIndex = 6;
            this.lblTituloIdPartida.Text = "Id da partida: ";
            // 
            // lblTituloNomePartida
            // 
            this.lblTituloNomePartida.AutoSize = true;
            this.lblTituloNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNomePartida.Location = new System.Drawing.Point(502, 271);
            this.lblTituloNomePartida.Name = "lblTituloNomePartida";
            this.lblTituloNomePartida.Size = new System.Drawing.Size(155, 20);
            this.lblTituloNomePartida.TabIndex = 7;
            this.lblTituloNomePartida.Text = "Nome da Partida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data da Partida:";
            // 
            // lstJogadores
            // 
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 16;
            this.lstJogadores.Location = new System.Drawing.Point(691, 147);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(208, 308);
            this.lstJogadores.TabIndex = 9;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(881, 487);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 16);
            this.lblVersao.TabIndex = 10;
            // 
            // lblTituloJogadoresPartida
            // 
            this.lblTituloJogadoresPartida.AutoSize = true;
            this.lblTituloJogadoresPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloJogadoresPartida.Location = new System.Drawing.Point(729, 99);
            this.lblTituloJogadoresPartida.Name = "lblTituloJogadoresPartida";
            this.lblTituloJogadoresPartida.Size = new System.Drawing.Size(121, 25);
            this.lblTituloJogadoresPartida.TabIndex = 11;
            this.lblTituloJogadoresPartida.Text = "Jogadores:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 523);
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
            this.Controls.Add(this.txtPartidas);
            this.Controls.Add(this.btnPartidas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.TextBox txtPartidas;
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
    }
}

