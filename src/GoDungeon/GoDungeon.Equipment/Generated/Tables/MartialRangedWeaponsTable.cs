//
// Martial Ranged Weapons
// Containing file adventuring\equipment\weapons.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.Tables;

/// <summary>
/// Martial Ranged Weapons
/// </summary>
public partial class MartialRangedWeaponsTable : NamedTable, IMartialRangedWeaponsTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public MartialRangedWeaponsTable()
	{
		Name = nameof(MartialRangedWeaponsTable);
		ProperName = "Martial Ranged Weapons Table";
		Description = "Martial Ranged Weapons";
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
				#region Blowgun
				new MartialRangedWeaponsTableEntryViewModel
				{
					MartialRangedWeapons = "Blowgun",
					Cost = "10 gp",
					Damage = "1 piercing",
					Weight = "1 lb.",
					Properties = "Ammunition (range 25/100), loading",
				},
				#endregion

				#region Crossbow, hand
				new MartialRangedWeaponsTableEntryViewModel
				{
					MartialRangedWeapons = "Crossbow, hand",
					Cost = "75 gp",
					Damage = "1d6 piercing",
					Weight = "3 lb.",
					Properties = "Ammunition (range 30/120), light, loading",
				},
				#endregion

				#region Crossbow, heavy
				new MartialRangedWeaponsTableEntryViewModel
				{
					MartialRangedWeapons = "Crossbow, heavy",
					Cost = "50 gp",
					Damage = "1d10 piercing",
					Weight = "18 lb.",
					Properties = "Ammunition (range 100/400), heavy, loading, two-handed",
				},
				#endregion

				#region Longbow
				new MartialRangedWeaponsTableEntryViewModel
				{
					MartialRangedWeapons = "Longbow",
					Cost = "50 gp",
					Damage = "1d8 piercing",
					Weight = "2 lb.",
					Properties = "Ammunition (range 150/600), heavy, two-handed",
				},
				#endregion

				#region Net
				new MartialRangedWeaponsTableEntryViewModel
				{
					MartialRangedWeapons = "Net",
					Cost = "1 gp",
					Damage = "-",
					Weight = "3 lb.",
					Properties = "Special, thrown (range 5/15)",
				},
				#endregion

			};
		}
	}
}
