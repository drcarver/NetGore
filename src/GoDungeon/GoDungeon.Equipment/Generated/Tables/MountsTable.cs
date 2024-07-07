//
// Mounts
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
					Name = nameof(MountsEnum.Camel),
					ProperName = "Camel",
					Cost = new CostViewModel("50 gp"),
					Speed = "50 ft.",
					CarryingCapacity = "480 lb.",
				},
				#endregion

				#region Donkey or mule
				new MountsTableEntryViewModel
				{
					Name = nameof(MountsEnum.Donkeyormule),
					ProperName = "Donkey or mule",
					Cost = new CostViewModel("8 gp"),
					Speed = "40 ft.",
					CarryingCapacity = "420 lb.",
				},
				#endregion

				#region Elephant
				new MountsTableEntryViewModel
				{
					Name = nameof(MountsEnum.Elephant),
					ProperName = "Elephant",
					Cost = new CostViewModel("200 gp"),
					Speed = "40 ft.",
					CarryingCapacity = "1,320 lb.",
				},
				#endregion

				#region Horse, draft
				new MountsTableEntryViewModel
				{
					Name = nameof(MountsEnum.Horsedraft),
					ProperName = "Horse, draft",
					Cost = new CostViewModel("50 gp"),
					Speed = "40 ft.",
					CarryingCapacity = "540 lb.",
				},
				#endregion

				#region Horse, riding
				new MountsTableEntryViewModel
				{
					Name = nameof(MountsEnum.Horseriding),
					ProperName = "Horse, riding",
					Cost = new CostViewModel("75 gp"),
					Speed = "60 ft.",
					CarryingCapacity = "480 lb.",
				},
				#endregion

				#region Mastiff
				new MountsTableEntryViewModel
				{
					Name = nameof(MountsEnum.Mastiff),
					ProperName = "Mastiff",
					Cost = new CostViewModel("25 gp"),
					Speed = "40 ft.",
					CarryingCapacity = "195 lb.",
				},
				#endregion

				#region Pony
				new MountsTableEntryViewModel
				{
					Name = nameof(MountsEnum.Pony),
					ProperName = "Pony",
					Cost = new CostViewModel("30 gp"),
					Speed = "40 ft.",
					CarryingCapacity = "225 lb.",
				},
				#endregion

				#region Warhorse
				new MountsTableEntryViewModel
				{
					Name = nameof(MountsEnum.Warhorse),
					ProperName = "Warhorse",
					Cost = new CostViewModel("400 gp"),
					Speed = "60 ft.",
					CarryingCapacity = "540 lb.",
				},
				#endregion

			};
		}
	}
}
