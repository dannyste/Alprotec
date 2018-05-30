using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RecepcionEquipoDTO
    {
        public RecepcionEquipo recepcionEquipo { get; set; }
        public Cliente cliente { get; set; }
        public Equipo equipo { get; set; }
    }
}
