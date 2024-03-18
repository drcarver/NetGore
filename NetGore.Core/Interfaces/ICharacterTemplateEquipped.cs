using System.ComponentModel;

using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterTemplateEquipped
{
    /// <summary>
    /// The chance of the item being equipped when a 
    /// character is instantiated from this template.
    /// </summary>
    ItemChance? Chance { get; set; }

    /// <summary>
    /// The character template.
    /// </summary>
    CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The item the character template has equipped.
    /// </summary>
    public ItemTemplate? ItemTemplate { get; set; }
}