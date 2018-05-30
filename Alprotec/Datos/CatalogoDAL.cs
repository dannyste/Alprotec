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
                                    from marca in db.Catalogo
                                    where marca.valor.Contains(filtro) && marca.idTipoCatalogo == (long)Constantes.Catalogo.Marca
                                    select new
                                    {
                                        Id = marca.idCatalogo,
                                        Nombre = marca.valor,
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
                                    from modelo in db.Catalogo
                                    join marca in db.Catalogo on modelo.idPadre equals marca.idCatalogo
                                    where modelo.valor.Contains(filtro) && (idPadre != 0L ? modelo.idPadre == idPadre : (modelo.idPadre != 0L)) && modelo.idTipoCatalogo == (long)Constantes.Catalogo.Modelo
                                    select new
                                    {
                                        Id = modelo.idCatalogo,
                                        Modelo = modelo.valor,
                                        Marca = marca.valor,
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
                                    from catalogo in db.Catalogo
                                    where catalogo.idCatalogo == idCatalogo
                                    select catalogo
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
                                    from catalogo in db.Catalogo
                                    where catalogo.idTipoCatalogo == idTipoCatalogo
                                    select catalogo
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
                    var actualizarCatalogo = (
                                    from catalogo in db.Catalogo
                                    where catalogo.idCatalogo == idCatalogo
                                    select catalogo
                                  ).Single();
                    actualizarCatalogo.estado = false;
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