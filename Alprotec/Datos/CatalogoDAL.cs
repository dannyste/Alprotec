using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class CatalogoDAL
    {
        public IEnumerable filtrarMarcas(String filtro, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from c in db.Catalogo
                                    where c.valor.Contains(filtro) && c.idTipoCatalogo == 5L
                                    select new
                                    {
                                        Id = c.idCatalogo,
                                        Nombre = c.valor,
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

        public IEnumerable filtrarModelos(long idPadre, String filtro, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from c in db.Catalogo
                                    join p in db.Catalogo on c.idPadre equals p.idCatalogo
                                    where c.valor.Contains(filtro) && (c.idPadre != 0L ? c.idPadre == idPadre : (c.idPadre != 0L)) && c.idTipoCatalogo == 6L
                                    select new
                                    {
                                        Id = c.idCatalogo,
                                        Modelo = c.valor,
                                        Marca = p.valor,
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

        public Catalogo obtenerCatalogo(long idCatalogo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from c in db.Catalogo
                                    where c.idCatalogo == idCatalogo
                                    select c
                                ).Single();
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

        public List<Catalogo> obtenerTipoCatalogo(long idTipoCatalogo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from c in db.Catalogo
                                    where c.idTipoCatalogo == idTipoCatalogo
                                    select c
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

        public void insertarCatalogo(Catalogo catalogo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    db.Catalogo.Add(catalogo);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void actualizarCatalogo(Catalogo catalogo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var actualizarCatalogo = (
                                                from c in db.Catalogo
                                                where c.idCatalogo == catalogo.idCatalogo
                                                select c
                                            ).Single();
                    actualizarCatalogo.valor = catalogo.valor;
                    actualizarCatalogo.idPadre = catalogo.idPadre;
                    actualizarCatalogo.idTipoCatalogo = catalogo.idTipoCatalogo;
                    actualizarCatalogo.fechaModificacion = DateTime.Now;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void eliminarCatalogo(long idCatalogo, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var catalogo = (
                                    from c in db.Catalogo
                                    where c.idCatalogo == idCatalogo
                                    select c
                                  ).Single();
                    db.Catalogo.Remove(catalogo);
                    db.SaveChanges();
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