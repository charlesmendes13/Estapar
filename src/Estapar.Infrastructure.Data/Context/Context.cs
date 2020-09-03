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
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
