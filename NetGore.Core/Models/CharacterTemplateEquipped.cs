using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplateEquipped : BaseObject, ICharacterTemplateEquipped
{
    /// <summary>
    /// The chance of the item being equipped when a 
    /// character is instantiated from this template.
    /// </summary>
    [Description("The chance of the item being equipped when a character is instantiated from this template.")]
    public ItemChance? Chance { get; set; }

    /// <summary>
    /// The character template.
    /// </summary>
    [Description("The character template.")]
    public CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The item the character template has equipped.
    /// </summary>
    [Description("The item the character template has equipped.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterTemplateEquipped()
    {
       
    }
}
