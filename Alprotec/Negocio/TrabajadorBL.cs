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
    public class TrabajadorBL
    {
        public static IEnumerable filtrarTrabajadores(int opcion, String filtro, ref bool error, ref String mensaje)
        {
            TrabajadorDAL trabajadorDAL = new TrabajadorDAL();
            return trabajadorDAL.filtrarTrabajadores(opcion, filtro, ref error, ref mensaje);
        }

        public static Trabajador obtenerTrabajador(long idTrabajador, ref bool error, ref String mensaje)
        {
            TrabajadorDAL trabajadorDAL = new TrabajadorDAL();
            return trabajadorDAL.obtenerTrabajador(idTrabajador, ref error, ref mensaje);
        }

        public static void insertarTrabajador(Trabajador trabajador, ref bool error, ref String mensaje)
        {
            TrabajadorDAL trabajadorDAL = new TrabajadorDAL();
            trabajadorDAL.insertarTrabajador(trabajador, ref error, ref mensaje);
        }

        public static void actualizarTrabajador(Trabajador trabajador, ref bool error, ref String mensaje)
        {
            TrabajadorDAL trabajadorDAL = new TrabajadorDAL();
            trabajadorDAL.actualizarTrabajador(trabajador, ref error, ref mensaje);
        }

        public static void eliminarTrabajador(long idTrabajador, ref bool error, ref String mensaje)
        {
            TrabajadorDAL trabajadorDAL = new TrabajadorDAL();
            trabajadorDAL.eliminarTrabajador(idTrabajador, ref error, ref mensaje);
        }
    }
}
