//
// Adventuring Gear view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Adventuring Gear
/// </summary>
public partial class AdventuringGearTableEntryViewModel : EquipmentTableEntryViewModel, IAdventuringGearTableEntry
{
}
