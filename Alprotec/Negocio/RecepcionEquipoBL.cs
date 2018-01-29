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
        public static IEnumerable filtrarRecepcionEquipos(int opcion, String filtro, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL equipoDAL = new RecepcionEquipoDAL();
            return equipoDAL.filtrarRecepcionEquipos(opcion, filtro, ref error, ref mensaje);
        }

        public static RecepcionEquipo obtenerRecepcionEquipo(long idRecepcionEquipo, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL equipoDAL = new RecepcionEquipoDAL();
            return equipoDAL.obtenerRecepcionEquipo(idRecepcionEquipo, ref error, ref mensaje);
        }

        public static void insertarRecepcionEquipo(RecepcionEquipo equipo, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL equipoDAL = new RecepcionEquipoDAL();
            equipoDAL.insertarRecepcionEquipo(equipo, ref error, ref mensaje);
        }

        public static void actualizarRecepcionEquipo(RecepcionEquipo equipo, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL equipoDAL = new RecepcionEquipoDAL();
            equipoDAL.actualizarRecepcionEquipo(equipo, ref error, ref mensaje);
        }

        public static void eliminarRecepcionEquipo(long idRecepcionEquipo, ref bool error, ref String mensaje)
        {
            RecepcionEquipoDAL equipoDAL = new RecepcionEquipoDAL();
            equipoDAL.eliminarRecepcionEquipo(idRecepcionEquipo, ref error, ref mensaje);
        }
    }
}