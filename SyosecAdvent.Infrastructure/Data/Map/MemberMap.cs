using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Infrastructure.Data.Map
{
    public class MemberMap : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable(nameof(Member));

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Id)
                   .IsRequired()
                   .HasColumnName("Id")
                   .HasColumnType("BIGINT")
                   .ValueGeneratedOnAdd();

            builder.OwnsOne(x => x.NameMember)
                   .Property(x => x.FirstName)
                   .HasColumnName("FirstName")
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(100);             
            
            builder.OwnsOne(x => x.NameMember)
                   .Property(x => x.LastName)
                   .HasColumnName("LastName")
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(100);

            builder.Property(x => x.Phone)
                   .HasColumnName("Phone")
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(20);

            builder.OwnsOne(x => x.AddressMember)
                   .Property(x => x.Street)
                   .HasColumnName("Street")
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(100); 

            builder.OwnsOne(x => x.AddressMember)
                   .Property(x => x.City)
                   .HasColumnName("City")
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(100); 

            builder.OwnsOne(x => x.AddressMember)
                   .Property(x => x.Province)
                   .HasColumnName("Province")
                   .HasColumnType("NVARCHAR")
                   .HasMaxLength(100); 
        }
    }
}
