using ConnPet.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConnPet.Api.Data.Mappings;

public class UserMapping : IEntityTypeConfiguration<User>
{
  public void Configure(EntityTypeBuilder<User> builder)
  {
    builder.ToTable("User");

    builder.HasKey(x => x.Id);

    builder.Property(x => x.Name)
      .IsRequired(true)
      .HasColumnType("NVARCHAR(255)");

    builder.Property(x => x.CRMV)
      .IsRequired(false)
      .HasColumnType("NVARCHAR(50)");

    builder.Property(x => x.StatusWorker)
      .IsRequired(true)
      .HasColumnType("CHAR(1)");

    builder.Property(x => x.Document)
      .IsRequired(true)
      .HasColumnType("NVARCHAR(14)");

    builder.Property(x => x.Type)
      .IsRequired(true)
      .HasColumnType("CHAR(1)");

    builder.Property(x => x.CreatedAt)
      .IsRequired(true)
      .HasColumnType("DATETIME");

    builder.Property(x => x.UpdatedAt)
      .IsRequired(false)
      .HasColumnType("DATETIME");


    builder.Property(x => x.AddressId)
      .IsRequired(true)
      .HasColumnType("BIGINT");

    builder.Property(x => x.ClinicId)
      .IsRequired(true)
      .HasColumnType("BIGINT");

    builder.HasOne(x => x.Address)
      .WithMany()
      .HasForeignKey(x => x.AddressId)
      .OnDelete(DeleteBehavior.Restrict);

    builder.HasOne(x => x.Clinic)
        .WithMany(c => c.Users)
        .HasForeignKey(x => x.ClinicId)
        .OnDelete(DeleteBehavior.Restrict);

  }
}
