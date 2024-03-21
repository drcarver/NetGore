using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IActiveTradeCash
{
    /// <summary>
    /// The amount of cash the character put down.
    /// </summary>
    int Cash { get; set; }

    /// <summary>
    /// The character that put the cash on the trade 
    /// table.
    /// </summary>
    PlayerCharacter? Character { get; set; }
}