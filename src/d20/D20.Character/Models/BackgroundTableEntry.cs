using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core.Models;

namespace D20.Character.Models;

public class BackgroundTableEntry : RandomTableEntry, IBackgroundTableEntry
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
