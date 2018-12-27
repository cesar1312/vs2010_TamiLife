using System;
using System.Windows.Forms;
using BC;
using BE;

namespace Neonatal_SanBartolome.Tarjetas
{
    public partial class RecepcionTarjetas : Form
    {
        HospitalBC hospitalBC = new HospitalBC();
        RecepcionBC recepcionBC = new RecepcionBC();
        ParametroGeneralBC parametroGeneralBC = new ParametroGeneralBC();
        FuncionesGenerales fg = new FuncionesGenerales();

        public RecepcionTarjetas()
        {
            InitializeComponent();

            cmbHospitales.DataSource = hospitalBC.ListaHospitales();
            cmbHospitales.DisplayMember = "cntFacility";
            cmbHospitales.ValueMember = "ContactId";

            cmbMeses.DataSource = parametroGeneralBC.ListaMeses();
            cmbMeses.DisplayMember = "ValorTexto";
            cmbMeses.ValueMember = "ValorEntero";
            cmbMeses.SelectedValue = 0;

            cmbAnho.DataSource = parametroGeneralBC.ListaAnhos();
            cmbAnho.DisplayMember = "ValorTexto";
            cmbAnho.ValueMember = "ValorEntero";
            cmbAnho.SelectedValue = DateTime.Today.Year;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvResultados.DataSource = recepcionBC.ObtenerRecepciones(1, 1, 1);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarRecepcion registar = new RegistrarRecepcion();
            //registar.MdiParent = this;
            registar.ShowDialog();
        }
    }
}
