//
// Martial Melee Weapons
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
/// Martial Melee Weapons
/// </summary>
public partial class MartialMeleeWeaponsTable : NamedTable, IMartialMeleeWeaponsTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public MartialMeleeWeaponsTable()
	{
		Name = nameof(MartialMeleeWeaponsTable);
		ProperName = "Martial Melee Weapons Table";
		Description = "Martial Melee Weapons";
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
				#region Battleaxe
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Battleaxe",
					Cost = "10 gp",
					Damage = "1d8 slashing",
					Weight = "4 lb.",
					Properties = "Versatile (1d10)",
				},
				#endregion

				#region Flail
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Flail",
					Cost = "10 gp",
					Damage = "1d8 bludgeoning",
					Weight = "2 lb.",
					Properties = "-",
				},
				#endregion

				#region Glaive
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Glaive",
					Cost = "20 gp",
					Damage = "1d10 slashing",
					Weight = "6 lb.",
					Properties = "Heavy, reach, two-handed",
				},
				#endregion

				#region Greataxe
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Greataxe",
					Cost = "30 gp",
					Damage = "1d12 slashing",
					Weight = "7 lb.",
					Properties = "Heavy, two-handed",
				},
				#endregion

				#region Greatsword
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Greatsword",
					Cost = "50 gp",
					Damage = "2d6 slashing",
					Weight = "6 lb.",
					Properties = "Heavy, two-handed",
				},
				#endregion

				#region Halberd
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Halberd",
					Cost = "20 gp",
					Damage = "1d10 slashing",
					Weight = "6 lb.",
					Properties = "Heavy, reach, two-handed",
				},
				#endregion

				#region Lance
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Lance",
					Cost = "10 gp",
					Damage = "1d12 piercing",
					Weight = "6 lb.",
					Properties = "Reach, special",
				},
				#endregion

				#region Longsword
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Longsword",
					Cost = "15 gp",
					Damage = "1d8 slashing",
					Weight = "3 lb.",
					Properties = "Versatile (1d10)",
				},
				#endregion

				#region Maul
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Maul",
					Cost = "10 gp",
					Damage = "2d6 bludgeoning",
					Weight = "10 lb.",
					Properties = "Heavy, two-handed",
				},
				#endregion

				#region Morningstar
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Morningstar",
					Cost = "15 gp",
					Damage = "1d8 piercing",
					Weight = "4 lb.",
					Properties = "-",
				},
				#endregion

				#region Pike
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Pike",
					Cost = "5 gp",
					Damage = "1d10 piercing",
					Weight = "18 lb.",
					Properties = "Heavy, reach, two-handed",
				},
				#endregion

				#region Rapier
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Rapier",
					Cost = "25 gp",
					Damage = "1d8 piercing",
					Weight = "2 lb.",
					Properties = "Finesse",
				},
				#endregion

				#region Scimitar
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Scimitar",
					Cost = "25 gp",
					Damage = "1d6 slashing",
					Weight = "3 lb.",
					Properties = "Finesse, light",
				},
				#endregion

				#region Shortsword
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Shortsword",
					Cost = "10 gp",
					Damage = "1d6 piercing",
					Weight = "2 lb.",
					Properties = "Finesse, light",
				},
				#endregion

				#region Trident
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Trident",
					Cost = "5 gp",
					Damage = "1d6 piercing",
					Weight = "4 lb.",
					Properties = "Thrown (range 20/60), versatile (1d8)",
				},
				#endregion

				#region War pick
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "War pick",
					Cost = "5 gp",
					Damage = "1d8 piercing",
					Weight = "2 lb.",
					Properties = "-",
				},
				#endregion

				#region Warhammer
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Warhammer",
					Cost = "15 gp",
					Damage = "1d8 bludgeoning",
					Weight = "2 lb.",
					Properties = "Versatile (1d10)",
				},
				#endregion

				#region Whip
				new MartialMeleeWeaponsTableEntryViewModel
				{
					MartialMeleeWeapons = "Whip",
					Cost = "2 gp",
					Damage = "1d4 slashing",
					Weight = "3 lb.",
					Properties = "Finesse, reach",
				},
				#endregion

			};
		}
	}
}
