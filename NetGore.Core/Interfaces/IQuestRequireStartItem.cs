using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IQuestRequireStartItem
{
    /// <summary>
    /// The amount of the item that is required.
    /// </summary>
    int Amount { get; set; }

    /// <summary>
    /// The template of the item that is required to 
    /// start the quest.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Quest that this requirement is for.
    /// </summary>
    Quest? Quest { get; set; }
}