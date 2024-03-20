using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AllianceAttackable : BaseObject, IAllianceAttackable
{
    /// <summary>
    /// The alliance.
    /// </summary>
    [Description("The alliance.")]
    public Alliance? Alliance { get; set; }

    /// <summary>
    /// The alliance that this alliance can attack.
    /// </summary>
    [Description("The alliance that this alliance can attack.")]
    public Alliance? Attackable { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AllianceAttackable()
    {
    }
}
