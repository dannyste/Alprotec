using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class UsuarioBL
    {
        public static Boolean iniciarSesion(Usuario usuario, ref bool error, ref String mensaje)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.iniciarSesion(usuario, ref error, ref mensaje);
        }

        public static Usuario obtenerUsuario(Usuario usuario, ref bool error, ref String mensaje)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.obtenerUsuario(usuario, ref error, ref mensaje);
        }
    }
}