using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Verifica4.Core2.Model;

namespace Verifica4.EntityFrk2.Configurations
{
    public class OrdineConfiguration : IEntityTypeConfiguration<Ordine>
    {
        public void Configure(EntityTypeBuilder<Ordine> builder)
        {
            builder
                .HasKey(o => o.Id);

            builder
                .Property(o => o.DataOrdine)
                .IsRequired();

            builder
                .Property(o => o.CodiceOrdine)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(o => o.CodiceProdotto)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(o => o.Importo)
                .IsRequired();

            builder
                .HasOne(o => o.Cliente)
                .WithMany(c => c.Ordini)
                .HasForeignKey(o => o.ClienteId);
        }
    }
}