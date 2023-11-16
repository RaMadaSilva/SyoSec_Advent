using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SyosecAdvent.Domain.Entities;

namespace SyosecAdvent.Infrastructure.Data.Map
{
    public class RecommendationMap : IEntityTypeConfiguration<Recommendation>
    {
        public void Configure(EntityTypeBuilder<Recommendation> builder)
        {
            builder.ToTable(nameof(Recommendation));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("BIGINT")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Observation)
                .IsRequired()
                .HasColumnName("Observation")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(500);

            builder.Property(x => x.DateRegister)
                .IsRequired()
                .HasColumnName("DateReturn")
                .HasColumnType("DATETIME2"); 
            
            builder.Property(x => x.ExpireDate)
                .IsRequired()
                .HasColumnName("DateReturn")
                .HasColumnType("DATETIME2");

            builder.Property(x => x.DateReturn)
                .IsRequired(false)
                .HasColumnName("DateReturn")
                .HasColumnType("DATETIME2");

            builder.Property(x=>x.UrlRecommendation)
                .IsRequired(false)
                .HasColumnName("URLRecommendation")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);

            builder.Property(x => x.DesireTrasfer)
                .IsRequired()
                .HasColumnName("DesireTransfer")
                .HasColumnType("BIT");

            builder.Property(x => x.RecommendationState)
                .IsRequired()
                .HasColumnName("RecommendationState")
                .HasColumnType("INT"); 

           builder.Property(x=> x.RecommendationType)
                .IsRequired()
                .HasColumnName("RecommendationType")
                .HasColumnType("INT");
          
            builder.HasOne(x => x.Church)
                .WithMany(x => x.Recommendations)
                .HasForeignKey("ChurchId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Member)
                .WithMany(x => x.Recommendations)
                .HasForeignKey("MemberId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
