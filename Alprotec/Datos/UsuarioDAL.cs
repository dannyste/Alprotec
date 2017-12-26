using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class UsuarioDAL
    {
        public Boolean iniciarSesion(Usuario usuario, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from u in db.Usuario
                                    where u.usuario1.ToLower() == usuario.usuario1.ToLower() && u.contraseña == usuario.contraseña
                                    select u
                                ).Any();
                    return query;
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
                return false;
            }
        }

        public Usuario obtenerUsuario(Usuario usuario, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from u in db.Usuario
                                    where u.usuario1.ToLower() == usuario.usuario1.ToLower() && u.contraseña == usuario.contraseña
                                    select u
                                ).First();
                    return query;
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
                return null;
            }
        }
    }
}