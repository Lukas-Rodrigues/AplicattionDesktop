﻿namespace CursoWindowsForms
{
    partial class Frm_ArquivoImagem_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_ArquivoImagem = new System.Windows.Forms.Label();
            this.PicArquivoImagem = new System.Windows.Forms.PictureBox();
            this.Btn_Cor = new System.Windows.Forms.Button();
            this.Btn_Fonte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicArquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ArquivoImagem
            // 
            this.Lbl_ArquivoImagem.AutoSize = true;
            this.Lbl_ArquivoImagem.Location = new System.Drawing.Point(16, 60);
            this.Lbl_ArquivoImagem.Name = "Lbl_ArquivoImagem";
            this.Lbl_ArquivoImagem.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ArquivoImagem.TabIndex = 0;
            this.Lbl_ArquivoImagem.Text = "label1";
            // 
            // PicArquivoImagem
            // 
            this.PicArquivoImagem.Location = new System.Drawing.Point(19, 101);
            this.PicArquivoImagem.Name = "PicArquivoImagem";
            this.PicArquivoImagem.Size = new System.Drawing.Size(392, 209);
            this.PicArquivoImagem.TabIndex = 1;
            this.PicArquivoImagem.TabStop = false;
            // 
            // Btn_Cor
            // 
            this.Btn_Cor.Location = new System.Drawing.Point(19, 19);
            this.Btn_Cor.Name = "Btn_Cor";
            this.Btn_Cor.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cor.TabIndex = 2;
            this.Btn_Cor.Text = "Cor";
            this.Btn_Cor.UseVisualStyleBackColor = true;
            this.Btn_Cor.Click += new System.EventHandler(this.Btn_Cor_Click);
            // 
            // Btn_Fonte
            // 
            this.Btn_Fonte.Location = new System.Drawing.Point(137, 19);
            this.Btn_Fonte.Name = "Btn_Fonte";
            this.Btn_Fonte.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fonte.TabIndex = 3;
            this.Btn_Fonte.Text = "Fonte";
            this.Btn_Fonte.UseVisualStyleBackColor = true;
            this.Btn_Fonte.Click += new System.EventHandler(this.Btn_Fonte_Click);
            // 
            // Frm_ArquivoImagem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Fonte);
            this.Controls.Add(this.Btn_Cor);
            this.Controls.Add(this.PicArquivoImagem);
            this.Controls.Add(this.Lbl_ArquivoImagem);
            this.Name = "Frm_ArquivoImagem_UC";
            this.Size = new System.Drawing.Size(660, 422);
            this.Load += new System.EventHandler(this.Frm_ArquivoImagem_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicArquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ArquivoImagem;
        private System.Windows.Forms.PictureBox PicArquivoImagem;
        private System.Windows.Forms.Button Btn_Cor;
        private System.Windows.Forms.Button Btn_Fonte;
    }
}
