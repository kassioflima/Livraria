using Livraria.Domain.UseCases.Cagetorias.Entity;
using Livraria.Domain.UseCases.Editoras.Entity;
using Livraria.Domain.UseCases.Livros.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Infrastructure.Context
{
    public class LivrariaContext(DbContextOptions<LivrariaContext> options) : DbContext(options)
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LivrariaContext).Assembly);
        }
    }
}
