using BRQ.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BRQ.Infra.Data.EntityConfig
{
    public class RegraConfiguration : EntityTypeConfiguration<Regra>
    {
        public RegraConfiguration()
        {
            HasKey(p => p.RegraId);

            Property(p => p.ClientSector)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.MinValue)
                .IsRequired();

            Property(p => p.MaxValue)
                  .IsRequired();

            Property(p => p.Risk)
                 .IsRequired()
                 .HasMaxLength(50);

            HasRequired(p => p.GrupoDeRegras)
                .WithMany()
                .HasForeignKey(p => p.GrupoDeRegrasId); 
        }
    }
}
