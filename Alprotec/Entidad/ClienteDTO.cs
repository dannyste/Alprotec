using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClienteDTO
    {
        public Cliente cliente { get; set; }
        public List<Contacto> contactos { get; set; }
    }
}
