using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccount
{
    /// <summary>
    /// The IP address that created the account.
    /// </summary>
    string? CreatorIp { get; set; }

    /// <summary>
    /// IP address currently logged in to the account, or 
    /// null if nobody is logged in.
    /// </summary>
    string? CurrentIp { get; set; }

    /// <summary>
    /// The email address.
    /// </summary>
    string? Email { get; set; }

    /// <summary>
    /// A list of friends that the user has.
    /// </summary>
    string? Friends { get; set; }

    /// <summary>
    /// The account password (MD5 hashed).
    /// </summary>
    string? Password { get; set; }

    /// <summary>
    /// The permission level bit mask (see UserPermissions 
    /// enum).
    /// </summary>
    UserPermissions? Permissions { get; set; }

    /// <summary>
    /// When the account was last logged in to.
    /// </summary>
    DateTime TimeLastLogin { get; set; }
}