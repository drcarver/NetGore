using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

namespace NetGore.Core.Ablities;

/// <summary>
/// Wisdom reflects how attuned you are to the world 
/// around you and represents perceptiveness and 
/// intuition.
/// </summary>
public class Wisdom : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Wisdom(ILogger logger)
        : base(logger)
    {
        Name = "Wisdom";
        Description = "Wisdom reflects how attuned you are to the world around you and represents perceptiveness and intuition.";
        Abbrieviation = "WIS";
    }
}
