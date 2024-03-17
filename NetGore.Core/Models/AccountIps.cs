using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AccountIps : BaseObject, IAccountIps
{
    /// <summary>
    /// The account.
    /// </summary>
    [Description("The account.")]
    public Account? Account { get; set; }

    /// <summary>
    /// The IP that logged into the account.
    /// </summary>
    [Description("The IP that logged into the account.")]
    public int Ip { get; set; }

    /// <summary>
    /// When this IP last logged into this account.
    /// </summary>
    [Description("When this IP last logged into this account.")]
    public DateTime LastLoggedInTime { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AccountIps()
    {
    }
}
