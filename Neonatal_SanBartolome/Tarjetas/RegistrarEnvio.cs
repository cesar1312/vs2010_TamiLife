using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BC;
using BE;

namespace Neonatal_SanBartolome.Tarjetas
{
    public partial class RegistrarEnvio : Form
    {
        HospitalBC hospitalBC = new HospitalBC();
        //ParametroGeneralBC parametroGeneralBC = new ParametroGeneralBC();
        //FuncionesGenerales fg = new FuncionesGenerales();
        EnvioBC envioBC = new EnvioBC();
        TarjetaBC tarjetaBC = new TarjetaBC();

        private int cumple = 0;
        private int idHospital;
        private string codigoInicial;
        private int cantidad;

        public RegistrarEnvio()
        {
            InitializeComponent();

            cmbHospitales.DataSource = hospitalBC.ListaHospitales();
            cmbHospitales.DisplayMember = "cntFacility";
            cmbHospitales.ValueMember = "ContactId";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        { 
            if (txtCodigoTarjeta.Text.CompareTo(string.Empty) == 0)
            {
                MessageBox.Show(@"Ingrese un codigo inicial");
                cumple = 0;
            }else
            {
                cumple = 1;
            }

            //cantidad = decimal.ToInt32(nudCantidad.Value);
            codigoInicial = txtCodigoTarjeta.Text;
            idHospital = int.Parse(cmbHospitales.SelectedValue.ToString());
            
            if (cumple == 1)
            {
                int codigo;
                if (int.TryParse(codigoInicial, out codigo))
                {
                    GenerarCodigos(codigo, cantidad);
                }else
                {
                    MessageBox.Show(@"Ingrese un codigo inicial valido");
                }
            }
           
        }

        public void GenerarCodigos(int codigoInicial, int cantidad)
        {
            var tope = codigoInicial + cantidad;

            //var listaTarjetas = new List<Tarjeta>();
            for (int i = codigoInicial; i < tope; i++)
            {
                dgvResultados.Rows.Add(1, i);

                
                //var tarjeta = new Tarjeta();
                //tarjeta.CodigoTarjeta = i.ToString();
                //tarjeta.idHospital = idHospital;
                //listaTarjetas.Add(tarjeta);
            }

            //dgvTarjetas.DataSource = listaTarjetas;

            //foreach (DataGridViewRow row in dgvTarjetas.Rows)
            //{
            //    var chk = (DataGridViewCheckBoxCell)row.Cells[0];
            //    chk.Value = true;
            //}

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Envio envio =  new Envio();
            //envio.idHospital = idHospital;
            //envio.CodigoInicial = codigoInicial;
            //envio.Cantidad = cantidad;
            //envio.FechaEnvio = dtpFechaEnvio.Value;
            //envio.Estado = 1;

            //int idEnvio;
            //idEnvio = envioBC.RegistrarEnvio(envio);

            //var listaTarjetas = new List<Tarjeta>();
            //foreach (DataGridViewRow row in dgvResultados.Rows)
            //{
            //    /*
            //     int id = Int32.Parse(row.Cells["idResultado"].Value.ToString());
            //     string pocillo = row.Cells["Pocillo"].Value.ToString();
            //     */
            //    var tarjeta = new Tarjeta();
            //    tarjeta.CodigoTarjeta = row.Cells["CodigoTarjeta"].Value.ToString();
            //    tarjeta.idHospital = idHospital;
            //    tarjeta.idEnvio = idEnvio;
            //    tarjeta.Estado = 1;
            //    listaTarjetas.Add(tarjeta);
              
            //}

            //tarjetaBC.RegistrarTarjetas(listaTarjetas);
        }
    }
}
