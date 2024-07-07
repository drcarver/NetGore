//
// Heavy Armor
// Containing file adventuring\equipment\armor.md
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
					Name = nameof(HeavyArmorEnum.Ringmail),
					ProperName = "Ring mail",
					Cost = new CostViewModel("30 gp"),
					ArmorClassAC = Convert.ToInt32(14),
					Strength = "-",
					Stealth = "Disadvantage",
					Weight = new WeightViewModel("40 lb."),
				},
				#endregion

				#region Chain mail
				new HeavyArmorTableEntryViewModel
				{
					Name = nameof(HeavyArmorEnum.Chainmail),
					ProperName = "Chain mail",
					Cost = new CostViewModel("75 gp"),
					ArmorClassAC = Convert.ToInt32(16),
					Strength = "Str 13",
					Stealth = "Disadvantage",
					Weight = new WeightViewModel("55 lb."),
				},
				#endregion

				#region Splint
				new HeavyArmorTableEntryViewModel
				{
					Name = nameof(HeavyArmorEnum.Splint),
					ProperName = "Splint",
					Cost = new CostViewModel("200 gp"),
					ArmorClassAC = Convert.ToInt32(17),
					Strength = "Str 15",
					Stealth = "Disadvantage",
					Weight = new WeightViewModel("60 lb."),
				},
				#endregion

				#region Plate
				new HeavyArmorTableEntryViewModel
				{
					Name = nameof(HeavyArmorEnum.Plate),
					ProperName = "Plate",
					Cost = new CostViewModel("1,500 gp"),
					ArmorClassAC = Convert.ToInt32(18),
					Strength = "Str 15",
					Stealth = "Disadvantage",
					Weight = new WeightViewModel("65 lb."),
				},
				#endregion

			};
		}
	}
}
