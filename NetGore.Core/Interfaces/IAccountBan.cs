using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAccountBan
{
    Account? Account { get; set; }
    Guid? AccountId { get; set; }
    DateTime EndTime { get; set; }
    bool Expired { get; set; }
    string IssuedBy { get; set; }
    string Reason { get; set; }
    DateTime StartTime { get; set; }
}