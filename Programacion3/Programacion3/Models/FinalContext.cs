using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Programacion3.Models
{
    public class FinalContext : DbContext
    {
        public FinalContext()
            : base("Cadena1")
        { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<EntradaMercancia> EntradaMercancias { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Factura> Facturas { get; set; }

    }
}