using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AccountIP : BaseObject, IAccountIP
{
    /// <summary>
    /// The account.
    /// </summary>
    [Description("The account.")]
    public Account? Account { get; set; }

    /// <summary>
    /// The account Id.
    /// </summary>
    [Description("The account Id.")]
    public Guid? AccountId { get; set; }

    /// <summary>
    /// The IP that logged into the account.
    /// </summary>
    [Description("The IP that logged into the account.")]
    public string? IP { get; set; }

    /// <summary>
    /// When this IP last logged into this account.
    /// </summary>
    [Description("When this IP last logged into this account.")]
    public DateTime LastLoggedInTime { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AccountIP()
    {
    }
}
