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
    
    public partial class PruebaElectricaInicial
    {
        public long idPruebaElectricaInicial { get; set; }
        public string inspeccion { get; set; }
        public Nullable<double> resistenciaAislamiento { get; set; }
        public Nullable<int> voltajePrueba { get; set; }
        public Nullable<double> indicePolaridad { get; set; }
        public Nullable<bool> continuidadLineas { get; set; }
        public Nullable<long> idTrabajador { get; set; }
    }
}
