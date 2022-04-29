using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercPrime
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void catálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogo catalogo = new frmCatalogo();
            catalogo.ShowDialog();
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario usuario = new frmCadastroUsuario();
            usuario.ShowDialog();
        }

        private void cadastroDeFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFilmes filmes = new frmCadastroFilmes();
            filmes.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
