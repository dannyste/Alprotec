using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class ClienteDAL
    {
        public IEnumerable filtrarClientes(int opcion, long idClienteCatalogo, String filtro, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    if (opcion == 1)
                    {
                        var query = (
                                        from c in db.Cliente
                                        where (c.idDocumentoCatalog == 7L && c.numeroDocumento.Contains(filtro)) && (idClienteCatalogo != 0L ? c.idClienteCatalogo == idClienteCatalogo : (c.idClienteCatalogo == 5L || c.idClienteCatalogo == 6L))
                                        select new
                                        {
                                            Id = c.idCliente,
                                            NoDocumento = c.numeroDocumento,
                                            Nombre = c.nombre,
                                        }
                                    ).ToList();
                        return query;
                    }
                    if (opcion == 2)
                    {
                        var query = (
                                        from c in db.Cliente
                                        where (c.idDocumentoCatalog == 9L && c.numeroDocumento.Contains(filtro)) && (idClienteCatalogo != 0L ? c.idClienteCatalogo == idClienteCatalogo : (c.idClienteCatalogo == 5L || c.idClienteCatalogo == 6L))
                                        select new
                                        {
                                            Id = c.idCliente,
                                            NoDocumento = c.numeroDocumento,
                                            Nombre = c.nombre,
                                        }
                                    ).ToList();
                        return query;
                    }
                    else
                    {
                        var query = (
                                        from c in db.Cliente
                                        where c.nombre.Contains(filtro) && (idClienteCatalogo != 0L ? c.idClienteCatalogo == idClienteCatalogo : (c.idClienteCatalogo == 5L || c.idClienteCatalogo == 6L))
                                        select new
                                        {
                                            Id = c.idCliente,
                                            NoDocumento = c.numeroDocumento,
                                            Nombre = c.nombre,
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

        public Cliente obtenerCliente(long idCliente, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from c in db.Cliente
                                    where c.idCliente == idCliente
                                    select c
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

        public void insertarCliente(Cliente cliente, List<Contacto> contactos, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    db.Cliente.Add(cliente);
                    db.SaveChanges();
                    foreach (Contacto contacto in contactos)
                    {
                        contacto.idCliente = cliente.idCliente;
                        db.Contacto.Add(contacto);
                        db.SaveChanges();
                    }
                    mensaje = "Cliente registado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void actualizarCliente(Cliente cliente, List<Contacto> contactos, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var actualizarCliente = (
                                                from c in db.Cliente
                                                where c.idCliente == cliente.idCliente
                                                select c
                                            ).Single();
                    actualizarCliente.codigo = cliente.codigo;
                    actualizarCliente.nombre = cliente.nombre;
                    actualizarCliente.direccion = cliente.direccion;
                    actualizarCliente.telefono = cliente.telefono;
                    actualizarCliente.idCiudadCatalogo = cliente.idCiudadCatalogo;
                    actualizarCliente.idClienteCatalogo = cliente.idClienteCatalogo;
                    actualizarCliente.modificadoPor = cliente.modificadoPor;
                    actualizarCliente.fechaModificacion = cliente.fechaModificacion;
                    db.SaveChanges();
                    foreach (Contacto contacto in contactos)
                    {
                        var queryOne = (
                                           from c in db.Contacto
                                           where c.idContacto == contacto.idContacto
                                           select c
                                       );
                        if (queryOne.Count() > 0)
                        {
                            Contacto actualizarContacto = queryOne.Single();
                            actualizarContacto.nombre = contacto.nombre;
                            actualizarContacto.cargo = contacto.cargo;
                            actualizarContacto.telefono = contacto.telefono;
                            actualizarContacto.movil = contacto.movil;
                            actualizarContacto.correoElectronico = contacto.correoElectronico;
                            actualizarContacto.observaciones = contacto.observaciones;
                            actualizarContacto.modificadoPor = contacto.modificadoPor;
                            actualizarContacto.fechaModificacion = contacto.fechaModificacion;
                            db.SaveChanges();
                        }
                        else
                        {
                            contacto.idCliente = cliente.idCliente;
                            db.Contacto.Add(contacto);
                            db.SaveChanges();
                        }
                    }
                    var queryTwo = (
                                       from c in db.Contacto
                                       where c.idCliente == cliente.idCliente
                                       select c
                                   ).ToList();
                    var results = ((List<Contacto>)queryTwo).Except(contactos);
                    mensaje = "Cliente actualizado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public void eliminarCliente(long idCliente, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var cliente = (
                                    from c in db.Cliente
                                    where c.idCliente == idCliente
                                    select c
                                  ).Single();
                    db.Cliente.Remove(cliente);
                    db.SaveChanges();
                    mensaje = "Cliente eliminado exitosamente.";
                }
                catch (Exception ex)
                {
                    error = true;
                    mensaje = ex.Message;
                }
            }
        }

        public String secuenciaCodigoCliente(ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    var query = (
                                    from c in db.Cliente
                                    where c.idClienteCatalogo == 5L
                                    select c
                                ).Count();
                    return Convert.ToString(query + 1);
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