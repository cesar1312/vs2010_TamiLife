using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DA;

namespace BC
{
    public class RecepcionBC
    {
        RecepcionDA da = new RecepcionDA();
        public Recepcion RegistrarRecepcion(Recepcion recepcion)
        {
            return da.RegistrarRecepcion(recepcion);
        }

        public Recepcion ObtenerRecepcion(int idRecepcion)
        {
            return da.ObtenerRecepcion(idRecepcion);
        }
        public void ActualizarRecepcion(Recepcion recepcion)
        {
            da.ActualizarRecepcion(recepcion);
        }

        public List<Vista_ListaRecepcione> ObtenerRecepciones(int idTipoEstablecimiento, int idEstablecimiento, int anho, int mes)
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
            return da.ObtenerRecepciones(idTipoEstablecimiento, idEstablecimiento, anho, mes, filtro);
        }
    }
}
