using D20.Character.Enum;
using D20.Core.Interfaces;

namespace D20.Character.Interfaces;

public interface IBackgroundTableEntry : IRandomTableEntry
{
    /// <summary>
    /// The racial traits for this creature 
    /// </summary>
    List<TraitEnum> Traits { get; set; }

    /// <summary>
    /// The alternate table
    /// </summary>
    Type? AlternateTable { get; set; }
}