//
// Aboleth
// Containing file gamemaster_rules\monsters\aboleth.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.Tables;

/// <summary>
/// Aboleth
/// </summary>
public partial class AbolethTable : NamedTable, IAbolethTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public AbolethTable()
	{
		Name = nameof(AbolethTable);
		ProperName = "Aboleth Table";
		Description = "Aboleth";
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
				#region 21 (+5)
				new AbolethTableEntryViewModel
				{
					STR = "21 (+5)",
					DEX = "9 (-1)",
					CON = "15 (+2)",
					INT = "18 (+4)",
					WIS = "15 (+2)",
					CHA = "18 (+4)",
				},
				#endregion

			};
		}
	}
}
