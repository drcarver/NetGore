//
// Other tools
// Containing file adventuring\equipment\tools.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Other tools
/// </summary>
public partial class OthertoolsTable : NamedTable, IOthertoolsTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public OthertoolsTable()
	{
		Name = nameof(OthertoolsTable);
		ProperName = "Other tools Table";
		Description = "Other tools";
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
				#region Herbalism kit
				new OthertoolsTableEntryViewModel
				{
					Item = "Herbalism kit",
					Cost = "5 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Navigator's tools
				new OthertoolsTableEntryViewModel
				{
					Item = "Navigator's tools",
					Cost = "25 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Poisoner's kit
				new OthertoolsTableEntryViewModel
				{
					Item = "Poisoner's kit",
					Cost = "50 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Thieves' tools
				new OthertoolsTableEntryViewModel
				{
					Item = "Thieves' tools",
					Cost = "25 gp",
					Weight = "1 lb.",
				},
				#endregion

			};
		}
	}
}
