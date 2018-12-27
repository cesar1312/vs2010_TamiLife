namespace Neonatal_SanBartolome
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestrasHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMuestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarResultadoTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioTarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionTarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestrasToolStripMenuItem,
            this.resultadosToolStripMenuItem,
            this.tarjetasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muestrasToolStripMenuItem
            // 
            this.muestrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muestrasHospitalToolStripMenuItem,
            this.buscarMuestraToolStripMenuItem});
            this.muestrasToolStripMenuItem.Name = "muestrasToolStripMenuItem";
            this.muestrasToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.muestrasToolStripMenuItem.Text = "Muestras";
            // 
            // muestrasHospitalToolStripMenuItem
            // 
            this.muestrasHospitalToolStripMenuItem.Name = "muestrasHospitalToolStripMenuItem";
            this.muestrasHospitalToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.muestrasHospitalToolStripMenuItem.Text = "Muestras_Hospital";
            this.muestrasHospitalToolStripMenuItem.Click += new System.EventHandler(this.muestrasHospitalToolStripMenuItem_Click);
            // 
            // buscarMuestraToolStripMenuItem
            // 
            this.buscarMuestraToolStripMenuItem.Name = "buscarMuestraToolStripMenuItem";
            this.buscarMuestraToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.buscarMuestraToolStripMenuItem.Text = "Buscar_Muestra";
            this.buscarMuestraToolStripMenuItem.Click += new System.EventHandler(this.buscarMuestraToolStripMenuItem_Click);
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarResultadosToolStripMenuItem,
            this.buscarResultadoTarjetaToolStripMenuItem});
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.resultadosToolStripMenuItem.Text = "Resultados";
            // 
            // consultarResultadosToolStripMenuItem
            // 
            this.consultarResultadosToolStripMenuItem.Name = "consultarResultadosToolStripMenuItem";
            this.consultarResultadosToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.consultarResultadosToolStripMenuItem.Text = "Consultar Resultados";
            this.consultarResultadosToolStripMenuItem.Click += new System.EventHandler(this.consultarResultadosToolStripMenuItem_Click);
            // 
            // buscarResultadoTarjetaToolStripMenuItem
            // 
            this.buscarResultadoTarjetaToolStripMenuItem.Name = "buscarResultadoTarjetaToolStripMenuItem";
            this.buscarResultadoTarjetaToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.buscarResultadoTarjetaToolStripMenuItem.Text = "Buscar_Resultado_Tarjeta";
            this.buscarResultadoTarjetaToolStripMenuItem.Click += new System.EventHandler(this.buscarResultadoTarjetaToolStripMenuItem_Click);
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envioTarjetasToolStripMenuItem,
            this.recepcionTarjetasToolStripMenuItem});
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.tarjetasToolStripMenuItem.Text = "Tarjetas";
            // 
            // envioTarjetasToolStripMenuItem
            // 
            this.envioTarjetasToolStripMenuItem.Name = "envioTarjetasToolStripMenuItem";
            this.envioTarjetasToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.envioTarjetasToolStripMenuItem.Text = "Envio";
            this.envioTarjetasToolStripMenuItem.Click += new System.EventHandler(this.envioTarjetasToolStripMenuItem_Click);
            // 
            // recepcionTarjetasToolStripMenuItem
            // 
            this.recepcionTarjetasToolStripMenuItem.Name = "recepcionTarjetasToolStripMenuItem";
            this.recepcionTarjetasToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.recepcionTarjetasToolStripMenuItem.Text = "Recepcion";
            this.recepcionTarjetasToolStripMenuItem.Click += new System.EventHandler(this.recepcionTarjetasToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 560);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "TamiSoft Ciansa";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestrasHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioTarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionTarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMuestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarResultadoTarjetaToolStripMenuItem;
    }
}

