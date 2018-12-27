using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using BE;

namespace BC
{
    public class EnvioBC
    {
        EnvioDA da = new EnvioDA();

        public Envio RegistrarEnvio(Envio envio)
        {
            envio.Estado = 1;
            envio.TieneRecepciones = false;
            envio = da.RegistrarEnvio(envio);
            
            int inicio = int.Parse(envio.CodigoInicial);
            int fin = int.Parse(envio.CodigoFinal);
            var listaTarjetas = new List<Tarjeta>();
            
            for (int i = inicio; i <= fin; i++)
            {
                Tarjeta tarjeta = new Tarjeta();
                tarjeta.idEnvio = envio.idEnvio;
                tarjeta.CodigoMuestra = i.ToString();
                tarjeta.idEstablecimiento = envio.idEstablecimiento;
                tarjeta.Estado = 1;
                tarjeta.Recibido = false;
                tarjeta.Rechazado = false;
                listaTarjetas.Add(tarjeta);
            }
            
            var tarjetaBC = new TarjetaBC(); 
            tarjetaBC.RegitrarTarjetas(listaTarjetas);
            return envio;
        }

        public void ActualizarEnvio(Envio envio)
        {
            da.ActualizarEnvio(envio);
        }

        public List<Vista_ListaEnvio> ObtenerEnvios()
        {
            return da.ObtenerEnvios(0);
        }

        public List<Vista_ListaEnvio> ObtenerEnvios(int idTipoEstablecimiento, int idEstablecimiento, int anho, int mes)
        {
            int filtro = 0;

            if (idTipoEstablecimiento != 0)
            {
                //Se selecciono un tipo de Establecimiento
                if (idEstablecimiento != 0)
                {
                    //Se selecciono un establecimiento
                    if (anho != 0)
                    {
                        //Se selecciono un año
                        if (mes != 0)
                        {
                            //Se selecciono un mes
                            filtro = 1;
                        }
                        else
                        {
                            //tipo, establecimiento y año
                            filtro = 2;
                        }
                    }
                    else
                    {
                        // tipo y establecimiento
                        filtro = 3;
                    }
                }
                else
                {
                    if (anho != 0)
                    {
                        //Se selecciono un año
                        if (mes != 0)
                        {
                            //Se selecciono un mes
                            filtro = 4;
                        }
                        else
                        {
                            //tipo establecimiento y año
                            filtro = 5;
                        }

                    }
                    else
                    {
                        //solo tipo de establecimiento
                        filtro = 6;
                    }
                }
            }
            else
            {
                if (anho != 0)
                {
                    //Se selecciono un año
                    if (mes != 0)
                    {
                        // año y mes
                        filtro = 7;
                    }
                    else
                    {
                        //año
                        filtro = 8;
                    }

                }
            }
            //return da.ObtenerEnvios(100);
            return da.ObtenerEnvios(idTipoEstablecimiento, idEstablecimiento, anho, mes, filtro);
        }

        public Envio ObtenerEnvio(int idEnvio)
        {
            return da.ObtenerEnvio(idEnvio);
        }
    }
}
