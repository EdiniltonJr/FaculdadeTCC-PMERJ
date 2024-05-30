using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace SistemadeCadastroPolicial
{
    public partial class frmComandante : Form
    {
        public frmComandante()
        {
            InitializeComponent();
        }

        private void comandanteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comandanteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPMDataSet1);
        }

        private void frmComandante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPMDataSet3.Comandante' table. You can move, or remove it, as needed.
            this.comandanteTableAdapter1.Fill(this.bDPMDataSet3.Comandante);
            // TODO: This line of code loads data into the 'bDPMDataSet1.Comandante' table. You can move, or remove it, as needed.
            //this.comandanteTableAdapter.Fill(this.bDPMDataSet1.Comandante);
        }

        #region Botões
        private void btnFotocmt_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFd1 = new OpenFileDialog();
            oFd1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = oFd1.ShowDialog();

            if (res == DialogResult.OK)
            {
                picFotoCmt.Image = Image.FromFile(oFd1.FileName);
            }
        }
        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbtnCadastroCmt_Click(object sender, EventArgs e)
        {
            DesabilitaBotõesCadastrar();
            HabilitaBotoesCadastrar();
            LimparCampos();
        }
        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",

MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja voltar e cancelar o cadastro?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private void tsbtnAlterarCmt_Click(object sender, EventArgs e)
        {
            DesabilitaBotoesAlterar();
            HabilitaBotoesAlterar();
        }
        private void tsbtnExcluircmt_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        private void tsbtnConfirmarCadastroCmt_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        private void tsbtnConfirmarAlteracaoCmt_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        #endregion

        #region Métodos

        private void DesabilitaBotõesCadastrar()
        {
            tsbtnAlterarCmt.Enabled = false;
            tsbtnExcluircmt.Enabled = false;
            tsbtnSair.Enabled = false;
            tsbtnVoltar.Enabled = false;
        }
        private void HabilitaBotoesCadastrar()
        {
            txtRGCmt.Enabled = true;
            txtNomeCmt.Enabled = true;
            cmbPostoCmt.Enabled = true;
            mskTelefoneCmt.Enabled = true;
            btnFotocmt.Enabled = true;
            rtbAnotacaoCmt.Enabled = true;
            tsbtnConfirmarCadastroCmt.Enabled = true;
            tsbtnCancelar.Enabled = true;
        }
        private void DesabilitaBotoesAlterar()
        {
            tsbtnExcluircmt.Enabled = false;
            tsbtnSair.Enabled = false;
            tsbtnVoltar.Enabled = false;
            tsbtnCadastroCmt.Enabled = false;
        }
        private void HabilitaBotoesAlterar()
        {
            txtNomeCmt.Enabled = true;
            cmbPostoCmt.Enabled = true;
            btnFotocmt.Enabled = true;
            mskTelefoneCmt.Enabled = true;
            rtbAnotacaoCmt.Enabled = true;
            tsbtnConfirmarAlteracaoCmt.Enabled = true;
            tsbtnCancelar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtRGCmt.Clear();
            txtNomeCmt.Clear();
            mskTelefoneCmt.Clear();
            rtbAnotacaoCmt.Clear();
            epErro.Clear();
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
                    string strConn = "DELETE FROM Comandante WHERE RG = @RG";

                    OleDbCommand objCommand = new OleDbCommand(strConn, objConexao);
                    OleDbDataAdapter ad = new OleDbDataAdapter(objCommand);
                    BDPMDataSet ds = new BDPMDataSet();
                    objCommand.Parameters.AddWithValue("@RG", txtRGCmt.Text);
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();
                    MessageBox.Show("Registro excluído com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.cadastroPolicialTableAdapter.Fill(bDPMDataSet.CadastroPolicial);
                    //this.cadastroPolicialTableAdapter.Update(this.bDPMDataSet.CadastroPolicial);
                    //ad.Fill(ds.CadastroPolicial);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Gravar()
        {
            bool camposValidados = true;

            try
            {
                OleDbConnection objConexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\Arquivos de programas\\Polícia Militar\\Setup2\\Banco de Dados\\BDPM.mdb");

                string strConn = "INSERT INTO Comandante (RG,Nome,Posto,Telefone,Anotacao,Foto) values (@RG,@Nome,@Posto,@Telefone,@Anotacao,@Foto)";

                OleDbCommand objCommand = new OleDbCommand(strConn, objConexao);

                //RG

                if (!String.IsNullOrEmpty(txtRGCmt.Text))
                {
                    objCommand.Parameters.AddWithValue("@RG", txtRGCmt.Text);

                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(txtRGCmt, "O campo RG é obrigatório!");
                    camposValidados = false;
                }

                //Nome

                if (!String.IsNullOrEmpty(txtNomeCmt.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNomeCmt.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(txtNomeCmt, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                //Posto

                if (!String.IsNullOrEmpty(cmbPostoCmt.Text))
                {
                    objCommand.Parameters.AddWithValue("@Posto", cmbPostoCmt.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(cmbPostoCmt, "O campo Posto é obrigatório!");
                    camposValidados = false;
                }

                //Telefone 

                {
                    objCommand.Parameters.AddWithValue("@Telefone", mskTelefoneCmt.Text);
                    camposValidados = true;
                }

                //Anotação

                {
                    objCommand.Parameters.AddWithValue("@Anotacao", rtbAnotacaoCmt.Text);
                    camposValidados = true;
                }

                //Foto

                MemoryStream ms = new MemoryStream();
                //convertendo a foto para dados binários
                if (picFotoCmt.Image != null)
                {
                    ms = new MemoryStream();
                    picFotoCmt.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //byte[] foto_array = ms.ToArray();
                    byte[] foto_array = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(foto_array, 0, foto_array.Length);
                    objCommand.Parameters.AddWithValue("@Foto", foto_array);
                    //foto_array = ms.ToArray();
                    picFotoCmt.Image = null;
                }
                else
                {
                    epErro.SetError(picFotoCmt, "O campo Foto é obrigatório!");
                    camposValidados = false;
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
                    txtRGCmt.Focus();
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
            bool camposValidados = true;

            try
            {
                OleDbConnection objConexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\Arquivos de programas\\Polícia Militar\\Setup2\\Banco de Dados\\BDPM.mdb");

                string strConn = "UPDATE  Comandante SET Nome=@Nome,Posto=@Posto,Telefone=@Telefone,Anotacao=@Anotacao,Foto=@Foto where RG=" + txtRGCmt.Text;

                OleDbCommand objCommand = new OleDbCommand(strConn, objConexao);

                //Nome

                if (!String.IsNullOrEmpty(txtNomeCmt.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNomeCmt.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(txtNomeCmt, "O campo Nome é obrigatório!");
                    //MessageBox.Show("O campo Nome é obrigatório", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    camposValidados = false;
                }

                //Posto

                if (!String.IsNullOrEmpty(cmbPostoCmt.Text))
                {
                    objCommand.Parameters.AddWithValue("@Posto", cmbPostoCmt.Text);
                    camposValidados = true;
                }

                else
                {
                    epErro.SetError(cmbPostoCmt, "O campo Posto é obrigatório!");
                    camposValidados = false;
                }

                //Telefone 

                {
                    objCommand.Parameters.AddWithValue("@Telefone", mskTelefoneCmt.Text);
                    camposValidados = true;
                }

                //Anotações

                {
                    objCommand.Parameters.AddWithValue("@Anotacao", rtbAnotacaoCmt.Text);
                    camposValidados = true;
                }

                //Foto

                MemoryStream ms = new MemoryStream();
                //convertendo a foto para dados binários
                if (picFotoCmt.Image != null)
                {
                    ms = new MemoryStream();
                    picFotoCmt.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //byte[] foto_array = ms.ToArray();
                    byte[] foto_array = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(foto_array, 0, foto_array.Length);
                    objCommand.Parameters.AddWithValue("@Foto", foto_array);
                    //foto_array = ms.ToArray();
                    picFotoCmt.Image = null;
                }
                else
                {
                    epErro.SetError(picFotoCmt, "O campo Foto é obrigatório!");
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

                    txtNomeCmt.Focus();
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
    }
}

	#endregion