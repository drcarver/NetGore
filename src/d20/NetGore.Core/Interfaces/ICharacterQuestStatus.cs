using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterQuestStatus
{
    /// <summary>
    /// Character this quest status info is for.
    /// </summary>
    PlayerCharacter? Character { get; set; }

    /// <summary>
    /// When the quest was completed. Null if incomplete. 
    /// Repeatable quests hold time is was most recently 
    /// completed.
    /// </summary>
    DateTime? CompletedOn { get; set; }

    /// <summary>
    /// The quest this information is for.
    /// </summary>
    Quest? Quest { get; set; }

    /// <summary>
    /// When the quest was started.
    /// </summary>
    DateTime StartedOn { get; set; }
}