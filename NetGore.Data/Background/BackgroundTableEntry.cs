using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

public class BackgroundTableEntry : RandomTableEntry
{
    /// <summary>
    /// The racial traits for this creature 
    /// </summary>
    public List<RacialTraitEnum> RacialTraits { get; set; } = [];

    /// <summary>
    /// Background table entry
    /// </summary>
    [SetsRequiredMembers]
    public BackgroundTableEntry()
    {
    }
}
