using ConnPet.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConnPet.Api.Data.Mappings;
public class TutorMapping : IEntityTypeConfiguration<Tutor>
{
    public void Configure(EntityTypeBuilder<Tutor> builder)
    {
        builder.ToTable("Tutor");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("NVARCHAR(255)");

        builder.Property(x => x.Document)
            .IsRequired()
            .HasColumnType("NVARCHAR(14)");

        builder.Property(x => x.CreatedAt)
            .IsRequired(true)
            .HasColumnType("DATETIME");

        builder.Property(x => x.UpdatedAt)
            .IsRequired(false)
            .HasColumnType("DATETIME");

        builder.HasOne(t => t.Address)
            .WithMany(a => a.Tutors)
            .HasForeignKey(t => t.AddressId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
