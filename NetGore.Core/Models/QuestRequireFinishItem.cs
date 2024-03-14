using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRequireFinishItem : BaseObject, IQuestRequireFinishItem
{
    /// <summary>
    /// The amount of the item required to finish this 
    /// quest.
    /// </summary>
    [Description("The amount of the item required to finish this quest.")]
    [Comment("The amount of the item required to finish this quest.")]
    public int Amount { get; set; }

    /// <summary>
    /// The template of the item that is required for 
    /// this quest to be finished.
    /// </summary>
    [Required]
    [Description("The template of the item that is required for this quest to be finished.")]
    [Comment("The template of the item that is required for this quest to be finished.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    [Description("The quest that this requirement is for.")]
    [Comment("The quest that this requirement is for.")]
    public required Quest Quest { get; set; }
}
