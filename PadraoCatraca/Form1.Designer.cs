﻿namespace PadraoCatraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnTeste = new System.Windows.Forms.Button();
            this.TxtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelRegistroTotal = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBuscarArquivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtQtdNumerosRA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTeste
            // 
            this.BtnTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeste.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTeste.Location = new System.Drawing.Point(113, 146);
            this.BtnTeste.Name = "BtnTeste";
            this.BtnTeste.Size = new System.Drawing.Size(154, 56);
            this.BtnTeste.TabIndex = 2;
            this.BtnTeste.Text = "Padronizar";
            this.BtnTeste.UseVisualStyleBackColor = true;
            this.BtnTeste.Click += new System.EventHandler(this.BtnPadrnizarClick);
            // 
            // TxtCaminhoArquivo
            // 
            this.TxtCaminhoArquivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCaminhoArquivo.Location = new System.Drawing.Point(12, 38);
            this.TxtCaminhoArquivo.Name = "TxtCaminhoArquivo";
            this.TxtCaminhoArquivo.Size = new System.Drawing.Size(333, 21);
            this.TxtCaminhoArquivo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Caminho do arquivo a ser padronizado.:";
            // 
            // LabelRegistroTotal
            // 
            this.LabelRegistroTotal.AutoSize = true;
            this.LabelRegistroTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistroTotal.Location = new System.Drawing.Point(12, 84);
            this.LabelRegistroTotal.Name = "LabelRegistroTotal";
            this.LabelRegistroTotal.Size = new System.Drawing.Size(149, 15);
            this.LabelRegistroTotal.TabIndex = 8;
            this.LabelRegistroTotal.Text = "Registros padronizados.:";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(142, 84);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(0, 15);
            this.LabelTotal.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Image = global::PadraoCatraca.Properties.Resources.icons8_ajuda_40;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.ajudaToolStripMenuItem.Text = "Instruções";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // BtnBuscarArquivo
            // 
            this.BtnBuscarArquivo.Image = global::PadraoCatraca.Properties.Resources.icons8_abrir_pasta_16;
            this.BtnBuscarArquivo.Location = new System.Drawing.Point(338, 37);
            this.BtnBuscarArquivo.Name = "BtnBuscarArquivo";
            this.BtnBuscarArquivo.Size = new System.Drawing.Size(28, 23);
            this.BtnBuscarArquivo.TabIndex = 7;
            this.BtnBuscarArquivo.UseVisualStyleBackColor = true;
            this.BtnBuscarArquivo.Click += new System.EventHandler(this.BtnBuscarArquivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Qtd. Numeros R.A";
            // 
            // TxtQtdNumerosRA
            // 
            this.TxtQtdNumerosRA.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQtdNumerosRA.Location = new System.Drawing.Point(125, 58);
            this.TxtQtdNumerosRA.Name = "TxtQtdNumerosRA";
            this.TxtQtdNumerosRA.Size = new System.Drawing.Size(35, 21);
            this.TxtQtdNumerosRA.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor padrão = 16";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 227);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtQtdNumerosRA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelRegistroTotal);
            this.Controls.Add(this.BtnBuscarArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCaminhoArquivo);
            this.Controls.Add(this.BtnTeste);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padronizador para Catraca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnTeste;
        private System.Windows.Forms.TextBox TxtCaminhoArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscarArquivo;
        private System.Windows.Forms.Label LabelRegistroTotal;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtQtdNumerosRA;
        private System.Windows.Forms.Label label3;
    }
}

