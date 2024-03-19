using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRequireKill : BaseObject, IQuestRequireKill
{
    /// <summary>
    /// The number of characters that must be killed to 
    /// complete this quest.
    /// </summary>
    [Description("The number of characters that must be killed to complete this quest.")]
    public int Amount { get; set; }

    /// <summary>
    /// The template of the characters that must be 
    /// killed to complete this quest.
    /// </summary>
    [Description("The template of the characters that must be killed to complete this quest.")]
    public CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    [Description("The quest that this requirement is for.")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected QuestRequireKill()
    {
    }
}
