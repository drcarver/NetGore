using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterStatusEffect : BaseObject, ICharacterStatusEffect
{
    /// <summary>
    /// The Character that the status effect is on.
    /// </summary>
    [Description("The Character that the status effect is on.")]
    public PlayerCharacter? Character { get; set; }

    /// <summary>
    /// The status effect instance.".
    /// </summary>
    [Description("The status effect instance.")]
    public ActiveStatusEffect? ActiveStatusEffect { get; set; }

    /// <summary>
    /// The power of this status effect instance.
    /// </summary>
    [Description("The power of this status effect instance.")]
    public int Power { get; set; }

    /// <summary>
    /// The status effect that this effect is for. This 
    /// corresponds to the StatusEffectType enum's value.
    /// </summary>
    [Description("The status effect that this effect is for. This corresponds to the StatusEffectType enum's value.")]
    public StatusEffectType StatusEffect { get; set; }

    /// <summary>
    /// The amount of time remaining for this status 
    /// effect in seconds.
    /// </summary>
    [Description("The amount of time remaining for this status effect in seconds.")]
    public int TimeLeftSecs { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterStatusEffect()
    {
    }
}
