//
// Medium Armor
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
					MediumArmor = "Hide",
					Cost = "10 gp",
					AC = "12 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "-",
					Weight = "12 lb.",
				},
				#endregion

				#region Chain shirt
				new MediumArmorTableEntryViewModel
				{
					MediumArmor = "Chain shirt",
					Cost = "50 gp",
					AC = "13 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "-",
					Weight = "20 lb.",
				},
				#endregion

				#region Scale mail
				new MediumArmorTableEntryViewModel
				{
					MediumArmor = "Scale mail",
					Cost = "50 gp",
					AC = "14 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "Disadvantage",
					Weight = "45 lb.",
				},
				#endregion

				#region Breastplate
				new MediumArmorTableEntryViewModel
				{
					MediumArmor = "Breastplate",
					Cost = "400 gp",
					AC = "14 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "-",
					Weight = "20 lb.",
				},
				#endregion

				#region Half plate
				new MediumArmorTableEntryViewModel
				{
					MediumArmor = "Half plate",
					Cost = "750 gp",
					AC = "15 + Dex modifier (max 2)",
					Strength = "-",
					Stealth = "Disadvantage",
					Weight = "40 lb.",
				},
				#endregion

			};
		}
	}
}
