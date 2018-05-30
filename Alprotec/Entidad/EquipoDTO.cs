using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EquipoDTO
    {
        public Equipo equipo { get; set; }
        public Cliente cliente { get; set; }
        public Catalogo marca { get; set; }
        public Catalogo modelo { get; set; }
    }
}
