using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;


namespace DA
{
    public class EstablecimientoDA
    {
        AccesoDB db = new AccesoDB();
        public List<Establecimiento> ObtenerEstablecimientosxTipo(int tipoEstablecimiento)
        {
            return (from e in db.tamilife_dc.Establecimientos where e.idTipoEstablecimiento == tipoEstablecimiento select e).ToList();
            //return q;)
        }
        public List<Establecimiento> ObtenerEstablecimientos(string nombreEstablecimiento, int tipoEstablecimiento)
        {
            var listaEstablecimientos = new List<Establecimiento>();
            //TipoEstablecimiento tipo =
            //    db.dc.TipoEstablecimiento.Where(e => e.idTipoEstablecimiento == tipoEstablecimiento).FirstOrDefault();
            if (nombreEstablecimiento == string.Empty)
            {
                if (tipoEstablecimiento == 0)
                {
                    listaEstablecimientos = (from e in db.tamilife_dc.Establecimientos select e).ToList();
                }
                else
                {
                    listaEstablecimientos = (from e in db.tamilife_dc.Establecimientos where e.idTipoEstablecimiento == tipoEstablecimiento select e).ToList();
                    //listaEstablecimientos = (from e in db.dc.Establecimiento where e.idTipoEstablecimiento == tipo.idTipoEstablecimiento select e).ToList();
                }
            }
            else
            {
                listaEstablecimientos = (from e in db.tamilife_dc.Establecimientos where e.Nombre.Contains(nombreEstablecimiento) select e).ToList();
            }
            //listaEstablecimientos = (from e in db.linqDataContext.Establecimientos where e.TipoEstablecimiento == tipoEstablecimiento select e).ToList();
            //return q;)
            return listaEstablecimientos;
        }

        public bool RegistrarEstablecimiento(Establecimiento establecimiento)
        {
            db.tamilife_dc.Establecimientos.InsertOnSubmit(establecimiento);
            try
            {
                db.tamilife_dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
        }

        public int ActualizarEstablecimiento(Establecimiento establecimiento)
        {
            //db.linqDataContext.Muestras. .InsertAllOnSubmit(muestras);
            try
            {
                db.tamilife_dc.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Establecimiento ObtenerEstablecimientoxIdEstablecimiento(int idEstablecimiento)
        {
            return (from e in db.tamilife_dc.Establecimientos where e.idEstablecimiento == idEstablecimiento select e).FirstOrDefault();
        }


        #region Metodos_Vista_Establecimientos

        //public List<Vista_Establecimientos> BuscarEstablecimiento(string nombre, int idTipoEstablecimiento,int departamento,int provincia )
        //{
        //    return db.dc.Vista_Establecimientos.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento).ToList();
        //}

        //public List<Vista_Establecimientos> BuscarEstablecimientoxNombre(string nombre)
        //{
        //    return db.dc.Vista_Establecimientos.Where(e => e.Establecimiento.Contains(nombre)).ToList();
        //}

        //public List<Vista_Establecimientos> BuscarEstablecimientoxTipoEstablecimiento(int idTipoEstablecimiento)
        //{
        //    return db.dc.Vista_Establecimientos.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento).ToList();
        //}
        //public List<Vista_Establecimientos> BuscarEstablecimientoxDepartamento(int idDepartamento)
        //{
        //    return db.dc.Vista_Establecimientos.Where(e => e.depUbigeo == idDepartamento).ToList();
        //}
        //public List<Vista_Establecimientos> BuscarEstablecimientoxProvincia(int idDepartamento, int idProvincia)
        //{
        //    return db.dc.Vista_Establecimientos.Where(e => e.depUbigeo == idDepartamento && e.proUbigeo == idProvincia).ToList();
        //}

        //public List<Vista_Establecimientos> BuscarEstablecimiento(int idTipoEstablecimiento, int idDepartamento, int idProvincia)
        //{
        //    return db.dc.Vista_Establecimientos.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento && e.depUbigeo == idDepartamento && e.proUbigeo == idProvincia).ToList();
        //}

        //public List<Vista_Establecimientos> BuscarEstablecimiento(int idTipoEstablecimiento, int idDepartamento)
        //{
        //    return db.dc.Vista_Establecimientos.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento && e.depUbigeo == idDepartamento).ToList();
        //}


        public Vista_Establecimiento ObtenerEstablecimiento(int idEstablecimiento)
        {
            return db.tamilife_dc.Vista_Establecimientos.First(e => e.idEstablecimiento == idEstablecimiento);

        }

        public List<Vista_Establecimiento> ObtenerEstablecimientos(string establecimiento, int idTipoEstablecimiento, int idDepartamento, int idProvincia, int filtro)
        {
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
            switch (filtro)
            {
                //v f f f FILTRO = 1
                case 1: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.Establecimiento.Contains(establecimiento)).ToList();
                //v v f f FILTRO = 2
                case 2: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.Establecimiento.Contains(establecimiento) && e.idTipoEstablecimiento == idTipoEstablecimiento).ToList();
                //v v v f FILTRO = 3
                case 3: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.Establecimiento.Contains(establecimiento) && e.idTipoEstablecimiento == idTipoEstablecimiento && e.depUbigeo == idDepartamento).ToList();
                //v v v v FILTRO = 4
                case 4: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.Establecimiento.Contains(establecimiento) && e.idTipoEstablecimiento == idTipoEstablecimiento && e.depUbigeo == idDepartamento && e.proUbigeo == idProvincia).ToList();
                //f v v v FILTRO = 5
                case 5: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento && e.depUbigeo == idDepartamento && e.proUbigeo == idProvincia).ToList();
                //f v v f FILTRO = 6
                case 6: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento && e.depUbigeo == idDepartamento).ToList();
                //f v f f FILTRO = 7
                case 7: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento).ToList();
                //v f v f FILTRO = 8
                case 8: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.Establecimiento.Contains(establecimiento) && e.depUbigeo == idDepartamento).ToList();
                //v f v v FILTRO = 9
                case 9: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.Establecimiento.Contains(establecimiento) && e.depUbigeo == idDepartamento && e.proUbigeo == idProvincia).ToList();
                //f f v v FILTRO = 10
                case 10: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.depUbigeo == idDepartamento && e.proUbigeo == idProvincia).ToList();
                //f f v f FILTRO = 11
                case 11: return db.tamilife_dc.Vista_Establecimientos.Where(e => e.depUbigeo == idDepartamento).ToList();
                //f f f f FILTRO = 0
                default: return db.tamilife_dc.Vista_Establecimientos.ToList();
            }


        }
        #endregion
    }
}
