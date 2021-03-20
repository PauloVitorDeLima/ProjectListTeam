
namespace ListaEncadeadaDeTimesBrasileiros
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtAdicionarInicio = new System.Windows.Forms.Button();
            this.BtRemoverFinal = new System.Windows.Forms.Button();
            this.TxtBxEstadio = new System.Windows.Forms.TextBox();
            this.txtBxNomeTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBxTreinador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtAdicionarFinal = new System.Windows.Forms.Button();
            this.BtRemoverInicio = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.BtListar = new System.Windows.Forms.Button();
            this.numericJogadores = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtAdicionarInicio
            // 
            this.BtAdicionarInicio.Location = new System.Drawing.Point(12, 284);
            this.BtAdicionarInicio.Name = "BtAdicionarInicio";
            this.BtAdicionarInicio.Size = new System.Drawing.Size(225, 23);
            this.BtAdicionarInicio.TabIndex = 0;
            this.BtAdicionarInicio.Text = "ADICIONAR NO INICIO DA LISTA";
            this.BtAdicionarInicio.UseVisualStyleBackColor = true;
            this.BtAdicionarInicio.Click += new System.EventHandler(this.BtAdicionarInicio_Click);
            // 
            // BtRemoverFinal
            // 
            this.BtRemoverFinal.Location = new System.Drawing.Point(874, 318);
            this.BtRemoverFinal.Name = "BtRemoverFinal";
            this.BtRemoverFinal.Size = new System.Drawing.Size(162, 23);
            this.BtRemoverFinal.TabIndex = 1;
            this.BtRemoverFinal.Text = "Remover do final";
            this.BtRemoverFinal.UseVisualStyleBackColor = true;
            // 
            // TxtBxEstadio
            // 
            this.TxtBxEstadio.Location = new System.Drawing.Point(136, 115);
            this.TxtBxEstadio.Name = "TxtBxEstadio";
            this.TxtBxEstadio.Size = new System.Drawing.Size(185, 23);
            this.TxtBxEstadio.TabIndex = 2;
            // 
            // txtBxNomeTime
            // 
            this.txtBxNomeTime.Location = new System.Drawing.Point(136, 56);
            this.txtBxNomeTime.Name = "txtBxNomeTime";
            this.txtBxNomeTime.Size = new System.Drawing.Size(185, 23);
            this.txtBxNomeTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOME DO TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOME DO ESTÁDIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "TREINADOR";
            // 
            // TxtBxTreinador
            // 
            this.TxtBxTreinador.Location = new System.Drawing.Point(136, 166);
            this.TxtBxTreinador.Name = "TxtBxTreinador";
            this.TxtBxTreinador.Size = new System.Drawing.Size(185, 23);
            this.TxtBxTreinador.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "QUANTIDADE DE JOGADORES";
            // 
            // BtAdicionarFinal
            // 
            this.BtAdicionarFinal.Location = new System.Drawing.Point(264, 284);
            this.BtAdicionarFinal.Name = "BtAdicionarFinal";
            this.BtAdicionarFinal.Size = new System.Drawing.Size(225, 23);
            this.BtAdicionarFinal.TabIndex = 12;
            this.BtAdicionarFinal.Text = "ADICIONAR NO FINAL DA LISTA";
            this.BtAdicionarFinal.UseVisualStyleBackColor = true;
            // 
            // BtRemoverInicio
            // 
            this.BtRemoverInicio.Location = new System.Drawing.Point(574, 318);
            this.BtRemoverInicio.Name = "BtRemoverInicio";
            this.BtRemoverInicio.Size = new System.Drawing.Size(162, 23);
            this.BtRemoverInicio.TabIndex = 13;
            this.BtRemoverInicio.Text = "Remover do inicio";
            this.BtRemoverInicio.UseVisualStyleBackColor = true;
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(565, 12);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(526, 284);
            this.RichTextBox.TabIndex = 14;
            this.RichTextBox.Text = "";
            // 
            // BtListar
            // 
            this.BtListar.Location = new System.Drawing.Point(462, 21);
            this.BtListar.Name = "BtListar";
            this.BtListar.Size = new System.Drawing.Size(97, 32);
            this.BtListar.TabIndex = 15;
            this.BtListar.Text = "LISTAR";
            this.BtListar.UseVisualStyleBackColor = true;
            this.BtListar.Click += new System.EventHandler(this.BtListar_Click);
            // 
            // numericJogadores
            // 
            this.numericJogadores.Location = new System.Drawing.Point(136, 225);
            this.numericJogadores.Name = "numericJogadores";
            this.numericJogadores.Size = new System.Drawing.Size(185, 23);
            this.numericJogadores.TabIndex = 16;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 360);
            this.Controls.Add(this.numericJogadores);
            this.Controls.Add(this.BtListar);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.BtRemoverInicio);
            this.Controls.Add(this.BtAdicionarFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxTreinador);
            this.Controls.Add(this.txtBxNomeTime);
            this.Controls.Add(this.TxtBxEstadio);
            this.Controls.Add(this.BtRemoverFinal);
            this.Controls.Add(this.BtAdicionarInicio);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericJogadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtAdicionarInicio;
        private System.Windows.Forms.Button BtRemoverFinal;
        private System.Windows.Forms.TextBox TxtBxEstadio;
        private System.Windows.Forms.TextBox txtBxNomeTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBxTreinador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtAdicionarFinal;
        private System.Windows.Forms.Button BtRemoverInicio;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button BtListar;
        private System.Windows.Forms.NumericUpDown numericJogadores;
    }
}

