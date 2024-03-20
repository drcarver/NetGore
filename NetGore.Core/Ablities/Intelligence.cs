using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

namespace NetGore.Core.Ablities;

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
    public Intelligence(ILogger logger)
        : base(logger)
    {
        Name = "Intelligence";
        Description = "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.";
        Abbrieviation = "INT";
    }
}
