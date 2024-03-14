using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRewardItem : BaseObject, IQuestRewardItem
{
    /// <summary>
    /// The amount of the item to give (should be 
    /// greater than 0).
    /// </summary>
    [Description("The amount of the item to give (should be greater than 0).")]
    [Comment("The amount of the item to give (should be greater than 0).")]
    public byte Amount { get; set; }

    /// <summary>
    /// The template of the item to give as the reward.
    /// </summary>
    [Required]
    [Description("The template of the item to give as the reward.")]
    [Comment("The template of the item to give as the reward.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// The quest that this completion reward is for.
    /// </summary>
    [Required]
    [Description("The quest that this completion reward is for.")]
    [Comment("The quest that this completion reward is for.")]
    public required Quest Quest { get; set; }
}
