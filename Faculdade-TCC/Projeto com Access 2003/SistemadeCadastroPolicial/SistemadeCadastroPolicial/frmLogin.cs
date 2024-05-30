using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemadeCadastroPolicial
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tsbtnEntrarLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = (ValidarSenha() ? DialogResult.OK : DialogResult.None);
            
        }

        private bool ValidarSenha()
        {
            //Faz a verificação de usuário e senha
            if (txtUsuario.Text.Equals("policia") && txtSenha.Text.Equals("1809"))
            {
                return true;
            }
               
            else
            {
                MessageBox.Show("Ops, ocorreram erros!\n\nUsuário ou Senha inválida!",

                    "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void tsbtnSairLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
