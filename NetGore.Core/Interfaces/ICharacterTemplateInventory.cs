using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterTemplateInventory
{
    /// <summary>
    /// Chance that this item will be created when the 
    /// character template is instantiated. Item quantity 
    /// will be between min and max (equal chance 
    /// distribution).
    /// </summary>
    ItemChance? Chance { get; set; }

    /// <summary>
    /// The character template.
    /// </summary>
    CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The item the character template has in their 
    /// inventory.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The maximum number of items to be created.
    /// </summary>
    int Max { get; set; }

    /// <summary>
    /// The minimum number of items to be created. Doesn't 
    /// affect item creation chance. Each value in range 
    /// has equal distribution.
    /// </summary>
    int Min { get; set; }
}