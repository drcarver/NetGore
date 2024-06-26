using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

public partial class WeaponDamageViewModel : BaseObjectViewModel, IWeaponDamage
{
    /// <summary>
    /// The type of Damage
    /// </summary>
    [ObservableProperty]
    private WeaponDamageTypeEnum? weaponDamageType;

    /// <summary>
    /// The dice to roll for damage
    /// </summary>
    [ObservableProperty]
    private string weaponDamageDice;

    /// <summary>
    /// Override to convert to a string
    /// </summary>
    /// <returns>The weight as a string</returns>
    public override string ToString()
    {
        if (WeaponDamageDice == string.Empty)
        {
            return string.Empty;
        }

        return $"{WeaponDamageDice} {WeaponDamageType.ToString()}";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="value">The value to be converted to a cost view model</param>
    public WeaponDamageViewModel(string  value)
    {
        string[] damage = value.Split(' ');
        if (damage.Length == 2)
        {
            WeaponDamageDice = damage[0].ToLower().Trim();
            WeaponDamageTypeEnum damageType;
            if (System.Enum.TryParse<Enum.WeaponDamageTypeEnum>(damage[1].Trim(), true, out damageType))
            {
                WeaponDamageType = damageType;
            }
        }
    }
}