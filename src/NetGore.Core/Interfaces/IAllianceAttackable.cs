using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAllianceAttackable
{
    /// <summary>
    /// The alliance.
    /// </summary>
    Alliance? Alliance { get; set; }

    /// <summary>
    /// The alliance that this alliance can attack.
    /// </summary>
    Alliance? Attackable { get; set; }
}