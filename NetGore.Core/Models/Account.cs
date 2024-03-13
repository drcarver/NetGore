using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Account : BaseObject, IAccount
{
    /// <summary>
    /// The IP address that created the account.
    /// </summary>
    [Description("The IP address that created the account.")]
    [Comment("The IP address that created the account.")]
    public int CreatorIp { get; set; }

    /// <summary>
    /// IP address currently logged in to the account, or 
    /// null if nobody is logged in.
    /// </summary>
    [Description("IP address currently logged in to the account, or null if nobody is logged in.")]
    [Comment("IP address currently logged in to the account, or null if nobody is logged in.")]
    public int? CurrentIp { get; set; }

    /// <summary>
    /// The email address.
    /// </summary>
    [Description("The email address.")]
    [Comment("The email address.")]
    public string? Email { get; set; }

    /// <summary>
    /// A list of friends that the user has.
    /// </summary>
    [Description("A list of friends that the user has.")]
    [Comment("A list of friends that the user has.")]
    public string? Friends { get; set; }

    /// <summary>
    /// The account password (MD5 hashed).
    /// </summary>
    [Required]
    [Description("The account password (MD5 hashed).")]
    [Comment("The account password (MD5 hashed).")]
    public required string Password { get; set; }

    /// <summary>
    /// The permission level bit mask (see UserPermissions 
    /// enum).
    /// </summary>
    [Required]
    [Description("The permission level bit mask (see UserPermissions enum).")]
    [Comment("The permission level bit mask (see UserPermissions enum).")]
    public required UserPermissions Permissions { get; set; }

    /// <summary>
    /// When the account was created.
    /// </summary>
    [Required]
    [Description("When the account was created.")]
    [Comment("When the account was created.")]
    public required DateTime TimeCreated { get; set; }

    /// <summary>
    /// When the account was last logged in to.
    /// </summary>
    [Required]
    [Description("When the account was last logged in to.")]
    [Comment("When the account was last logged in to.")]
    public required DateTime TimeLastLogin { get; set; }
}
