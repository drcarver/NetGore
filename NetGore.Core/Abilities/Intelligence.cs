using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

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
    public Intelligence(ILogger? logger)
        : base(logger)
    {
        Name = "Intelligence";
        Description = "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.";
        Abbreviation = "INT";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Intelligence(int baseAbility)
        : base(baseAbility)
    {
        Name = "Intelligence";
        Description = "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.";
        Abbreviation = "INT";
    }
}
