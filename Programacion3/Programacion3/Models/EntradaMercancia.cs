using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Programacion3.Models
{
    public class EntradaMercancia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdEntrada { get; set; }

        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; }

        [ForeignKey("IdProveedor")]
        public Proveedor Proveedor { get; set; }

        [Required]
        public DateTime FechaEntrada { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}