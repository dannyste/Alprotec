using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Constantes
    {
        public enum Catalogo : long 
        { 
            Pais = 1L,
            Estado = 2L,
            Ciudad = 3L,
            TipoCliente = 4L,
            TipoDocumento = 5L,
            Marca = 6L,
            Modelo = 7L
        }
    }
}
