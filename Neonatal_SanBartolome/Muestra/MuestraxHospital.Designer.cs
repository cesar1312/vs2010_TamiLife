namespace Neonatal_SanBartolome.Muestra
{
    partial class MuestraxHospital
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTipoResultados = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbHospitales = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMeses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnho = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreNeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoNeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concentracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAceptacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Establecimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historiaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaToma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadGestacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnExcel);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResultados);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 646);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTipoResultados);
            this.groupBox4.Location = new System.Drawing.Point(525, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 62);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo Resultados";
            this.groupBox4.Visible = false;
            // 
            // cmbTipoResultados
            // 
            this.cmbTipoResultados.AccessibleName = "";
            this.cmbTipoResultados.FormattingEnabled = true;
            this.cmbTipoResultados.Location = new System.Drawing.Point(10, 25);
            this.cmbTipoResultados.Name = "cmbTipoResultados";
            this.cmbTipoResultados.Size = new System.Drawing.Size(150, 28);
            this.cmbTipoResultados.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPrueba);
            this.groupBox3.Location = new System.Drawing.Point(378, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 62);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prueba";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.FormattingEnabled = true;
            this.cmbPrueba.Location = new System.Drawing.Point(10, 25);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(120, 28);
            this.cmbPrueba.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbHospitales);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 62);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hospital";
            // 
            // cmbHospitales
            // 
            this.cmbHospitales.FormattingEnabled = true;
            this.cmbHospitales.Location = new System.Drawing.Point(10, 25);
            this.cmbHospitales.Name = "cmbHospitales";
            this.cmbHospitales.Size = new System.Drawing.Size(662, 28);
            this.cmbHospitales.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMeses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbAnho);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha Resultado";
            // 
            // cmbMeses
            // 
            this.cmbMeses.FormattingEnabled = true;
            this.cmbMeses.Location = new System.Drawing.Point(56, 25);
            this.cmbMeses.Name = "cmbMeses";
            this.cmbMeses.Size = new System.Drawing.Size(120, 28);
            this.cmbMeses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mes:";
            // 
            // cmbAnho
            // 
            this.cmbAnho.FormattingEnabled = true;
            this.cmbAnho.Location = new System.Drawing.Point(248, 25);
            this.cmbAnho.Name = "cmbAnho";
            this.cmbAnho.Size = new System.Drawing.Size(100, 28);
            this.cmbAnho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año:";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(700, 78);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 38);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(700, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fila,
            this.CodigoMuestra,
            this.NombreNeonato,
            this.ApellidoNeonato,
            this.Prueba,
            this.Concentracion,
            this.Unidad,
            this.FechaResultado,
            this.FechaAceptacion,
            this.Establecimiento,
            this.Sexo,
            this.historiaClinica,
            this.FechaNacimiento,
            this.FechaToma,
            this.EdadGestacional,
            this.ResultCode});
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(0, 0);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(1000, 490);
            this.dgvResultados.TabIndex = 0;
            // 
            // Fila
            // 
            this.Fila.DataPropertyName = "Fila";
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            // 
            // CodigoMuestra
            // 
            this.CodigoMuestra.DataPropertyName = "CodigoMuestra";
            this.CodigoMuestra.HeaderText = "Codigo Muestra";
            this.CodigoMuestra.Name = "CodigoMuestra";
            this.CodigoMuestra.ReadOnly = true;
            // 
            // NombreNeonato
            // 
            this.NombreNeonato.DataPropertyName = "NombreNeonato";
            this.NombreNeonato.HeaderText = "Nombres";
            this.NombreNeonato.Name = "NombreNeonato";
            this.NombreNeonato.ReadOnly = true;
            // 
            // ApellidoNeonato
            // 
            this.ApellidoNeonato.DataPropertyName = "ApellidosNeonato";
            this.ApellidoNeonato.HeaderText = "Apellidos";
            this.ApellidoNeonato.Name = "ApellidoNeonato";
            this.ApellidoNeonato.ReadOnly = true;
            // 
            // Prueba
            // 
            this.Prueba.DataPropertyName = "Prueba";
            this.Prueba.HeaderText = "Prueba";
            this.Prueba.Name = "Prueba";
            this.Prueba.ReadOnly = true;
            // 
            // Concentracion
            // 
            this.Concentracion.DataPropertyName = "Concentracion";
            this.Concentracion.HeaderText = "Conc";
            this.Concentracion.Name = "Concentracion";
            this.Concentracion.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "Unidad";
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // FechaResultado
            // 
            this.FechaResultado.DataPropertyName = "FechaResultado";
            dataGridViewCellStyle9.Format = "g";
            dataGridViewCellStyle9.NullValue = null;
            this.FechaResultado.DefaultCellStyle = dataGridViewCellStyle9;
            this.FechaResultado.HeaderText = "Fecha Resultado";
            this.FechaResultado.Name = "FechaResultado";
            this.FechaResultado.ReadOnly = true;
            // 
            // FechaAceptacion
            // 
            this.FechaAceptacion.DataPropertyName = "FechaAceptacion";
            dataGridViewCellStyle10.Format = "g";
            dataGridViewCellStyle10.NullValue = null;
            this.FechaAceptacion.DefaultCellStyle = dataGridViewCellStyle10;
            this.FechaAceptacion.HeaderText = "Fecha Aceptacion";
            this.FechaAceptacion.Name = "FechaAceptacion";
            this.FechaAceptacion.ReadOnly = true;
            // 
            // Establecimiento
            // 
            this.Establecimiento.DataPropertyName = "Establecimiento";
            this.Establecimiento.HeaderText = "Hospital";
            this.Establecimiento.Name = "Establecimiento";
            this.Establecimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // historiaClinica
            // 
            this.historiaClinica.DataPropertyName = "historiaClinica";
            this.historiaClinica.HeaderText = "H. Clinica";
            this.historiaClinica.Name = "historiaClinica";
            this.historiaClinica.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "fechaNacimiento";
            dataGridViewCellStyle11.Format = "d";
            this.FechaNacimiento.DefaultCellStyle = dataGridViewCellStyle11;
            this.FechaNacimiento.HeaderText = "Fecha Nac.";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // FechaToma
            // 
            this.FechaToma.DataPropertyName = "fechaToma";
            dataGridViewCellStyle12.Format = "d";
            this.FechaToma.DefaultCellStyle = dataGridViewCellStyle12;
            this.FechaToma.HeaderText = "Fecha Toma";
            this.FechaToma.Name = "FechaToma";
            this.FechaToma.ReadOnly = true;
            // 
            // EdadGestacional
            // 
            this.EdadGestacional.DataPropertyName = "EdadGestacional";
            this.EdadGestacional.HeaderText = "Edad Ges.";
            this.EdadGestacional.Name = "EdadGestacional";
            this.EdadGestacional.ReadOnly = true;
            // 
            // ResultCode
            // 
            this.ResultCode.DataPropertyName = "ResultCode";
            this.ResultCode.HeaderText = "ResultCode";
            this.ResultCode.Name = "ResultCode";
            this.ResultCode.ReadOnly = true;
            // 
            // MuestraxHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 646);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MuestraxHospital";
            this.Text = "MuestraxHospital";
            this.Load += new System.EventHandler(this.MuestraxHospital_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbAnho;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbTipoResultados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPrueba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbHospitales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreNeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoNeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concentracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAceptacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Establecimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn historiaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaToma;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadGestacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultCode;
    }
}