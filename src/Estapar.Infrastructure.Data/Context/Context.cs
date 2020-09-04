using Estapar.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Infrastructure.Data
{
    public class Context : DbContext, IDisposable
    {
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Manobrista> Manobrista { get; set; }
        public DbSet<CarroManobrista> CarroManobrista { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Carro>(b =>
            {
                b.HasIndex(e => new { e.Placa }).IsUnique(true);
            });

            modelBuilder.Entity<CarroManobrista>(b =>
            {
                b.HasIndex(e => new { e.IdCarro }).IsUnique(true);
            });

            modelBuilder.Entity<Manobrista>(b =>
            {
                b.HasIndex(e => new { e.Cpf }).IsUnique(true);
            });
        }

        public override int SaveChanges()
        {          
            return base.SaveChanges();                 
        }
    }
}
