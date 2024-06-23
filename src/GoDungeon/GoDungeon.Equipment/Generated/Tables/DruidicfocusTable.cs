//
// Druidic focus
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
/// Druidic focus
/// </summary>
public partial class DruidicfocusTable : NamedTable, IDruidicfocusTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public DruidicfocusTable()
	{
		Name = nameof(DruidicfocusTable);
		ProperName = "Druidic focus Table";
		Description = "Druidic focus";
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
				#region Sprig of mistletoe
				new DruidicfocusTableEntryViewModel
				{
					Item = "Sprig of mistletoe",
					Cost = "1 gp",
					Weight = "-",
				},
				#endregion

				#region Totem
				new DruidicfocusTableEntryViewModel
				{
					Item = "Totem",
					Cost = "1 gp",
					Weight = "-",
				},
				#endregion

				#region Wooden staff
				new DruidicfocusTableEntryViewModel
				{
					Item = "Wooden staff",
					Cost = "5 gp",
					Weight = "4 lb.",
				},
				#endregion

				#region Yew wand
				new DruidicfocusTableEntryViewModel
				{
					Item = "Yew wand",
					Cost = "10 gp",
					Weight = "1 lb.",
				},
				#endregion

			};
		}
	}
}
