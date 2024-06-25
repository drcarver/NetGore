//
// Ammunition
// Containing file adventuring\equipment\adventuring_gear.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Ammunition
/// </summary>
public partial class AmmunitionTable : NamedTable, IAmmunitionTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public AmmunitionTable()
	{
		Name = nameof(AmmunitionTable);
		ProperName = "Ammunition Table";
		Description = "Ammunition";
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
				#region Arrows (20)
				new AmmunitionTableEntryViewModel
				{
                    Name = nameof(AmmunitionEnum.Arrows20),
					ProperName = "Arrows (20)",
					Cost = "1 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Blowgun needles (50)
				new AmmunitionTableEntryViewModel
				{
					Name = nameof(AmmunitionEnum.Blowgunneedles50),
					ProperName = "Blowgun needles (50)",
					Cost = "1 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Crossbow bolts (20)
				new AmmunitionTableEntryViewModel
				{
					Name = nameof(AmmunitionEnum.Crossbowbolts20),
					ProperName = "Crossbow bolts (20)",
					Cost = "1 gp",
					Weight = "1 1/2 lb.",
				},
				#endregion

				#region Sling bullets (20)
				new AmmunitionTableEntryViewModel
				{
					Name = nameof(AmmunitionEnum.Slingbullets20),
					ProperName = "Sling bullets (20)",
					Cost = "4 cp",
					Weight = "1 1/2 lb.",
				},
				#endregion

			};
		}
	}
}
