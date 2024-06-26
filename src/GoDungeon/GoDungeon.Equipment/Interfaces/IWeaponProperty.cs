using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces;

public interface IWeaponProperty
{
    /// <summary>
    /// The type of Damage
    /// </summary>
    WeaponPropertyTypeEnum? WeaponPropertyType { get; set; }

    /// <summary>
    /// The dice to roll for damage
    /// </summary>
    string WeaponDamageDice { get; set; }
}