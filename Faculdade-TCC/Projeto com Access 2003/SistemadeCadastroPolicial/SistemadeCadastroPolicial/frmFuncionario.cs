using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using SistemadeCadastroPolicial.BDPMDataSetTableAdapters;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;

namespace SistemadeCadastroPolicial
{
    public partial class frmFuncionario : Form
    {
        
        public frmFuncionario()
        {
            InitializeComponent();
        }
        public string Nome,Filiacao,Posto, Endereco,Bairro, Cidade, TelResidencial,TelCelular, Email,DataNascimento,DataInclusao,DataPromocao, Anotacao, CPF, PASEP;
        public string RG;
       // public Image foto_array;
        public byte[] foto_array;

        #region Botões
        private void cadastroPolicialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroPolicialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPMDataSet);
        }
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPMDataSet3.CadastroPolicial' table. You can move, or remove it, as needed.
            this.cadastroPolicialTableAdapter3.Fill(this.bDPMDataSet3.CadastroPolicial);
            // TODO: This line of code loads data into the 'bDPMDataSet2.CadastroPolicial' table. You can move, or remove it, as needed.
            //this.cadastroPolicialTableAdapter2.Fill(this.bDPMDataSet2.CadastroPolicial);
                // TODO: This line of code loads data into the 'bDPMDataSet1.CadastroPolicial' table. You can move, or remove it, as needed.
               // this.cadastroPolicialTableAdapter1.Fill(this.bDPMDataSet1.CadastroPolicial);
            PreencherConsulta();
        }
        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",

MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbtnConfirmarCad_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void tsbtnConfirmarAlt_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja voltar e cancelar o cadastro?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFd1 = new OpenFileDialog();
            oFd1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = oFd1.ShowDialog();

            if (res == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(oFd1.FileName);
            }
        }

        private void tsbtnAlterar_Click(object sender, EventArgs e)
        {
            DesabilitaBotoesAlterar();
            HabilitaBotoesAlterar();
            txtNome.Focus();
        }

        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitaBotoesCadastrar();
            HabilitaBotoesCadastrar();
            txtRG.Focus();
            tsbtnCadastrar.Enabled = false;
        }

        private void tsbtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        private void ajudaDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqAjudadeCusto();
        }
        private void tsreqCartãoFUSPOM_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqCartaoFuspom();
        }
        private void tsreqconfecçãoDeAuxilioFardamento3ºSGTE2ºSGT_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqConfAuxilioFardamento3ºSGTe2ºSGT();
        }
        private void tsreqarmasDeFogo_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqArmasdeFogo();
        }
        private void tsreqcALCULODEATRASADO_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqCalculodeAtrasado();
        }
        private void tsreqidentidade_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqIdentidade();
        }
        private void tsreqidentidadeParaDependentes_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqIdentidadeDependente();
        }
        private void tsreqinclusãoDeTempoDeEnsinoAlunoAprendiz_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqInclusaoAlunoAprendiz();
        }
        private void tsreqinscriçãoCAS_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqInscricaoCas();
        }
        private void tsreqlicençaEspecialLE1ª_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqLicencaEspecial();
        }
        private void tsreqlicençaEspecialLTIPInterrupção_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqLicencaEspecialLTIPIinterrupcao();
        }
        private void tsreqaquisiçãoDeArmasDeFogo_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqAquisicaodeArmadeFogo();
        }
        private void tsreqaquisiçãoDaPistolaCal40_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqAquisicaodaPistola40();
        }
        private void tsreqmudançaDeEstadoCivil_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqMudancadeEstadocivil();
        }
        private void tsreqtransferirArmasDeFogo_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqTransferirArmadeFogo();
        }
        private void tsreqinscriçãoPOEPP_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqInscricaoPOEPP();
        }
        private void tsreqsolicitaçãoUsoDeCelular_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqLicitacaoUsodeCelular();
        }
        private void tsreqinclusãoDeTempoINSS_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqInclusaodeTempoINSS();
        }
        private void tsreqpermisãoParaPrestarConcurso_Click(object sender, EventArgs e)
        {
            PreencherDocWordReqPermisaoparaPrestarConcurso();
        }
        private void tspartetermoDeTransferênciaArmaDeFogo_Click(object sender, EventArgs e)
        {
            PreencherDocWordParteTermodeTransferenciaArmadeFogo();
        }
        private void tsparteInclusãoDeDependenteCartaoFUSPOM_Click(object sender, EventArgs e)
        {
            PreencherDocWordParteInclusaodeDependenteCartãoFUSPOM();
        }
        private void tsparteaniversário_Click(object sender, EventArgs e)
        {
            PreencherDocWordParteAniversario();
        }
        private void tspartemudançaDeEndereço_Click(object sender, EventArgs e)
        {
            PreencherDocWordParteMudancadeEndereco();
        }        
        
        #endregion
        #region Métodos

        private void Gravar()
        {
            bool camposValidados = true;

            try
            {
                OleDbConnection objConexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\Arquivos de programas\\Polícia Militar\\Setup2\\Banco de Dados\\BDPM.mdb");

                string strConn = "INSERT INTO CadastroPolicial (RG,Nome,Filiacao,Posto,Endereco,Bairro," +
                    "Cidade,TelResidencial,TelCelular,Email,DataNascimento,DataInclusao,DataPromocao,Foto, Anotacao, CPF, PASEP)" +
                    "Values (@RG,@Nome,@Filiacao,@Posto,@Endereco,@Bairro,@Cidade,@TelRes,@TelCel,@Email,@DtNasc,@DtIncl,@DtProm,@Foto, @Anotacao, @CPF, @PASEP)";
                OleDbCommand objCommand = new OleDbCommand(strConn, objConexao);

                //RG

                if (!String.IsNullOrEmpty(txtRG.Text))
                {
                    objCommand.Parameters.AddWithValue("@RG", txtRG.Text);

                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(txtRG, "O campo RG é obrigatório!");
                    camposValidados = false;
                }

                //Nome

                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNome.Text);

                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                //Filiação

                if (!String.IsNullOrEmpty(txtFiliacao.Text))
                {
                    objCommand.Parameters.AddWithValue("@Filiacao", txtFiliacao.Text);

                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(txtFiliacao, "O campo Filiação é obrigatório!");
                    camposValidados = false;
                }

                //Posto

                if (!String.IsNullOrEmpty(cmbPosto.Text))
                {
                    objCommand.Parameters.AddWithValue("@Posto", cmbPosto.Text);

                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(cmbPosto, "O campo Posto é obrigatório!");
                    camposValidados = false;
                }

                //Endereço

                {
                    objCommand.Parameters.AddWithValue("@Endereco", txtEndereco.Text);

                    camposValidados = true;
                }

                //Bairro
                {
                    objCommand.Parameters.AddWithValue("@Bairro", txtBairro.Text);

                    camposValidados = true;
                }

                //Cidade
                {
                    objCommand.Parameters.AddWithValue("@Cidade", txtCidade.Text);

                    camposValidados = true;
                }

                //Telefone Residencial

                {
                    objCommand.Parameters.AddWithValue("@TelRes", mskTelResidencial.Text);

                    camposValidados = true;
                }

                //Telefone Celular
                {
                    objCommand.Parameters.AddWithValue("@TelCel", mskTelCelular.Text);

                    camposValidados = true;
                }

                //Email
                {
                    objCommand.Parameters.AddWithValue("@Email", txtEmail.Text);

                    camposValidados = true;
                }

                //Data Nascimento
                if (!String.IsNullOrEmpty(mskDtNascimento.Text))
                {
                    objCommand.Parameters.AddWithValue("@DtNasc", mskDtNascimento.Text);
                    camposValidados = true;
                }
                else
                {
                    epErro.SetError(mskDtNascimento, "O campo Data de Nascimento é obrigatório!");
                    camposValidados = false;
                }

                //Data Inclusão

                if (!String.IsNullOrEmpty(mskDtInclusao.Text))
                {
                    objCommand.Parameters.AddWithValue("@DtIncl", mskDtInclusao.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(mskDtInclusao, "O campo Data de Inclusão é obrigatório!");
                    camposValidados = false;
                }

                //Data Promoção

                {
                    objCommand.Parameters.AddWithValue("@DtProm", mskDtPromocao.Text);
                    camposValidados = true;
                }

                //Foto
                MemoryStream ms = new MemoryStream();
                //convertendo a foto para dados binários
                if (picFoto.Image != null)
                {

                    ms = new MemoryStream();
                    picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //byte[] foto_array = ms.ToArray();
                    byte[] foto_array = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(foto_array, 0, foto_array.Length);
                    objCommand.Parameters.AddWithValue("@Foto", foto_array);
                    //foto_array = ms.ToArray();
                    picFoto.Image = null;
                }
                else
                {
                    epErro.SetError(picFoto, "O campo Foto é obrigatório!");
                    camposValidados = false;
                }

                //Anotação

                {
                    objCommand.Parameters.AddWithValue("@Anotacao", rtbAnotacao.Text);
                    camposValidados = true;
                }

                //CPF

                {
                    objCommand.Parameters.AddWithValue("@CPF", mskCPF.Text);
                    camposValidados = true;
                }

                //PASEP

                {
                    objCommand.Parameters.AddWithValue("@PASEP", mskPASEP.Text);
                    camposValidados = true;
                }

                //Verifico se o retorno de minha variável camposValidados é true

                if (camposValidados)
                {
                    objConexao.Open();
                    //Uso o método ExecuteNonQuery para executar os comandos e realizar o Insert no banco

                    objCommand.ExecuteNonQuery();

                    //Fecho a conexão

                    objConexao.Close();

                    //Exibo a mensagem ao usuário de confirmação da inserção no banco

                    MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Chamo o método para limpar os campos e dou o foco ao rGTextBox

                    LimparCampos();
                    txtRG.Focus();
                }

                else
                {
                    //Exibo a mensagem ao usuário de erro
                    camposValidados = false;
                    MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",
                    "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, ocorreram erros!\n" + ex.Message);
            }
        }

        private void Alterar()
        {
            bool camposValidados = false;

            try
            {
                OleDbConnection objConexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\Arquivos de programas\\Polícia Militar\\Setup2\\Banco de Dados\\BDPM.mdb");

                string strConn = "UPDATE  CadastroPolicial SET Nome=@Nome,Filiacao=@Filiacao,Posto=@Posto,Endereco=@Endereco,Bairro=@Bairro," +
                    "Cidade=@Cidade,TelResidencial=@TelRes,TelCelular=@TelCel,Email=@Email,DataNascimento=@DtNasc,DataInclusao=@DtIncl,DataPromocao=@DtProm," +
                    "Foto=@Foto,Anotacao=@Anotacao, CPF=@CPF, PASEP=@PASEP where RG=" + txtRG.Text;

                OleDbCommand objCommand = new OleDbCommand(strConn, objConexao);
                
                //Nome

                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNome.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                //Filiação

                if (!String.IsNullOrEmpty(txtFiliacao.Text))
                {
                    objCommand.Parameters.AddWithValue("@Filiacao", txtFiliacao.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(txtFiliacao, "O campo Filiação é obrigatório!");
                    camposValidados = false;
                }

                //Posto

                if (!String.IsNullOrEmpty(cmbPosto.Text))
                {
                    objCommand.Parameters.AddWithValue("@Posto", cmbPosto.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(cmbPosto, "O campo Posto é obrigatório!");
                    camposValidados = false;
                }

                //Endereço

                {
                    objCommand.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                    camposValidados = true;
                }

                //Bairro

                {
                    objCommand.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                    camposValidados = true;
                }

                //Cidade

                {
                    objCommand.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                    camposValidados = true;
                }

                //Telefone Residencial

                {
                    objCommand.Parameters.AddWithValue("@TelRes", mskTelResidencial.Text);
                    camposValidados = true;
                }

                //Telefone Celular

                {
                    objCommand.Parameters.AddWithValue("@TelCel", mskTelCelular.Text);
                    camposValidados = true;
                }

                //Email
                {
                    objCommand.Parameters.AddWithValue("@Email", txtEmail.Text);
                    camposValidados = true;
                }

                //Data Nascimento

                if (!String.IsNullOrEmpty(mskDtNascimento.Text))
                {
                    objCommand.Parameters.AddWithValue("@DtNasc", mskDtNascimento.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(mskDtNascimento, "O campo Data de Nascimento é obrigatório!");
                    camposValidados = false;
                }

                //Data Inclusão

                if (!String.IsNullOrEmpty(mskDtInclusao.Text))
                {
                    objCommand.Parameters.AddWithValue("@DtIncl", mskDtInclusao.Text);
                    camposValidados = false;
                }

                else
                {
                    epErro.SetError(mskDtInclusao, "O campo Data de Inclusão é obrigatório!");
                    camposValidados = false;
                }

                //Data Promoção

                {
                    objCommand.Parameters.AddWithValue("@DtProm", mskDtPromocao.Text);
                    camposValidados = true;
                }

                //Foto

                MemoryStream ms = new MemoryStream();
                //convertendo a foto para dados binários
                if (picFoto.Image != null)
                {
                    ms = new MemoryStream();
                    picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //byte[] foto_array = ms.ToArray();
                    byte[] foto_array = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(foto_array, 0, foto_array.Length);
                    objCommand.Parameters.AddWithValue("@Foto", foto_array);
                    //foto_array = ms.ToArray();
                    picFoto.Image = null;
                }
                else
                {
                    epErro.SetError(picFoto, "O campo Foto é obrigatório!");
                }

                //Anotações

                {
                    objCommand.Parameters.AddWithValue("@Anotacao", rtbAnotacao.Text);
                    camposValidados = true;
                }

                //CPF

                {
                    objCommand.Parameters.AddWithValue("@CPF", mskCPF.Text);
                    camposValidados = true;
                }

                //PASEP

                {
                    objCommand.Parameters.AddWithValue("@PASEP", mskPASEP.Text);
                    camposValidados = true;
                }

                //Verifico se o retorno de minha variável camposValidados é true

                if (camposValidados)
                {
                    objConexao.Open();
                    //Uso o método ExecuteNonQuery para executar os comandos e realizar o Insert no banco

                    objCommand.ExecuteNonQuery();

                    //Fecho a conexão

                    objConexao.Close();

                    //Exibo a mensagem ao usuário de confirmação da inserção no banco

                    MessageBox.Show("Registro alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome.Focus();
                }

                else
                {
                    //Exibo a mensagem ao usuário de erro

                    MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",

                    "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             catch
             {
                 MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",
                     "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void Excluir()
        {
            //Se o usuário confirmar a exclusão, crio a conexão com o banco e excluo o respectivo registro
            if (MessageBox.Show("Tem certeza que deseja excluir o registro?", "Mensagem do Sistema",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    OleDbConnection objConexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\Arquivos de programas\\Polícia Militar\\Setup2\\Banco de Dados\\BDPM.mdb");
                    string strConn = "DELETE FROM CadastroPolicial WHERE RG = @RG";
                    
                    OleDbCommand objCommand = new OleDbCommand(strConn, objConexao);
                    OleDbDataAdapter ad = new OleDbDataAdapter(objCommand);
                    BDPMDataSet ds = new BDPMDataSet();
                    objCommand.Parameters.AddWithValue("@RG", txtRG.Text);
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Registro excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DesabilitaBotoesCadastrar()
        {
            tsbtnAlterar.Enabled = false;
            tsbtnExcluir.Enabled = false;
            tsbtnSair.Enabled = false;
            tsbtnVoltar.Enabled = false;
            tsbtnDocumentos.Enabled = false;
        }

        private void HabilitaBotoesAlterar()
        {
            txtNome.Enabled = true;
            cmbPosto.Enabled = true;
            txtFiliacao.Enabled = true;
            txtEndereco.Enabled = true;
            txtEmail.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            mskTelResidencial.Enabled = true;
            mskTelCelular.Enabled = true;
            mskDtNascimento.Enabled = true;
            mskDtInclusao.Enabled = true;
            mskDtPromocao.Enabled = true;
            mskCPF.Enabled = true;
            mskPASEP.Enabled = true;
            btnFoto.Enabled = true;
            rtbAnotacao.Enabled = true;
            tsbtnConfirmarAlt.Enabled = true;
            tsbtnCancelar.Enabled = true;
        }

        private void DesabilitaBotoesAlterar()
        {
            tsbtnExcluir.Enabled = false;
            tsbtnSair.Enabled = false;
            tsbtnVoltar.Enabled = false;
            tsbtnCadastrar.Enabled = false;
            tsbtnDocumentos.Enabled = false;
            tsbtnAlterar.Enabled = false;
        }

        private void HabilitaBotoesCadastrar()
        {
            txtRG.Enabled = true;
            txtNome.Enabled = true;
            cmbPosto.Enabled = true;
            txtFiliacao.Enabled = true;
            txtEndereco.Enabled = true;
            txtEmail.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            mskTelResidencial.Enabled = true;
            mskTelCelular.Enabled = true;
            mskDtNascimento.Enabled = true;
            mskDtInclusao.Enabled = true;
            mskDtPromocao.Enabled = true;
            mskCPF.Enabled = true;
            mskPASEP.Enabled = true;
            btnFoto.Enabled = true;
            rtbAnotacao.Enabled = true;
            tsbtnConfirmarCad.Enabled = true;
            tsbtnCancelar.Enabled = true;
        }

        private void LimparCampos()
        {
            txtRG.Clear();
            txtNome.Clear();
            txtFiliacao.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            mskTelResidencial.Clear();
            mskTelCelular.Clear();
            txtEmail.Clear();
            mskDtNascimento.Clear();
            mskDtInclusao.Clear();
            mskDtPromocao.Clear();
            mskCPF.Clear();
            mskPASEP.Clear();
            rtbAnotacao.Clear();
            epErro.Clear();
        }

        private void PreencherConsulta()
        {
            txtRG.Text = RG;
            txtNome.Text = Nome;
            txtFiliacao.Text = Filiacao;
            cmbPosto.Text = Posto;
            txtEndereco.Text = Endereco;
            txtBairro.Text = Bairro;
            txtCidade.Text = Cidade;
            mskTelResidencial.Text = TelResidencial;
            mskTelCelular.Text = TelCelular;
            txtEmail.Text = Email;
            mskDtNascimento.Text = DataNascimento;
            mskDtInclusao.Text = DataInclusao;
            mskDtPromocao.Text = DataPromocao;
            MemoryStream ms = new MemoryStream();
            //ms = new MemoryStream();
            //picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] foto_array = ms.ToArray();
            //foto_array = new byte[ms.Length];
            //ms.Position = 0;
            //ms.Read(foto_array, 0, foto_array.Length);
            //foto_array = ms.ToArray();
            //picFoto.Image = null;
            //picFoto.Image = Image.FromStream(ms);
            rtbAnotacao.Text = Anotacao;
            mskCPF.Text = CPF;
            mskPASEP.Text = PASEP;
        }

        
//Requerimentos

        private void PreencherDocWordReqAjudadeCusto()
{
    frmComandante objFormComandante = new frmComandante();
    objFormComandante.ShowDialog();
    //Objeto a ser usado nos parâmetros opcionais

    object missing = System.Reflection.Missing.Value;

    //Abre a aplicação Word e faz uma cópia do documento mapeado

    Word.Application oApp = new Word.Application();

    object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Ajuda de Custo.doc";

    Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);
   
    //Troca o conteúdo de alguns tags

    Word.Range oRng = oDoc.Range(ref missing, ref missing);

    object FindText = "[rg]";

    object ReplaceWith = txtRG.Text;

    object MatchWholeWord = true;

    object Forward = true;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = txtRG.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }

    FindText = "[nome]";

    ReplaceWith = txtNome.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = txtNome.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[Filiacao]";

    ReplaceWith = txtFiliacao.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = txtFiliacao.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[posto]";

    ReplaceWith = cmbPosto.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = cmbPosto.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[datanasc]";

    ReplaceWith = mskDtNascimento.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = mskDtNascimento.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[dataincl]";

    ReplaceWith = mskDtInclusao.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = mskDtInclusao.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[dataprom]";

    ReplaceWith = mskDtPromocao.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = mskDtPromocao.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[NomeCmt]";

    ReplaceWith = objFormComandante.txtNomeCmt.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
           ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = objFormComandante.txtNomeCmt.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[RGCmt]";

    ReplaceWith = objFormComandante.txtRGCmt;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = objFormComandante.txtRGCmt.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[PostoCmt]";

    ReplaceWith = objFormComandante.cmbPostoCmt.Top;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = objFormComandante.cmbPostoCmt.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    oApp.Visible = true;
}
        private void PreencherDocWordReqCartaoFuspom()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

    object missing = System.Reflection.Missing.Value;

    //Abre a aplicação Word e faz uma cópia do documento mapeado

    Word.Application oApp = new Word.Application();

    object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Cartão FUSPOM.doc";

    Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);
   
    //Troca o conteúdo de alguns tags

    Word.Range oRng = oDoc.Range(ref missing, ref missing);

    object FindText = "[rg]";

    object ReplaceWith = txtRG.Text;

    object MatchWholeWord = true;

    object Forward = true;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = txtRG.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }

    FindText = "[nome]";

    ReplaceWith = txtNome.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = txtNome.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[Filiacao]";

    ReplaceWith = txtFiliacao.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = txtFiliacao.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[posto]";

    ReplaceWith = cmbPosto.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = cmbPosto.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[datanasc]";

    ReplaceWith = mskDtNascimento.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = mskDtNascimento.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[dataincl]";

    ReplaceWith = mskDtInclusao.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = mskDtInclusao.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[dataprom]";

    ReplaceWith = mskDtPromocao.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = mskDtPromocao.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[NomeCmt]";

    ReplaceWith = objFormComandante.txtNomeCmt.Text;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
           ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = objFormComandante.txtNomeCmt.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[RGCmt]";

    ReplaceWith = objFormComandante.txtRGCmt;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = objFormComandante.txtRGCmt.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    FindText = "[PostoCmt]";

    ReplaceWith = objFormComandante.cmbPostoCmt.Top;

    while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
            ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
            ref missing, ref missing, ref missing) == true)
    {
        oRng.Text = objFormComandante.cmbPostoCmt.Text;
        oRng = oDoc.Range(ref missing, ref missing);
    }
    oApp.Visible = true;
}
        private void PreencherDocWordReqConfAuxilioFardamento3ºSGTe2ºSGT()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Confecção de auxilio fardamento (3º SGT e 2º SGT).doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }        
        private void PreencherDocWordReqArmasdeFogo()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Armas de Fogo.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqCalculodeAtrasado()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Cálculo de Atrasado.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqIdentidade()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Identidade.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[end]";

            ReplaceWith = txtEndereco.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtEndereco.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[bairro]";

            ReplaceWith = txtBairro.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtBairro.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[munic]";

            ReplaceWith = txtCidade.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtCidade.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[telres]";

            ReplaceWith = mskTelResidencial.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskTelResidencial.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[telcel]";

            ReplaceWith = mskTelCelular.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskTelCelular.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[cpf]";

            ReplaceWith = mskCPF.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskCPF.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[pasep]";

            ReplaceWith = mskPASEP.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskPASEP.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqIdentidadeDependente()
{
 	 frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Identidade para Dependentes.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[end]";

            ReplaceWith = txtEndereco.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtEndereco.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[bairro]";

            ReplaceWith = txtBairro.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtBairro.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[munic]";

            ReplaceWith = txtCidade.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtCidade.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[telres]";

            ReplaceWith = mskTelResidencial.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskTelResidencial.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[telcel]";

            ReplaceWith = mskTelCelular.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskTelCelular.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[cpf]";

            ReplaceWith = mskCPF.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskCPF.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[pasep]";

            ReplaceWith = mskPASEP.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskPASEP.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqInclusaoAlunoAprendiz()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Inclusão de Tempo de Ensino-Aluno Aprendiz.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
           
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {

                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqInscricaoCas()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Inscrição CAS.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqLicencaEspecial()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Licença Especial (LE) 1ª.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqLicencaEspecialLTIPIinterrupcao()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Licença Especial (LTIP) INTERRUPÇÃO.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqAquisicaodeArmadeFogo()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Aquisição de Armas de Fogo.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqAquisicaodaPistola40()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Aquisição da Pistola 40.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqMudancadeEstadocivil()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Mudança de estado civil.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqTransferirArmadeFogo()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Transferir Armas de Fogo.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqInscricaoPOEPP()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Inscrição POEPP.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqLicitacaoUsodeCelular()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\solicitação uso de celular.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqInclusaodeTempoINSS()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Inclusão de Tempo-INSS.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordReqPermisaoparaPrestarConcurso()
        {
            frmComandante objFormComandante = new frmComandante();
            objFormComandante.ShowDialog();
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Requerimentos Prontos\\Permisão para Prestar Concurso.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[Filiacao]";

            ReplaceWith = txtFiliacao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtFiliacao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[datanasc]";

            ReplaceWith = mskDtNascimento.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtNascimento.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataincl]";

            ReplaceWith = mskDtInclusao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtInclusao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[dataprom]";

            ReplaceWith = mskDtPromocao.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskDtPromocao.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[NomeCmt]";

            ReplaceWith = objFormComandante.txtNomeCmt.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                   ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtNomeCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[RGCmt]";

            ReplaceWith = objFormComandante.txtRGCmt;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.txtRGCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[PostoCmt]";

            ReplaceWith = objFormComandante.cmbPostoCmt.Top;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = objFormComandante.cmbPostoCmt.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }

        //Partes

        private void PreencherDocWordParteTermodeTransferenciaArmadeFogo()
        {
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Partes Prontas\\Termo de Transferência- Arma de Fogo.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[end]";

            ReplaceWith = txtEndereco.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtEndereco.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[bairro]";

            ReplaceWith = txtBairro.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtBairro.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[munic]";

            ReplaceWith = txtCidade.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtCidade.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            
            FindText = "[cpf]";

            ReplaceWith = mskCPF.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = mskCPF.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            oApp.Visible = true;
        }
        private void PreencherDocWordParteInclusaodeDependenteCartãoFUSPOM()
        {
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Partes Prontas\\Parte Inclusão de Dependente Cartao FUSPOM.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            oApp.Visible = true;
        }
        private void PreencherDocWordParteAniversario()
        {
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Partes Prontas\\Aniversário.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            oApp.Visible = true;
        }
        private void PreencherDocWordParteMudancadeEndereco()
        {
            //Objeto a ser usado nos parâmetros opcionais

            object missing = System.Reflection.Missing.Value;

            //Abre a aplicação Word e faz uma cópia do documento mapeado

            Word.Application oApp = new Word.Application();

            object template = @"C:\\Arquivos de programas\\Polícia Militar\\Setup2\\Partes e Requerimentos\\Partes Prontas\\Mudança de Endereço.doc";

            Word.Document oDoc = oApp.Documents.Add(ref template, ref missing, ref missing, ref missing);

            //Troca o conteúdo de alguns tags

            Word.Range oRng = oDoc.Range(ref missing, ref missing);

            object FindText = "[rg]";

            object ReplaceWith = txtRG.Text;

            object MatchWholeWord = true;

            object Forward = true;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
 MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtRG.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[nome]";

            ReplaceWith = txtNome.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtNome.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            FindText = "[posto]";

            ReplaceWith = cmbPosto.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = cmbPosto.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[end]";

            ReplaceWith = txtEndereco.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtEndereco.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[bairro]";

            ReplaceWith = txtBairro.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtBairro.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }
            FindText = "[munic]";

            ReplaceWith = txtCidade.Text;

            while (oRng.Find.Execute(ref FindText, ref missing, ref 
MatchWholeWord, ref missing, ref missing, ref Forward, ref missing,
                    ref missing, ref missing, ref ReplaceWith, ref missing, ref missing,
                    ref missing, ref missing, ref missing) == true)
            {
                oRng.Text = txtCidade.Text;
                oRng = oDoc.Range(ref missing, ref missing);
            }

            oApp.Visible = true;
        }

                    
}
        }

#endregion