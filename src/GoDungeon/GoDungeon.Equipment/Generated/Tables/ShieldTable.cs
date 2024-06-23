//
// Shield
// Containing file adventuring\equipment\armor.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Shield
/// </summary>
public partial class ShieldTable : NamedTable, IShieldTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public ShieldTable()
	{
		Name = nameof(ShieldTable);
		ProperName = "Shield Table";
		Description = "Shield";
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
				#region Shield
				new ShieldTableEntryViewModel
				{
					Shield = "Shield",
					Cost = "10 gp",
					AC = +2,
					Strength = "-",
					Stealth = "-",
					Weight = "6  lb.",
				},
				#endregion

			};
		}
	}
}
