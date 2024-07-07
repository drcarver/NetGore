//
// Light Armor
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
/// Light Armor
/// </summary>
public partial class LightArmorTable : NamedTable, ILightArmorTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public LightArmorTable()
	{
		Name = nameof(LightArmorTable);
		ProperName = "Light Armor Table";
		Description = "Light Armor";
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
				#region Padded
				new LightArmorTableEntryViewModel
				{
					Name = nameof(LightArmorEnum.Padded),
					ProperName = "Padded",
					Cost = new CostViewModel("5 gp"),
					ArmorClassAC = "11 + Dex modifier",
					Strength = "-",
					Stealth = "Disadvantage",
					Weight = new WeightViewModel("8 lb."),
				},
				#endregion

				#region Leather
				new LightArmorTableEntryViewModel
				{
					Name = nameof(LightArmorEnum.Leather),
					ProperName = "Leather",
					Cost = new CostViewModel("10 gp"),
					ArmorClassAC = "11 + Dex modifier",
					Strength = "-",
					Stealth = "-",
					Weight = new WeightViewModel("10 lb."),
				},
				#endregion

				#region Studded leather
				new LightArmorTableEntryViewModel
				{
					Name = nameof(LightArmorEnum.Studdedleather),
					ProperName = "Studded leather",
					Cost = new CostViewModel("45 gp"),
					ArmorClassAC = "12 + Dex modifier",
					Strength = "-",
					Stealth = "-",
					Weight = new WeightViewModel("13 lb."),
				},
				#endregion

			};
		}
	}
}
