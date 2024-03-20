using System.Diagnostics.CodeAnalysis;

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
    public Intelligence()
    {
        Name = "Intelligence";
        Description = "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.";
        Abbrieviation = "INT";
    }
}
