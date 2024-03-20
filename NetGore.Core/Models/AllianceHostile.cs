using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AllianceHostile : DataObject, IAllianceHostile
{
    /// <summary>
    /// The alliance that is hotile.
    /// </summary>
    [Description("The alliance that is hostile.")]
    public Alliance? Alliance { get; set; }

    /// <summary>
    /// The alliance that this alliance is hostile towards 
    /// by default.
    /// </summary>
    [Description("The alliance that this alliance (alliance_id) is hostile towards by default.")]
    public Alliance? Hostile { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AllianceHostile()
    {
    }
}
