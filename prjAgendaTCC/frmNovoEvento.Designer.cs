namespace prjAgendaTCC
{
    partial class frmNovoEvento
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNumeroEvento = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblValorArrecadado = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.mtxtHoraInicial = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mtxtHoraFinal = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.mtxtInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFinal = new System.Windows.Forms.MaskedTextBox();
            this.grbAnimais = new System.Windows.Forms.GroupBox();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.lstAnimais = new System.Windows.Forms.ListBox();
            this.grbAnimais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(642, 453);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNumeroEvento
            // 
            this.lblNumeroEvento.AutoSize = true;
            this.lblNumeroEvento.Location = new System.Drawing.Point(13, 80);
            this.lblNumeroEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEvento.Name = "lblNumeroEvento";
            this.lblNumeroEvento.Size = new System.Drawing.Size(126, 16);
            this.lblNumeroEvento.TabIndex = 3;
            this.lblNumeroEvento.Text = "Número do Evento: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(13, 9);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 16);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data: ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 453);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 28);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblValorArrecadado
            // 
            this.lblValorArrecadado.AutoSize = true;
            this.lblValorArrecadado.Location = new System.Drawing.Point(13, 386);
            this.lblValorArrecadado.Name = "lblValorArrecadado";
            this.lblValorArrecadado.Size = new System.Drawing.Size(118, 16);
            this.lblValorArrecadado.TabIndex = 6;
            this.lblValorArrecadado.Text = "Valor Arrecadado:";
            this.lblValorArrecadado.Visible = false;
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Location = new System.Drawing.Point(146, 389);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(25, 16);
            this.lblRS.TabIndex = 7;
            this.lblRS.Text = "R$";
            this.lblRS.Visible = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(146, 80);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(56, 16);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Numero";
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(149, 120);
            this.cmbTipoEvento.MaxLength = 100;
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(223, 24);
            this.cmbTipoEvento.TabIndex = 5;
            this.cmbTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEvento_SelectedIndexChanged);
            this.cmbTipoEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoEvento_KeyPress);
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(13, 125);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(100, 16);
            this.lblTipoEvento.TabIndex = 11;
            this.lblTipoEvento.Text = "Tipo de Evento";
            // 
            // mtxtHoraInicial
            // 
            this.mtxtHoraInicial.Location = new System.Drawing.Point(538, 6);
            this.mtxtHoraInicial.Mask = "00:00";
            this.mtxtHoraInicial.Name = "mtxtHoraInicial";
            this.mtxtHoraInicial.ReadOnly = true;
            this.mtxtHoraInicial.Size = new System.Drawing.Size(38, 22);
            this.mtxtHoraInicial.TabIndex = 2;
            this.mtxtHoraInicial.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtHoraInicial.ValidatingType = typeof(System.DateTime);
            this.mtxtHoraInicial.TextChanged += new System.EventHandler(this.mtxtHoraInicial_TextChanged);
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(402, 9);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(75, 16);
            this.lblHoraInicio.TabIndex = 15;
            this.lblHoraInicio.Text = "Hora Inicio:";
            // 
            // btnExc
            // 
            this.btnExc.Enabled = false;
            this.btnExc.Location = new System.Drawing.Point(228, 150);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(56, 23);
            this.btnExc.TabIndex = 18;
            this.btnExc.TabStop = false;
            this.btnExc.Text = "Excluir";
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(149, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mtxtHoraFinal
            // 
            this.mtxtHoraFinal.Location = new System.Drawing.Point(538, 38);
            this.mtxtHoraFinal.Mask = "00:00";
            this.mtxtHoraFinal.Name = "mtxtHoraFinal";
            this.mtxtHoraFinal.ReadOnly = true;
            this.mtxtHoraFinal.Size = new System.Drawing.Size(38, 22);
            this.mtxtHoraFinal.TabIndex = 4;
            this.mtxtHoraFinal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtHoraFinal.ValidatingType = typeof(System.DateTime);
            this.mtxtHoraFinal.TextChanged += new System.EventHandler(this.mtxtHoraFinal_TextChanged);
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(402, 44);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(94, 16);
            this.lblHoraFinal.TabIndex = 20;
            this.lblHoraFinal.Text = "Hora Termino:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(114, 16);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome do evento: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(149, 41);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 193);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(139, 16);
            this.lblDescricao.TabIndex = 23;
            this.lblDescricao.Text = "Descrição do evento: ";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 219);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(356, 134);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(246, 9);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(27, 16);
            this.lblComplemento.TabIndex = 26;
            this.lblComplemento.Text = "até";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(177, 383);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(91, 22);
            this.txtValor.TabIndex = 10;
            this.txtValor.Visible = false;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // mtxtInicio
            // 
            this.mtxtInicio.Location = new System.Drawing.Point(149, 6);
            this.mtxtInicio.Mask = "00/00/0000";
            this.mtxtInicio.Name = "mtxtInicio";
            this.mtxtInicio.Size = new System.Drawing.Size(73, 22);
            this.mtxtInicio.TabIndex = 0;
            this.mtxtInicio.ValidatingType = typeof(System.DateTime);
            this.mtxtInicio.TextChanged += new System.EventHandler(this.mtxtInicio_TextChanged);
            // 
            // mtxtFinal
            // 
            this.mtxtFinal.Location = new System.Drawing.Point(299, 6);
            this.mtxtFinal.Mask = "00/00/0000";
            this.mtxtFinal.Name = "mtxtFinal";
            this.mtxtFinal.Size = new System.Drawing.Size(73, 22);
            this.mtxtFinal.TabIndex = 1;
            this.mtxtFinal.ValidatingType = typeof(System.DateTime);
            this.mtxtFinal.TextChanged += new System.EventHandler(this.mtxtFinal_TextChanged);
            // 
            // grbAnimais
            // 
            this.grbAnimais.Controls.Add(this.btnAnimais);
            this.grbAnimais.Controls.Add(this.lstAnimais);
            this.grbAnimais.Location = new System.Drawing.Point(405, 80);
            this.grbAnimais.Name = "grbAnimais";
            this.grbAnimais.Size = new System.Drawing.Size(361, 316);
            this.grbAnimais.TabIndex = 29;
            this.grbAnimais.TabStop = false;
            this.grbAnimais.Text = "Animais Participantes";
            // 
            // btnAnimais
            // 
            this.btnAnimais.Location = new System.Drawing.Point(19, 281);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(135, 28);
            this.btnAnimais.TabIndex = 9;
            this.btnAnimais.Text = "Editar Lista Animal";
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // lstAnimais
            // 
            this.lstAnimais.FormattingEnabled = true;
            this.lstAnimais.ItemHeight = 16;
            this.lstAnimais.Location = new System.Drawing.Point(19, 31);
            this.lstAnimais.Name = "lstAnimais";
            this.lstAnimais.Size = new System.Drawing.Size(321, 244);
            this.lstAnimais.TabIndex = 8;
            // 
            // frmNovoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 493);
            this.ControlBox = false;
            this.Controls.Add(this.grbAnimais);
            this.Controls.Add(this.mtxtFinal);
            this.Controls.Add(this.mtxtInicio);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mtxtHoraFinal);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mtxtHoraInicial);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.lblValorArrecadado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNumeroEvento);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Evento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNovoEvento_FormClosing);
            this.Load += new System.EventHandler(this.frmNovoEvento_Load);
            this.grbAnimais.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTipoEvento;
        public System.Windows.Forms.Label lblValorArrecadado;
        public System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblHoraInicio;
        public System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.MaskedTextBox mtxtHoraInicial;
        public System.Windows.Forms.MaskedTextBox mtxtHoraFinal;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.Label lblComplemento;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtxtInicio;
        private System.Windows.Forms.MaskedTextBox mtxtFinal;
        private System.Windows.Forms.GroupBox grbAnimais;
        private System.Windows.Forms.Button btnAnimais;
        public System.Windows.Forms.ListBox lstAnimais;
    }
}