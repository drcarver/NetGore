using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccountIps
{
    /// <summary>
    /// The account.
    /// </summary>
    Account? Account { get; set; }

    /// <summary>
    /// The IP that logged into the account.
    /// </summary>
    int Ip { get; set; }

    /// <summary>
    /// When this IP last logged into this account.
    /// </summary>
    DateTime LastLoggedInTime { get; set; }
}