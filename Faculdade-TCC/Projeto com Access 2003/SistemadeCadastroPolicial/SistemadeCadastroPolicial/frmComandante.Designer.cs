namespace SistemadeCadastroPolicial
{
    partial class frmComandante
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
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label postoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label anotacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComandante));
            this.bDPMDataSet1 = new SistemadeCadastroPolicial.BDPMDataSet1();
            this.comandanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandanteTableAdapter = new SistemadeCadastroPolicial.BDPMDataSet1TableAdapters.ComandanteTableAdapter();
            this.tableAdapterManager = new SistemadeCadastroPolicial.BDPMDataSet1TableAdapters.TableAdapterManager();
            this.txtRGCmt = new System.Windows.Forms.TextBox();
            this.txtNomeCmt = new System.Windows.Forms.TextBox();
            this.cmbPostoCmt = new System.Windows.Forms.ComboBox();
            this.mskTelefoneCmt = new System.Windows.Forms.MaskedTextBox();
            this.rtbAnotacaoCmt = new System.Windows.Forms.RichTextBox();
            this.picFotoCmt = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlterarCmt = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCadastroCmt = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluircmt = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.comandanteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.comandanteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFotocmt = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConfirmarAlteracaoCmt = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConfirmarCadastroCmt = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.bDPMDataSet3 = new SistemadeCadastroPolicial.BDPMDataSet3();
            this.comandanteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comandanteTableAdapter1 = new SistemadeCadastroPolicial.BDPMDataSet3TableAdapters.ComandanteTableAdapter();
            rGLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            postoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            anotacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoCmt)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comandanteBindingNavigator)).BeginInit();
            this.comandanteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandanteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(11, 92);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 1;
            rGLabel.Text = "RG:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(11, 131);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // postoLabel
            // 
            postoLabel.AutoSize = true;
            postoLabel.Location = new System.Drawing.Point(123, 92);
            postoLabel.Name = "postoLabel";
            postoLabel.Size = new System.Drawing.Size(37, 13);
            postoLabel.TabIndex = 5;
            postoLabel.Text = "Posto:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(11, 170);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 7;
            telefoneLabel.Text = "Telefone:";
            // 
            // anotacaoLabel
            // 
            anotacaoLabel.AutoSize = true;
            anotacaoLabel.Location = new System.Drawing.Point(12, 229);
            anotacaoLabel.Name = "anotacaoLabel";
            anotacaoLabel.Size = new System.Drawing.Size(61, 13);
            anotacaoLabel.TabIndex = 9;
            anotacaoLabel.Text = "Anotações:";
            // 
            // bDPMDataSet1
            // 
            this.bDPMDataSet1.DataSetName = "BDPMDataSet1";
            this.bDPMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comandanteBindingSource
            // 
            this.comandanteBindingSource.DataMember = "Comandante";
            this.comandanteBindingSource.DataSource = this.bDPMDataSet1;
            // 
            // comandanteTableAdapter
            // 
            this.comandanteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroPolicialTableAdapter = null;
            this.tableAdapterManager.ComandanteTableAdapter = this.comandanteTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemadeCadastroPolicial.BDPMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtRGCmt
            // 
            this.txtRGCmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comandanteBindingSource1, "RG", true));
            this.txtRGCmt.Enabled = false;
            this.txtRGCmt.Location = new System.Drawing.Point(14, 108);
            this.txtRGCmt.Name = "txtRGCmt";
            this.txtRGCmt.Size = new System.Drawing.Size(68, 20);
            this.txtRGCmt.TabIndex = 2;
            // 
            // txtNomeCmt
            // 
            this.txtNomeCmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comandanteBindingSource1, "Nome", true));
            this.txtNomeCmt.Enabled = false;
            this.txtNomeCmt.Location = new System.Drawing.Point(14, 147);
            this.txtNomeCmt.Name = "txtNomeCmt";
            this.txtNomeCmt.Size = new System.Drawing.Size(426, 20);
            this.txtNomeCmt.TabIndex = 4;
            // 
            // cmbPostoCmt
            // 
            this.cmbPostoCmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comandanteBindingSource1, "Posto", true));
            this.cmbPostoCmt.Enabled = false;
            this.cmbPostoCmt.FormattingEnabled = true;
            this.cmbPostoCmt.Items.AddRange(new object[] {
            "Cadete 3º Ano",
            "ASP OF PM",
            "2º TEN PM",
            "1º TEN PM",
            "CAP PM",
            "MAJ PM",
            "TEN CEL PM ",
            "CEL PM"});
            this.cmbPostoCmt.Location = new System.Drawing.Point(126, 108);
            this.cmbPostoCmt.Name = "cmbPostoCmt";
            this.cmbPostoCmt.Size = new System.Drawing.Size(121, 21);
            this.cmbPostoCmt.TabIndex = 6;
            // 
            // mskTelefoneCmt
            // 
            this.mskTelefoneCmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comandanteBindingSource1, "Telefone", true));
            this.mskTelefoneCmt.Enabled = false;
            this.mskTelefoneCmt.Location = new System.Drawing.Point(14, 186);
            this.mskTelefoneCmt.Mask = "(99) 0000-0000";
            this.mskTelefoneCmt.Name = "mskTelefoneCmt";
            this.mskTelefoneCmt.Size = new System.Drawing.Size(84, 20);
            this.mskTelefoneCmt.TabIndex = 8;
            // 
            // rtbAnotacaoCmt
            // 
            this.rtbAnotacaoCmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comandanteBindingSource1, "Anotacao", true));
            this.rtbAnotacaoCmt.Enabled = false;
            this.rtbAnotacaoCmt.Location = new System.Drawing.Point(12, 245);
            this.rtbAnotacaoCmt.Name = "rtbAnotacaoCmt";
            this.rtbAnotacaoCmt.Size = new System.Drawing.Size(517, 96);
            this.rtbAnotacaoCmt.TabIndex = 10;
            this.rtbAnotacaoCmt.Text = "";
            // 
            // picFotoCmt
            // 
            this.picFotoCmt.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.comandanteBindingSource1, "Foto", true));
            this.picFotoCmt.Enabled = false;
            this.picFotoCmt.Location = new System.Drawing.Point(446, 92);
            this.picFotoCmt.Name = "picFotoCmt";
            this.picFotoCmt.Size = new System.Drawing.Size(83, 98);
            this.picFotoCmt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoCmt.TabIndex = 12;
            this.picFotoCmt.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar,
            this.tsbtnAlterarCmt,
            this.tsbtnCadastroCmt,
            this.tsbtnExcluircmt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(541, 55);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnVoltar
            // 
            this.tsbtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVoltar.Image")));
            this.tsbtnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVoltar.Name = "tsbtnVoltar";
            this.tsbtnVoltar.Size = new System.Drawing.Size(90, 52);
            this.tsbtnVoltar.Text = "Voltar";
            this.tsbtnVoltar.Click += new System.EventHandler(this.tsbtnVoltar_Click);
            // 
            // tsbtnAlterarCmt
            // 
            this.tsbtnAlterarCmt.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlterarCmt.Image")));
            this.tsbtnAlterarCmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAlterarCmt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAlterarCmt.Name = "tsbtnAlterarCmt";
            this.tsbtnAlterarCmt.Size = new System.Drawing.Size(94, 52);
            this.tsbtnAlterarCmt.Text = "Alterar";
            this.tsbtnAlterarCmt.Click += new System.EventHandler(this.tsbtnAlterarCmt_Click);
            // 
            // tsbtnCadastroCmt
            // 
            this.tsbtnCadastroCmt.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCadastroCmt.Image")));
            this.tsbtnCadastroCmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCadastroCmt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadastroCmt.Name = "tsbtnCadastroCmt";
            this.tsbtnCadastroCmt.Size = new System.Drawing.Size(112, 52);
            this.tsbtnCadastroCmt.Text = "Cadastrar ";
            this.tsbtnCadastroCmt.Click += new System.EventHandler(this.tsbtnCadastroCmt_Click);
            // 
            // tsbtnExcluircmt
            // 
            this.tsbtnExcluircmt.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExcluircmt.Image")));
            this.tsbtnExcluircmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExcluircmt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExcluircmt.Name = "tsbtnExcluircmt";
            this.tsbtnExcluircmt.Size = new System.Drawing.Size(93, 52);
            this.tsbtnExcluircmt.Text = "Excluir";
            this.tsbtnExcluircmt.Click += new System.EventHandler(this.tsbtnExcluircmt_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // comandanteBindingNavigatorSaveItem
            // 
            this.comandanteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.comandanteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("comandanteBindingNavigatorSaveItem.Image")));
            this.comandanteBindingNavigatorSaveItem.Name = "comandanteBindingNavigatorSaveItem";
            this.comandanteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.comandanteBindingNavigatorSaveItem.Text = "Save Data";
            this.comandanteBindingNavigatorSaveItem.Click += new System.EventHandler(this.comandanteBindingNavigatorSaveItem_Click);
            // 
            // comandanteBindingNavigator
            // 
            this.comandanteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.comandanteBindingNavigator.BindingSource = this.comandanteBindingSource;
            this.comandanteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.comandanteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.comandanteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.comandanteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.comandanteBindingNavigatorSaveItem});
            this.comandanteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.comandanteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.comandanteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.comandanteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.comandanteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.comandanteBindingNavigator.Name = "comandanteBindingNavigator";
            this.comandanteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.comandanteBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.comandanteBindingNavigator.TabIndex = 0;
            this.comandanteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.comandanteBindingSource1;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 55);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(541, 25);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFotocmt
            // 
            this.btnFotocmt.Enabled = false;
            this.btnFotocmt.Location = new System.Drawing.Point(446, 193);
            this.btnFotocmt.Name = "btnFotocmt";
            this.btnFotocmt.Size = new System.Drawing.Size(83, 20);
            this.btnFotocmt.TabIndex = 15;
            this.btnFotocmt.Text = "Foto";
            this.btnFotocmt.UseVisualStyleBackColor = true;
            this.btnFotocmt.Click += new System.EventHandler(this.btnFotocmt_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair,
            this.tsbtnConfirmarAlteracaoCmt,
            this.tsbtnConfirmarCadastroCmt,
            this.tsbtnCancelar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 344);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(541, 55);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(78, 52);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // tsbtnConfirmarAlteracaoCmt
            // 
            this.tsbtnConfirmarAlteracaoCmt.Enabled = false;
            this.tsbtnConfirmarAlteracaoCmt.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConfirmarAlteracaoCmt.Image")));
            this.tsbtnConfirmarAlteracaoCmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnConfirmarAlteracaoCmt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConfirmarAlteracaoCmt.Name = "tsbtnConfirmarAlteracaoCmt";
            this.tsbtnConfirmarAlteracaoCmt.Size = new System.Drawing.Size(166, 52);
            this.tsbtnConfirmarAlteracaoCmt.Text = "Confirmar Alteração";
            this.tsbtnConfirmarAlteracaoCmt.Click += new System.EventHandler(this.tsbtnConfirmarAlteracaoCmt_Click);
            // 
            // tsbtnConfirmarCadastroCmt
            // 
            this.tsbtnConfirmarCadastroCmt.Enabled = false;
            this.tsbtnConfirmarCadastroCmt.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConfirmarCadastroCmt.Image")));
            this.tsbtnConfirmarCadastroCmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnConfirmarCadastroCmt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConfirmarCadastroCmt.Name = "tsbtnConfirmarCadastroCmt";
            this.tsbtnConfirmarCadastroCmt.Size = new System.Drawing.Size(163, 52);
            this.tsbtnConfirmarCadastroCmt.Text = "Confirmar Cadastro";
            this.tsbtnConfirmarCadastroCmt.Click += new System.EventHandler(this.tsbtnConfirmarCadastroCmt_Click);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.Enabled = false;
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(105, 52);
            this.tsbtnCancelar.Text = "Cancelar";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
            // 
            // epErro
            // 
            this.epErro.ContainerControl = this;
            // 
            // bDPMDataSet3
            // 
            this.bDPMDataSet3.DataSetName = "BDPMDataSet3";
            this.bDPMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comandanteBindingSource1
            // 
            this.comandanteBindingSource1.DataMember = "Comandante";
            this.comandanteBindingSource1.DataSource = this.bDPMDataSet3;
            // 
            // comandanteTableAdapter1
            // 
            this.comandanteTableAdapter1.ClearBeforeFill = true;
            // 
            // frmComandante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 399);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btnFotocmt);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.txtRGCmt);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txtNomeCmt);
            this.Controls.Add(postoLabel);
            this.Controls.Add(this.cmbPostoCmt);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.mskTelefoneCmt);
            this.Controls.Add(anotacaoLabel);
            this.Controls.Add(this.rtbAnotacaoCmt);
            this.Controls.Add(this.picFotoCmt);
            this.Controls.Add(this.comandanteBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComandante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Comandantes";
            this.Load += new System.EventHandler(this.frmComandante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoCmt)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comandanteBindingNavigator)).EndInit();
            this.comandanteBindingNavigator.ResumeLayout(false);
            this.comandanteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandanteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDPMDataSet1 bDPMDataSet1;
        private System.Windows.Forms.BindingSource comandanteBindingSource;
        private BDPMDataSet1TableAdapters.ComandanteTableAdapter comandanteTableAdapter;
        private BDPMDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox mskTelefoneCmt;
        private System.Windows.Forms.RichTextBox rtbAnotacaoCmt;
        private System.Windows.Forms.PictureBox picFotoCmt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton comandanteBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator comandanteBindingNavigator;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnFotocmt;
        private System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.ToolStripButton tsbtnCadastroCmt;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStripButton tsbtnConfirmarCadastroCmt;
        private System.Windows.Forms.ToolStripButton tsbtnConfirmarAlteracaoCmt;
        private System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ToolStripButton tsbtnAlterarCmt;
        private System.Windows.Forms.ToolStripButton tsbtnExcluircmt;
        private System.Windows.Forms.ErrorProvider epErro;
        public System.Windows.Forms.TextBox txtRGCmt;
        public System.Windows.Forms.TextBox txtNomeCmt;
        public System.Windows.Forms.ComboBox cmbPostoCmt;
        private BDPMDataSet3 bDPMDataSet3;
        private System.Windows.Forms.BindingSource comandanteBindingSource1;
        private BDPMDataSet3TableAdapters.ComandanteTableAdapter comandanteTableAdapter1;
    }
}