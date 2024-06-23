//
// Heavy Armor
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
/// Heavy Armor
/// </summary>
public partial class HeavyArmorTable : NamedTable, IHeavyArmorTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public HeavyArmorTable()
	{
		Name = nameof(HeavyArmorTable);
		ProperName = "Heavy Armor Table";
		Description = "Heavy Armor";
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
				#region Ring mail
				new HeavyArmorTableEntryViewModel
				{
					HeavyArmor = "Ring mail",
					Cost = "30 gp",
					AC = 14,
					Strength = "-",
					Stealth = "Disadvantage",
					Weight = "40 lb.",
				},
				#endregion

				#region Chain mail
				new HeavyArmorTableEntryViewModel
				{
					HeavyArmor = "Chain mail",
					Cost = "75 gp",
					AC = 16,
					Strength = "Str 13",
					Stealth = "Disadvantage",
					Weight = "55 lb.",
				},
				#endregion

				#region Splint
				new HeavyArmorTableEntryViewModel
				{
					HeavyArmor = "Splint",
					Cost = "200 gp",
					AC = 17,
					Strength = "Str 15",
					Stealth = "Disadvantage",
					Weight = "60 lb.",
				},
				#endregion

				#region Plate
				new HeavyArmorTableEntryViewModel
				{
					HeavyArmor = "Plate",
					Cost = "1,500 gp",
					AC = 18,
					Strength = "Str 15",
					Stealth = "Disadvantage",
					Weight = "65 lb.",
				},
				#endregion

			};
		}
	}
}
