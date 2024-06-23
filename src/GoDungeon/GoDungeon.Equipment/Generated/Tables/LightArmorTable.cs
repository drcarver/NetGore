//
// Light Armor
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
					LightArmor = "Padded",
					Cost = "5 gp",
					AC = "11 + Dex modifier",
					Strength = "-",
					Stealth = "Disadvantage",
					Weight = "8 lb.",
				},
				#endregion

				#region Leather
				new LightArmorTableEntryViewModel
				{
					LightArmor = "Leather",
					Cost = "10 gp",
					AC = "11 + Dex modifier",
					Strength = "-",
					Stealth = "-",
					Weight = "10 lb.",
				},
				#endregion

				#region Studded leather
				new LightArmorTableEntryViewModel
				{
					LightArmor = "Studded leather",
					Cost = "45 gp",
					AC = "12 + Dex modifier",
					Strength = "-",
					Stealth = "-",
					Weight = "13 lb.",
				},
				#endregion

			};
		}
	}
}
