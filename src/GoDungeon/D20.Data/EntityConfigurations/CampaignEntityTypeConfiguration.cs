using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NetGore.Core.Models;

namespace NetGore.Data.EntityConfigurations;

public class CampaignEntityTypeConfiguration : IEntityTypeConfiguration<Campaign>
{
    public void Configure(EntityTypeBuilder<Campaign> builder)
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

        builder?
            .HasOne(p => p.World);

        builder?
            .Property(p => p.World)
            .IsRequired()
            .HasComment("The world for this game");

        builder?
            .HasMany(p => p.Campaigns)
            .WithOne(e => e.Campaign)
            .HasForeignKey(e => e.CampaignId)
            .IsRequired();

        builder?
            .Property(p => p.Campaigns)
            .HasComment("The campaigns for this game.");
    }
}