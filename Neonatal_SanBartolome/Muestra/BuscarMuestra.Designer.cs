namespace Neonatal_SanBartolome.Muestra
{
    partial class BuscarMuestra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtApellidosNeonato = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHClinica = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNombresNeonato = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDNI_Madre = new System.Windows.Forms.TextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.CodigoMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreNeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoNeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.btnExcel);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResultados);
            this.splitContainer1.Size = new System.Drawing.Size(1456, 651);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtApellidosNeonato);
            this.groupBox3.Location = new System.Drawing.Point(12, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 62);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Apellidos Neonato";
            // 
            // txtApellidosNeonato
            // 
            this.txtApellidosNeonato.Location = new System.Drawing.Point(6, 25);
            this.txtApellidosNeonato.Name = "txtApellidosNeonato";
            this.txtApellidosNeonato.Size = new System.Drawing.Size(280, 26);
            this.txtApellidosNeonato.TabIndex = 13;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(468, 75);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 38);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(468, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 38);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHClinica);
            this.groupBox2.Location = new System.Drawing.Point(318, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 62);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "H. Clinica";
            // 
            // txtHClinica
            // 
            this.txtHClinica.Location = new System.Drawing.Point(6, 25);
            this.txtHClinica.Name = "txtHClinica";
            this.txtHClinica.Size = new System.Drawing.Size(120, 26);
            this.txtHClinica.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNombresNeonato);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 62);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nombres Neonato";
            // 
            // txtNombresNeonato
            // 
            this.txtNombresNeonato.Location = new System.Drawing.Point(6, 25);
            this.txtNombresNeonato.Name = "txtNombresNeonato";
            this.txtNombresNeonato.Size = new System.Drawing.Size(280, 26);
            this.txtNombresNeonato.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDNI_Madre);
            this.groupBox1.Location = new System.Drawing.Point(318, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 62);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DNI Madre";
            // 
            // txtDNI_Madre
            // 
            this.txtDNI_Madre.Location = new System.Drawing.Point(6, 25);
            this.txtDNI_Madre.MaxLength = 8;
            this.txtDNI_Madre.Name = "txtDNI_Madre";
            this.txtDNI_Madre.Size = new System.Drawing.Size(120, 26);
            this.txtDNI_Madre.TabIndex = 0;
            this.txtDNI_Madre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_Madre_KeyPress);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMuestra,
            this.NombreNeonato,
            this.ApellidoNeonato,
            this.DNI,
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
            this.dgvResultados.Size = new System.Drawing.Size(1456, 498);
            this.dgvResultados.TabIndex = 1;
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
            this.NombreNeonato.Width = 160;
            // 
            // ApellidoNeonato
            // 
            this.ApellidoNeonato.DataPropertyName = "ApellidosNeonato";
            this.ApellidoNeonato.HeaderText = "Apellidos";
            this.ApellidoNeonato.Name = "ApellidoNeonato";
            this.ApellidoNeonato.ReadOnly = true;
            this.ApellidoNeonato.Width = 160;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI Madre";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 90;
            // 
            // Prueba
            // 
            this.Prueba.DataPropertyName = "Prueba";
            this.Prueba.HeaderText = "Prueba";
            this.Prueba.Name = "Prueba";
            this.Prueba.ReadOnly = true;
            this.Prueba.Width = 70;
            // 
            // Concentracion
            // 
            this.Concentracion.DataPropertyName = "Concentracion";
            this.Concentracion.HeaderText = "Conc";
            this.Concentracion.Name = "Concentracion";
            this.Concentracion.ReadOnly = true;
            this.Concentracion.Width = 60;
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaResultado.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaResultado.HeaderText = "Fecha Resultado";
            this.FechaResultado.Name = "FechaResultado";
            this.FechaResultado.ReadOnly = true;
            // 
            // FechaAceptacion
            // 
            this.FechaAceptacion.DataPropertyName = "FechaAceptacion";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaAceptacion.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.Sexo.Width = 50;
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
            dataGridViewCellStyle3.Format = "d";
            this.FechaNacimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // FechaToma
            // 
            this.FechaToma.DataPropertyName = "fechaToma";
            dataGridViewCellStyle4.Format = "d";
            this.FechaToma.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.EdadGestacional.Width = 60;
            // 
            // ResultCode
            // 
            this.ResultCode.DataPropertyName = "ResultCode";
            this.ResultCode.HeaderText = "ResultCode";
            this.ResultCode.Name = "ResultCode";
            this.ResultCode.ReadOnly = true;
            this.ResultCode.Width = 160;
            // 
            // BuscarMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 651);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BuscarMuestra";
            this.Text = "BuscarResultado";
            this.Load += new System.EventHandler(this.BuscarMuestra_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNombresNeonato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDNI_Madre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtApellidosNeonato;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtHClinica;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreNeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoNeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
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