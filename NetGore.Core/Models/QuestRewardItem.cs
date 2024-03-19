using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRewardItem : BaseObject, IQuestRewardItem
{
    /// <summary>
    /// The amount of the item to give (should be 
    /// greater than 0).
    /// </summary>
    [Description("The amount of the item to give (should be greater than 0).")]
    public int Amount { get; set; }

    /// <summary>
    /// The template of the item to give as the reward.
    /// </summary>
    [Description("The template of the item to give as the reward.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The quest that this completion reward is for.
    /// </summary>
    [Description("The quest that this completion reward is for.")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected QuestRewardItem()
    {
    }
}
