using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DA;

namespace BC
{
    public class TarjetaBC
    {
        TarjetaDA da = new TarjetaDA();
        public void RegitrarTarjetas(List<Tarjeta> lista)
        {
            da.RegitrarTarjetas(lista);
        }
        public void RegitrarRecepcionTarjetas(List<Tarjeta> lista)
        {
            List<Tarjeta> listaTarjetasSinRegistrar = new List<Tarjeta>();
            foreach (Tarjeta tarjeta in lista)
            {
                string codigo = tarjeta.CodigoMuestra;
                Tarjeta ta = da.ObtenerTarjeta(codigo);
                if (ta != null)
                {
                    ta.idRecepcion = tarjeta.idRecepcion;
                    ta.Recibido = tarjeta.Recibido;
                    ta.Rechazado = tarjeta.Rechazado;
                    da.ActualizarTarjeta(ta);
                }
                else
                {
                    ta = new Tarjeta();
                    ta.CodigoMuestra = tarjeta.CodigoMuestra;
                    ta.idRecepcion = tarjeta.idRecepcion;
                    ta.Recibido = tarjeta.Recibido;
                    ta.Rechazado = tarjeta.Rechazado;
                    ta.idEstablecimiento = tarjeta.idEstablecimiento;
                    ta.Estado = 1;
                    listaTarjetasSinRegistrar.Add(ta);
                }

            }
            if (listaTarjetasSinRegistrar.Count > 0)
            {
                da.RegitrarTarjetas(listaTarjetasSinRegistrar);
            }

        }

        public bool ValidarRangoTarjetas(string inicio, string fin)
        {
            Tarjeta primera = da.ObtenerTarjeta(inicio);
            Tarjeta ultima = da.ObtenerTarjeta(fin);

            if (primera != null || ultima != null)
            {
                return false;
            }
            return true;
        }

        public List<Vista_ListaTarjeta> ObtenerListaTarjetas(int id, int indice)
        {
            /*
             * indice = 1 : el parametro es idEnvio
             * indice = 2 : el parametro es idRecepcion
             */
            return da.ObtenerListaTarjetas(id, indice);
        }

        public void ActualizarEstadoTarjetas(int idEnvio, int estado)
        {
            da.ActualizarEstadoTarjetas(idEnvio, estado);
        }
    }
}
