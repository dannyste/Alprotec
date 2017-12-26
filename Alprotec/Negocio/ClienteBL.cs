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
    public class ClienteBL
    {
        public static IEnumerable filtrarClientes(int opcion, long idClienteCatalogo, String filtro, ref bool error, ref String mensaje)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.filtrarClientes(opcion, idClienteCatalogo, filtro, ref error, ref mensaje);
        }

        public static Cliente obtenerCliente(long idCliente, ref bool error, ref String mensaje)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.obtenerCliente(idCliente, ref error, ref mensaje);
        }

        public static void insertarCliente(Cliente cliente, List<Contacto> contactos, ref bool error, ref String mensaje)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.insertarCliente(cliente, contactos, ref error, ref mensaje);
        }

        public static void actualizarCliente(Cliente cliente, List<Contacto> contactos, ref bool error, ref String mensaje)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.actualizarCliente(cliente, contactos, ref error, ref mensaje);
        }

        public static void eliminarCliente(long idCliente, ref bool error, ref String mensaje)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.eliminarCliente(idCliente, ref error, ref mensaje);
        }

        public static String secuenciaCodigoCliente(ref bool error, ref String mensaje)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.secuenciaCodigoCliente(ref error, ref mensaje);
        }
    }
}