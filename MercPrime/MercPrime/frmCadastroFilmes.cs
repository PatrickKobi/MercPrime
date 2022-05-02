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
    public partial class frmCadastroFilmes : Form
    {
        public frmCadastroFilmes()
        {
            InitializeComponent();
        }

        private void btnCadastrarFilme_Click(object sender, EventArgs e)
        {
            string filme, genero, descricao;
            filme = txtFilme.Text;
            genero = txtGenero.Text;
            descricao = txtDecricao.Text;
            

            MessageBox.Show("Filme Cadastrado com Sucesso \n" +
                "Filme: " + filme + "\n" +
                "Gênero: " + genero + "\n" +
                "Descrição: " + descricao + "\n",         
                "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFilme.Enabled = true;
            txtDecricao.Enabled = true;
            txtGenero.Enabled = true;
            btnCadastrarFilme.Visible = true;
        }
    }
}
