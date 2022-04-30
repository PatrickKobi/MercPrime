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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario,senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;


            if ((usuario == "admin") || (usuario == "") && (senha == ""))
            {
                MessageBox.Show("Bem vindo ao sistema!","LOGADO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.ShowDialog();           
                
            }
            else
            {
                MessageBox.Show("USUARIO OU SENHA INCORRETO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string usuario, senha;
                usuario = txtUsuario.Text;
                senha = txtSenha.Text;

                if ((usuario == "admin") || (usuario == "") && (senha == ""))
                {
                    MessageBox.Show("LOGADO COM SUCESSO", "LOGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmMenu menu = new frmMenu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO OU SENHA INCORRETO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
