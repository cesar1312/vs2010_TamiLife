namespace Neonatal_SanBartolome
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnBuscarMuestra = new System.Windows.Forms.Button();
            this.btnResultadosHospital = new System.Windows.Forms.Button();
            this.btnRecepcion = new System.Windows.Forms.Button();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(210, 745);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnBuscarMuestra
            // 
            this.btnBuscarMuestra.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnBuscarMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMuestra.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMuestra.Location = new System.Drawing.Point(4, 304);
            this.btnBuscarMuestra.Name = "btnBuscarMuestra";
            this.btnBuscarMuestra.Size = new System.Drawing.Size(200, 60);
            this.btnBuscarMuestra.TabIndex = 11;
            this.btnBuscarMuestra.Text = "BUSQUEDA  MUESTRA";
            this.btnBuscarMuestra.UseVisualStyleBackColor = false;
            this.btnBuscarMuestra.Click += new System.EventHandler(this.btnBuscarMuestra_Click);
            // 
            // btnResultadosHospital
            // 
            this.btnResultadosHospital.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnResultadosHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultadosHospital.ForeColor = System.Drawing.Color.White;
            this.btnResultadosHospital.Location = new System.Drawing.Point(4, 238);
            this.btnResultadosHospital.Name = "btnResultadosHospital";
            this.btnResultadosHospital.Size = new System.Drawing.Size(200, 60);
            this.btnResultadosHospital.TabIndex = 10;
            this.btnResultadosHospital.Text = "RESULTADOS HOSPITAL";
            this.btnResultadosHospital.UseVisualStyleBackColor = false;
            this.btnResultadosHospital.Click += new System.EventHandler(this.btnResultadosHospital_Click);
            // 
            // btnRecepcion
            // 
            this.btnRecepcion.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepcion.ForeColor = System.Drawing.Color.White;
            this.btnRecepcion.Location = new System.Drawing.Point(4, 172);
            this.btnRecepcion.Name = "btnRecepcion";
            this.btnRecepcion.Size = new System.Drawing.Size(200, 60);
            this.btnRecepcion.TabIndex = 9;
            this.btnRecepcion.Text = "ADMINISTRAR RECEPCIONES";
            this.btnRecepcion.UseVisualStyleBackColor = false;
            this.btnRecepcion.Click += new System.EventHandler(this.btnRecepcion_Click);
            // 
            // btnEnvios
            // 
            this.btnEnvios.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvios.ForeColor = System.Drawing.Color.White;
            this.btnEnvios.Location = new System.Drawing.Point(4, 106);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(200, 60);
            this.btnEnvios.TabIndex = 8;
            this.btnEnvios.Text = "ADMINISTRAR ENVIOS";
            this.btnEnvios.UseVisualStyleBackColor = false;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Neonatal_SanBartolome.Properties.Resources.LogoCiansaTiny;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 745);
            this.Controls.Add(this.btnEnvios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscarMuestra);
            this.Controls.Add(this.btnResultadosHospital);
            this.Controls.Add(this.btnRecepcion);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnBuscarMuestra;
        private System.Windows.Forms.Button btnResultadosHospital;
        private System.Windows.Forms.Button btnRecepcion;
        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}