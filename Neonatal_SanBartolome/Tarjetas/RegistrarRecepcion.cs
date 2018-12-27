using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BC;
using BE;

namespace Neonatal_SanBartolome.Tarjetas
{
    public partial class RegistrarRecepcion : Form
    {
        HospitalBC hospitalBC = new HospitalBC();
        //ParametroGeneralBC parametroGeneralBC = new ParametroGeneralBC();
        //FuncionesGenerales fg = new FuncionesGenerales();
        RecepcionBC recepcionBC = new RecepcionBC();
        TarjetaBC tarjetaBC = new TarjetaBC();

        public RegistrarRecepcion()
        {
            InitializeComponent();
            cmbHospitales.DataSource = hospitalBC.ListaHospitales();
            cmbHospitales.DisplayMember = "cntFacility";
            cmbHospitales.ValueMember = "ContactId";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
