using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterSkill : BaseObject, ICharacterSkill
{
    /// <summary>
    /// The character that knows the skill.
    /// </summary>
    [Description("The character that knows the skill.")]
    public PlayerCharacter? Character { get; set; }

    /// <summary>
    /// The skill the character knows.
    /// </summary>
    [Description("The skill the character knows.")]
    public Skill? Skill { get; set; }

    /// <summary>
    /// When this row was added.
    /// </summary>
    [Description("When this row was added.")]
    public DateTime TimeAdded { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterSkill()
    {
    }
}
