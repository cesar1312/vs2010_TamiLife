using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BC;
using BE;

namespace Neonatal_SanBartolome.Tarjetas
{
    public partial class AdministrarEnvios : Form
    {
        //Si no es nuevo es porque es edición
        private bool esNuevo = true;
        readonly EnvioBC envioBC = new EnvioBC();
        readonly HospitalBC hospitalBC = new HospitalBC();
        readonly ParametroGeneralBC parametroGeneralBC = new ParametroGeneralBC();
        readonly EstablecimientoBC establecimientoBC = new EstablecimientoBC();
        readonly TarjetaBC tarjetaBC = new TarjetaBC();
        //private int idEnvio;
        public AdministrarEnvios()
        {
            InitializeComponent();
        }

        #region Registrar
        
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            CambiarEstadoBotonesToolStrip(true);
            //tslTitulo.Visible = true;
            tslTitulo.Text = "Editar";
            esNuevo = false;
            DesbloquearControles(true);
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            CambiarEstadoBotonesToolStrip(false);
            tslTitulo.Text = "";
        }

        private void CambiarEstadoBotonesToolStrip(bool estado)
        {
            tsbGuardar.Visible = estado;
            tsbCancelar.Visible = estado;
            tsbGenerar.Visible = estado;
            tsbEditar.Visible = !estado;
            tsbNuevo.Visible = !estado;
            tslTitulo.Visible = estado;
        }
        private void DesbloquearControles(bool estado)
        {
            cmbHospitales.Enabled = estado;
            dtpFechaEnvio.Enabled = estado;
            txtCodigoInicial.Enabled = estado;
            txtCodigoFinal.Enabled = estado;
            //dgvTarjetas.Enabled = estado;
        } 

        private void LimpiarControles()
        {
            //cmbHospitales.SelectedValue = 0;
            dtpFechaEnvio.Value = DateTime.Today;
            txtCodigoInicial.Text = string.Empty;
            txtCodigoFinal.Text = string.Empty;
            dgvTarjetas.DataSource = string.Empty;
        }

        private void LlenarHospitales()
        {
            cmbHospitales.DataSource = hospitalBC.ListaHospitales();
            cmbHospitales.DisplayMember = "cntFacility";
            cmbHospitales.ValueMember = "ContactId";
            cmbHospitales.SelectedValue = 0;

            cmbHospitalesBuscar.DataSource = hospitalBC.ListaHospitales();
            cmbHospitalesBuscar.DisplayMember = "cntFacility";
            cmbHospitalesBuscar.ValueMember = "ContactId";
            cmbHospitalesBuscar.SelectedValue = 0;
        }

        private void CargarMes()
        {
            List<ParametroGeneral> listaMeses = parametroGeneralBC.ListaMeses();
            //listaMeses = parametroGeneralBC.AgregarParametroTodos(listaMeses);
            cmbMes.DataSource = listaMeses;
            cmbMes.DisplayMember = "ValorTexto";
            cmbMes.ValueMember = "ValorEntero";
            cmbMes.SelectedValue = 0;
        }

        private void CargarAnho()
        {
            List<ParametroGeneral> listaAnhos = parametroGeneralBC.ListaAnhos();
            //listaAnhos = parametroGeneralBC.AgregarParametroTodos(listaAnhos);
            cmbAnho.DataSource = listaAnhos;
            cmbAnho.DisplayMember = "ValorTexto";
            cmbAnho.ValueMember = "ValorEntero";
            cmbAnho.SelectedValue = DateTime.Today.Year;
        }

        //private void CargarTipoEstablecimiento()
        //{
        //    ddlTipoEstablecimiento.DataSource = tipoEstablecimientoBC.ObtenerTipoEstablecimiento();
        //    ddlTipoEstablecimiento.DataTextField = "Nombre";
        //    ddlTipoEstablecimiento.DataValueField = "idTipoEstablecimiento";
        //    ddlTipoEstablecimiento.DataBind();
        //    ListItem item = new ListItem("--Todos--", "0");
        //    ddlTipoEstablecimiento.Items.Insert(0, item);
        //    ddlTipoEstablecimiento.SelectedValue = "0";
        //}
        public void CargarEstablecimiento(int tipoEstablecimiento)
        {
            cmbHospitales.DisplayMember = "Nombre";
            cmbHospitales.ValueMember = "idEstablecimiento";
            cmbHospitales.DataSource = establecimientoBC.ObtenerEstablecimientosxTipo(tipoEstablecimiento);
        }

