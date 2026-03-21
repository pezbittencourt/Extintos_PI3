namespace Extintos
{
    partial class FormDraftosaurus
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
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtIDdaPartida = new System.Windows.Forms.TextBox();
            this.lblDjogador = new System.Windows.Forms.Label();
            this.bntEntrar = new System.Windows.Forms.Button();
            this.lblJogadorEscolhido = new System.Windows.Forms.Label();
            this.lblFaceDado = new System.Windows.Forms.Label();
            this.bntExibirMao = new System.Windows.Forms.Button();
            this.lblQuantidadeDino = new System.Windows.Forms.Label();
            this.lblCodDinossauro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(11, 101);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(125, 20);
            this.txtSenhaJogador.TabIndex = 41;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.Location = new System.Drawing.Point(11, 76);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(122, 15);
            this.lblSenhaJogador.TabIndex = 40;
            this.lblSenhaJogador.Text = "Senha da Partida:";
            // 
            // txtIDdaPartida
            // 
            this.txtIDdaPartida.Location = new System.Drawing.Point(11, 41);
            this.txtIDdaPartida.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDdaPartida.Name = "txtIDdaPartida";
            this.txtIDdaPartida.Size = new System.Drawing.Size(125, 20);
            this.txtIDdaPartida.TabIndex = 39;
            // 
            // lblDjogador
            // 
            this.lblDjogador.AutoSize = true;
            this.lblDjogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDjogador.Location = new System.Drawing.Point(11, 16);
            this.lblDjogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDjogador.Name = "lblDjogador";
            this.lblDjogador.Size = new System.Drawing.Size(95, 15);
            this.lblDjogador.TabIndex = 38;
            this.lblDjogador.Text = "ID da Partida:";
            // 
            // bntEntrar
            // 
            this.bntEntrar.Location = new System.Drawing.Point(31, 142);
            this.bntEntrar.Name = "bntEntrar";
            this.bntEntrar.Size = new System.Drawing.Size(75, 23);
            this.bntEntrar.TabIndex = 42;
            this.bntEntrar.Text = "Iniciar";
            this.bntEntrar.UseVisualStyleBackColor = true;
            this.bntEntrar.Click += new System.EventHandler(this.bntEntrar_Click);
            // 
            // lblJogadorEscolhido
            // 
            this.lblJogadorEscolhido.AutoSize = true;
            this.lblJogadorEscolhido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorEscolhido.Location = new System.Drawing.Point(176, 45);
            this.lblJogadorEscolhido.Name = "lblJogadorEscolhido";
            this.lblJogadorEscolhido.Size = new System.Drawing.Size(0, 16);
            this.lblJogadorEscolhido.TabIndex = 43;
            // 
            // lblFaceDado
            // 
            this.lblFaceDado.AutoSize = true;
            this.lblFaceDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaceDado.Location = new System.Drawing.Point(176, 99);
            this.lblFaceDado.Name = "lblFaceDado";
            this.lblFaceDado.Size = new System.Drawing.Size(0, 16);
            this.lblFaceDado.TabIndex = 44;
            // 
            // bntExibirMao
            // 
            this.bntExibirMao.Location = new System.Drawing.Point(401, 241);
            this.bntExibirMao.Name = "bntExibirMao";
            this.bntExibirMao.Size = new System.Drawing.Size(120, 56);
            this.bntExibirMao.TabIndex = 45;
            this.bntExibirMao.Text = "Ver Mão";
            this.bntExibirMao.UseVisualStyleBackColor = true;
            this.bntExibirMao.Click += new System.EventHandler(this.bntExibirMao_Click);
            // 
            // lblQuantidadeDino
            // 
            this.lblQuantidadeDino.AutoSize = true;
            this.lblQuantidadeDino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDino.Location = new System.Drawing.Point(431, 192);
            this.lblQuantidadeDino.Name = "lblQuantidadeDino";
            this.lblQuantidadeDino.Size = new System.Drawing.Size(0, 16);
            this.lblQuantidadeDino.TabIndex = 47;
            // 
            // lblCodDinossauro
            // 
            this.lblCodDinossauro.AutoSize = true;
            this.lblCodDinossauro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodDinossauro.Location = new System.Drawing.Point(431, 138);
            this.lblCodDinossauro.Name = "lblCodDinossauro";
            this.lblCodDinossauro.Size = new System.Drawing.Size(0, 16);
            this.lblCodDinossauro.TabIndex = 46;
            // 
            // FormDraftosaurus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblQuantidadeDino);
            this.Controls.Add(this.lblCodDinossauro);
            this.Controls.Add(this.bntExibirMao);
            this.Controls.Add(this.lblFaceDado);
            this.Controls.Add(this.lblJogadorEscolhido);
            this.Controls.Add(this.bntEntrar);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.txtIDdaPartida);
            this.Controls.Add(this.lblDjogador);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDraftosaurus";
            this.Text = "FormDraftosaurus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtIDdaPartida;
        private System.Windows.Forms.Label lblDjogador;
        private System.Windows.Forms.Button bntEntrar;
        private System.Windows.Forms.Label lblJogadorEscolhido;
        private System.Windows.Forms.Label lblFaceDado;
        private System.Windows.Forms.Button bntExibirMao;
        private System.Windows.Forms.Label lblQuantidadeDino;
        private System.Windows.Forms.Label lblCodDinossauro;
    }
}