using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccountIpsTable
{
    Account Account { get; set; }
    int Ip { get; set; }
    DateTime LastLoggedInTime { get; set; }
}