using BRQ.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BRQ.Infra.Data.EntityConfig
{
    public class GrupoDeRegrasConfiguration : EntityTypeConfiguration<GrupoDeRegras>
    {
        //Fluent API
        public GrupoDeRegrasConfiguration()
        {
            HasKey(c => c.GrupoDeRegrasId);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150);

        }
    }
}
