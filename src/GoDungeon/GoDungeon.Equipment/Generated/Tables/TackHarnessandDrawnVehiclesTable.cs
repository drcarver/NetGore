//
// Tack, Harness, and Drawn Vehicles
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
/// Tack, Harness, and Drawn Vehicles
/// </summary>
public partial class TackHarnessandDrawnVehiclesTable : NamedTable, ITackHarnessandDrawnVehiclesTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public TackHarnessandDrawnVehiclesTable()
	{
		Name = nameof(TackHarnessandDrawnVehiclesTable);
		ProperName = "Tack, Harness, and Drawn Vehicles Table";
		Description = "Tack, Harness, and Drawn Vehicles";
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
				#region Barding
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Barding),
					ProperName = "Barding",
					Cost = new CostViewModel("x4"),
					Weight = new WeightViewModel("x2"),
				},
				#endregion

				#region Bit and bridle
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Bitandbridle),
					ProperName = "Bit and bridle",
					Cost = new CostViewModel("2 gp"),
					Weight = new WeightViewModel("1 lb."),
				},
				#endregion

				#region Carriage
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Carriage),
					ProperName = "Carriage",
					Cost = new CostViewModel("100 gp"),
					Weight = new WeightViewModel("600 lb."),
				},
				#endregion

				#region Cart
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Cart),
					ProperName = "Cart",
					Cost = new CostViewModel("15 gp"),
					Weight = new WeightViewModel("200 lb."),
				},
				#endregion

				#region Chariot
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Chariot),
					ProperName = "Chariot",
					Cost = new CostViewModel("250 gp"),
					Weight = new WeightViewModel("100 lb."),
				},
				#endregion

				#region Feed (per day)
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Feedperday),
					ProperName = "Feed (per day)",
					Cost = new CostViewModel("5 cp"),
					Weight = new WeightViewModel("10 lb."),
				},
				#endregion

				#region Saddlebags
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Saddlebags),
					ProperName = "Saddlebags",
					Cost = new CostViewModel("4 gp"),
					Weight = new WeightViewModel("8 lb."),
				},
				#endregion

				#region Sled
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Sled),
					ProperName = "Sled",
					Cost = new CostViewModel("20 gp"),
					Weight = new WeightViewModel("300 lb."),
				},
				#endregion

				#region Stabling (per day)
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Stablingperday),
					ProperName = "Stabling (per day)",
					Cost = new CostViewModel("5 sp"),
					Weight = new WeightViewModel("-"),
				},
				#endregion

				#region Wagon
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Name = nameof(TackHarnessandDrawnVehiclesEnum.Wagon),
					ProperName = "Wagon",
					Cost = new CostViewModel("35 gp"),
					Weight = new WeightViewModel("400 lb."),
				},
				#endregion

			};
		}
	}
}
