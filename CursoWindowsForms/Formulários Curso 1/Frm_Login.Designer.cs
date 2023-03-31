namespace CursoWindowsForms
{
    partial class Frm_Login
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
            this.pic_Login = new System.Windows.Forms.PictureBox();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Lbl_PassWorld = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_Passworld = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Lbl_ExibirSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Login
            // 
            this.pic_Login.Image = global::CursoWindowsForms.Properties.Resources.key;
            this.pic_Login.Location = new System.Drawing.Point(12, 17);
            this.pic_Login.Name = "pic_Login";
            this.pic_Login.Size = new System.Drawing.Size(100, 93);
            this.pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Login.TabIndex = 0;
            this.pic_Login.TabStop = false;
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(119, 17);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Login.TabIndex = 1;
            this.Lbl_Login.Text = "LAbel1";
            // 
            // Lbl_PassWorld
            // 
            this.Lbl_PassWorld.AutoSize = true;
            this.Lbl_PassWorld.Location = new System.Drawing.Point(119, 65);
            this.Lbl_PassWorld.Name = "Lbl_PassWorld";
            this.Lbl_PassWorld.Size = new System.Drawing.Size(39, 13);
            this.Lbl_PassWorld.TabIndex = 2;
            this.Lbl_PassWorld.Text = "Label2";
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(122, 33);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(131, 20);
            this.Txt_Login.TabIndex = 3;
            // 
            // Txt_Passworld
            // 
            this.Txt_Passworld.Location = new System.Drawing.Point(122, 81);
            this.Txt_Passworld.Name = "Txt_Passworld";
            this.Txt_Passworld.Size = new System.Drawing.Size(131, 20);
            this.Txt_Passworld.TabIndex = 4;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(25, 158);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Btn_OK.TabIndex = 5;
            this.Btn_OK.Text = "button1";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(236, 158);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "button1";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lbl_ExibirSenha
            // 
            this.Lbl_ExibirSenha.Location = new System.Drawing.Point(271, 81);
            this.Lbl_ExibirSenha.Name = "Lbl_ExibirSenha";
            this.Lbl_ExibirSenha.Size = new System.Drawing.Size(75, 23);
            this.Lbl_ExibirSenha.TabIndex = 7;
            this.Lbl_ExibirSenha.Text = "button1";
            this.Lbl_ExibirSenha.UseVisualStyleBackColor = true;
            this.Lbl_ExibirSenha.Click += new System.EventHandler(this.Lbl_ExibirSenha_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 213);
            this.Controls.Add(this.Lbl_ExibirSenha);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Txt_Passworld);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Lbl_PassWorld);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.pic_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Login;
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Label Lbl_PassWorld;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.TextBox Txt_Passworld;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Lbl_ExibirSenha;
    }
}