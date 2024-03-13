using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterQuestStatus : BaseObject, ICharacterQuestStatus
{
    /// <summary>
    /// Character this quest status info is for.
    /// </summary>
    [Required]
    [Description("Character this quest status info is for.")]
    [Comment("Character this quest status info is for.")]
    public required Character Character { get; set; }

    /// <summary>
    /// When the quest was completed. Null if incomplete. 
    /// Repeatable quests hold time is was most recently 
    /// completed.
    /// </summary>
    [Description("When the quest was completed. Null if incomplete. Repeatable quests hold time is was most recently completed.")]
    [Comment("When the quest was completed. Null if incomplete. Repeatable quests hold time is was most recently completed.")]
    public DateTime? CompletedOn { get; set; }

    /// <summary>
    /// The quest this information is for.
    /// </summary>
    [Required]
    [Description("The quest this information is for.")]
    [Comment("The quest this information is for.")]
    public required Quest Quest { get; set; }

    /// <summary>
    /// Gets or sets the value for the field that maps onto the database column `started_on`.
    /// The underlying database type is `datetime`.The database column contains the comment: 
    /// "When the quest was started.".
    /// </summary>
    [Required]
    [Description("When the quest was started.")]
    [Comment("When the quest was started.")]
    public required DateTime StartedOn { get; set; }
}
