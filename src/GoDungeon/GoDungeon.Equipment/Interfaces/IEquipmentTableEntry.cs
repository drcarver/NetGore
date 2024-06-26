//
// Adventuring Gear view model interface
//
using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.ViewModels;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IAdventuring Gear
/// </summary>
public interface IEquipmentTableEntry : IStandardTableEntry
{
	/// <summary>
	/// Cost
	/// </summary>
	CostViewModel? Cost { get; set; }

	/// <summary>
	/// Weight
	/// </summary>
	WeightViewModel? Weight { get; set; }
}
