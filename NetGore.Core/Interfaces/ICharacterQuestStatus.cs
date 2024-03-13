using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterQuestStatus
{
    Character Character { get; set; }
    DateTime? CompletedOn { get; set; }
    Quest Quest { get; set; }
    DateTime StartedOn { get; set; }
}