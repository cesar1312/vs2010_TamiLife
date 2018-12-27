using System;
using System.Windows.Forms;
using BC;


namespace Neonatal_SanBartolome.Resultado
{
    public partial class BuscarResultadoTarjeta : Form
    {
        ResultadoBC resultadoBC = new ResultadoBC();
        FuncionesGenerales fg = new FuncionesGenerales();

        public BuscarResultadoTarjeta()
        {
            InitializeComponent();
            dgvResultados.AutoGenerateColumns = false;
        }

        private void BuscarResultadoTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoMuestra = txtCodigoMuestra.Text;
            if ((codigoMuestra.CompareTo(string.Empty) != 0))
                dgvResultados.DataSource = resultadoBC.BuscarResultadoxTarjeta(codigoMuestra);
            else
            {
                MessageBox.Show(@"Ingrese un Codigo de Tarjeta Valido");

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            fg.WriteCSV(dgvResultados);
        }

       
        
    }
}
