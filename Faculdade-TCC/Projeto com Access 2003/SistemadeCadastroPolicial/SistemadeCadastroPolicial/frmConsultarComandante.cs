using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemadeCadastroPolicial
{
    public partial class frmConsultarComandante : Form
    {
        public frmConsultarComandante()
        {
            InitializeComponent();
        }
        #region Botões

        private void btnConsultarCmt_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNome.Checked)
            {
                txtConsultaCmt.Text = string.Empty;
                txtConsultaCmt.Focus();
            }
        }
        private void rbtRG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRG.Checked)
            {
                txtConsultaCmt.Text = string.Empty;
                txtConsultaCmt.Focus();
            }
        }
        private void rbtPosto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPosto.Checked)
            {
                txtConsultaCmt.Text = string.Empty;
                txtConsultaCmt.Focus();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos

        private void Consultar()
        {
            try
            {
                OleDbConnection objConexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\Arquivos de programas\\Polícia Militar\\Setup2\\Banco de Dados\\BDPM.mdb");

                if (rbtNome.Checked && !String.IsNullOrEmpty(txtConsultaCmt.Text))
                {
                    string strConn = ("select * from Comandante where Nome LIKE (@Nome)");
                    OleDbDataAdapter Da = new OleDbDataAdapter(strConn, objConexao);
                    //DataTable dt = new DataTable();
                    Da.SelectCommand.Parameters.AddWithValue("@Nome", txtConsultaCmt.Text + "%");
                    DataSet ds = new DataSet();
                    Da.Fill(ds, "Nome");
                    dgvDadosCmt.DataSource = ds.Tables["Nome"];
                }

                else if (rbtRG.Checked && !String.IsNullOrEmpty(txtConsultaCmt.Text))
                {
                    string strConn = ("select * from Comandante where RG LIKE (@RG)");
                    OleDbDataAdapter Da = new OleDbDataAdapter(strConn, objConexao);
                    Da.SelectCommand.Parameters.AddWithValue("@RG", txtConsultaCmt.Text + "%");
                    DataSet ds = new DataSet();
                    Da.Fill(ds, "RG");
                    dgvDadosCmt.DataSource = ds.Tables["RG"];
                }
                else
                {
                    string strConn = ("select * from Comandante where Posto LIKE (@Posto)");
                    OleDbDataAdapter Da = new OleDbDataAdapter(strConn, objConexao);
                    Da.SelectCommand.Parameters.AddWithValue("Posto", txtConsultaCmt.Text + "%");
                    DataSet ds = new DataSet();
                    Da.Fill(ds, "Posto");
                    dgvDadosCmt.DataSource = ds.Tables["Posto"];
                }

                toolStripStatusLabel1.Text = "Encontrado(s): \"" + dgvDadosCmt.RowCount +
                   "\" registros com a palavra \"" + txtConsultaCmt.Text + "\""; ;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.BDPoliciaMilitarTableAdapter.Fill(this.BDPoliciaMilitarDataSet.Nomes);
        }
    }
}
        #endregion