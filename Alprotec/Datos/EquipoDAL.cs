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
    public class EquipoDAL
    {
        public IEnumerable filtrarEquipos(String nombreCliente, double potenciaHP, double potenciakW, long idMarca, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from equipo in db.Equipo 
                                    join cliente in db.Cliente on equipo.idEquipo equals cliente.idCliente
                                    join modelo in db.Catalogo on equipo.idModeloCatalogo equals modelo.idCatalogo
                                    join marca in db.Catalogo on modelo.idPadre equals marca.idCatalogo
                                    where cliente.nombre.Contains(nombreCliente) && ((equipo.potenciaHP == potenciaHP || potenciaHP == 0) || (equipo.potenciakW == potenciakW || potenciakW == 0)) && (marca.idCatalogo == idMarca || idMarca == 0) && equipo.estado
                                    select new
                                    {
                                        Id = equipo.idEquipo,
                                        Cliente = cliente.nombre,
                                        CodigoInterno = equipo.codigoInterno,
                                        ClaseMaquina = equipo.claseMaquina,
                                        NumeroSerie = equipo.numeroSerie,
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

        public EquipoDTO obtenerEquipo(long idEquipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    EquipoDTO equipoDTO = (
                                              from equipo in db.Equipo
                                              where equipo.idEquipo == idEquipo && equipo.estado
                                              select new EquipoDTO
                                              {
                                                  equipo = equipo,
                                                  cliente = (
                                                                from cliente in db.Cliente
                                                                where equipo.idCliente == cliente.idCliente && cliente.estado
                                                                select cliente
                                                            ).FirstOrDefault(),
                                                  modelo = (
                                                               from modelo in db.Catalogo
                                                               where equipo.idModeloCatalogo == modelo.idCatalogo
                                                               select modelo
                                                           ).FirstOrDefault(),
                                                  marca = (
                                                              from modelo in db.Catalogo
                                                              join marca in db.Catalogo on modelo.idPadre equals marca.idCatalogo
                                                              where equipo.idModeloCatalogo == modelo.idCatalogo
                                                              select marca
                                                          ).FirstOrDefault(),
                                              }
                                          ).Single();
                    return equipoDTO;
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
                return null;
            }
        }

        public void insertarEquipo(Equipo equipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    db.Equipo.Add(equipo);
                    db.SaveChanges();
                    mensaje = "Equipo registado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void actualizarEquipo(Equipo equipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var actualizarEquipo = (
                                                from e in db.Equipo
                                                where e.idEquipo == equipo.idEquipo
                                                select e
                                           ).Single();
                    actualizarEquipo.codigoInterno = equipo.codigoInterno;
                    actualizarEquipo.claseMaquina = equipo.claseMaquina;
                    actualizarEquipo.numeroSerie = equipo.numeroSerie;
                    actualizarEquipo.rpm = equipo.rpm;
                    actualizarEquipo.amp = equipo.amp;
                    actualizarEquipo.numeroInventarioCliente = equipo.numeroInventarioCliente;
                    actualizarEquipo.potenciaHP = equipo.potenciaHP;
                    actualizarEquipo.claseAislamiento = equipo.claseAislamiento;
                    actualizarEquipo.designacionNema = equipo.designacionNema;
                    actualizarEquipo.frame = equipo.frame;
                    actualizarEquipo.voltaje = equipo.voltaje;
                    actualizarEquipo.factorServicio = equipo.factorServicio;
                    actualizarEquipo.idCliente = equipo.idCliente;
                    actualizarEquipo.idModeloCatalogo = equipo.idModeloCatalogo;
                    actualizarEquipo.modificadoPor = Globales.UsuarioGlobal.idUsuario;
                    actualizarEquipo.fechaModificacion = DateTime.Now;
                    db.SaveChanges();
                    mensaje = "Equipo actualizado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void eliminarEquipo(long idEquipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var actualizarEquipo = (
                                              from equipo in db.Equipo
                                              where equipo.idEquipo == idEquipo
                                              select equipo
                                           ).Single();
                    actualizarEquipo.estado = false;
                    db.SaveChanges();
                    mensaje = "Equipo eliminado exitosamente.";
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
