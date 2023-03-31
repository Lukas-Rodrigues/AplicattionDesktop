using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            Lbl_Login.Text = "Usuário";
            Lbl_PassWorld.Text = "Password";
            Lbl_ExibirSenha.Text = "Exibir senha";
            Btn_OK.Text = "OK";
            Btn_Cancel.Text = "Cancel";
            Txt_Passworld.PasswordChar= '*';

        }

        public string senha { get; set; }
        public string Login { get; set; }

        public bool Btn_senha { get; private set; }


        private void Btn_OK_Click(object sender, EventArgs e)
        {
            senha = Txt_Passworld.Text;
            Login = Txt_Login.Text; 
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Lbl_ExibirSenha_Click(object sender, EventArgs e)
        {
            if (Btn_senha == false)
            {
              Txt_Passworld.PasswordChar= '*';
                Btn_senha = true;
                Lbl_ExibirSenha.Text = "Exibir senha";
            }
            else
            {
                Txt_Passworld.PasswordChar = '\0';
                Lbl_ExibirSenha.Text = "Esconder senha";
                Btn_senha = false;  
            }
        }
    }
}
