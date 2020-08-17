using Microsoft.EntityFrameworkCore;
using Simulacion_Comercial.Clases;

namespace Simulacion_Comercial.Models {
    public class TiendaContext : DbContext {
        public TiendaContext() { }
        public TiendaContext(DbContextOptions<TiendaContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( @"Server =.\SQLEXPRESS; Database = ComercialDB; Trusted_Connection = True;");
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Productos> Productos { get; set; }
    }
}