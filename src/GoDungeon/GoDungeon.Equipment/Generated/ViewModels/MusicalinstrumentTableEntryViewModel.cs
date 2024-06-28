//
// Musical instrument view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Musical instrument
/// </summary>
public partial class MusicalinstrumentTableEntryViewModel : EquipmentTableEntryViewModel, IMusicalinstrumentTableEntry
{
}
