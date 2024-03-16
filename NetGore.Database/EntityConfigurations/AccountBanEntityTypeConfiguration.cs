using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NetGore.Core.Models;

namespace NetGore.Database.EntityConfigurations;

/// <summary>
/// Accounts that are baned from the game
/// </summary>
public class AccountBanEntityTypeConfiguration : IEntityTypeConfiguration<AccountBan>
{
    public void Configure(EntityTypeBuilder<AccountBan> builder)
    {
        builder?
            .HasComment("Accounts that are baned from the game")
            .HasQueryFilter(p => !p.IsDeleted)
            .HasKey(p => p.Id);

        builder?
            .Property(p => p.Id)
            .IsRequired()
            .HasComment("The primary Key");

        builder?
            .HasOne(p => p.Account);

        builder?
            .Property(p => p.Account)
            .IsRequired()
            .HasComment("The account this ban is for.");

        builder?
            .Property(p => p.EndTime)
            .IsRequired()
            .HasComment("When this ban ends.");

        builder?
            .Property(p => p.Expired)
            .IsRequired()
            .HasComment("If the ban is expired.");

        builder?
            .Property(p => p.IssuedBy)
            .IsRequired()
            .HasMaxLength(50)
            .HasComment("Name of the person or system that issued this ban (not strongly typed at all).");

        builder?
            .Property(p => p.Reason)
            .IsRequired()
            .HasComment("The reason why this account was banned.");

        builder?
            .Property(p => p.StartTime)
            .IsRequired()
            .HasComment("When this ban started.");
    }
}