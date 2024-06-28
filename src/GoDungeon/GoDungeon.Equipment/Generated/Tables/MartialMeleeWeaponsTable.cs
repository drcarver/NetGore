//
// Martial Melee Weapons
// Containing file adventuring\equipment\weapons.md
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
					Name = nameof(MartialMeleeWeaponsEnum.Battleaxe),
					ProperName = "Battleaxe",
					Cost = new CostViewModel("10 gp"),
					Damage = new WeaponDamageViewModel("1d8 slashing"),
					Weight = new WeightViewModel("4 lb."),
					Properties = "Versatile (1d10)",
				},
				#endregion

				#region Flail
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Flail),
					ProperName = "Flail",
					Cost = new CostViewModel("10 gp"),
					Damage = new WeaponDamageViewModel("1d8 bludgeoning"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "-",
				},
				#endregion

				#region Glaive
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Glaive),
					ProperName = "Glaive",
					Cost = new CostViewModel("20 gp"),
					Damage = new WeaponDamageViewModel("1d10 slashing"),
					Weight = new WeightViewModel("6 lb."),
					Properties = "Heavy, reach, two-handed",
				},
				#endregion

				#region Greataxe
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Greataxe),
					ProperName = "Greataxe",
					Cost = new CostViewModel("30 gp"),
					Damage = new WeaponDamageViewModel("1d12 slashing"),
					Weight = new WeightViewModel("7 lb."),
					Properties = "Heavy, two-handed",
				},
				#endregion

				#region Greatsword
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Greatsword),
					ProperName = "Greatsword",
					Cost = new CostViewModel("50 gp"),
					Damage = new WeaponDamageViewModel("2d6 slashing"),
					Weight = new WeightViewModel("6 lb."),
					Properties = "Heavy, two-handed",
				},
				#endregion

				#region Halberd
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Halberd),
					ProperName = "Halberd",
					Cost = new CostViewModel("20 gp"),
					Damage = new WeaponDamageViewModel("1d10 slashing"),
					Weight = new WeightViewModel("6 lb."),
					Properties = "Heavy, reach, two-handed",
				},
				#endregion

				#region Lance
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Lance),
					ProperName = "Lance",
					Cost = new CostViewModel("10 gp"),
					Damage = new WeaponDamageViewModel("1d12 piercing"),
					Weight = new WeightViewModel("6 lb."),
					Properties = "Reach, special",
				},
				#endregion

				#region Longsword
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Longsword),
					ProperName = "Longsword",
					Cost = new CostViewModel("15 gp"),
					Damage = new WeaponDamageViewModel("1d8 slashing"),
					Weight = new WeightViewModel("3 lb."),
					Properties = "Versatile (1d10)",
				},
				#endregion

				#region Maul
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Maul),
					ProperName = "Maul",
					Cost = new CostViewModel("10 gp"),
					Damage = new WeaponDamageViewModel("2d6 bludgeoning"),
					Weight = new WeightViewModel("10 lb."),
					Properties = "Heavy, two-handed",
				},
				#endregion

				#region Morningstar
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Morningstar),
					ProperName = "Morningstar",
					Cost = new CostViewModel("15 gp"),
					Damage = new WeaponDamageViewModel("1d8 piercing"),
					Weight = new WeightViewModel("4 lb."),
					Properties = "-",
				},
				#endregion

				#region Pike
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Pike),
					ProperName = "Pike",
					Cost = new CostViewModel("5 gp"),
					Damage = new WeaponDamageViewModel("1d10 piercing"),
					Weight = new WeightViewModel("18 lb."),
					Properties = "Heavy, reach, two-handed",
				},
				#endregion

				#region Rapier
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Rapier),
					ProperName = "Rapier",
					Cost = new CostViewModel("25 gp"),
					Damage = new WeaponDamageViewModel("1d8 piercing"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Finesse",
				},
				#endregion

				#region Scimitar
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Scimitar),
					ProperName = "Scimitar",
					Cost = new CostViewModel("25 gp"),
					Damage = new WeaponDamageViewModel("1d6 slashing"),
					Weight = new WeightViewModel("3 lb."),
					Properties = "Finesse, light",
				},
				#endregion

				#region Shortsword
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Shortsword),
					ProperName = "Shortsword",
					Cost = new CostViewModel("10 gp"),
					Damage = new WeaponDamageViewModel("1d6 piercing"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Finesse, light",
				},
				#endregion

				#region Trident
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Trident),
					ProperName = "Trident",
					Cost = new CostViewModel("5 gp"),
					Damage = new WeaponDamageViewModel("1d6 piercing"),
					Weight = new WeightViewModel("4 lb."),
					Properties = "Thrown (range 20/60), versatile (1d8)",
				},
				#endregion

				#region War pick
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Warpick),
					ProperName = "War pick",
					Cost = new CostViewModel("5 gp"),
					Damage = new WeaponDamageViewModel("1d8 piercing"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "-",
				},
				#endregion

				#region Warhammer
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Warhammer),
					ProperName = "Warhammer",
					Cost = new CostViewModel("15 gp"),
					Damage = new WeaponDamageViewModel("1d8 bludgeoning"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Versatile (1d10)",
				},
				#endregion

				#region Whip
				new MartialMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(MartialMeleeWeaponsEnum.Whip),
					ProperName = "Whip",
					Cost = new CostViewModel("2 gp"),
					Damage = new WeaponDamageViewModel("1d4 slashing"),
					Weight = new WeightViewModel("3 lb."),
					Properties = "Finesse, reach",
				},
				#endregion

			};
		}
	}
}
