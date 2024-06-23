//
// Tack, Harness, and Drawn Vehicles
// Containing file adventuring\equipment\mounts_and_vehicles.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

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
					Item = "Barding",
					Cost = "x4",
					Weight = "x2",
				},
				#endregion

				#region Bit and bridle
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Bit and bridle",
					Cost = "2 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Carriage
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Carriage",
					Cost = "100 gp",
					Weight = "600 lb.",
				},
				#endregion

				#region Cart
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Cart",
					Cost = "15 gp",
					Weight = "200 lb.",
				},
				#endregion

				#region Chariot
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Chariot",
					Cost = "250 gp",
					Weight = "100 lb.",
				},
				#endregion

				#region Feed (per day)
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Feed (per day)",
					Cost = "5 cp",
					Weight = "10 lb.",
				},
				#endregion

				#region Saddlebags
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Saddlebags",
					Cost = "4 gp",
					Weight = "8 lb.",
				},
				#endregion

				#region Sled
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Sled",
					Cost = "20 gp",
					Weight = "300 lb.",
				},
				#endregion

				#region Stabling (per day)
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Stabling (per day)",
					Cost = "5 sp",
					Weight = "-",
				},
				#endregion

				#region Wagon
				new TackHarnessandDrawnVehiclesTableEntryViewModel
				{
					Item = "Wagon",
					Cost = "35 gp",
					Weight = "400 lb.",
				},
				#endregion

			};
		}
	}
}
