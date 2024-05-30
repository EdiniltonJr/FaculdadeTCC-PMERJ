using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using SistemadeCadastroPolicial.BDPMDataSet1TableAdapters;
using System.IO;
namespace SistemadeCadastroPolicial
{
    public partial class frmConsultarFuncionario : Form
    {
        private string RG, Nome, Filiacao, Posto, Endereco, Bairro, Cidade, TelResidencial, TelCelular, Email, DataNascimento, DataInclusao, DataPromocao, Anotacao, CPF, PASEP;
        //private Image foto_array;
        byte[] foto_array;
        public frmConsultarFuncionario()
            
        {
            InitializeComponent();
        }

        public int linhaAtual = 0;
        #region Botões

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNome.Checked)
            {
                txtConsulta.Text = string.Empty;
                txtConsulta.Focus();
            }
        }
        private void rbtRG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRG.Checked)
            {
                txtConsulta.Text = string.Empty;
                txtConsulta.Focus();
            }
        }
        private void rbtPosto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPosto.Checked)
            {
                txtConsulta.Text = string.Empty;
                txtConsulta.Focus();
            }
        }
        private void frmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPMDataSet1.CadastroPolicial' table. You can move, or remove it, as needed.
            //this.cadastroPolicialTableAdapter1.Fill(this.bDPMDataSet1.CadastroPolicial);
        }
        private void tsbtnVoltarPesquisa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BDPMDataSet2 ds = new BDPMDataSet2();
            linhaAtual = int.Parse(e.RowIndex.ToString());
            TransferirDados();
        }

        #endregion
        #region Métodos
        private void Consultar()
        {
            try
            {
                OleDbConnection objConexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\Arquivos de programas\\Polícia Militar\\Setup2\\Banco de Dados\\BDPM.mdb");

                if (rbtNome.Checked && !String.IsNullOrEmpty(txtConsulta.Text))
                {
                    string strConn = ("select * from CadastroPolicial where Nome LIKE (@Nome)");
                    OleDbDataAdapter Da = new OleDbDataAdapter(strConn, objConexao);
                    //DataTable dt = new DataTable();
                    Da.SelectCommand.Parameters.AddWithValue("@Nome", txtConsulta.Text + "%");
                    DataSet ds = new DataSet();
                    Da.Fill(ds, "Nome");
                    dgvDados.DataSource = ds.Tables["Nome"];
                }

                else if (rbtRG.Checked && !String.IsNullOrEmpty(txtConsulta.Text))
                {
                    string strConn = ("select * from CadastroPolicial where RG LIKE (@RG)");
                    OleDbDataAdapter Da = new OleDbDataAdapter(strConn, objConexao);
                    Da.SelectCommand.Parameters.AddWithValue("@RG", txtConsulta.Text + "%");
                    DataSet ds = new DataSet();
                    Da.Fill(ds, "RG");
                    dgvDados.DataSource = ds.Tables["RG"];
                }
                else
                {
                    string strConn = ("select * from CadastroPolicial where Posto LIKE (@Posto)");
                    OleDbDataAdapter Da = new OleDbDataAdapter(strConn, objConexao);
                    Da.SelectCommand.Parameters.AddWithValue("Posto", txtConsulta.Text + "%");
                    DataSet ds = new DataSet();
                    Da.Fill(ds, "Posto");
                    dgvDados.DataSource = ds.Tables["Posto"];
                }
                toolStripStatusLabel2.Text = "Encontrado(s): \"" + dgvDados.RowCount +
                    "\" registros com a palavra \"" + txtConsulta.Text + "\""; ;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.BDPoliciaMilitarTableAdapter.Fill(this.BDPoliciaMilitarDataSet.Nomes);
        }

        private void obtemDadosGrid()
        {
            BDPMDataSet1 ds = new BDPMDataSet1();
            frmFuncionario ff = new frmFuncionario();
            //obtém os dados do datagridview da linha selecionada usando as posi‡äes das colunas

            //a primeira coluna ‚ a coluna 0 a segunda ‚ a coluna 1 , e , assim por diante
            
                Nome = dgvDados[1, linhaAtual].Value.ToString();
                Filiacao = dgvDados[2, linhaAtual].Value.ToString();
                Posto = dgvDados[3, linhaAtual].Value.ToString();
                Endereco = dgvDados[4, linhaAtual].Value.ToString();
                Bairro = dgvDados[5, linhaAtual].Value.ToString();
                Cidade = dgvDados[6, linhaAtual].Value.ToString();
                TelResidencial = dgvDados[7, linhaAtual].Value.ToString();
                TelCelular = dgvDados[8, linhaAtual].Value.ToString();
                Email = dgvDados[9, linhaAtual].Value.ToString();
                DataNascimento = dgvDados[10, linhaAtual].Value.ToString();
                DataInclusao = dgvDados[11, linhaAtual].Value.ToString();
                DataPromocao = dgvDados[12, linhaAtual].Value.ToString();
                //foto_array =(Image)dgvDados[13,linhaAtual].Value;
                foto_array = (byte[])dgvDados[13,linhaAtual].Value;
                 Anotacao = dgvDados[14, linhaAtual].Value.ToString();
                 CPF = dgvDados[15, linhaAtual].Value.ToString();
                 PASEP = dgvDados[16, linhaAtual].Value.ToString();
        }

        private void TransferirDados()
{
            try
            {

                //obtem o RG do cliente a partir da linha selecionada no datagridview

                RG = dgvDados[0, linhaAtual].Value.ToString();

                if (linhaAtual >= 0 )
                {
                    //obtem dados do datagridview e atribui as vari veis definidas no formulario ff
                    
                    obtemDadosGrid();

                    frmFuncionario ff = new frmFuncionario();

                    foto_array = null;
                    ff.RG = RG;
                    ff.Nome = Nome;
                    ff.Filiacao = Filiacao;
                    ff.Posto = Posto;
                    ff.Endereco = Endereco;
                    ff.Bairro = Bairro;
                    ff.Cidade = Cidade;
                    ff.TelResidencial = TelResidencial;
                    ff.TelCelular = TelCelular;
                    ff.Email = Email;
                    ff.DataNascimento = DataNascimento;
                    ff.DataInclusao = DataInclusao;
                    ff.DataPromocao = DataPromocao;
                    ff.foto_array = foto_array ;
                    ff.Anotacao = Anotacao;
                    ff.CPF = CPF;
                    ff.PASEP = PASEP;
                    //exibe o formul rio para altera‡Æo

                    ff.ShowDialog();

                    //atualiza o grid e reexibe os dados

                    dgvDados.Update();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
    }
}
        #endregion
    

