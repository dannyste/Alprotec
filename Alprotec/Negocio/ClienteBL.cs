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
        public static IEnumerable filtrarClientes(String numeroDocumento, long idTipoDocumento, String nombreCliente, ref bool error, ref String mensaje)
        {
            ClienteDAL clienteDAL = new ClienteDAL();
            return clienteDAL.filtrarClientes(numeroDocumento, idTipoDocumento, nombreCliente, ref error, ref mensaje);
        }

        public static ClienteDTO obtenerCliente(long idCliente, ref bool error, ref String mensaje)
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