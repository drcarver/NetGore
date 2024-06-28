//
// Waterborne Vehicles
// Containing file adventuring\equipment\mounts_and_vehicles.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Waterborne Vehicles
/// </summary>
public partial class WaterborneVehiclesTable : NamedTable, IWaterborneVehiclesTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public WaterborneVehiclesTable()
	{
		Name = nameof(WaterborneVehiclesTable);
		ProperName = "Waterborne Vehicles Table";
		Description = "Waterborne Vehicles";
	}

	/// <summary>
	/// Initialize the table.  This is a separate method so
	/// we can create a game table for it's meta properties
	/// with out creating the actual table values.  A bit of
	/// optimization to conserve memory on big tables
	/// </summary>
	public override void InitializeTable()
	{
		if (Table == null || Table.Count == 0)
		{
			Table = new ObservableCollection<IGameTableEntry>()
			{
				#region Galley
				new WaterborneVehiclesTableEntryViewModel
				{
					Name = nameof(WaterborneVehiclesEnum.Galley),
					ProperName = "Galley",
					Cost = new CostViewModel("30,000 gp"),
					Speed = "4 mph",
				},
				#endregion

				#region Keelboat
				new WaterborneVehiclesTableEntryViewModel
				{
					Name = nameof(WaterborneVehiclesEnum.Keelboat),
					ProperName = "Keelboat",
					Cost = new CostViewModel("3,000 gp"),
					Speed = "1 mph",
				},
				#endregion

				#region Longship
				new WaterborneVehiclesTableEntryViewModel
				{
					Name = nameof(WaterborneVehiclesEnum.Longship),
					ProperName = "Longship",
					Cost = new CostViewModel("10,000 gp"),
					Speed = "3 mph",
				},
				#endregion

				#region Rowboat
				new WaterborneVehiclesTableEntryViewModel
				{
					Name = nameof(WaterborneVehiclesEnum.Rowboat),
					ProperName = "Rowboat",
					Cost = new CostViewModel("50 gp"),
					Speed = "1 1/2  mph",
				},
				#endregion

				#region Sailing ship
				new WaterborneVehiclesTableEntryViewModel
				{
					Name = nameof(WaterborneVehiclesEnum.Sailingship),
					ProperName = "Sailing ship",
					Cost = new CostViewModel("10,000 gp"),
					Speed = "2 mph",
				},
				#endregion

				#region Warship
				new WaterborneVehiclesTableEntryViewModel
				{
					Name = nameof(WaterborneVehiclesEnum.Warship),
					ProperName = "Warship",
					Cost = new CostViewModel("25,000 gp"),
					Speed = "2 1/2 mph",
				},
				#endregion

			};
		}
	}
}
