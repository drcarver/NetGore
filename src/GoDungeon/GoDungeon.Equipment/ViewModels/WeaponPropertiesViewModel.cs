using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

public partial class WeaponPropertiesViewModel : BaseObjectViewModel, IWeaponProperties
{
    /// <summary>
    /// The properties of the weapon
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<WeaponPropertyViewModel> weaponProperties;

    /// <summary>
    /// Override to convert to a string
    /// </summary>
    /// <returns>The weight as a string</returns>
    public override string ToString()
    {
        return base.ToString();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="value">The value to be converted to a cost view model</param>
    public WeaponPropertiesViewModel(string  value)
    {

    }
}