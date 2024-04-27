using D20.Core.Interfaces;

namespace D20.Gaming.Interfaces;

public interface ICharacterWealthByLevelEntry : IGameTableEntry
{
    /// <summary>
    /// Character level
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Wealth in gold pieces
    /// </summary>
    public int Wealth { get; set; }
}