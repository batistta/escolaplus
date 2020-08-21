namespace ESCOLAPLUS
{
    partial class FormHOME
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripSplitButton btnArquivo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHOME));
            this.ordenarAlunosPelaMatrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarAlunosNoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlBOTOESPRINCIPAIS = new System.Windows.Forms.Panel();
            this.btnEXIBIR = new System.Windows.Forms.Button();
            this.btnPESQUISAR = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.btnINSERIR = new System.Windows.Forms.Button();
            this.pnlINSERIR = new System.Windows.Forms.Panel();
            this.mskTELEFONE = new System.Windows.Forms.MaskedTextBox();
            this.btnADDLIST = new System.Windows.Forms.Button();
            this.txtCÓDIGO = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.lblTELEFONE = new System.Windows.Forms.Label();
            this.lblCÓDIGO = new System.Windows.Forms.Label();
            this.lblNOME = new System.Windows.Forms.Label();
            btnArquivo = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStrip1.SuspendLayout();
            this.pnlBOTOESPRINCIPAIS.SuspendLayout();
            this.pnlINSERIR.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArquivo
            // 
            btnArquivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btnArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarAlunosPelaMatrículaToolStripMenuItem,
            this.gravarAlunosNoSistemaToolStripMenuItem,
            this.carregarDadosToolStripMenuItem});
            btnArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnArquivo.Image")));
            btnArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnArquivo.Name = "btnArquivo";
            btnArquivo.Size = new System.Drawing.Size(80, 24);
            btnArquivo.Text = "Arquivo";
            // 
            // ordenarAlunosPelaMatrículaToolStripMenuItem
            // 
            this.ordenarAlunosPelaMatrículaToolStripMenuItem.Name = "ordenarAlunosPelaMatrículaToolStripMenuItem";
            this.ordenarAlunosPelaMatrículaToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.ordenarAlunosPelaMatrículaToolStripMenuItem.Text = "Ordenar alunos pela matrícula";
            // 
            // gravarAlunosNoSistemaToolStripMenuItem
            // 
            this.gravarAlunosNoSistemaToolStripMenuItem.Name = "gravarAlunosNoSistemaToolStripMenuItem";
            this.gravarAlunosNoSistemaToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.gravarAlunosNoSistemaToolStripMenuItem.Text = "Gravar alunos no sistema";
            // 
            // carregarDadosToolStripMenuItem
            // 
            this.carregarDadosToolStripMenuItem.Name = "carregarDadosToolStripMenuItem";
            this.carregarDadosToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.carregarDadosToolStripMenuItem.Text = "Carregar dados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            btnArquivo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1286, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnlBOTOESPRINCIPAIS
            // 
            this.pnlBOTOESPRINCIPAIS.Controls.Add(this.btnEXIBIR);
            this.pnlBOTOESPRINCIPAIS.Controls.Add(this.btnPESQUISAR);
            this.pnlBOTOESPRINCIPAIS.Controls.Add(this.btnEXCLUIR);
            this.pnlBOTOESPRINCIPAIS.Controls.Add(this.btnALTERAR);
            this.pnlBOTOESPRINCIPAIS.Controls.Add(this.btnINSERIR);
            this.pnlBOTOESPRINCIPAIS.Location = new System.Drawing.Point(12, 134);
            this.pnlBOTOESPRINCIPAIS.Name = "pnlBOTOESPRINCIPAIS";
            this.pnlBOTOESPRINCIPAIS.Size = new System.Drawing.Size(261, 287);
            this.pnlBOTOESPRINCIPAIS.TabIndex = 1;
            // 
            // btnEXIBIR
            // 
            this.btnEXIBIR.Location = new System.Drawing.Point(0, 65);
            this.btnEXIBIR.Name = "btnEXIBIR";
            this.btnEXIBIR.Size = new System.Drawing.Size(254, 48);
            this.btnEXIBIR.TabIndex = 5;
            this.btnEXIBIR.Text = "Exibir alunos cadastrados ";
            this.btnEXIBIR.UseVisualStyleBackColor = true;
            // 
            // btnPESQUISAR
            // 
            this.btnPESQUISAR.Location = new System.Drawing.Point(0, 173);
            this.btnPESQUISAR.Name = "btnPESQUISAR";
            this.btnPESQUISAR.Size = new System.Drawing.Size(254, 48);
            this.btnPESQUISAR.TabIndex = 3;
            this.btnPESQUISAR.Text = "Pesquisar aluno";
            this.btnPESQUISAR.UseVisualStyleBackColor = true;
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Location = new System.Drawing.Point(0, 227);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(254, 48);
            this.btnEXCLUIR.TabIndex = 2;
            this.btnEXCLUIR.Text = "Excluir aluno";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Location = new System.Drawing.Point(0, 119);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(254, 48);
            this.btnALTERAR.TabIndex = 1;
            this.btnALTERAR.Text = "Alterar dados do aluno";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            // 
            // btnINSERIR
            // 
            this.btnINSERIR.Location = new System.Drawing.Point(0, 11);
            this.btnINSERIR.Name = "btnINSERIR";
            this.btnINSERIR.Size = new System.Drawing.Size(254, 48);
            this.btnINSERIR.TabIndex = 0;
            this.btnINSERIR.Text = "Inserir aluno";
            this.btnINSERIR.UseVisualStyleBackColor = true;
            this.btnINSERIR.Click += new System.EventHandler(this.btnINSERIR_Click);
            // 
            // pnlINSERIR
            // 
            this.pnlINSERIR.AutoSize = true;
            this.pnlINSERIR.Controls.Add(this.mskTELEFONE);
            this.pnlINSERIR.Controls.Add(this.btnADDLIST);
            this.pnlINSERIR.Controls.Add(this.txtCÓDIGO);
            this.pnlINSERIR.Controls.Add(this.txtEMAIL);
            this.pnlINSERIR.Controls.Add(this.txtNOME);
            this.pnlINSERIR.Controls.Add(this.lblEMAIL);
            this.pnlINSERIR.Controls.Add(this.lblTELEFONE);
            this.pnlINSERIR.Controls.Add(this.lblCÓDIGO);
            this.pnlINSERIR.Controls.Add(this.lblNOME);
            this.pnlINSERIR.Location = new System.Drawing.Point(418, 45);
            this.pnlINSERIR.Name = "pnlINSERIR";
            this.pnlINSERIR.Size = new System.Drawing.Size(384, 522);
            this.pnlINSERIR.TabIndex = 2;
            this.pnlINSERIR.Visible = false;
            // 
            // mskTELEFONE
            // 
            this.mskTELEFONE.Location = new System.Drawing.Point(30, 263);
            this.mskTELEFONE.Mask = "(99) 00000-0000";
            this.mskTELEFONE.Name = "mskTELEFONE";
            this.mskTELEFONE.Size = new System.Drawing.Size(318, 22);
            this.mskTELEFONE.TabIndex = 6;
            this.mskTELEFONE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskTELEFONE_KeyDown);
            // 
            // btnADDLIST
            // 
            this.btnADDLIST.Location = new System.Drawing.Point(141, 461);
            this.btnADDLIST.Name = "btnADDLIST";
            this.btnADDLIST.Size = new System.Drawing.Size(97, 55);
            this.btnADDLIST.TabIndex = 8;
            this.btnADDLIST.Text = "Salvar ";
            this.btnADDLIST.UseVisualStyleBackColor = true;
            this.btnADDLIST.Click += new System.EventHandler(this.btnADDLIST_Click);
            // 
            // txtCÓDIGO
            // 
            this.txtCÓDIGO.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCÓDIGO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCÓDIGO.Location = new System.Drawing.Point(30, 184);
            this.txtCÓDIGO.Name = "txtCÓDIGO";
            this.txtCÓDIGO.ReadOnly = true;
            this.txtCÓDIGO.Size = new System.Drawing.Size(318, 22);
            this.txtCÓDIGO.TabIndex = 0;
            this.txtCÓDIGO.Click += new System.EventHandler(this.btnINSERIR_Click);
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(30, 338);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(318, 22);
            this.txtEMAIL.TabIndex = 7;
            this.txtEMAIL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEMAIL_KeyDown);
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(30, 107);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(318, 22);
            this.txtNOME.TabIndex = 5;
            this.txtNOME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNOME_KeyDown);
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.AutoSize = true;
            this.lblEMAIL.Location = new System.Drawing.Point(164, 302);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(51, 17);
            this.lblEMAIL.TabIndex = 3;
            this.lblEMAIL.Text = "E-mail:";
            // 
            // lblTELEFONE
            // 
            this.lblTELEFONE.AutoSize = true;
            this.lblTELEFONE.Location = new System.Drawing.Point(132, 225);
            this.lblTELEFONE.Name = "lblTELEFONE";
            this.lblTELEFONE.Size = new System.Drawing.Size(114, 17);
            this.lblTELEFONE.TabIndex = 2;
            this.lblTELEFONE.Text = "Telefone celular:";
            // 
            // lblCÓDIGO
            // 
            this.lblCÓDIGO.AutoSize = true;
            this.lblCÓDIGO.Location = new System.Drawing.Point(132, 148);
            this.lblCÓDIGO.Name = "lblCÓDIGO";
            this.lblCÓDIGO.Size = new System.Drawing.Size(115, 17);
            this.lblCÓDIGO.TabIndex = 1;
            this.lblCÓDIGO.Text = "Código do aluno:";
            // 
            // lblNOME
            // 
            this.lblNOME.AutoSize = true;
            this.lblNOME.Location = new System.Drawing.Point(133, 71);
            this.lblNOME.Name = "lblNOME";
            this.lblNOME.Size = new System.Drawing.Size(112, 17);
            this.lblNOME.TabIndex = 0;
            this.lblNOME.Text = "Nome do aluno: ";
            // 
            // FormHOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 618);
            this.Controls.Add(this.pnlINSERIR);
            this.Controls.Add(this.pnlBOTOESPRINCIPAIS);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormHOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscolaPlus";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlBOTOESPRINCIPAIS.ResumeLayout(false);
            this.pnlINSERIR.ResumeLayout(false);
            this.pnlINSERIR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pnlINSERIR;
        public System.Windows.Forms.TextBox txtEMAIL;
        public System.Windows.Forms.MaskedTextBox mskTELEFONE;
        public System.Windows.Forms.TextBox txtCÓDIGO;
        public System.Windows.Forms.TextBox txtNOME;
        public System.Windows.Forms.Button btnINSERIR;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.Panel pnlBOTOESPRINCIPAIS;
        public System.Windows.Forms.Button btnEXIBIR;
        public System.Windows.Forms.Button btnPESQUISAR;
        public System.Windows.Forms.Button btnEXCLUIR;
        public System.Windows.Forms.Button btnALTERAR;
        public System.Windows.Forms.ToolStripMenuItem ordenarAlunosPelaMatrículaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gravarAlunosNoSistemaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem carregarDadosToolStripMenuItem;
        public System.Windows.Forms.Label lblEMAIL;
        public System.Windows.Forms.Label lblTELEFONE;
        public System.Windows.Forms.Label lblCÓDIGO;
        public System.Windows.Forms.Label lblNOME;
        public System.Windows.Forms.Button btnADDLIST;
    }
}

