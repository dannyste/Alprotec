//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.Contacto = new HashSet<Contacto>();
            this.Equipo = new HashSet<Equipo>();
            this.RecepcionEquipo = new HashSet<RecepcionEquipo>();
        }
    
        public long idCliente { get; set; }
        public string codigo { get; set; }
        public string numeroDocumento { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public long idTipoClienteCatalogo { get; set; }
        public long idDocumentoCatalog { get; set; }
        public long idCiudadCatalogo { get; set; }
        public bool estado { get; set; }
        public long creadoPor { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public long modificadoPor { get; set; }
        public System.DateTime fechaModificacion { get; set; }
    
        public virtual Catalogo Catalogo { get; set; }
        public virtual Catalogo Catalogo1 { get; set; }
        public virtual Catalogo Catalogo2 { get; set; }
        public virtual ICollection<Contacto> Contacto { get; set; }
        public virtual ICollection<Equipo> Equipo { get; set; }
        public virtual ICollection<RecepcionEquipo> RecepcionEquipo { get; set; }
    }
}
