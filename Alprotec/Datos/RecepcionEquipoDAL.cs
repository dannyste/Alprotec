using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Utilidades;

namespace Datos
{
    public class RecepcionEquipoDAL
    {
        public IEnumerable filtrarRecepcionEquipos(int opcion, String filtro, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    if (opcion == 1)
                    {
                        var query = (
                                        from re in db.RecepcionEquipo
                                        select new
                                        {
                                            Id = re.idRecepcionEquipo,
                                        }
                                    ).ToList();
                        return query;
                    }
                    if (opcion == 2)
                    {
                        var query = (
                                        from re in db.RecepcionEquipo
                                        select new
                                        {
                                            Id = re.idRecepcionEquipo,
                                        }
                                    ).ToList();
                        return query;
                    }
                    else
                    {
                        var query = (
                                        from re in db.RecepcionEquipo
                                        select new
                                        {
                                            Id = re.idRecepcionEquipo,
                                        }
                                    ).ToList();
                        return query;
                    }
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
                return null;
            }
        }

        public RecepcionEquipo obtenerRecepcionEquipo(long idRecepcionEquipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from re in db.RecepcionEquipo
                                    where re.idRecepcionEquipo == idRecepcionEquipo
                                    select re
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

        public void insertarRecepcionEquipo(RecepcionEquipo recepcionEquipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    db.RecepcionEquipo.Add(recepcionEquipo);
                    db.SaveChanges();
                    mensaje = "Recepción de equipo registado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void actualizarRecepcionEquipo(RecepcionEquipo recepcionEquipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var actualizarRecepcionEquipo = (
                                                        from re in db.RecepcionEquipo
                                                        where re.idRecepcionEquipo == recepcionEquipo.idRecepcionEquipo
                                                        select re
                                                    ).Single();
                    actualizarRecepcionEquipo.modificadoPor = Globales.UsuarioGlobal.idUsuario;
                    actualizarRecepcionEquipo.fechaModificacion = DateTime.Now;
                    db.SaveChanges();
                    mensaje = "Recepcion de equipo actualizado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void eliminarRecepcionEquipo(long idRecepcionEquipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var recepcionEquipo = (
                                    from re in db.RecepcionEquipo
                                    where re.idRecepcionEquipo == idRecepcionEquipo
                                    select re
                                  ).Single();
                    db.RecepcionEquipo.Remove(recepcionEquipo);
                    db.SaveChanges();
                    mensaje = "Recepcion de equipo eliminado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }
    }
}
