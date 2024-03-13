using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AccountBan : BaseObject, IAccountBan
{
    /// <summary>
    /// The account that this ban is for.
    /// </summary>
    [Required]
    [Description("The account that this ban is for.")]
    [Comment("The account that this ban is for.")]
    public required Account Account { get; set; }

    // <summary>
    /// When this ban ends.
    /// </summary>
    [Description("When this ban ends.")]
    [Comment("When this ban ends.")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// If the ban is expired.
    /// </summary>
    [Description("If the ban is expired")]
    [Comment("If the ban is expired.")]
    public bool Expired { get; set; }

    /// <summary>
    /// Name of the person or system that issued this ban 
    /// (not strongly typed at all).".
    /// </summary>
    [MaxLength(256)]
    [Required]
    [Description("Name of the person or system that issued this ban (not strongly typed at all).")]
    [Comment("Name of the person or system that issued this ban (not strongly typed at all).")]
    public required string IssuedBy { get; set; }

    /// <summary>
    /// The reason why this account was banned.
    /// </summary>
    [Required]
    [Description("The reason why this account was banned.")]
    [Comment("The reason why this account was banned.")]
    public required string Reason { get; set; }

    /// <summary>
    /// When this ban started.
    /// </summary>
    [Description("When this ban started.")]
    [Comment("When this ban started.")]
    public DateTime StartTime { get; set; }
}