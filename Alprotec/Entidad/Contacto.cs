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
    
    public partial class Contacto
    {
        public long idContacto { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public string telefono { get; set; }
        public string movil { get; set; }
        public string correoElectronico { get; set; }
        public string observaciones { get; set; }
        public long idCliente { get; set; }
        public bool estado { get; set; }
        public long creadoPor { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public long modificadoPor { get; set; }
        public System.DateTime fechaModificacion { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
