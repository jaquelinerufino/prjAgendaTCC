namespace prjAgendaTCC
{
    partial class frmVistoria
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
            this.lblAdata = new System.Windows.Forms.Label();
            this.lblpessoa = new System.Windows.Forms.Label();
            this.cmbPessoa = new System.Windows.Forms.ComboBox();
            this.lblDataVistoria = new System.Windows.Forms.Label();
            this.mtxtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblPassou = new System.Windows.Forms.Label();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.mtxtHora = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataVis = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblAdata
            // 
            this.lblAdata.AutoSize = true;
            this.lblAdata.Location = new System.Drawing.Point(13, 9);
            this.lblAdata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdata.Name = "lblAdata";
            this.lblAdata.Size = new System.Drawing.Size(43, 16);
            this.lblAdata.TabIndex = 0;
            this.lblAdata.Text = "Data: ";
            // 
            // lblpessoa
            // 
            this.lblpessoa.AutoSize = true;
            this.lblpessoa.Location = new System.Drawing.Point(13, 77);
            this.lblpessoa.Name = "lblpessoa";
            this.lblpessoa.Size = new System.Drawing.Size(61, 16);
            this.lblpessoa.TabIndex = 2;
            this.lblpessoa.Text = "Pessoa: ";
            // 
            // cmbPessoa
            // 
            this.cmbPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPessoa.FormattingEnabled = true;
            this.cmbPessoa.Location = new System.Drawing.Point(140, 74);
            this.cmbPessoa.Name = "cmbPessoa";
            this.cmbPessoa.Size = new System.Drawing.Size(184, 24);
            this.cmbPessoa.TabIndex = 1;
            this.cmbPessoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPessoa_KeyPress);
            // 
            // lblDataVistoria
            // 
            this.lblDataVistoria.AutoSize = true;
            this.lblDataVistoria.Location = new System.Drawing.Point(13, 118);
            this.lblDataVistoria.Name = "lblDataVistoria";
            this.lblDataVistoria.Size = new System.Drawing.Size(117, 16);
            this.lblDataVistoria.TabIndex = 4;
            this.lblDataVistoria.Text = "Data Vencimento: ";
            this.lblDataVistoria.Visible = false;
            // 
            // mtxtDataVencimento
            // 
            this.mtxtDataVencimento.Location = new System.Drawing.Point(140, 115);
            this.mtxtDataVencimento.Mask = "00/00/0000";
            this.mtxtDataVencimento.Name = "mtxtDataVencimento";
            this.mtxtDataVencimento.Size = new System.Drawing.Size(70, 22);
            this.mtxtDataVencimento.TabIndex = 2;
            this.mtxtDataVencimento.ValidatingType = typeof(System.DateTime);
            this.mtxtDataVencimento.Visible = false;
            this.mtxtDataVencimento.TextChanged += new System.EventHandler(this.mtxtDataVistoria_TextChanged);
            this.mtxtDataVencimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtDataVencimento_KeyPress);
            // 
            // lblPassou
            // 
            this.lblPassou.AutoSize = true;
            this.lblPassou.Location = new System.Drawing.Point(13, 160);
            this.lblPassou.Name = "lblPassou";
            this.lblPassou.Size = new System.Drawing.Size(76, 16);
            this.lblPassou.TabIndex = 6;
            this.lblPassou.Text = "Habilitado: ";
            this.lblPassou.Visible = false;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Checked = true;
            this.rdbSim.Location = new System.Drawing.Point(140, 158);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(49, 20);
            this.rdbSim.TabIndex = 3;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.Visible = false;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(195, 158);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(52, 20);
            this.rdbNao.TabIndex = 4;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            this.rdbNao.Visible = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 203);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(143, 16);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição da Vistoria: ";
            this.lblDescricao.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 222);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(308, 186);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 414);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 30);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(195, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 30);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(13, 41);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 16);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Hora:";
            // 
            // mtxtHora
            // 
            this.mtxtHora.Location = new System.Drawing.Point(140, 38);
            this.mtxtHora.Mask = "00:00";
            this.mtxtHora.Name = "mtxtHora";
            this.mtxtHora.Size = new System.Drawing.Size(38, 22);
            this.mtxtHora.TabIndex = 0;
            this.mtxtHora.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtHora.ValidatingType = typeof(System.DateTime);
            this.mtxtHora.TextChanged += new System.EventHandler(this.mtxtHora_TextChanged);
            // 
            // mtxtDataVis
            // 
            this.mtxtDataVis.Location = new System.Drawing.Point(140, 6);
            this.mtxtDataVis.Mask = "00/00/0000";
            this.mtxtDataVis.Name = "mtxtDataVis";
            this.mtxtDataVis.Size = new System.Drawing.Size(70, 22);
            this.mtxtDataVis.TabIndex = 14;
            this.mtxtDataVis.ValidatingType = typeof(System.DateTime);
            this.mtxtDataVis.TextChanged += new System.EventHandler(this.mtxtDataVis_TextChanged);
            // 
            // frmVistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 453);
            this.ControlBox = false;
            this.Controls.Add(this.mtxtDataVis);
            this.Controls.Add(this.mtxtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.rdbNao);
            this.Controls.Add(this.rdbSim);
            this.Controls.Add(this.lblPassou);
            this.Controls.Add(this.mtxtDataVencimento);
            this.Controls.Add(this.lblDataVistoria);
            this.Controls.Add(this.cmbPessoa);
            this.Controls.Add(this.lblpessoa);
            this.Controls.Add(this.lblAdata);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Vistoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVistoria_FormClosing);
            this.Load += new System.EventHandler(this.frmVistoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdata;
        private System.Windows.Forms.Label lblpessoa;
        private System.Windows.Forms.ComboBox cmbPessoa;
        private System.Windows.Forms.Label lblPassou;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MaskedTextBox mtxtHora;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtxtDataVis;
        public System.Windows.Forms.Label lblDataVistoria;
        public System.Windows.Forms.MaskedTextBox mtxtDataVencimento;
    }
}