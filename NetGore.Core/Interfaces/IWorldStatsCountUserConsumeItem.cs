using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountUserConsumeItem
{
    /// <summary>
    /// The amount of the item that the user has consumed.
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// The item template that this consumption counter 
    /// is for.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Character this counter is for. Logically, it 
    /// should be a user (not persistent NPC).
    /// </summary>
    Character? User { get; set; }
}