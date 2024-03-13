using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAllianceAttackable
{
    Alliance Alliance { get; set; }
    Alliance Attackable { get; set; }
}