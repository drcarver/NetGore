using NetGore.Core.Enum;

namespace NetGore.Data.Interfaces;

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