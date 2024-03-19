using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

/// <summary>
/// Accounts that are baned from the game
/// </summary>
public interface IAccountBan
{
    /// <summary>
    /// The account that this ban is for.
    /// </summary>
    Account? Account { get; set; }

    // <summary>
    /// When this ban ends.
    /// </summary>
    DateTime EndTime { get; set; }

    /// <summary>
    /// If the ban is expired.
    /// </summary>
    bool Expired { get; set; }

    /// <summary>
    /// Name of the person or system that issued this ban 
    /// (not strongly typed at all).".
    /// </summary>
    string? IssuedBy { get; set; }

    /// <summary>
    /// The reason why this account was banned.
    /// </summary>
    string? Reason { get; set; }

    /// <summary>
    /// When this ban started.
    /// </summary>
    DateTime StartTime { get; set; }
}