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
            this.SuspendLayout();
            // 
            // lblDraftosaurus
            // 
            this.lblDraftosaurus.AutoSize = true;
            this.lblDraftosaurus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraftosaurus.Location = new System.Drawing.Point(223, 23);
            this.lblDraftosaurus.Name = "lblDraftosaurus";
            this.lblDraftosaurus.Size = new System.Drawing.Size(344, 32);
            this.lblDraftosaurus.TabIndex = 23;
            this.lblDraftosaurus.Text = "Selecione a sua partida!";
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.Location = new System.Drawing.Point(316, 81);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(163, 28);
            this.btnListarPartidas.TabIndex = 24;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(229, 121);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(150, 212);
            this.lstPartidas.TabIndex = 25;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblTituloIdPartida
            // 
            this.lblTituloIdPartida.AutoSize = true;
            this.lblTituloIdPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIdPartida.Location = new System.Drawing.Point(412, 144);
            this.lblTituloIdPartida.Name = "lblTituloIdPartida";
            this.lblTituloIdPartida.Size = new System.Drawing.Size(122, 20);
            this.lblTituloIdPartida.TabIndex = 26;
            this.lblTituloIdPartida.Text = "Id da Partida:";
            // 
            // lblTituloNomePartida
            // 
            this.lblTituloNomePartida.AutoSize = true;
            this.lblTituloNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNomePartida.Location = new System.Drawing.Point(412, 213);
            this.lblTituloNomePartida.Name = "lblTituloNomePartida";
            this.lblTituloNomePartida.Size = new System.Drawing.Size(155, 20);
            this.lblTituloNomePartida.TabIndex = 27;
            this.lblTituloNomePartida.Text = "Nome da Partida:";
            // 
            // lblTituloDataPartida
            // 
            this.lblTituloDataPartida.AutoSize = true;
            this.lblTituloDataPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDataPartida.Location = new System.Drawing.Point(412, 283);
            this.lblTituloDataPartida.Name = "lblTituloDataPartida";
            this.lblTituloDataPartida.Size = new System.Drawing.Size(147, 20);
            this.lblTituloDataPartida.TabIndex = 28;
            this.lblTituloDataPartida.Text = "Data da Partida:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.Location = new System.Drawing.Point(316, 367);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(193, 61);
            this.btnEntrarPartida.TabIndex = 29;
            this.btnEntrarPartida.Text = "Entrar na partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(413, 181);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(0, 16);
            this.lblPartida.TabIndex = 30;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(413, 250);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(0, 16);
            this.lblNomePartida.TabIndex = 31;
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(413, 317);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(0, 16);
            this.lblDataPartida.TabIndex = 32;
            // 
            // FormPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}