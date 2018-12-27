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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void muestrasHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muestra.MuestraxHospital buscar = new Muestra.MuestraxHospital();
            buscar.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            buscar.WindowState = FormWindowState.Maximized;
            buscar.Show();
        }

        private void consultarResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultado.ConsultarResultados buscar = new Resultado.ConsultarResultados();
            buscar.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            buscar.WindowState = FormWindowState.Maximized;
            buscar.Show();
        }

        private void envioTarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarEnvios envio = new AdministrarEnvios();
            envio.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            envio.WindowState = FormWindowState.Maximized;
            envio.Show();
        }

        private void buscarMuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muestra.BuscarMuestra buscar = new Muestra.BuscarMuestra();
            buscar.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            buscar.WindowState = FormWindowState.Maximized;
            buscar.Show();
        }

        private void buscarResultadoTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultado.BuscarResultadoTarjeta buscar = new Resultado.BuscarResultadoTarjeta();
            buscar.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            buscar.WindowState = FormWindowState.Maximized;
            buscar.Show();
        }

        private void recepcionTarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecepcionTarjetas recepcion = new RecepcionTarjetas();
            recepcion.MdiParent = this;
            //this.WindowState = FormWindowState.Maximized;
            recepcion.WindowState = FormWindowState.Maximized;
            recepcion.Show();
        }

      
        
    }
}
