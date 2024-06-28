//
// Saddles
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
/// Saddles
/// </summary>
public partial class SaddlesTable : NamedTable, ISaddlesTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public SaddlesTable()
	{
		Name = nameof(SaddlesTable);
		ProperName = "Saddles Table";
		Description = "Saddles";
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
				#region Exotic
				new SaddlesTableEntryViewModel
				{
					Name = nameof(SaddlesEnum.Exotic),
					ProperName = "Exotic",
					Cost = new CostViewModel("60 gp"),
					Weight = new WeightViewModel("40 lb."),
				},
				#endregion

				#region Military
				new SaddlesTableEntryViewModel
				{
					Name = nameof(SaddlesEnum.Military),
					ProperName = "Military",
					Cost = new CostViewModel("20 gp"),
					Weight = new WeightViewModel("30 lb."),
				},
				#endregion

				#region Pack
				new SaddlesTableEntryViewModel
				{
					Name = nameof(SaddlesEnum.Pack),
					ProperName = "Pack",
					Cost = new CostViewModel("5 gp"),
					Weight = new WeightViewModel("15 lb."),
				},
				#endregion

				#region Riding
				new SaddlesTableEntryViewModel
				{
					Name = nameof(SaddlesEnum.Riding),
					ProperName = "Riding",
					Cost = new CostViewModel("10 gp"),
					Weight = new WeightViewModel("25 lb."),
				},
				#endregion

			};
		}
	}
}
