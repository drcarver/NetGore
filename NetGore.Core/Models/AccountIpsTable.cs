using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AccountIpsTable : BaseObject, IAccountIpsTable
{
    /// <summary>
    /// The account.
    /// </summary>
    [Required]
    [Description("The account.")]
    [Comment("The account.")]
    public required Account Account { get; set; }

    /// <summary>
    /// The IP that logged into the account.
    /// </summary>
    [Required]
    [Description("The IP that logged into the account.")]
    [Comment("The IP that logged into the account.")]
    public required int Ip { get; set; }

    /// <summary>
    /// When this IP last logged into this account.
    /// </summary>
    [Required]
    [Description("When this IP last logged into this account.")]
    [Comment("When this IP last logged into this account.")]
    public required DateTime LastLoggedInTime { get; set; }
}
