using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Programacion3.Models
{
    public class Factura
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdFactura { get; set; }

        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Total { get; set; }
        [Required]
        public DateTime FechaFactura { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }

    }
}