//
// Getting Into and Out of Armor
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
/// Getting Into and Out of Armor
/// </summary>
public partial class GettingIntoandOutofArmorTable : NamedTable, IGettingIntoandOutofArmorTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public GettingIntoandOutofArmorTable()
	{
		Name = nameof(GettingIntoandOutofArmorTable);
		ProperName = "Getting Into and Out of Armor Table";
		Description = "Getting Into and Out of Armor";
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
				#region Light Armor
				new GettingIntoandOutofArmorTableEntryViewModel
				{
					Name = nameof(GettingIntoandOutofArmorEnum.LightArmor),
					ProperName = "Light Armor",
					Don = "1 minute",
					Doff = "1 minute",
				},
				#endregion

				#region Medium Armor
				new GettingIntoandOutofArmorTableEntryViewModel
				{
					Name = nameof(GettingIntoandOutofArmorEnum.MediumArmor),
					ProperName = "Medium Armor",
					Don = "5 minutes",
					Doff = "1 minute",
				},
				#endregion

				#region Heavy Armor
				new GettingIntoandOutofArmorTableEntryViewModel
				{
					Name = nameof(GettingIntoandOutofArmorEnum.HeavyArmor),
					ProperName = "Heavy Armor",
					Don = "10 minutes",
					Doff = "5 minutes",
				},
				#endregion

				#region Shield
				new GettingIntoandOutofArmorTableEntryViewModel
				{
					Name = nameof(GettingIntoandOutofArmorEnum.Shield),
					ProperName = "Shield",
					Don = "1 action",
					Doff = "1 action",
				},
				#endregion

			};
		}
	}
}
