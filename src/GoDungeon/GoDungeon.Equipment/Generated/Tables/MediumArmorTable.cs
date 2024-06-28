//
// Medium Armor
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
/// Medium Armor
/// </summary>
public partial class MediumArmorTable : NamedTable, IMediumArmorTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public MediumArmorTable()
	{
		Name = nameof(MediumArmorTable);
		ProperName = "Medium Armor Table";
		Description = "Medium Armor";
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
				#region Hide
				new MediumArmorTableEntryViewModel
				{
					Name = nameof(MediumArmorEnum.Hide),
					ProperName = "Hide",
					Cost = new CostViewModel("10 gp"),
					ArmorClassAC = "12 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "-",
					Weight = new WeightViewModel("12 lb."),
				},
				#endregion

				#region Chain shirt
				new MediumArmorTableEntryViewModel
				{
					Name = nameof(MediumArmorEnum.Chainshirt),
					ProperName = "Chain shirt",
					Cost = new CostViewModel("50 gp"),
					ArmorClassAC = "13 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "-",
					Weight = new WeightViewModel("20 lb."),
				},
				#endregion

				#region Scale mail
				new MediumArmorTableEntryViewModel
				{
					Name = nameof(MediumArmorEnum.Scalemail),
					ProperName = "Scale mail",
					Cost = new CostViewModel("50 gp"),
					ArmorClassAC = "14 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "Disadvantage",
					Weight = new WeightViewModel("45 lb."),
				},
				#endregion

				#region Breastplate
				new MediumArmorTableEntryViewModel
				{
					Name = nameof(MediumArmorEnum.Breastplate),
					ProperName = "Breastplate",
					Cost = new CostViewModel("400 gp"),
					ArmorClassAC = "14 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "-",
					Weight = new WeightViewModel("20 lb."),
				},
				#endregion

				#region Half plate
				new MediumArmorTableEntryViewModel
				{
					Name = nameof(MediumArmorEnum.Halfplate),
					ProperName = "Half plate",
					Cost = new CostViewModel("750 gp"),
					ArmorClassAC = "15 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "Disadvantage",
					Weight = new WeightViewModel("40 lb."),
				},
				#endregion

			};
		}
	}
}
