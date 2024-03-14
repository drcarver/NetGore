using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IQuestRequireKill
{
    int Amount { get; set; }
    CharacterTemplate CharacterTemplate { get; set; }
    Quest Quest { get; set; }
}