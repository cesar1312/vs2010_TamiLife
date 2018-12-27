using System;
using System.Windows.Forms;
using BC;


namespace Neonatal_SanBartolome.Resultado
{
    public partial class ConsultarResultados : Form
    {
        readonly ParametroGeneralBC parametroGeneralBC = new ParametroGeneralBC();
        readonly ResultadoBC resultadoBC = new ResultadoBC();
        readonly FuncionesGenerales fg = new FuncionesGenerales();

        public ConsultarResultados()
        {
            InitializeComponent();
            cmbMeses.DataSource = parametroGeneralBC.ListaMeses();
            cmbMeses.DisplayMember = "ValorTexto";
            cmbMeses.ValueMember = "ValorEntero";
            cmbMeses.SelectedValue = 0;

            cmbAnho.DataSource = parametroGeneralBC.ListaAnhos();
            cmbAnho.DisplayMember = "ValorTexto";
            cmbAnho.ValueMember = "ValorEntero";
            cmbAnho.SelectedValue = 0;

            cmbPrueba.DataSource = parametroGeneralBC.ListaPruebas();
            cmbPrueba.DisplayMember = "ValorTexto";
            cmbPrueba.ValueMember = "ValorEntero";
            cmbPrueba.SelectedValue = 0;

            cmbTipoResultados.DataSource = parametroGeneralBC.ListarTipoResultados();
            cmbTipoResultados.DisplayMember = "ValorTexto";
            cmbTipoResultados.ValueMember = "ValorEntero";
            cmbTipoResultados.SelectedValue = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numEnsayo = 0;
            dgvResultados.AutoGenerateColumns = false;
            if (txtID.Text.CompareTo(string.Empty) != 0)
                numEnsayo = int.Parse(txtID.Text);

            dgvResultados.DataSource = resultadoBC.ListaResultados(numEnsayo,
                                                                int.Parse(cmbMeses.SelectedValue.ToString()),
                                                                int.Parse(cmbAnho.SelectedValue.ToString()),
                                                                int.Parse(cmbPrueba.SelectedValue.ToString()),
                                                                int.Parse(cmbTipoResultados.SelectedValue.ToString()));
        }

        private void ConsultarResultados_Load(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            fg.WriteCSV(dgvResultados);
            
        }
       
    }
}
