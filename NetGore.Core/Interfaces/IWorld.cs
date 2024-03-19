using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorld
{
    List<Campaign>? Campaigns { get; set; }
    List<Account> Accounts { get; set; }
    List<AccountBan> BannedAccounts { get; set; }
}