namespace Neonatal_SanBartolome.Tarjetas
{
    partial class AdministrarRecepciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarRecepciones));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbAnho = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbHospitalesBuscar = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgvEnvios = new System.Windows.Forms.DataGridView();
            this.idEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Establecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslTitulo = new System.Windows.Forms.ToolStripLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbHospitales = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoInicial = new System.Windows.Forms.TextBox();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbGenerar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Rechazada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(1258, 745);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbMes);
            this.groupBox7.Location = new System.Drawing.Point(657, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(141, 62);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Mes";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(10, 25);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 28);
            this.cmbMes.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(844, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbAnho);
            this.groupBox6.Location = new System.Drawing.Point(510, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(141, 62);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Año";
            // 
            // cmbAnho
            // 
            this.cmbAnho.FormattingEnabled = true;
            this.cmbAnho.Location = new System.Drawing.Point(10, 25);
            this.cmbAnho.Name = "cmbAnho";
            this.cmbAnho.Size = new System.Drawing.Size(121, 28);
            this.cmbAnho.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbHospitalesBuscar);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(471, 62);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hospital";
            // 
            // cmbHospitalesBuscar
            // 
            this.cmbHospitalesBuscar.FormattingEnabled = true;
            this.cmbHospitalesBuscar.Location = new System.Drawing.Point(10, 25);
            this.cmbHospitalesBuscar.Name = "cmbHospitalesBuscar";
            this.cmbHospitalesBuscar.Size = new System.Drawing.Size(450, 28);
            this.cmbHospitalesBuscar.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 657);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(3, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgvEnvios);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(1255, 657);
            this.splitContainer3.SplitterDistance = 700;
            this.splitContainer3.TabIndex = 0;
            // 
            // dgvEnvios
            // 
            this.dgvEnvios.AllowUserToAddRows = false;
            this.dgvEnvios.AllowUserToDeleteRows = false;
            this.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEnvio,
            this.Establecimiento,
            this.FechaEnvio,
            this.CodigoInicial,
            this.CodigoFinal});
            this.dgvEnvios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnvios.Location = new System.Drawing.Point(0, 0);
            this.dgvEnvios.Name = "dgvEnvios";
            this.dgvEnvios.ReadOnly = true;
            this.dgvEnvios.RowTemplate.Height = 28;
            this.dgvEnvios.Size = new System.Drawing.Size(700, 657);
            this.dgvEnvios.TabIndex = 0;
            // 
            // idEnvio
            // 
            this.idEnvio.DataPropertyName = "idEnvio";
            this.idEnvio.HeaderText = "idEnvio";
            this.idEnvio.Name = "idEnvio";
            this.idEnvio.ReadOnly = true;
            // 
            // Establecimiento
            // 
            this.Establecimiento.DataPropertyName = "Establecimiento";
            this.Establecimiento.HeaderText = "Establecimiento";
            this.Establecimiento.Name = "Establecimiento";
            this.Establecimiento.ReadOnly = true;
            this.Establecimiento.Width = 450;
            // 
            // FechaEnvio
            // 
            this.FechaEnvio.DataPropertyName = "FechaEnvio";
            this.FechaEnvio.HeaderText = "Fecha Envio";
            this.FechaEnvio.Name = "FechaEnvio";
            this.FechaEnvio.ReadOnly = true;
            this.FechaEnvio.Width = 150;
            // 
            // CodigoInicial
            // 
            this.CodigoInicial.DataPropertyName = "CodigoInicial";
            this.CodigoInicial.HeaderText = "Codigo Inicial";
            this.CodigoInicial.Name = "CodigoInicial";
            this.CodigoInicial.ReadOnly = true;
            this.CodigoInicial.Width = 150;
            // 
            // CodigoFinal
            // 
            this.CodigoFinal.DataPropertyName = "CodigoFinal";
            this.CodigoFinal.HeaderText = "Codigo Final";
            this.CodigoFinal.Name = "CodigoFinal";
            this.CodigoFinal.ReadOnly = true;
            this.CodigoFinal.Width = 150;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvTarjetas);
            this.splitContainer2.Size = new System.Drawing.Size(551, 657);
            this.splitContainer2.SplitterDistance = 183;
            this.splitContainer2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTitulo,
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbGenerar,
            this.tsbGuardar,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(551, 40);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslTitulo
            // 
            this.tslTitulo.Name = "tslTitulo";
            this.tslTitulo.Size = new System.Drawing.Size(56, 37);
            this.tslTitulo.Text = "Titulo";
            this.tslTitulo.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbHospitales);
            this.groupBox2.Location = new System.Drawing.Point(6, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 62);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hospital";
            // 
            // cmbHospitales
            // 
            this.cmbHospitales.Enabled = false;
            this.cmbHospitales.FormattingEnabled = true;
            this.cmbHospitales.Location = new System.Drawing.Point(10, 25);
            this.cmbHospitales.Name = "cmbHospitales";
            this.cmbHospitales.Size = new System.Drawing.Size(450, 28);
            this.cmbHospitales.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpFechaEnvio);
            this.groupBox4.Location = new System.Drawing.Point(266, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 62);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fecha de Recepcion";
            // 
            // dtpFechaEnvio
            // 
            this.dtpFechaEnvio.Enabled = false;
            this.dtpFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEnvio.Location = new System.Drawing.Point(10, 25);
            this.dtpFechaEnvio.Name = "dtpFechaEnvio";
            this.dtpFechaEnvio.Size = new System.Drawing.Size(120, 26);
            this.dtpFechaEnvio.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoInicial);
            this.groupBox1.Location = new System.Drawing.Point(6, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 62);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codigo Inicial";
            // 
            // txtCodigoInicial
            // 
            this.txtCodigoInicial.Enabled = false;
            this.txtCodigoInicial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigoInicial.Location = new System.Drawing.Point(10, 25);
            this.txtCodigoInicial.MaxLength = 9;
            this.txtCodigoInicial.Name = "txtCodigoInicial";
            this.txtCodigoInicial.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoInicial.TabIndex = 0;
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fila,
            this.CodigoTarjeta,
            this.Recibida,
            this.Rechazada});
            this.dgvTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarjetas.Location = new System.Drawing.Point(0, 0);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.RowTemplate.Height = 28;
            this.dgvTarjetas.Size = new System.Drawing.Size(551, 470);
            this.dgvTarjetas.TabIndex = 1;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(36, 37);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.AutoSize = false;
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(40, 40);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbGenerar
            // 
            this.tsbGenerar.AutoSize = false;
            this.tsbGenerar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGenerar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerar.Image")));
            this.tsbGenerar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerar.Name = "tsbGenerar";
            this.tsbGenerar.Size = new System.Drawing.Size(40, 40);
            this.tsbGenerar.Text = "Generar";
            this.tsbGenerar.Visible = false;
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.AutoSize = false;
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(40, 40);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Visible = false;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.AutoSize = false;
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(40, 40);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Visible = false;
            // 
            // Fila
            // 
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            this.Fila.Width = 50;
            // 
            // CodigoTarjeta
            // 
            this.CodigoTarjeta.DataPropertyName = "CodigoMuestra";
            this.CodigoTarjeta.HeaderText = "Codigo Tarjeta";
            this.CodigoTarjeta.Name = "CodigoTarjeta";
            this.CodigoTarjeta.ReadOnly = true;
            this.CodigoTarjeta.Width = 150;
            // 
            // Recibida
            // 
            this.Recibida.DataPropertyName = "Recibido";
            this.Recibida.FalseValue = "false";
            this.Recibida.HeaderText = "Recibida";
            this.Recibida.Name = "Recibida";
            this.Recibida.ReadOnly = true;
            this.Recibida.TrueValue = "true";
            this.Recibida.Visible = false;
            this.Recibida.Width = 80;
            // 
            // Rechazada
            // 
            this.Rechazada.DataPropertyName = "Rechazado";
            this.Rechazada.FalseValue = "false";
            this.Rechazada.HeaderText = "Rechazada";
            this.Rechazada.Name = "Rechazada";
            this.Rechazada.ReadOnly = true;
            this.Rechazada.TrueValue = "true";
            // 
            // AdministrarRecepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 745);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdministrarRecepciones";
            this.Text = "Administrar Recepciones";
            this.Load += new System.EventHandler(this.AdministrarRecepciones_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbAnho;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbHospitalesBuscar;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvEnvios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Establecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFinal;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslTitulo;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbGenerar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbHospitales;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpFechaEnvio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoInicial;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTarjeta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recibida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rechazada;
    }
}