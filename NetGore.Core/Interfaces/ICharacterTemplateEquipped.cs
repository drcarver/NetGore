using NetGore.Core.Models;

namespace NetGore.Core.Interfaces
{
    public interface ICharacterTemplateEquipped
    {
        ItemChance Chance { get; set; }
        CharacterTemplate CharacterTemplate { get; set; }
    }
}