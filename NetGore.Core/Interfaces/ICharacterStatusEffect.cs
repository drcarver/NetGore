using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterStatusEffect
{
    /// <summary>
    /// The Character that the status effect is on.
    /// </summary>
    Character? Character { get; set; }

    /// <summary>
    /// The status effect instance.".
    /// </summary>
    ActiveStatusEffect? ActiveStatusEffect { get; set; }

    /// <summary>
    /// The power of this status effect instance.
    /// </summary>
    int Power { get; set; }

    /// <summary>
    /// The status effect that this effect is for. This 
    /// corresponds to the StatusEffectType enum's value.
    /// </summary>
    StatusEffectType StatusEffect { get; set; }

    /// <summary>
    /// The amount of time remaining for this status 
    /// effect in seconds.
    /// </summary>
    int TimeLeftSecs { get; set; }
}