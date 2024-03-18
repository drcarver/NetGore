using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterTemplateQuestProvider
{
    /// <summary>
    /// The character template.
    /// </summary>
    CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The quest provided by this character template. 
    /// Only applies for valid quest givers (that is, 
    /// not users).
    /// </summary>
    Quest? Quest { get; set; }
}