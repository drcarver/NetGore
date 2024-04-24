using D20.Background.Enum;
using D20.Core.Interfaces;

namespace D20.Background.Interfaces;

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