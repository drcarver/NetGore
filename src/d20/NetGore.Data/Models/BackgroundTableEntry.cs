using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Data.Interfaces;

namespace NetGore.Data.Models;

public class BackgroundTableEntry : GameTableEntry, IBackgroundTableEntry
{
    /// <summary>
    /// The racial traits for this creature 
    /// </summary>
    public List<TraitEnum> Traits { get; set; } = [];

    /// <summary>
    /// The alternate table
    /// </summary>
    public Type? AlternateTable { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public BackgroundTableEntry()
    {
    }
}
