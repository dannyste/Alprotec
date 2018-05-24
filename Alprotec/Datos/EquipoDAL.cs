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
        public IEnumerable filtrarEquipos(String cliente, double potenciaHP, double potenciakW, long idMarca, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from e in db.Equipo 
                                    join c in db.Cliente on e.idEquipo equals c.idCliente
                                    join modelo in db.Catalogo on e.idModeloCatalogo equals modelo.idCatalogo
                                    join marca in db.Catalogo on modelo.idPadre equals marca.idCatalogo
                                    where c.nombre.Contains(cliente) && ((e.potenciaHP == potenciaHP || potenciaHP == 0) || (e.potenciakW == potenciakW || potenciakW == 0)) && (marca.idCatalogo == idMarca || idMarca == 0)
                                    select new
                                    {
                                        Id = e.idEquipo,
                                        Cliente = c.nombre,
                                        CodigoInterno = e.codigoInterno,
                                        ClaseMaquina = e.claseMaquina,
                                        NumeroSerie = e.numeroSerie,
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

        public Equipo obtenerEquipo(long idEquipo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from e in db.Equipo
                                    join c in db.Cliente on e.idEquipo equals c.idCliente
                                    join m in db.Catalogo on e.idModeloCatalogo equals m.idCatalogo
                                    where e.idEquipo == idEquipo
                                    select e
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
                    var equipo = (
                                    from e in db.Equipo
                                    where e.idEquipo == idEquipo
                                    select e
                                 ).Single();
                    db.Equipo.Remove(equipo);
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
