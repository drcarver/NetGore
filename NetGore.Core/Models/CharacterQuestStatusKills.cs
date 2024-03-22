using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterQuestStatusKills : BaseObject, ICharacterQuestStatusKills
{
    /// <summary>
    /// The character who is doing this quest.
    /// </summary>
    [Description("The character who is doing this quest.")]
    public PlayerCharacter? Character { get; set; }

    /// <summary>
    /// The character template that is to be killed for 
    /// the quest.
    /// </summary>
    [Description("The character template that is to be killed for the quest.")]
    public CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The current kill count of characters with this 
    /// template.
    /// </summary>
    [Description("The current kill count of characters with this template.")]
    public int Count { get; set; }

    /// <summary>
    /// The quest that the kill count is for.
    /// </summary>
    [Description("The quest that the kill count is for.")]
    public Quest? Quest { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterQuestStatusKills()
    {
    }
}
