using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRequireStartItem : BaseObject, IQuestRequireStartItem
{
    /// <summary>
    /// The amount of the item that is required.
    /// </summary>
    [Description("The amount of the item that is required.")]
    [Comment("The amount of the item that is required.")]
    public int Amount { get; set; }

    /// <summary>
    /// The template of the item that is required to 
    /// start the quest.
    /// </summary>
    [Required]
    [Description("The template of the item that is required to start the quest.")]
    [Comment("The template of the item that is required to start the quest.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// Quest that this requirement is for.
    /// </summary>
    [Required]
    [Description("Quest that this requirement is for.")]
    [Comment("Quest that this requirement is for.")]
    public required Quest Quest { get; set; }
}
