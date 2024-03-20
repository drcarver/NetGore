using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplateQuestProvider : BaseObject, ICharacterTemplateQuestProvider
{
    /// <summary>
    /// The character template.
    /// </summary>
    [Description("The character template.")]
    public CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The quest provided by this character template. 
    /// Only applies for valid quest givers (that is, 
    /// not users).
    /// </summary>
    [Description("The quest provided by this character template. Only applies for valid quest givers (that is, not users).")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterTemplateQuestProvider()
    {
    }
}
