using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class RecepcionEquipoBL
    {
        public static IEnumerable filtrarRecepcionEquipos(DateTime fechaInicial, DateTime fechaFinal, String cliente, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL recepcionEquipoDAL = new RecepcionEquipoDAL();
            return recepcionEquipoDAL.filtrarRecepcionEquipos(fechaInicial, fechaFinal, cliente, ref error, ref mensaje);
        }

        public static RecepcionEquipoDTO obtenerRecepcionEquipo(long idRecepcionEquipo, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL recepcionEquipoDAL = new RecepcionEquipoDAL();
            return recepcionEquipoDAL.obtenerRecepcionEquipo(idRecepcionEquipo, ref error, ref mensaje);
        }

        public static void insertarRecepcionEquipo(RecepcionEquipo equipo, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL recepcionEquipoDAL = new RecepcionEquipoDAL();
            recepcionEquipoDAL.insertarRecepcionEquipo(equipo, ref error, ref mensaje);
        }

        public static void actualizarRecepcionEquipo(RecepcionEquipo equipo, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL recepcionEquipoDAL = new RecepcionEquipoDAL();
            recepcionEquipoDAL.actualizarRecepcionEquipo(equipo, ref error, ref mensaje);
        }

        public static void eliminarRecepcionEquipo(long idRecepcionEquipo, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL recepcionEquipoDAL = new RecepcionEquipoDAL();
            recepcionEquipoDAL.eliminarRecepcionEquipo(idRecepcionEquipo, ref error, ref mensaje);
        }

        public static String secuenciaNumeroRecepcionEquipo(ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL recepcionEquipoDAL = new RecepcionEquipoDAL();
            return recepcionEquipoDAL.secuenciaNumeroRecepcionEquipo(ref error, ref mensaje);
        }

    }
}