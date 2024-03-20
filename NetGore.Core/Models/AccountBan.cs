using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

/// <summary>
/// Accounts that are baned from the game
/// </summary>
public class AccountBan : DataObject, IAccountBan
{
    /// <summary>
    /// The account id that this ban is for.
    /// </summary>
    [Description("The account id that this ban is for.")]
    public Guid? AccountId { get; set; }

    /// <summary>
    /// The account that this ban is for.
    /// </summary>
    [Description("The account that this ban is for.")]
    public virtual Account? Account { get; set; }

    // <summary>
    /// When this ban ends.
    /// </summary>
    [Description("When this ban ends.")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// If the ban is expired.
    /// </summary>
    [Description("If the ban is expired")]
    public bool Expired { get; set; }

    /// <summary>
    /// Name of the person or system that issued this ban 
    /// (not strongly typed at all).".
    /// </summary>
    [Description("Name of the person or system that issued this ban (not strongly typed at all).")]
    public string? IssuedBy { get; set; }

    /// <summary>
    /// The reason why this account was banned.
    /// </summary>
    [Description("The reason why this account was banned.")]
    public string? Reason { get; set; }

    /// <summary>
    /// When this ban started.
    /// </summary>
    [Description("When this ban started.")]
    public DateTime StartTime { get; set; }

    [SetsRequiredMembers]
    public AccountBan()
    {
        Expired = false;
        StartTime = DateTime.UtcNow;
    }
}