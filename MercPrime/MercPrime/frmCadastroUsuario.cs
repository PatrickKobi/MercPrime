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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome,email,usuario,senha,nascimento;
            nome = txtNome.Text;
            email = txtEmail.Text;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            nascimento = txtNascimento.Text;

            if ((txtNome.Text == "") || (txtEmail.Text == "") || (txtUsuario.Text == "") || (txtSenha.Text == "") || (txtNascimento.Text == ""))
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Usuário Cadastrado com Sucesso \n" +
                "Nome: " + nome + "\n" +
                "Email: " + email + "\n" +
                "Usuário: " + usuario + "\n" +
                "Senha: " + senha + "\n" +
                "Data de nascimento: " + nascimento + "\n"

                , "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnNovo.Enabled = true;
            btnCadastrar.Visible = false;

            txtNome.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtNascimento.Text = "";

            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtNascimento.Enabled = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtNascimento.Enabled = true;

            btnCadastrar.Visible = true;
            btnNovo.Enabled = false;
        }
    }
}
