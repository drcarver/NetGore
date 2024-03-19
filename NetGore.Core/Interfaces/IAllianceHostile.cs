using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IAllianceHostile
{
    /// <summary>
    /// The alliance that is hotile.
    /// </summary>
    Alliance? Alliance { get; set; }

    /// <summary>
    /// The alliance that this alliance is hostile towards 
    /// by default.
    /// </summary>
    Alliance? Hostile { get; set; }
}