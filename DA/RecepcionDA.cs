using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DA
{
    public class RecepcionDA
    {
        AccesoDB db = new AccesoDB();

        public Recepcion RegistrarRecepcion(Recepcion recepcion)
        {
            db.tamilife_dc.Recepcions.InsertOnSubmit(recepcion);
            try
            {
                db.tamilife_dc.SubmitChanges();
                return recepcion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarRecepcion(Recepcion recepcion)
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

        public Recepcion ObtenerRecepcion(int idRecepcion)
        {
            return db.tamilife_dc.Recepcions.First(r => r.idRecepcion == idRecepcion);

        }

        public List<Vista_ListaRecepcione> ObtenerRecepciones(int idTipoEstablecimiento, int idEstablecimiento, int anho, int mes, int filtro)
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
                case 1: return db.tamilife_dc.Vista_ListaRecepciones.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.idEstablecimiento == idEstablecimiento &&
                                                            e.FechaRecepcion.Year == anho && e.FechaRecepcion.Month == mes).ToList();

                case 2: return db.tamilife_dc.Vista_ListaRecepciones.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.idEstablecimiento == idEstablecimiento &&
                                                            e.FechaRecepcion.Year == anho).ToList();

                case 3: return db.tamilife_dc.Vista_ListaRecepciones.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.idEstablecimiento == idEstablecimiento).ToList();

                case 4: return db.tamilife_dc.Vista_ListaRecepciones.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.FechaRecepcion.Year == anho && e.FechaRecepcion.Month == mes).ToList();

                case 5: return db.tamilife_dc.Vista_ListaRecepciones.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento &&
                                                            e.FechaRecepcion.Year == anho).ToList();

                case 6: return db.tamilife_dc.Vista_ListaRecepciones.Where(e => e.idTipoEstablecimiento == idTipoEstablecimiento).ToList();

                case 7: return db.tamilife_dc.Vista_ListaRecepciones.Where(e => e.FechaRecepcion.Year == anho && e.FechaRecepcion.Month == mes).ToList();

                case 8: return db.tamilife_dc.Vista_ListaRecepciones.Where(e => e.FechaRecepcion.Year == anho).ToList();

                default: return db.tamilife_dc.Vista_ListaRecepciones.ToList();
            }
        }
    }
}
