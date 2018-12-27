using System;
using System.Windows.Forms;
using BC;

namespace Neonatal_SanBartolome.Muestra
{
    public partial class BuscarMuestra : Form
    {
        MuestraBC muestraBC = new MuestraBC();
        FuncionesGenerales fg = new FuncionesGenerales();

        public BuscarMuestra()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = muestraBC.BuscarResultadoxMuestra(txtNombresNeonato.Text
                                                                       ,txtApellidosNeonato.Text
                                                                       ,txtDNI_Madre.Text
                                                                       ,txtHClinica.Text);
        }

        private void txtDNI_Madre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            fg.WriteCSV(dgvResultados);
        }

        private void BuscarMuestra_Load(object sender, EventArgs e)
        {

        }
    }
}
