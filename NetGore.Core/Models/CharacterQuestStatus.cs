using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterQuestStatus : BaseObject, ICharacterQuestStatus
{
    /// <summary>
    /// Character this quest status info is for.
    /// </summary>
    [Description("Character this quest status info is for.")]
    public Character? Character { get; set; }

    /// <summary>
    /// When the quest was completed. Null if incomplete. 
    /// Repeatable quests hold time is was most recently 
    /// completed.
    /// </summary>
    [Description("When the quest was completed. Null if incomplete. Repeatable quests hold time is was most recently completed.")]
    public DateTime? CompletedOn { get; set; }

    /// <summary>
    /// The quest this information is for.
    /// </summary>
    [Description("The quest this information is for.")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// When the quest was started.
    /// </summary>
    [Description("When the quest was started.")]
    public DateTime StartedOn { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterQuestStatus()
    {
    }
}
