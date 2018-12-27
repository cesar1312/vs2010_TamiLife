namespace Neonatal_SanBartolome.Resultado
{
    partial class BuscarResultadoTarjeta
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCodigoMuestra = new System.Windows.Forms.TextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.NumEnsayo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concentracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAceptacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnExcel);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvResultados);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 504);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(444, 31);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 38);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(318, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 38);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCodigoMuestra);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 62);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Codigo de Muestra";
            // 
            // txtCodigoMuestra
            // 
            this.txtCodigoMuestra.Location = new System.Drawing.Point(6, 25);
            this.txtCodigoMuestra.Name = "txtCodigoMuestra";
            this.txtCodigoMuestra.Size = new System.Drawing.Size(280, 26);
            this.txtCodigoMuestra.TabIndex = 13;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumEnsayo,
            this.CodigoMuestra,
            this.Concentracion,
            this.Unidad,
            this.Prueba,
            this.ResultCode,
            this.FechaResultado,
            this.FechaAceptacion});
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(0, 0);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(1028, 413);
            this.dgvResultados.TabIndex = 1;
            // 
            // NumEnsayo
            // 
            this.NumEnsayo.DataPropertyName = "NumEnsayo";
            this.NumEnsayo.HeaderText = "ID";
            this.NumEnsayo.Name = "NumEnsayo";
            this.NumEnsayo.ReadOnly = true;
            // 
            // CodigoMuestra
            // 
            this.CodigoMuestra.DataPropertyName = "CodigoMuestra";
            this.CodigoMuestra.HeaderText = "Codigo Muestra";
            this.CodigoMuestra.Name = "CodigoMuestra";
            this.CodigoMuestra.ReadOnly = true;
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
            // Prueba
            // 
            this.Prueba.DataPropertyName = "Prueba";
            this.Prueba.HeaderText = "Prueba";
            this.Prueba.Name = "Prueba";
            this.Prueba.ReadOnly = true;
            // 
            // ResultCode
            // 
            this.ResultCode.DataPropertyName = "ResultCode";
            this.ResultCode.HeaderText = "ResultCode";
            this.ResultCode.Name = "ResultCode";
            this.ResultCode.ReadOnly = true;
            // 
            // FechaResultado
            // 
            this.FechaResultado.DataPropertyName = "FechaResultado";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaResultado.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaResultado.HeaderText = "Fecha Resultado";
            this.FechaResultado.Name = "FechaResultado";
            this.FechaResultado.ReadOnly = true;
            // 
            // FechaAceptacion
            // 
            this.FechaAceptacion.DataPropertyName = "FechaAceptacion";
            dataGridViewCellStyle2.Format = "g";
            this.FechaAceptacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaAceptacion.HeaderText = "Fecha Aceptación";
            this.FechaAceptacion.Name = "FechaAceptacion";
            this.FechaAceptacion.ReadOnly = true;
            // 
            // BuscarResultadoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 504);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BuscarResultadoTarjeta";
            this.Text = "BuscarResultadoTarjeta";
            this.Load += new System.EventHandler(this.BuscarResultadoTarjeta_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCodigoMuestra;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEnsayo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concentracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAceptacion;
    }
}