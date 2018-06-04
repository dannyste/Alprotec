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
        public IEnumerable filtrarRecepcionEquipos(DateTime fechaInicial, DateTime fechaFinal, String nombreCliente, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from recepcionEquipo in db.RecepcionEquipo
                                    join cliente in db.Cliente on recepcionEquipo.idCliente equals cliente.idCliente
                                    join equipo in db.Equipo on recepcionEquipo.idEquipo equals equipo.idEquipo
                                    where recepcionEquipo.fechaCreacion >= fechaInicial && recepcionEquipo.fechaCreacion < fechaFinal && cliente.nombre.Contains(nombreCliente) && recepcionEquipo.estado
                                    select new
                                    {
                                        Id = recepcionEquipo.idRecepcionEquipo,
                                        Cliente = cliente.nombre,
                                        Equipo = equipo.numeroSerie,
                                    }
                                ).ToList();
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

        public RecepcionEquipoDTO obtenerRecepcionEquipo(long idRecepcionEquipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    RecepcionEquipoDTO recepcionEquipoDTO = (
                                                                from recepcionEquipo in db.RecepcionEquipo
                                                                where recepcionEquipo.idRecepcionEquipo == idRecepcionEquipo && recepcionEquipo.estado
                                                                select new RecepcionEquipoDTO 
                                                                { 
                                                                    recepcionEquipo = recepcionEquipo,
                                                                    cliente = (
                                                                                  from cliente in db.Cliente
                                                                                  where recepcionEquipo.idCliente == cliente.idCliente
                                                                                  select cliente
                                                                              ).FirstOrDefault(),
                                                                    equipo = (
                                                                                 from equipo in db.Equipo
                                                                                 where recepcionEquipo.idCliente == equipo.idEquipo
                                                                                 select equipo
                                                                             ).FirstOrDefault(),
                                                                }
                                                            ).Single();
                    return recepcionEquipoDTO;
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

        public String secuenciaNumeroRecepcionEquipo(ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var numero = (
                                    from recepcionEquipo in db.RecepcionEquipo
                                    select recepcionEquipo.numero
                                 ).DefaultIfEmpty().Max();
                    return Convert.ToString(numero + 1);
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
