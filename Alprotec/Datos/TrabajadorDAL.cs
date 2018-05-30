using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class TrabajadorDAL
    {
        public IEnumerable filtrarTrabajadores(int opcion, String filtro, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    if (opcion == 1)
                    {
                        var query = (
                                        from trabajador in db.Trabajador
                                        where trabajador.cedulaIdentidad.Contains(filtro)
                                        select new
                                        {
                                            Id = trabajador.idTrabajador,
                                            Cedula = trabajador.cedulaIdentidad,
                                            Nombre = trabajador.nombre,
                                            Cargo = trabajador.cargo,
                                        }
                                    ).ToList();
                        return query;
                    }
                    if (opcion == 2)
                    {
                        var query = (
                                        from trabajador in db.Trabajador
                                        where trabajador.nombre.Contains(filtro)
                                        select new
                                        {
                                            Id = trabajador.idTrabajador,
                                            Cedula = trabajador.cedulaIdentidad,
                                            Nombre = trabajador.nombre,
                                            Cargo = trabajador.cargo,
                                        }
                                    ).ToList();
                        return query;
                    }
                    else
                    {
                        var query = (
                                        from trabajador in db.Trabajador
                                        where trabajador.cargo.Contains(filtro)
                                        select new
                                        {
                                            Id = trabajador.idTrabajador,
                                            Cedula = trabajador.cedulaIdentidad,
                                            Nombre = trabajador.nombre,
                                            Cargo = trabajador.cargo,
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

        public Trabajador obtenerTrabajador(long idTrabajador, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from trabajador in db.Trabajador
                                    where trabajador.idTrabajador == idTrabajador
                                    select trabajador
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

        public void insertarTrabajador(Trabajador trabajador, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    db.Trabajador.Add(trabajador);
                    db.SaveChanges();
                    mensaje = "Trabajador registado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void actualizarTrabajador(Trabajador trabajador, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var actualizarTrabajador = (
                                                from t in db.Trabajador
                                                where t.idTrabajador == trabajador.idTrabajador
                                                select t
                                            ).Single();
                    actualizarTrabajador.cedulaIdentidad = trabajador.cedulaIdentidad;
                    actualizarTrabajador.nombre = trabajador.nombre;
                    actualizarTrabajador.cargo = trabajador.cargo;
                    actualizarTrabajador.telefono = trabajador.telefono;
                    actualizarTrabajador.movil = trabajador.movil;
                    actualizarTrabajador.direccion = trabajador.direccion;
                    actualizarTrabajador.modificadoPor = trabajador.modificadoPor;
                    actualizarTrabajador.fechaModificacion = trabajador.fechaModificacion;
                    db.SaveChanges();
                    mensaje = "Trabajador actualizado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void eliminarTrabajador(long idTrabajador, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var actualizarTrabajador = (
                                                    from trabajador in db.Trabajador
                                                    where trabajador.idTrabajador == idTrabajador
                                                    select trabajador
                                               ).Single();
                    actualizarTrabajador.estado = false;
                    db.SaveChanges();
                    mensaje = "Trabajador eliminado exitosamente.";
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
