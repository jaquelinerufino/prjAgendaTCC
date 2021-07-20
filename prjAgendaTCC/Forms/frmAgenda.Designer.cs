namespace prjAgendaTCC
{
    partial class frmAgenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblEventos = new System.Windows.Forms.Label();
            this.rdbEvento = new System.Windows.Forms.RadioButton();
            this.rdbVistoria = new System.Windows.Forms.RadioButton();
            this.grbEscolhas = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblEventoRelacionado = new System.Windows.Forms.Label();
            this.btnNovaRelacao = new System.Windows.Forms.Button();
            this.dgvListas = new System.Windows.Forms.DataGridView();
            this.gtcDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnimais = new System.Windows.Forms.DataGridView();
            this.dgcNomeAnimais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCodigoAnimais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovoEvento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbEscolhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 87);
            this.monthCalendar1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 15;
            this.monthCalendar1.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Location = new System.Drawing.Point(15, 65);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(89, 13);
            this.lblEventos.TabIndex = 3;
            this.lblEventos.Text = "Lista de Eventos:";
            // 
            // rdbEvento
            // 
            this.rdbEvento.AutoSize = true;
            this.rdbEvento.Location = new System.Drawing.Point(6, 19);
            this.rdbEvento.Name = "rdbEvento";
            this.rdbEvento.Size = new System.Drawing.Size(59, 17);
            this.rdbEvento.TabIndex = 0;
            this.rdbEvento.TabStop = true;
            this.rdbEvento.Text = "Evento";
            this.rdbEvento.UseVisualStyleBackColor = true;
            this.rdbEvento.CheckedChanged += new System.EventHandler(this.rdbEvento_CheckedChanged);
            // 
            // rdbVistoria
            // 
            this.rdbVistoria.AutoSize = true;
            this.rdbVistoria.Location = new System.Drawing.Point(71, 20);
            this.rdbVistoria.Name = "rdbVistoria";
            this.rdbVistoria.Size = new System.Drawing.Size(59, 17);
            this.rdbVistoria.TabIndex = 1;
            this.rdbVistoria.TabStop = true;
            this.rdbVistoria.Text = "Vistoria";
            this.rdbVistoria.UseVisualStyleBackColor = true;
            this.rdbVistoria.CheckedChanged += new System.EventHandler(this.rdbVistoria_CheckedChanged);
            // 
            // grbEscolhas
            // 
            this.grbEscolhas.Controls.Add(this.rdbVistoria);
            this.grbEscolhas.Controls.Add(this.rdbEvento);
            this.grbEscolhas.Location = new System.Drawing.Point(18, 12);
            this.grbEscolhas.Name = "grbEscolhas";
            this.grbEscolhas.Size = new System.Drawing.Size(690, 42);
            this.grbEscolhas.TabIndex = 100;
            this.grbEscolhas.TabStop = false;
            this.grbEscolhas.Text = "Escolha um tipo:";
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(230, 362);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 29);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(320, 362);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(84, 29);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblEventoRelacionado
            // 
            this.lblEventoRelacionado.AutoSize = true;
            this.lblEventoRelacionado.Location = new System.Drawing.Point(418, 65);
            this.lblEventoRelacionado.Name = "lblEventoRelacionado";
            this.lblEventoRelacionado.Size = new System.Drawing.Size(273, 13);
            this.lblEventoRelacionado.TabIndex = 13;
            this.lblEventoRelacionado.Text = "Lista de animais participantes deste evento selecionado:";
            // 
            // btnNovaRelacao
            // 
            this.btnNovaRelacao.Enabled = false;
            this.btnNovaRelacao.Location = new System.Drawing.Point(566, 362);
            this.btnNovaRelacao.Name = "btnNovaRelacao";
            this.btnNovaRelacao.Size = new System.Drawing.Size(142, 29);
            this.btnNovaRelacao.TabIndex = 14;
            this.btnNovaRelacao.TabStop = false;
            this.btnNovaRelacao.Text = "&Editar Relação";
            this.btnNovaRelacao.UseVisualStyleBackColor = true;
            this.btnNovaRelacao.Click += new System.EventHandler(this.btnNovaRelacao_Click);
            // 
            // dgvListas
            // 
            this.dgvListas.AllowUserToAddRows = false;
            this.dgvListas.AllowUserToDeleteRows = false;
            this.dgvListas.AllowUserToResizeColumns = false;
            this.dgvListas.AllowUserToResizeRows = false;
            this.dgvListas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListas.ColumnHeadersHeight = 40;
            this.dgvListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gtcDataInicio,
            this.dgcDataFinal,
            this.dgcTitulo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListas.Location = new System.Drawing.Point(18, 86);
            this.dgvListas.MultiSelect = false;
            this.dgvListas.Name = "dgvListas";
            this.dgvListas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListas.RowHeadersVisible = false;
            this.dgvListas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListas.Size = new System.Drawing.Size(386, 238);
            this.dgvListas.TabIndex = 1;
            this.dgvListas.SelectionChanged += new System.EventHandler(this.dgvListas_SelectionChanged);
            this.dgvListas.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvListas_Paint);
            // 
            // gtcDataInicio
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.gtcDataInicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.gtcDataInicio.HeaderText = "Data de Início";
            this.gtcDataInicio.Name = "gtcDataInicio";
            this.gtcDataInicio.ReadOnly = true;
            this.gtcDataInicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gtcDataInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgcDataFinal
            // 
            this.dgcDataFinal.HeaderText = "Data de Termino";
            this.dgcDataFinal.Name = "dgcDataFinal";
            this.dgcDataFinal.ReadOnly = true;
            this.dgcDataFinal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcDataFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgcTitulo
            // 
            this.dgcTitulo.HeaderText = "Titulo do Evento";
            this.dgcTitulo.Name = "dgcTitulo";
            this.dgcTitulo.ReadOnly = true;
            this.dgcTitulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcTitulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcTitulo.Width = 183;
            // 
            // dgvAnimais
            // 
            this.dgvAnimais.AllowUserToAddRows = false;
            this.dgvAnimais.AllowUserToDeleteRows = false;
            this.dgvAnimais.AllowUserToResizeColumns = false;
            this.dgvAnimais.AllowUserToResizeRows = false;
            this.dgvAnimais.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnimais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAnimais.ColumnHeadersHeight = 40;
            this.dgvAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAnimais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcNomeAnimais,
            this.dgcCodigoAnimais});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnimais.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAnimais.Location = new System.Drawing.Point(421, 86);
            this.dgvAnimais.Name = "dgvAnimais";
            this.dgvAnimais.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnimais.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAnimais.RowHeadersVisible = false;
            this.dgvAnimais.Size = new System.Drawing.Size(287, 238);
            this.dgvAnimais.TabIndex = 16;
            this.dgvAnimais.TabStop = false;
            this.dgvAnimais.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvAnimais_Paint);
            // 
            // dgcNomeAnimais
            // 
            this.dgcNomeAnimais.HeaderText = "Código dos Animais";
            this.dgcNomeAnimais.Name = "dgcNomeAnimais";
            this.dgcNomeAnimais.ReadOnly = true;
            this.dgcNomeAnimais.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcNomeAnimais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgcCodigoAnimais
            // 
            this.dgcCodigoAnimais.HeaderText = "Nome dos Animais";
            this.dgcCodigoAnimais.Name = "dgcCodigoAnimais";
            this.dgcCodigoAnimais.ReadOnly = true;
            this.dgcCodigoAnimais.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcCodigoAnimais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcCodigoAnimais.Width = 183;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(624, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 29);
            this.btnCancelar.TabIndex = 101;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnNovoEvento
            // 
            this.btnNovoEvento.Location = new System.Drawing.Point(18, 362);
            this.btnNovoEvento.Name = "btnNovoEvento";
            this.btnNovoEvento.Size = new System.Drawing.Size(84, 29);
            this.btnNovoEvento.TabIndex = 102;
            this.btnNovoEvento.Text = "Novo Evento";
            this.btnNovoEvento.UseVisualStyleBackColor = true;
            this.btnNovoEvento.Click += new System.EventHandler(this.btnNovoEvento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = " - Eventos/Vistorias prontos para atualização.";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 447);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovoEvento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvAnimais);
            this.Controls.Add(this.dgvListas);
            this.Controls.Add(this.btnNovaRelacao);
            this.Controls.Add(this.lblEventoRelacionado);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.grbEscolhas);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblEventos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Mapan";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.grbEscolhas.ResumeLayout(false);
            this.grbEscolhas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.RadioButton rdbEvento;
        public System.Windows.Forms.RadioButton rdbVistoria;
        public System.Windows.Forms.GroupBox grbEscolhas;
        private System.Windows.Forms.Label lblEventoRelacionado;
        private System.Windows.Forms.Button btnNovaRelacao;
        public System.Windows.Forms.DataGridView dgvListas;
        public System.Windows.Forms.DataGridView dgvAnimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtcDataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNomeAnimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCodigoAnimais;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovoEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}