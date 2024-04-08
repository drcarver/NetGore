using NetGore.Core.Interfaces;

namespace NetGore.Data.Interfaces;

public interface IRandomTableEntry : IGameTableEntry
{
    /// <summary>
    /// The range for this entry
    /// </summary>
    Range Range { get; set; }
}