//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        public Persona()
        {
            this.Facturas = new HashSet<Factura>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public short Edad { get; set; }
    
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
