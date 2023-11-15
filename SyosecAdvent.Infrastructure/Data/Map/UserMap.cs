using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Infrastructure.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();

            builder.OwnsOne(x => x.FullName)
                .Property(x => x.FirstName)
                .IsRequired()
                .HasColumnName("FistName")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);

            builder.OwnsOne(x => x.FullName)
                .Property(x => x.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);

            builder.Property(x => x.UserName)
                .IsRequired()
                .HasColumnName("UserName")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);

            builder.Property(x => x.PasswordHash)
                .IsRequired()
                .HasColumnName("PasswordHash")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(100);

            //TODO: Relacionamento com o Role de muitos para muitos

        }
    }
}
