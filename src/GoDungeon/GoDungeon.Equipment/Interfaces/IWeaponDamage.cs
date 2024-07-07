using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces;

public interface IWeaponDamage : IBaseObject
{
    /// <summary>
    /// The type of Damage
    /// </summary>
    WeaponDamageTypeEnum? WeaponDamageType { get; set; }

    /// <summary>
    /// The dice to roll for damage
    /// </summary>
    string WeaponDamageDice { get; set; }
}