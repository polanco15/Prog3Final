﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Programacion3.Models
{
    public class Proveedor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdProveedor { get; set; }
        [Required]
        public long Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public long Telefono { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
           ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        public string Email { get; set; }
    }
}