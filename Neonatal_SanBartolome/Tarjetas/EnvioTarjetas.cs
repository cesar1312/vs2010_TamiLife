using System;
using System.Windows.Forms;
using BC;

namespace Neonatal_SanBartolome.Tarjetas
{
    public partial class EnvioTarjetas : Form
    {
        HospitalBC hospitalBC = new HospitalBC();
        EnvioBC envioBC = new EnvioBC();
        ParametroGeneralBC parametroGeneralBC = new ParametroGeneralBC();
        FuncionesGenerales fg = new FuncionesGenerales();

        public EnvioTarjetas()
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarEnvio registar = new RegistrarEnvio();
            //registar.MdiParent = this;
            registar.ShowDialog();
        }

        private void EnvioTarjetas_Load(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvResultados.DataSource = envioBC.ObtenerEnvios(1,1,1);
        }
    }
}
