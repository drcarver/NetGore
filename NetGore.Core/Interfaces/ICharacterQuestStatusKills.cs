using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterQuestStatusKills
{
    Character Character { get; set; }
    CharacterTemplate CharacterTemplate { get; set; }
    int Count { get; set; }
    Quest Quest { get; set; }
}