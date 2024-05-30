namespace SistemadeCadastroPolicial
{
    partial class frmConsultarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFuncionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtPosto = new System.Windows.Forms.RadioButton();
            this.rbtRG = new System.Windows.Forms.RadioButton();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.bDPMDataSet = new SistemadeCadastroPolicial.BDPMDataSet();
            this.cadastroPolicialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroPolicialTableAdapter = new SistemadeCadastroPolicial.BDPMDataSetTableAdapters.CadastroPolicialTableAdapter();
            this.bDPMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPMDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDPMDataSet1 = new SistemadeCadastroPolicial.BDPMDataSet1();
            this.cadastroPolicialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroPolicialTableAdapter1 = new SistemadeCadastroPolicial.BDPMDataSet1TableAdapters.CadastroPolicialTableAdapter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltarPesquisa = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPolicialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPolicialBindingSource1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtPosto);
            this.groupBox1.Controls.Add(this.rbtRG);
            this.groupBox1.Controls.Add(this.rbtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // rbtPosto
            // 
            this.rbtPosto.AutoSize = true;
            this.rbtPosto.Location = new System.Drawing.Point(118, 39);
            this.rbtPosto.Name = "rbtPosto";
            this.rbtPosto.Size = new System.Drawing.Size(83, 17);
            this.rbtPosto.TabIndex = 2;
            this.rbtPosto.TabStop = true;
            this.rbtPosto.Text = "Grad./Posto";
            this.rbtPosto.UseVisualStyleBackColor = true;
            this.rbtPosto.CheckedChanged += new System.EventHandler(this.rbtPosto_CheckedChanged);
            // 
            // rbtRG
            // 
            this.rbtRG.AutoSize = true;
            this.rbtRG.Location = new System.Drawing.Point(71, 39);
            this.rbtRG.Name = "rbtRG";
            this.rbtRG.Size = new System.Drawing.Size(41, 17);
            this.rbtRG.TabIndex = 1;
            this.rbtRG.TabStop = true;
            this.rbtRG.Text = "RG";
            this.rbtRG.UseVisualStyleBackColor = true;
            this.rbtRG.CheckedChanged += new System.EventHandler(this.rbtRG_CheckedChanged);
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Location = new System.Drawing.Point(12, 39);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(53, 17);
            this.rbtNome.TabIndex = 0;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            this.rbtNome.CheckedChanged += new System.EventHandler(this.rbtNome_CheckedChanged);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(225, 97);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(251, 20);
            this.txtConsulta.TabIndex = 1;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(401, 123);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Pesquisar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 183);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(464, 169);
            this.dgvDados.TabIndex = 3;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 308);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(488, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnVoltar
            // 
            this.tsbtnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVoltar.Image")));
            this.tsbtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVoltar.Name = "tsbtnVoltar";
            this.tsbtnVoltar.Size = new System.Drawing.Size(42, 22);
            this.tsbtnVoltar.Text = "Voltar";
            this.tsbtnVoltar.Click += new System.EventHandler(this.tsbtnVoltar_Click);
            // 
            // bDPMDataSet
            // 
            this.bDPMDataSet.DataSetName = "BDPMDataSet";
            this.bDPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroPolicialBindingSource
            // 
            this.cadastroPolicialBindingSource.DataMember = "CadastroPolicial";
            this.cadastroPolicialBindingSource.DataSource = this.bDPMDataSet;
            // 
            // cadastroPolicialTableAdapter
            // 
            this.cadastroPolicialTableAdapter.ClearBeforeFill = true;
            // 
            // bDPMDataSetBindingSource
            // 
            this.bDPMDataSetBindingSource.DataSource = this.bDPMDataSet;
            this.bDPMDataSetBindingSource.Position = 0;
            // 
            // bDPMDataSetBindingSource1
            // 
            this.bDPMDataSetBindingSource1.DataSource = this.bDPMDataSet;
            this.bDPMDataSetBindingSource1.Position = 0;
            // 
            // bDPMDataSet1
            // 
            this.bDPMDataSet1.DataSetName = "BDPMDataSet1";
            this.bDPMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroPolicialBindingSource1
            // 
            this.cadastroPolicialBindingSource1.DataMember = "CadastroPolicial";
            this.cadastroPolicialBindingSource1.DataSource = this.bDPMDataSet1;
            // 
            // cadastroPolicialTableAdapter1
            // 
            this.cadastroPolicialTableAdapter1.ClearBeforeFill = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltarPesquisa});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(488, 55);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnVoltarPesquisa
            // 
            this.tsbtnVoltarPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVoltarPesquisa.Image")));
            this.tsbtnVoltarPesquisa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnVoltarPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVoltarPesquisa.Name = "tsbtnVoltarPesquisa";
            this.tsbtnVoltarPesquisa.Size = new System.Drawing.Size(90, 52);
            this.tsbtnVoltarPesquisa.Text = "Voltar";
            this.tsbtnVoltarPesquisa.Click += new System.EventHandler(this.tsbtnVoltarPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite o texto a ser pesquisado e clique em pesquisar:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel2.Text = "Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "*Para selecionar um registro é só dar 2 cliques.";
            // 
            // frmConsultarFuncionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(488, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Praças e Oficiais";
            this.Load += new System.EventHandler(this.frmConsultarFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPolicialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroPolicialBindingSource1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtPosto;
        private System.Windows.Forms.RadioButton rbtRG;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnVoltar;
        public System.Windows.Forms.DataGridView dgvDados;
        private BDPMDataSet bDPMDataSet;
        private System.Windows.Forms.BindingSource cadastroPolicialBindingSource;
        private BDPMDataSetTableAdapters.CadastroPolicialTableAdapter cadastroPolicialTableAdapter;
        private System.Windows.Forms.BindingSource bDPMDataSetBindingSource;
        private System.Windows.Forms.BindingSource bDPMDataSetBindingSource1;
        private BDPMDataSet1 bDPMDataSet1;
        private System.Windows.Forms.BindingSource cadastroPolicialBindingSource1;
        private BDPMDataSet1TableAdapters.CadastroPolicialTableAdapter cadastroPolicialTableAdapter1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnVoltarPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label1;
    }
}