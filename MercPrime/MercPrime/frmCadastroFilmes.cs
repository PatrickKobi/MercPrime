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
            descricao = txtDescricao.Text;

            if ((txtFilme.Text == "") || (txtGenero.Text == "") || (txtDescricao.Text == ""))
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Filme Cadastrado com Sucesso \n" +
                "Filme: " + filme + "\n" +
                "Gênero: " + genero + "\n" +
                "Descrição: " + descricao + "\n",
                "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            btnCadastrarFilme.Visible = false;
            btnNovo.Enabled = true;

            txtFilme.Text = "";
            txtGenero.Text = "";
            txtDescricao.Text = "";

            txtFilme.Enabled = false;
            txtDescricao.Enabled = false;
            txtGenero.Enabled = false;

           
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            txtFilme.Enabled = true;
            txtDescricao.Enabled = true;
            txtGenero.Enabled = true;
            btnCadastrarFilme.Visible = true;
            btnNovo.Enabled = false;
        }

    }
}
