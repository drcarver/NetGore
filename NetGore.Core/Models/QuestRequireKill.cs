using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRequireKill : BaseObject, IQuestRequireKill
{
    /// <summary>
    /// The number of characters that must be killed to 
    /// complete this quest.
    /// </summary>
    [Description("The number of characters that must be killed to complete this quest.")]
    [Comment("The number of characters that must be killed to complete this quest.")]
    public int Amount { get; set; }

    /// <summary>
    /// The template of the characters that must be 
    /// killed to complete this quest.
    /// </summary>
    [Required]
    [Description("The template of the characters that must be killed to complete this quest.")]
    [Comment("The template of the characters that must be killed to complete this quest.")]
    public required CharacterTemplate CharacterTemplate { get; set; }

    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    [Description("The quest that this requirement is for.")]
    [Comment("The quest that this requirement is for.")]
    public required Quest Quest { get; set; }
}
