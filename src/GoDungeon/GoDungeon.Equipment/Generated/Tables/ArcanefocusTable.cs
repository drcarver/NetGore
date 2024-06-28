//
// Arcane focus
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
/// Arcane focus
/// </summary>
public partial class ArcanefocusTable : NamedTable, IArcanefocusTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public ArcanefocusTable()
	{
		Name = nameof(ArcanefocusTable);
		ProperName = "Arcane focus Table";
		Description = "Arcane focus";
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
				#region Crystal
				new ArcanefocusTableEntryViewModel
				{
					Name = nameof(ArcanefocusEnum.Crystal),
					ProperName = "Crystal",
					Cost = new CostViewModel("10 gp"),
					Weight = new WeightViewModel("1 lb."),
				},
				#endregion

				#region Orb
				new ArcanefocusTableEntryViewModel
				{
					Name = nameof(ArcanefocusEnum.Orb),
					ProperName = "Orb",
					Cost = new CostViewModel("20 gp"),
					Weight = new WeightViewModel("3 lb."),
				},
				#endregion

				#region Rod
				new ArcanefocusTableEntryViewModel
				{
					Name = nameof(ArcanefocusEnum.Rod),
					ProperName = "Rod",
					Cost = new CostViewModel("10 gp"),
					Weight = new WeightViewModel("2 lb."),
				},
				#endregion

				#region Staff
				new ArcanefocusTableEntryViewModel
				{
					Name = nameof(ArcanefocusEnum.Staff),
					ProperName = "Staff",
					Cost = new CostViewModel("5 gp"),
					Weight = new WeightViewModel("4 lb."),
				},
				#endregion

				#region Wand
				new ArcanefocusTableEntryViewModel
				{
					Name = nameof(ArcanefocusEnum.Wand),
					ProperName = "Wand",
					Cost = new CostViewModel("10 gp"),
					Weight = new WeightViewModel("1 lb."),
				},
				#endregion

			};
		}
	}
}
