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

            MessageBox.Show("Usuário Cadastrado com Sucesso \n" + 
                "Nome: " + nome + "\n" +
                "Email: " + email + "\n" + 
                "Usuário: " + usuario + "\n" + 
                "Senha: " + senha + "\n" +
                "Data de nascimento: " + nascimento + "\n" 

                ,"CADASTRADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
