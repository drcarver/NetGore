using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IQuestRewardItem
{
    /// <summary>
    /// The amount of the item to give (should be 
    /// greater than 0).
    /// </summary>
    int Amount { get; set; }

    /// <summary>
    /// The template of the item to give as the reward.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The quest that this completion reward is for.
    /// </summary>
    Quest? Quest { get; set; }
}