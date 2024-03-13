using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAllianceHostile
{
    Alliance Alliance { get; set; }
    Alliance Hostile { get; set; }
}