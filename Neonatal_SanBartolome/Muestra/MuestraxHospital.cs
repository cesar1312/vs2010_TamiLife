using System;
using System.Windows.Forms;
using BC;


namespace Neonatal_SanBartolome.Muestra
{
    public partial class MuestraxHospital : Form
    {
        MuestraBC muestraBC = new MuestraBC();
        HospitalBC hospitalBC = new HospitalBC();
        ParametroGeneralBC parametroGeneralBC = new ParametroGeneralBC();
        FuncionesGenerales fg = new FuncionesGenerales();

        public MuestraxHospital()
        {

            InitializeComponent();

            cmbMeses.DataSource = parametroGeneralBC.ListaMeses();
            cmbMeses.DisplayMember = "ValorTexto";
            cmbMeses.ValueMember = "ValorEntero";
            cmbMeses.SelectedValue = 0;

            cmbAnho.DataSource = parametroGeneralBC.ListaAnhos();
            cmbAnho.DisplayMember = "ValorTexto";
            cmbAnho.ValueMember = "ValorEntero";
            cmbAnho.SelectedValue = DateTime.Today.Year;

            cmbHospitales.DataSource = hospitalBC.ListaHospitales();
            cmbHospitales.DisplayMember = "cntFacility";
            cmbHospitales.ValueMember = "ContactId";
            //cmbHospitales.Items.Insert(0,"TODOS"); //.Add(new item("2", "2"));
            cmbHospitales.SelectedValue = 0;
           

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
            dgvResultados.AutoGenerateColumns = false;
            //row.HeaderCell.Value = String.Format("{0}", row.Index + 1);

            //setRowNumber(dgvResultados);
            dgvResultados.DataSource = muestraBC.ListaMuestras(int.Parse(cmbMeses.SelectedValue.ToString()), 
                                                                int.Parse(cmbAnho.Text),
                                                                int.Parse(cmbPrueba.SelectedValue.ToString()),
                                                                int.Parse(cmbHospitales.SelectedValue.ToString()),
                                                                int.Parse(cmbTipoResultados.SelectedValue.ToString()));
            
            //dgvResultados.ro
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            fg.WriteCSV(dgvResultados);
        }

        private void MuestraxHospital_Load(object sender, EventArgs e)
        {
           

            //cmbMeses.DataSource = parametroGeneralBC.ListaMeses();
            //cmbMeses.DisplayMember = "ValorTexto";
            //cmbMeses.ValueMember = "ValorEntero";
            //cmbMeses.SelectedValue = 0;
        } 
    }
}
