using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Neonatal_SanBartolome.Tarjetas;

namespace Neonatal_SanBartolome
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            AdministrarEnvios envio = new AdministrarEnvios();
            envio.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            envio.WindowState = FormWindowState.Maximized;
            envio.Show();
        }

        private void btnResultadosHospital_Click(object sender, EventArgs e)
        {
            Muestra.MuestraxHospital buscar = new Muestra.MuestraxHospital();
            buscar.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            buscar.WindowState = FormWindowState.Maximized;
            buscar.Show();
        }

        private void btnBuscarMuestra_Click(object sender, EventArgs e)
        {
            Muestra.BuscarMuestra buscar = new Muestra.BuscarMuestra();
            buscar.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            buscar.WindowState = FormWindowState.Maximized;
            buscar.Show();
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            AdministrarRecepciones recepcion = new AdministrarRecepciones();
            recepcion.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            recepcion.WindowState = FormWindowState.Maximized;
            recepcion.Show();
        }

        
    }
}
