using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NetGore.Core.Models;

namespace NetGore.Database.EntityConfigurations;

/// <summary>
/// A example entity
/// </summary>
public class ExampleEntityTypeConfiguration : IEntityTypeConfiguration<AccountBan>
{
    public void Configure(EntityTypeBuilder<AccountBan> builder)
    {
        builder?
            .HasComment("A example entity")
            .HasQueryFilter(p => !p.IsDeleted)
            .HasKey(p => p.Id);

        builder?
            .Property(p => p.Id)
            .IsRequired()
            .HasComment("The primary Key of the example");

        builder?
            .Property(p => p.Name)
            .HasMaxLength(80)
            .HasComment("The name of the example");

        builder?
            .Property(p => p.Description)
            .HasComment("The description of the example");

        builder?
            .Property<DateTime>("UpdatedAt")
            .HasComment("The description of the example");

        builder?
            .Property<DateTime>("CreatedAt")
            .HasComment("The description of the example");
    }
}