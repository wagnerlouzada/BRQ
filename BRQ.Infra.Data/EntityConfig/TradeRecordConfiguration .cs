using BRQ.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BRQ.Infra.Data.EntityConfig
{
    public class TradeRecordConfiguration : EntityTypeConfiguration<TradeRecord>
    {
        //Fluent API
        public TradeRecordConfiguration()
        {
            HasKey(c => c.TradeId);

            Property(c => c.ClientSector)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Value)
                .IsRequired();

        }
    }
}
