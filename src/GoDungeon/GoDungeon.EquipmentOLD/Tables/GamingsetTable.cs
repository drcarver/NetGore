//
// Gaming set
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
/// Gaming set
/// </summary>
public partial class GamingsetTable : NamedTable, IGamingsetTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public GamingsetTable()
	{
		Name = nameof(GamingsetTable);
		ProperName = "Gaming set Table";
		Description = "Gaming set";
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
				#region Dice set
				new GamingsetTableEntryViewModel
				{
					Item = "Dice set",
					Cost = "1 sp",
					Weight = "-",
				},
				#endregion

				#region Playing card set
				new GamingsetTableEntryViewModel
				{
					Item = "Playing card set",
					Cost = "5 sp",
					Weight = "-",
				},
				#endregion

			};
		}
	}
}
