//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProveedoresRec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class recibos
    {
        public int ID { get; set; }
        public string Proveedor { get; set; }
        public int Monto { get; set; }
        public int Moneda { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Comentario { get; set; }
    }
}
