using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

public partial class WeaponPropertyViewModel : BaseObjectViewModel, IWeaponProperty
{
    /// <summary>
    /// The type of Damage
    /// </summary>
    [ObservableProperty]
    private WeaponPropertyTypeEnum? weaponPropertyType;

    /// <summary>
    /// The dice to roll for damage
    /// </summary>
    [ObservableProperty]
    private string weaponDamageDice = string.Empty;
}