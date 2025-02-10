using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Core.Entities;
using System.Reflection;

namespace SistemaBiblioteca.Infrastructure.Persistence
{
    public class BibliotecaSistemaContext : DbContext
    {
        public BibliotecaSistemaContext(DbContextOptions<BibliotecaSistemaContext> options) : base(options) { 
     
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
