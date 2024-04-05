using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccountIP
{
    /// <summary>
    /// The account.
    /// </summary>
    Account? Account { get; set; }

    /// <summary>
    /// The account Id.
    /// </summary>
    Guid? AccountId { get; set; }

    /// <summary>
    /// The IP that logged into the account.
    /// </summary>
    string IP { get; set; }

    /// <summary>
    /// When this IP last logged into this account.
    /// </summary>
    DateTime LastLoggedInTime { get; set; }
}