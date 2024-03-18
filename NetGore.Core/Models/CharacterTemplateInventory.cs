using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplateInventory : BaseObject, ICharacterTemplateInventory
{
    /// <summary>
    /// Chance that this item will be created when the 
    /// character template is instantiated. Item quantity 
    /// will be between min and max (equal chance 
    /// distribution).
    /// </summary>
    [Description("Chance that this item will be created when the character template is instantiated. Item quantity will be between min and max (equal chance distribution).")]
    public ItemChance? Chance { get; set; }

    /// <summary>
    /// The character template.
    /// </summary>
    [Description("The character template.")]
    public CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The item the character template has in their 
    /// inventory.
    /// </summary>
    [Description("The item the character template has in their inventory.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The maximum number of items to be created.
    /// </summary>
    [Description("The maximum number of items to be created.")]
    public int Max { get; set; }

    /// <summary>
    /// The minimum number of items to be created. Doesn't 
    /// affect item creation chance. Each value in range 
    /// has equal distribution.
    /// </summary>
    [Description("The minimum number of items to be created. Doesn't affect item creation chance. Each value in range has equal distribution.")]
    public int Min { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterTemplateInventory()
    {
    }
}
