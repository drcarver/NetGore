using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IQuestRequireFinishItem
{
    /// <summary>
    /// The amount of the item required to finish this 
    /// quest.
    /// </summary>
    int Amount { get; set; }

    /// <summary>
    /// The template of the item that is required for 
    /// this quest to be finished.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    Quest? Quest { get; set; }
}