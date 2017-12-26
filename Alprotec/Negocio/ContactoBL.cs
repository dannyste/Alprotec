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
    public class ContactoBL
    {
        public static List<Contacto> obtenerContactos(long idCliente, ref bool error, ref String mensaje)
        {
            ContactoDAL contactoDAL = new ContactoDAL();
            return contactoDAL.obtenerContactos(idCliente, ref error, ref mensaje);
        }
    }
}