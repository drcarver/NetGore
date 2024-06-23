//
// Mounts
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
/// Mounts
/// </summary>
public partial class MountsTable : NamedTable, IMountsTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public MountsTable()
	{
		Name = nameof(MountsTable);
		ProperName = "Mounts Table";
		Description = "Mounts";
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
				#region Camel
				new MountsTableEntryViewModel
				{
					Item = "Camel",
					Cost = "50 gp",
					Speed = "50 ft.",
					CarryingCapacity = "480 lb.",
				},
				#endregion

				#region Donkey or mule
				new MountsTableEntryViewModel
				{
					Item = "Donkey or mule",
					Cost = "8 gp",
					Speed = "40 ft.",
					CarryingCapacity = "420 lb.",
				},
				#endregion

				#region Elephant
				new MountsTableEntryViewModel
				{
					Item = "Elephant",
					Cost = "200 gp",
					Speed = "40 ft.",
					CarryingCapacity = "1,320 lb.",
				},
				#endregion

				#region Horse, draft
				new MountsTableEntryViewModel
				{
					Item = "Horse, draft",
					Cost = "50 gp",
					Speed = "40 ft.",
					CarryingCapacity = "540 lb.",
				},
				#endregion

				#region Horse, riding
				new MountsTableEntryViewModel
				{
					Item = "Horse, riding",
					Cost = "75 gp",
					Speed = "60 ft.",
					CarryingCapacity = "480 lb.",
				},
				#endregion

				#region Mastiff
				new MountsTableEntryViewModel
				{
					Item = "Mastiff",
					Cost = "25 gp",
					Speed = "40 ft.",
					CarryingCapacity = "195 lb.",
				},
				#endregion

				#region Pony
				new MountsTableEntryViewModel
				{
					Item = "Pony",
					Cost = "30 gp",
					Speed = "40 ft.",
					CarryingCapacity = "225 lb.",
				},
				#endregion

				#region Warhorse
				new MountsTableEntryViewModel
				{
					Item = "Warhorse",
					Cost = "400 gp",
					Speed = "60 ft.",
					CarryingCapacity = "540 lb.",
				},
				#endregion

			};
		}
	}
}
