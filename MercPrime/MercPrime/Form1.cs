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
                        
            if ( (txtUsuario.Text == "") && (txtSenha.Text == ""))
            {
                MessageBox.Show("Bem vindo ao sistema!","LOGADO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
            }
            
            
        }
    }
}
