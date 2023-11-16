using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Infrastructure.Data.Map
{
public class ChurchMap : IEntityTypeConfiguration<Church>
    {
        public void Configure(EntityTypeBuilder<Church> builder)
        {
            builder.ToTable(nameof(Church));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .IsRequired()
                   .HasColumnName("Id")
                   .HasColumnType("BIGINT")
                   .ValueGeneratedOnAdd();

            builder.Property(x => x.NameChurch)
                    .IsRequired()
                    .HasColumnName("Name")
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(100);

            builder.OwnsOne(x=>x.AddressChurch)
                    .Property(x=>x.Street)
                    .IsRequired()
                    .HasColumnName("Street")
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(200);            
            
            builder.OwnsOne(x=>x.AddressChurch)
                    .Property(x=>x.City)
                    .IsRequired()
                    .HasColumnName("City")
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(200);            
            
            builder.OwnsOne(x=>x.AddressChurch)
                    .Property(x=>x.Province)
                    .IsRequired()
                    .HasColumnName("Province")
                    .HasColumnType("NVARCHAR")
                    .HasMaxLength(200);

            //TODO: Relacionamento com a recomendações uma igreja tem muitas recomendações
        }
    }
}
