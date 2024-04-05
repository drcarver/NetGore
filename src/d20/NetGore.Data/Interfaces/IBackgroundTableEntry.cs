using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Data.Interfaces;

public interface IBackgroundTableEntry : IGameTableEntry
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