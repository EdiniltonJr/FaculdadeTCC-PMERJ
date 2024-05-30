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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #region Botões
        
        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",

                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void tsmPesquisarPraca_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmConsultarFuncionario objFrmConsulta = new frmConsultarFuncionario();
            objFrmConsulta.ShowDialog();
        }

        private void tsmCadastroPraca_Click(object sender, EventArgs e)
        {
            frmFuncionario objFrmFuncionarios = new frmFuncionario();

            objFrmFuncionarios.ShowDialog();
        }

        private void tsmCadastroComandante_Click(object sender, EventArgs e)
        {
            frmComandante objFrmComandante = new frmComandante();
            objFrmComandante.ShowDialog();
        }

        private void tsmPesquisarComandante_Click(object sender, EventArgs e)
        {
            frmConsultarComandante objFrmConsultarComandante = new frmConsultarComandante();
            objFrmConsultarComandante.ShowDialog();
        } 
    }
}
        #endregion