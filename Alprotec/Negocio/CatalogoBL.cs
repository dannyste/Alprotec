using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class CatalogoBL
    {
        public static IEnumerable filtrarMarcas(String filtro, ref bool error, ref String mensaje)
        {
            CatalogoDAL catalogoDAL = new CatalogoDAL();
            return catalogoDAL.filtrarMarcas(filtro, ref error, ref mensaje);
        }

        public static IEnumerable filtrarModelos(long idPadre, String filtro, ref bool error, ref String mensaje)
        {
            CatalogoDAL catalogoDAL = new CatalogoDAL();
            return catalogoDAL.filtrarModelos(idPadre, filtro, ref error, ref mensaje);
        }

        public static Catalogo obtenerCatalogo(long idCatalogo, ref bool error, ref String mensaje)
        {
            CatalogoDAL catalogoDAL = new CatalogoDAL();
            return catalogoDAL.obtenerCatalogo(idCatalogo, ref error, ref mensaje);
        }

        public static List<Catalogo> obtenerTipoCatalogo(long idTipoCatalogo, ref bool error, ref String mensaje)
        {
            CatalogoDAL catalogoDAL = new CatalogoDAL();
            return catalogoDAL.obtenerTipoCatalogo(idTipoCatalogo, ref error, ref mensaje);
        }

        public static void insertarCatalogo(Catalogo catalogo, ref bool error, ref String mensaje)
        {
            CatalogoDAL catalogoDAL = new CatalogoDAL();
            catalogoDAL.insertarCatalogo(catalogo, ref error, ref mensaje);
        }

        public static void actualizarCatalogo(Catalogo catalogo, ref bool error, ref String mensaje)
        {
            CatalogoDAL catalogoDAL = new CatalogoDAL();
            catalogoDAL.actualizarCatalogo(catalogo, ref error, ref mensaje);
        }

        public static void eliminarCatalogo(long idCatalogo, ref bool error, ref String mensaje)
        {
            CatalogoDAL catalogoDAL = new CatalogoDAL();
            catalogoDAL.eliminarCatalogo(idCatalogo, ref error, ref mensaje);
        }
    }
}