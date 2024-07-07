//
// Container Capacity
// Containing file adventuring\equipment\adventuring_gear.md
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
					Name = nameof(ContainerCapacityEnum.Backpack),
					ProperName = "Backpack*",
					Capacity = "1 cubic foot/30 pounds of gear",
				},
				#endregion

				#region Barrel
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Barrel),
					ProperName = "Barrel",
					Capacity = "40 gallons liquid, 4 cubic feet solid",
				},
				#endregion

				#region Basket
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Basket),
					ProperName = "Basket",
					Capacity = "2 cubic feet/40 pounds of gear",
				},
				#endregion

				#region Bottle
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Bottle),
					ProperName = "Bottle",
					Capacity = "1 1/2 pints liquid",
				},
				#endregion

				#region Bucket
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Bucket),
					ProperName = "Bucket",
					Capacity = "3 gallons liquid, 1/2 cubic foot solid",
				},
				#endregion

				#region Chest
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Chest),
					ProperName = "Chest",
					Capacity = "12 cubic feet/300 pounds gear",
				},
				#endregion

				#region Flask or tankard
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Flaskortankard),
					ProperName = "Flask or tankard",
					Capacity = "1 pint liquid",
				},
				#endregion

				#region Jug or pitcher
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Jugorpitcher),
					ProperName = "Jug or pitcher",
					Capacity = "1 gallon liquid",
				},
				#endregion

				#region Pot, iron
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Potiron),
					ProperName = "Pot, iron",
					Capacity = "1 gallon liquid",
				},
				#endregion

				#region Pouch
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Pouch),
					ProperName = "Pouch",
					Capacity = "1/5 cubic foot/6 pounds of gear",
				},
				#endregion

				#region Sack
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Sack),
					ProperName = "Sack",
					Capacity = "1 cubic foot/30 pounds of gear",
				},
				#endregion

				#region Vial
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Vial),
					ProperName = "Vial",
					Capacity = "4 ounces liquid",
				},
				#endregion

				#region Waterskin
				new ContainerCapacityTableEntryViewModel
				{
					Name = nameof(ContainerCapacityEnum.Waterskin),
					ProperName = "Waterskin",
					Capacity = "4 pints liquid",
				},
				#endregion

			};
		}
	}
}
