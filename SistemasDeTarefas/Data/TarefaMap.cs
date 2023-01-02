using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistemasDeTarefas.Model;

namespace SistemasDeTarefas.Data
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(1000);
        }
    }
}
