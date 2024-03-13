using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterStatusEffect
{
    ActiveStatusEffect ActiveStatusEffect { get; set; }
    Character Character { get; set; }
    int Power { get; set; }
    StatusEffectType StatusEffect { get; set; }
    int TimeLeftSecs { get; set; }
}