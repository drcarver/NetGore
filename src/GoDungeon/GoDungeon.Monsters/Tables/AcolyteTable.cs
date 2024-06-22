//
// Acolyte
// Containing file gamemaster_rules\monsters\acolyte.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.Tables;

/// <summary>
/// Acolyte
/// </summary>
public partial class AcolyteTable : NamedTable, IAcolyteTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public AcolyteTable()
	{
		Name = nameof(AcolyteTable);
		ProperName = "Acolyte Table";
		Description = "Acolyte";
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
				#region 10 (+0)
				new AcolyteTableEntryViewModel
				{
					STR = "10 (+0)",
					DEX = "10 (+0)",
					CON = "10 (+0)",
					INT = "10 (+0)",
					WIS = "14 (+2)",
					CHA = "11 (+0)",
				},
				#endregion

			};
		}
	}
}
