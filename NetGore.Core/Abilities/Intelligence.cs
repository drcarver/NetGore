using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Models;

namespace NetGore.Core.Abilities;

/// <summary>
/// Intelligence measures mental acuity, accuracy of recall,
/// and the ability to reason.
/// </summary>
public class Intelligence : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Intelligence(ILogger? logger, Creature parent)
        : base(logger, parent)
    {
        Name = "Intelligence";
        Description = "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.";
        Abbreviation = "INT";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Intelligence(int baseAbility, Creature parent)
        : base(baseAbility, parent)
    {
        Name = "Intelligence";
        Description = "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.";
        Abbreviation = "INT";
    }
}
