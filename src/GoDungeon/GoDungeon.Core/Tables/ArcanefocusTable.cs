//
// Arcane focus
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
					Item = "Crystal",
					Cost = "10 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Orb
				new ArcanefocusTableEntryViewModel
				{
					Item = "Orb",
					Cost = "20 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Rod
				new ArcanefocusTableEntryViewModel
				{
					Item = "Rod",
					Cost = "10 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Staff
				new ArcanefocusTableEntryViewModel
				{
					Item = "Staff",
					Cost = "5 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Wand
				new ArcanefocusTableEntryViewModel
				{
					Item = "Wand",
					Cost = "10 gp",
					Weight = "1 lb.",
				},
				#endregion

			};
		}
	}
}
