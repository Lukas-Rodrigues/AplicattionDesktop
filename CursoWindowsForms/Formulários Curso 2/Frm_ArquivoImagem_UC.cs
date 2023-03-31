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
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivo)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivo;
            PicArquivoImagem.Image = Image.FromFile(nomeArquivo);
        }

        private void Frm_ArquivoImagem_UC_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if (CDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = CDb.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog();
            if (FDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = FDb.Font;
            }
        }
    }
}
