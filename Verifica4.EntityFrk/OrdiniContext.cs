using Microsoft.EntityFrameworkCore;
using System;
using Verifica4.Core2.Model;
using Verifica4.EntityFrk.Configurations;

namespace Verifica4.EntityFrk
{
    public class OrdiniContext : DbContext
    {
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Ordine> Ordini { get; set; }

        public OrdiniContext() : base() { }

        public OrdiniContext(DbContextOptions<OrdiniContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Verifica4_Ordini;Integrated Security=True";
                options.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration<Ordine>(new OrdineConfiguration());
        }
    }
}
