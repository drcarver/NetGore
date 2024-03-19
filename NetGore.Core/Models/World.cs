using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class World : BaseObject, IWorld
{
    public List<Campaign>? Campaigns { get; set; } = new List<Campaign>();
    public List<Account> Accounts { get; set; } = new List<Account>();
    public List<AccountBan> BannedAccounts { get; set; } = new List<AccountBan>();

    /// <summary>
    /// Create a new Campaign
    /// </summary>
    [SetsRequiredMembers]
    protected World()
    {
    }
}
