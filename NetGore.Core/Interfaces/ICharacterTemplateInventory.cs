using NetGore.Core.Models;

namespace NetGore.Core.Interfaces
{
    public interface ICharacterTemplateInventory
    {
        ItemChance Chance { get; set; }
        CharacterTemplate CharacterTemplate { get; set; }
        ItemTemplate ItemTemplate { get; set; }
        byte Max { get; set; }
        byte Min { get; set; }
    }
}