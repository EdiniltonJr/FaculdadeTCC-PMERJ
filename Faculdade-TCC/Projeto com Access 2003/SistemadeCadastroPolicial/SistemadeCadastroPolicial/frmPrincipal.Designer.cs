namespace SistemadeCadastroPolicial
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsddmPraca = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmCadastroPraca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPesquisarPraca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddmComandante = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmCadastroComandante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPesquisarComandante = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddmPraca,
            this.tsddmComandante});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(636, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsddmPraca
            // 
            this.tsddmPraca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroPraca});
            this.tsddmPraca.Image = ((System.Drawing.Image)(resources.GetObject("tsddmPraca.Image")));
            this.tsddmPraca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsddmPraca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddmPraca.Name = "tsddmPraca";
            this.tsddmPraca.Size = new System.Drawing.Size(146, 52);
            this.tsddmPraca.Text = "Praças/Oficiais";
            // 
            // tsmCadastroPraca
            // 
            this.tsmCadastroPraca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPesquisarPraca});
            this.tsmCadastroPraca.Name = "tsmCadastroPraca";
            this.tsmCadastroPraca.Size = new System.Drawing.Size(226, 22);
            this.tsmCadastroPraca.Text = "Cadastro de Praças/Oficiais";
            this.tsmCadastroPraca.Click += new System.EventHandler(this.tsmCadastroPraca_Click);
            // 
            // tsmPesquisarPraca
            // 
            this.tsmPesquisarPraca.Name = "tsmPesquisarPraca";
            this.tsmPesquisarPraca.Size = new System.Drawing.Size(132, 22);
            this.tsmPesquisarPraca.Text = "Pesquisar";
            this.tsmPesquisarPraca.Click += new System.EventHandler(this.tsmPesquisarPraca_Click);
            // 
            // tsddmComandante
            // 
            this.tsddmComandante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroComandante});
            this.tsddmComandante.Image = ((System.Drawing.Image)(resources.GetObject("tsddmComandante.Image")));
            this.tsddmComandante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsddmComandante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddmComandante.Name = "tsddmComandante";
            this.tsddmComandante.Size = new System.Drawing.Size(137, 52);
            this.tsddmComandante.Text = "Comandante";
            // 
            // tsmCadastroComandante
            // 
            this.tsmCadastroComandante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPesquisarComandante});
            this.tsmCadastroComandante.Name = "tsmCadastroComandante";
            this.tsmCadastroComandante.Size = new System.Drawing.Size(217, 22);
            this.tsmCadastroComandante.Text = "Cadastro de Comandante";
            this.tsmCadastroComandante.Click += new System.EventHandler(this.tsmCadastroComandante_Click);
            // 
            // tsmPesquisarComandante
            // 
            this.tsmPesquisarComandante.Name = "tsmPesquisarComandante";
            this.tsmPesquisarComandante.Size = new System.Drawing.Size(132, 22);
            this.tsmPesquisarComandante.Text = "Pesquisar";
            this.tsmPesquisarComandante.Click += new System.EventHandler(this.tsmPesquisarComandante_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair});
            this.toolStrip2.Location = new System.Drawing.Point(0, 350);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(636, 55);
            this.toolStrip2.TabIndex = 1;
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Policia Militar do Estado do Rio de Janeiro";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        public System.Windows.Forms.ToolStripDropDownButton tsddmPraca;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroPraca;
        private System.Windows.Forms.ToolStripMenuItem tsmPesquisarPraca;
        private System.Windows.Forms.ToolStripDropDownButton tsddmComandante;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroComandante;
        private System.Windows.Forms.ToolStripMenuItem tsmPesquisarComandante;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}