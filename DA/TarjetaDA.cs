using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DA
{
    public class TarjetaDA
    {
        AccesoDB db = new AccesoDB();

        public void RegitrarTarjetas(List<Tarjeta> lista)
        {
            db.tamilife_dc.Tarjetas.InsertAllOnSubmit(lista);
            try
            {
                db.tamilife_dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarTarjeta(Tarjeta t)
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

        public Tarjeta ObtenerTarjeta(string codigo)
        {
            try
            {
                return (from t in db.tamilife_dc.Tarjetas where t.CodigoMuestra == codigo && t.Estado == 1 select t).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Vista_ListaTarjeta> ObtenerListaTarjetas(int id, int indice)
        {
            /*
             * indice = 1 : el parametro es idEnvio
             * indice = 2 : el parametro es idRecepcion
             */
            switch (indice)
            {
                case 1: return db.tamilife_dc.Vista_ListaTarjetas.Where(t => t.idEnvio == id).ToList();
                case 2: return db.tamilife_dc.Vista_ListaTarjetas.Where(t => t.idRecepcion == id).ToList();
                default: return db.tamilife_dc.Vista_ListaTarjetas.ToList();
            }

        }

        public void ActualizarEstadoTarjetas(int idEnvio, int estado)
        {
            List<Tarjeta> lista = db.tamilife_dc.Tarjetas.Where(t => t.idEnvio == idEnvio).ToList();
            foreach (var t in lista)
            {
                t.Estado = estado;
            }
            try
            {
                db.tamilife_dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
