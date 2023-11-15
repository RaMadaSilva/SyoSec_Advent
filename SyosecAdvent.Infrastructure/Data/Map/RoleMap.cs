using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Infrastructure.Data.Map
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(nameof(Role));

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.RoleName)
                .IsRequired()
                .HasColumnName("RoleName")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50); 

            //TODO: Relacionamento com user de muitos para muitos
        }
    }
}
