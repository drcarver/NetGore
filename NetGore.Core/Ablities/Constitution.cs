using System.Diagnostics.CodeAnalysis;

namespace NetGore.Core.Ablities;

/// <summary>
/// Constitution measures health, stamina, and vital 
/// force.
/// </summary>
public class Constitution : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Constitution()
    {
        Name = "Constitution";
        Description = "Constitution measures health, stamina, and vital force.";
        Abbrieviation = "CON";
    }
}
