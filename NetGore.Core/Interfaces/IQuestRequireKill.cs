using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IQuestRequireKill
{
    /// <summary>
    /// The number of characters that must be killed to 
    /// complete this quest.
    /// </summary>
    int Amount { get; set; }

    /// <summary>
    /// The template of the characters that must be 
    /// killed to complete this quest.
    /// </summary>
    CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    Quest? Quest { get; set; }
}