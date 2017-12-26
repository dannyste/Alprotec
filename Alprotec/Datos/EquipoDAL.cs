using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class EquipoDAL
    {
        public IEnumerable filtrarEquipos(int opcion, String filtro, ref bool error, ref String mensaje)
        {
            error = false;
            using (AlprotecdbEntities db = new AlprotecdbEntities())
            {
                try
                {
                    /*if (opcion == 1)
                    {
                        var query = (
                                        from c in db.Equipo
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
                    }*/
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
