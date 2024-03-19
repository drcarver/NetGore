using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterQuestStatusKills
{
    /// <summary>
    /// The character who is doing this quest.
    /// </summary>
    Character? Character { get; set; }

    /// <summary>
    /// The character template that is to be killed for 
    /// the quest.
    /// </summary>
    CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The current kill count of characters with this 
    /// template.
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// The quest that the kill count is for.
    /// </summary>
    Quest? Quest { get; set; }
}