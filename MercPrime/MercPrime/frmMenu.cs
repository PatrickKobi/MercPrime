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
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente desconectar?", "Desconectando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void sAIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
