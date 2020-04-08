using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Programacion3.Models
{
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdProducto{ get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Decimal Precio { get; set; }

    }
}