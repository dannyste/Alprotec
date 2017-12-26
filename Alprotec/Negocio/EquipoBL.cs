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
    }
}
