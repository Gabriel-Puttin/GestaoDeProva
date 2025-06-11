using GestaoDeProvas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeProvas.Repository
{
    public class GestaoDeProvaContext : DbContext, IGestaoDeProvaContext
    {
        public GestaoDeProvaContext(DbContextOptions<GestaoDeProvaContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;TrustServerCertificate=True;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações iniciais, se necessário
        }
    }
}