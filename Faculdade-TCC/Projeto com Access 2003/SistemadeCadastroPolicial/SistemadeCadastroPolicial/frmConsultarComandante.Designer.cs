namespace SistemadeCadastroPolicial
{
    partial class frmConsultarComandante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarComandante));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtPosto = new System.Windows.Forms.RadioButton();
            this.rbtRG = new System.Windows.Forms.RadioButton();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.txtConsultaCmt = new System.Windows.Forms.TextBox();
            this.btnConsultarCmt = new System.Windows.Forms.Button();
            this.dgvDadosCmt = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCmt)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtPosto);
            this.groupBox1.Controls.Add(this.rbtRG);
            this.groupBox1.Controls.Add(this.rbtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // rbtPosto
            // 
            this.rbtPosto.AutoSize = true;
            this.rbtPosto.Location = new System.Drawing.Point(113, 37);
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
            this.rbtRG.Location = new System.Drawing.Point(66, 37);
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
            this.rbtNome.Location = new System.Drawing.Point(7, 39);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(53, 17);
            this.rbtNome.TabIndex = 0;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            this.rbtNome.CheckedChanged += new System.EventHandler(this.rbtNome_CheckedChanged);
            // 
            // txtConsultaCmt
            // 
            this.txtConsultaCmt.Location = new System.Drawing.Point(224, 105);
            this.txtConsultaCmt.Name = "txtConsultaCmt";
            this.txtConsultaCmt.Size = new System.Drawing.Size(252, 20);
            this.txtConsultaCmt.TabIndex = 3;
            // 
            // btnConsultarCmt
            // 
            this.btnConsultarCmt.Location = new System.Drawing.Point(401, 133);
            this.btnConsultarCmt.Name = "btnConsultarCmt";
            this.btnConsultarCmt.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCmt.TabIndex = 4;
            this.btnConsultarCmt.Text = "Pesquisar";
            this.btnConsultarCmt.UseVisualStyleBackColor = true;
            this.btnConsultarCmt.Click += new System.EventHandler(this.btnConsultarCmt_Click);
            // 
            // dgvDadosCmt
            // 
            this.dgvDadosCmt.AllowUserToAddRows = false;
            this.dgvDadosCmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosCmt.Location = new System.Drawing.Point(12, 166);
            this.dgvDadosCmt.Name = "dgvDadosCmt";
            this.dgvDadosCmt.ReadOnly = true;
            this.dgvDadosCmt.Size = new System.Drawing.Size(464, 169);
            this.dgvDadosCmt.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o texto a ser consultado e clique em pesquisar:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(488, 55);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 52);
            this.toolStripButton1.Text = "Voltar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmConsultarComandante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 360);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtConsultaCmt);
            this.Controls.Add(this.btnConsultarCmt);
            this.Controls.Add(this.dgvDadosCmt);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultarComandante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Comandantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCmt)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtPosto;
        private System.Windows.Forms.RadioButton rbtRG;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.TextBox txtConsultaCmt;
        private System.Windows.Forms.Button btnConsultarCmt;
        private System.Windows.Forms.DataGridView dgvDadosCmt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}