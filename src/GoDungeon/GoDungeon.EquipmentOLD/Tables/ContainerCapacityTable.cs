//
// Container Capacity
// Containing file adventuring\equipment\adventuring_gear.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Container Capacity
/// </summary>
public partial class ContainerCapacityTable : NamedTable, IContainerCapacityTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public ContainerCapacityTable()
	{
		Name = nameof(ContainerCapacityTable);
		ProperName = "Container Capacity Table";
		Description = "Container Capacity";
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
				#region Backpack*
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Backpack*",
					Capacity = "1 cubic foot/30 pounds of gear",
				},
				#endregion

				#region Barrel
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Barrel",
					Capacity = "40 gallons liquid, 4 cubic feet solid",
				},
				#endregion

				#region Basket
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Basket",
					Capacity = "2 cubic feet/40 pounds of gear",
				},
				#endregion

				#region Bottle
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Bottle",
					Capacity = "1 1/2 pints liquid",
				},
				#endregion

				#region Bucket
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Bucket",
					Capacity = "3 gallons liquid, 1/2 cubic foot solid",
				},
				#endregion

				#region Chest
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Chest",
					Capacity = "12 cubic feet/300 pounds gear",
				},
				#endregion

				#region Flask or tankard
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Flask or tankard",
					Capacity = "1 pint liquid",
				},
				#endregion

				#region Jug or pitcher
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Jug or pitcher",
					Capacity = "1 gallon liquid",
				},
				#endregion

				#region Pot, iron
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Pot, iron",
					Capacity = "1 gallon liquid",
				},
				#endregion

				#region Pouch
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Pouch",
					Capacity = "1/5 cubic foot/6 pounds of gear",
				},
				#endregion

				#region Sack
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Sack",
					Capacity = "1 cubic foot/30 pounds of gear",
				},
				#endregion

				#region Vial
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Vial",
					Capacity = "4 ounces liquid",
				},
				#endregion

				#region Waterskin
				new ContainerCapacityTableEntryViewModel
				{
					Container = "Waterskin",
					Capacity = "4 pints liquid",
				},
				#endregion

			};
		}
	}
}
