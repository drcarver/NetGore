using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NetGore.Core.Models;

namespace NetGore.Data.EntityConfigurations;

public class AllianceEntityTypeConfiguration : IEntityTypeConfiguration<Alliance>
{
    public void Configure(EntityTypeBuilder<Alliance> builder)
    {
        #region BaseObject
        builder?
            .HasQueryFilter(p => !p.IsDeleted)
            .HasKey(p => p.Id);

        builder?
            .Property(p => p.Id)
            .IsRequired()
            .HasComment("The primary Key");

        builder?
            .Property(p => p.Name)
            .HasMaxLength(80)
            .IsRequired()
            .HasComment("The name");

        builder?
            .Property(p => p.Description)
            .HasComment("The description");

        builder?
            .Property(p => p.UpdatedAt)
            .IsRequired()
            .HasComment("The date and time last updated");

        builder?
            .Property(p => p.CreatedAt)
            .IsRequired()
            .HasComment("The date and time created");

        builder?
            .Property(p => p.IsDeleted)
            .IsRequired()
            .HasComment("Is it marked for deletion?");
        #endregion
    }
}