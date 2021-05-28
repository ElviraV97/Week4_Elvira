using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Verifica4.Core2.Model;

namespace Verifica4.EntityFrk2.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.CodiceCliente)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(c => c.Nome)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(c => c.Cognome)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}