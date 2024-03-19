using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NetGore.Core.Models;

namespace NetGore.Data.EntityConfigurations;

public class AccountEntityTypeConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
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
            .Property(p => p.CreatorIp)
            .IsRequired()
            .HasComment("The IP address that created the account.");

        builder?
            .Property(p => p.CurrentIp)
            .IsRequired()
            .HasComment("IP address currently logged in to the account, or null if nobody is logged in.");

        builder?
            .Property(p => p.Email)
            .HasComment("The email address.");

        builder?
            .Property(p => p.Friends)
            .HasComment("A list of friends that the user has.");

        builder?
            .Property(p => p.Password)
            .HasComment("The account password (MD5 hashed).");

        builder?
            .Property(p => p.Permissions)
            .HasComment("The permission level bit mask (see UserPermissions enum).");

        builder?
            .Property(p => p.TimeLastLogin)
            .IsRequired()
            .HasComment("When the account was last logged in to.");

        builder?
            .Property(p => p.TimeLastLogin)
            .IsRequired()
            .HasComment("When the account was last logged in to.");
    }
}