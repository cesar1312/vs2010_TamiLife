using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DA
{
    public class EnvioDA
    {
        AccesoDB db = new AccesoDB();

        public Envio RegistrarEnvio(Envio envio)
        {
            db.tamilife_dc.Envios.InsertOnSubmit(envio);
            try
            {
                db.tamilife_dc.SubmitChanges();
                return envio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarEnvio(Envio envio)
        {
            try
            {
                db.tamilife_dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Vista_ListaEnvio> ObtenerEnvios(int Top)
        {
            if (Top > 0)
                return db.tamilife_dc.Vista_ListaEnvios.Take(Top).ToList();

            return db.tamilife_dc.Vista_ListaEnvios.ToList();
        }

        public List<Vista_ListaEnvio> ObtenerEnvios(int idTipoEstablecimiento, int idEstablecimiento, int anho, int mes, int filtro)
        {
            /*
             *  El parametro filtro sirve para indicarnos los filtros que debemos aplicar a la consulta
             *  filtro = 0 : No Aplicar filtros
             *  filtro = 1 : Aplicar todos los filtros(Tipo Establecimiento, Establecimiento, Año y Mes)
             *  filtro = 2 : Aplicar filtro Tipo Establecimiento, Establecimietno y Año
             *  filtro = 3 : Aplicar filtro Tipo Establecimiento y Establecimiento 
             *  filtro = 4 : Aplicar filtro Tipo Establecimiento, Año y Mes
             *  filtro = 5 : Aplicar filtro Tipo Establecimiento y Año 
             *  filtro = 6 : Aplicar filtro Tipo Establecimiento 
             *  filtro = 7 : Aplicar Filtro Año y Mes
             *  filtro = 8 : Aplicar filtro Año
             */
            switch (filtro)
            {
                case 1: return db.tamilife_dc.Vista_ListaEnvios.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.idEstablecimiento == idEstablecimiento &&
                                                            e.FechaEnvio.Year == anho && e.FechaEnvio.Month == mes).ToList();

                case 2: return db.tamilife_dc.Vista_ListaEnvios.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.idEstablecimiento == idEstablecimiento &&
                                                            e.FechaEnvio.Year == anho).ToList();

                case 3: return db.tamilife_dc.Vista_ListaEnvios.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.idEstablecimiento == idEstablecimiento).ToList();

                case 4: return db.tamilife_dc.Vista_ListaEnvios.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.FechaEnvio.Year == anho && e.FechaEnvio.Month == mes).ToList();

                case 5: return db.tamilife_dc.Vista_ListaEnvios.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.FechaEnvio.Year == anho).ToList();

                case 6: return db.tamilife_dc.Vista_ListaEnvios.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento).ToList();

                case 7: return db.tamilife_dc.Vista_ListaEnvios.Where(e => e.FechaEnvio.Year == anho && e.FechaEnvio.Month == mes).ToList();

                case 8: return db.tamilife_dc.Vista_ListaEnvios.Where(e => e.FechaEnvio.Year == anho).ToList();

                default: return db.tamilife_dc.Vista_ListaEnvios.ToList();
            }
        }

        public Envio ObtenerEnvio(int idEnvio)
        {
            return db.tamilife_dc.Envios.First(e => e.idEnvio == idEnvio);
        }
    }
}