        public void CargarEstablecimientoBuscar(int tipoEstablecimiento)
        {
            cmbHospitalesBuscar.DisplayMember = "Nombre";
            cmbHospitalesBuscar.ValueMember = "idEstablecimiento";
            var listaEstablecimientos = establecimientoBC.ObtenerEstablecimientosxTipo(tipoEstablecimiento);
            listaEstablecimientos = establecimientoBC.AddEstablecimientosTodos(listaEstablecimientos);
            cmbHospitalesBuscar.DataSource = listaEstablecimientos;
            cmbHospitalesBuscar.SelectedValue = 0;
        }
        #endregion

        #region Buscar
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idEstablecimiento = int.Parse(cmbHospitalesBuscar.SelectedValue.ToString());
            int anho = int.Parse(cmbAnho.SelectedValue.ToString());
            int mes = int.Parse(cmbMes.SelectedValue.ToString());
            List<Vista_ListaEnvio> listaEnvio = envioBC.ObtenerEnvios(1, idEstablecimiento, anho, mes);
            dgvEnvios.DataSource = listaEnvio;
        }

        #endregion

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CambiarEstadoBotonesToolStrip(true);
            tslTitulo.Text = "Nuevo";
            esNuevo = true;
            LimpiarControles();
            DesbloquearControles(true);
        }

        private void AdministrarEnvios_Load(object sender, EventArgs e)
        {
            CargarMes();
            CargarAnho();
            CargarEstablecimiento(1);
            CargarEstablecimientoBuscar(1);
            dgvEnvios.AutoGenerateColumns = false;
            dgvTarjetas.AutoGenerateColumns = false;
        }




        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                RegistrarEnvioTarjetas();
                DesbloquearControles(false);
                //LimpiarControles();
            }else
            {
                ActualizarEnvioTarjetas();
            }
            CambiarEstadoBotonesToolStrip(false);
            tslTitulo.Text = "";
        }

        private void RegistrarEnvioTarjetas()
        {
            var envio = new Envio
                            {
                                CodigoInicial = txtCodigoInicial.Text,
                                CodigoFinal = txtCodigoFinal.Text,
                                FechaEnvio = dtpFechaEnvio.Value,
                                idEstablecimiento = int.Parse(cmbHospitales.SelectedValue.ToString())
                            };

            envio = envioBC.RegistrarEnvio(envio);
            dgvTarjetas.DataSource = tarjetaBC.ObtenerListaTarjetas(envio.idEnvio, 1);
        }

        private void ActualizarEnvioTarjetas()
        {
            
        }

        private void dgvEnvios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvEnvios.CurrentCell.RowIndex;
            int idEnvio = int.Parse(dgvEnvios.CurrentRow.Cells["idEnvio"].Value.ToString());
            CargarDatosEnvio(idEnvio);
            CambiarEstadoBotonesToolStrip(false);
            DesbloquearControles(false);
            //bloquearControles();
            //tsbEditar.Enabled = true;
            //tsbReporte.Enabled = true;
            //editToolDisable();
        }

        private void CargarDatosEnvio(int idEnvio)
        {
            Envio envio = envioBC.ObtenerEnvio(idEnvio);
            cmbHospitales.SelectedValue = envio.idEstablecimiento;
            txtCodigoInicial.Text = envio.CodigoInicial;
            txtCodigoFinal.Text = envio.CodigoFinal;
            dtpFechaEnvio.Value = envio.FechaEnvio;
            List<Vista_ListaTarjeta> tarjetas = tarjetaBC.ObtenerListaTarjetas(idEnvio, 1);
            dgvTarjetas.DataSource = tarjetas;
        }

        private void txtCodigoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistrarRecepcion registrar = new RegistrarRecepcion();
            registrar.ShowDialog(); //.Show();
        }
    }
}
