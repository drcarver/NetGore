using NetGore.Core.Models;

namespace NetGore.Core.Interfaces
{
    public interface ICharacterTemplateQuestProvider
    {
        CharacterTemplate CharacterTemplate { get; set; }
        Quest Quest { get; set; }
    }
}