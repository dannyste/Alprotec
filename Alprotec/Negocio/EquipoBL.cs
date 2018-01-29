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
    public class EquipoBL
    {
        public static IEnumerable filtrarEquipos(int opcion, String filtro, ref bool error, ref String mensaje)
        {
            EquipoDAL equipoDAL = new EquipoDAL();
            return equipoDAL.filtrarEquipos(opcion, filtro, ref error, ref mensaje);
        }

        public static Equipo obtenerEquipo(long idEquipo, ref bool error, ref String mensaje)
        {
            EquipoDAL equipoDAL = new EquipoDAL();
            return equipoDAL.obtenerEquipo(idEquipo, ref error, ref mensaje);
        }

        public static void insertarEquipo(Equipo equipo, ref bool error, ref String mensaje)
        {
            EquipoDAL equipoDAL = new EquipoDAL();
            equipoDAL.insertarEquipo(equipo, ref error, ref mensaje);
        }

        public static void actualizarEquipo(Equipo equipo, ref bool error, ref String mensaje)
        {
            EquipoDAL equipoDAL = new EquipoDAL();
            equipoDAL.actualizarEquipo(equipo, ref error, ref mensaje);
        }

        public static void eliminarEquipo(long idEquipo, ref bool error, ref String mensaje)
        {
            EquipoDAL equipoDAL = new EquipoDAL();
            equipoDAL.eliminarEquipo(idEquipo, ref error, ref mensaje);
        }
    }
}
