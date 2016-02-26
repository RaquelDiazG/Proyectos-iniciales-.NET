using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjemploTiendaWeb.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }
        
        public int Precio { get; set; }
    }
}