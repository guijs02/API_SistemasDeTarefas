using Microsoft.EntityFrameworkCore;
using SistemasDeTarefas.Model;

namespace SistemasDeTarefas.Data
{
    public class SistemaDeTarefaDBContext : DbContext
    {
        public SistemaDeTarefaDBContext(DbContextOptions<SistemaDeTarefaDBContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
