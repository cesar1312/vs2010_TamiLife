using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using BE;

namespace BC
{
    public class EstablecimientoBC
    {
        EstablecimientoDA da = new EstablecimientoDA();

        public List<Establecimiento> AddEstablecimientosTodos(List<Establecimiento> lista)
        {
            Establecimiento establecimiento = new Establecimiento();
            establecimiento.idEstablecimiento = 0;
            establecimiento.Nombre = "Todos";
            lista.Add(establecimiento);
            return lista;
        }

        public List<Establecimiento> ObtenerEstablecimientosxTipo(int tipoEstablecimiento)
        {
            return da.ObtenerEstablecimientosxTipo(tipoEstablecimiento);
        }
        public List<Establecimiento> ObtenerEstablecimientos(string nombreEstablecimiento, int tipoEstablecimiento)
        {
            return da.ObtenerEstablecimientos(nombreEstablecimiento, tipoEstablecimiento);
        }

        public bool RegistrarEstablecimiento(Establecimiento establecimiento)
        {
            return da.RegistrarEstablecimiento(establecimiento);
        }

        public int ActualizarEstablecimiento(Establecimiento establecimiento)
        {
            return da.ActualizarEstablecimiento(establecimiento);
        }

        public Establecimiento ObtenerEstablecimientoxIdEstablecimiento(int idEstablecimiento)
        {
            return da.ObtenerEstablecimientoxIdEstablecimiento(idEstablecimiento);
        }


        //Buscar Establecimiento
        //public List<Vista_Establecimientos> BuscarEstablecimiento(string establecimiento, int idTipoEstablecimiento, int idDepartamento, int idProvincia)
        //{
        //    if ((establecimiento != null) && (establecimiento.CompareTo(string.Empty)!=0))
        //        return da.BuscarEstablecimientoxNombre(establecimiento);

        //    if (idTipoEstablecimiento > 0 && idDepartamento == 0 && idProvincia == 0)
        //        return da.BuscarEstablecimientoxTipoEstablecimiento(idTipoEstablecimiento);

        //    if (idTipoEstablecimiento == 0 && idDepartamento > 0 && idProvincia == 0)
        //        return da.BuscarEstablecimientoxDepartamento(idDepartamento);

        //    if (idTipoEstablecimiento == 0 && idDepartamento > 0 && idProvincia > 0)
        //        return da.BuscarEstablecimientoxProvincia(idDepartamento, idProvincia);

        //    if (idTipoEstablecimiento > 0 && idDepartamento > 0 && idProvincia == 0)
        //        return da.BuscarEstablecimiento(idTipoEstablecimiento, idDepartamento);

        //    if (idTipoEstablecimiento > 0 && idDepartamento > 0 && idProvincia > 0)
        //        return da.BuscarEstablecimiento(idTipoEstablecimiento,idDepartamento,idProvincia);
        //    //return establecimientoDA.BuscarEstablecimiento(nombre, idTipoEstablecimiento, departamento, provincia);
        //    List<Vista_Establecimientos> lista = new List<Vista_Establecimientos>();
        //    return lista;
        //}

        public List<Vista_Establecimiento> ObtenerEstablecimientos(string establecimiento, int idTipoEstablecimiento, int idDepartamento, int idProvincia)
        {
            bool establecimientoIngresado = establecimiento.CompareTo(string.Empty) != 0;
            bool tipoSeleccionado = idTipoEstablecimiento != 0;
            bool departamentoSeleccionado = idDepartamento != 0;
            bool provinciaSeleccionada = idProvincia != 0;
            int filtro = 0;

            /*
             * f f f f FILTRO = 0
             * v f f f FILTRO = 1
             * v v f f FILTRO = 2
             * v v v f FILTRO = 3
             * v v v v FILTRO = 4
             * f v v v FILTRO = 5
             * f v v f FILTRO = 6
             * f v f f FILTRO = 7
             * v f v f FILTRO = 8
             * v f v v FILTRO = 9
             * f f v v FILTRO = 10
             * f f v f FILTRO = 11
             *
             * f v f v Este escenario no se daria nunca ya que para seleccionar una provincia es necesario seleccionar un departamento. 
             *
             */

            //v f f f FILTRO = 1
            if (establecimientoIngresado && !tipoSeleccionado && !departamentoSeleccionado && !provinciaSeleccionada)
                filtro = 1;
            //v v f f FILTRO = 2
            if (establecimientoIngresado && tipoSeleccionado && !departamentoSeleccionado && !provinciaSeleccionada)
                filtro = 2;
            //v v v f FILTRO = 3
            if (establecimientoIngresado && tipoSeleccionado && departamentoSeleccionado && !provinciaSeleccionada)
                filtro = 3;
            //v v v v FILTRO = 4
            if (establecimientoIngresado && tipoSeleccionado && departamentoSeleccionado && provinciaSeleccionada)
                filtro = 4;
            //f v v v FILTRO = 5
            if (!establecimientoIngresado && tipoSeleccionado && departamentoSeleccionado && provinciaSeleccionada)
                filtro = 5;
            //f v v f FILTRO = 6
            if (!establecimientoIngresado && tipoSeleccionado && departamentoSeleccionado && !provinciaSeleccionada)
                filtro = 6;
            //f v f f FILTRO = 7
            if (!establecimientoIngresado && tipoSeleccionado && !departamentoSeleccionado && !provinciaSeleccionada)
                filtro = 7;
            //v f v f FILTRO = 8
            if (establecimientoIngresado && !tipoSeleccionado && departamentoSeleccionado && !provinciaSeleccionada)
                filtro = 8;
            //v f v v FILTRO = 9
            if (establecimientoIngresado && !tipoSeleccionado && departamentoSeleccionado && provinciaSeleccionada)
                filtro = 9;
            //f f v v FILTRO = 10
            if (!establecimientoIngresado && !tipoSeleccionado && departamentoSeleccionado && provinciaSeleccionada)
                filtro = 10;
            //f f v f FILTRO = 11
            if (!establecimientoIngresado && !tipoSeleccionado && departamentoSeleccionado && !provinciaSeleccionada)
                filtro = 11;

            return da.ObtenerEstablecimientos(establecimiento, idTipoEstablecimiento, idDepartamento, idProvincia, filtro);
        }

        public Vista_Establecimiento ObtenerEstablecimiento(int idEstablecimiento)
        {
            return da.ObtenerEstablecimiento(idEstablecimiento);
        }
    }
}
