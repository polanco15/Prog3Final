using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Programacion3.Models
{
    public class DetalleFactura
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdDetalle { get; set; }

        public int IdFactura { get; set; }
        [ForeignKey("IdFactura")]
        public Factura Factura { get; set; }

        public int IdProducto { get; set; }
        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Precio { get; set; }

        public decimal SubTotal { get; set; }
    }
}