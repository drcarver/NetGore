//
// Simple Melee Weapons
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
/// Simple Melee Weapons
/// </summary>
public partial class SimpleMeleeWeaponsTable : NamedTable, ISimpleMeleeWeaponsTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public SimpleMeleeWeaponsTable()
	{
		Name = nameof(SimpleMeleeWeaponsTable);
		ProperName = "Simple Melee Weapons Table";
		Description = "Simple Melee Weapons";
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
				#region Club
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Club),
					ProperName = "Club",
					Cost = new CostViewModel("1 sp"),
					Damage = new WeaponDamageViewModel("1d4 bludgeoning"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Light",
				},
				#endregion

				#region Dagger
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Dagger),
					ProperName = "Dagger",
					Cost = new CostViewModel("2 gp"),
					Damage = new WeaponDamageViewModel("1d4 piercing"),
					Weight = new WeightViewModel("1 lb."),
					Properties = "Finesse, light, thrown (range 20/60)",
				},
				#endregion

				#region Greatclub
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Greatclub),
					ProperName = "Greatclub",
					Cost = new CostViewModel("2 sp"),
					Damage = new WeaponDamageViewModel("1d8 bludgeoning"),
					Weight = new WeightViewModel("10 lb."),
					Properties = "Two-handed",
				},
				#endregion

				#region Handaxe
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Handaxe),
					ProperName = "Handaxe",
					Cost = new CostViewModel("5 gp"),
					Damage = new WeaponDamageViewModel("1d6 slashing"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Light, thrown (range 20/60)",
				},
				#endregion

				#region Javelin
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Javelin),
					ProperName = "Javelin",
					Cost = new CostViewModel("5 sp"),
					Damage = new WeaponDamageViewModel("1d6 piercing"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Thrown (range 30/120)",
				},
				#endregion

				#region Light hammer
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Lighthammer),
					ProperName = "Light hammer",
					Cost = new CostViewModel("2 gp"),
					Damage = new WeaponDamageViewModel("1d4 bludgeoning"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Light, thrown (range 20/60)",
				},
				#endregion

				#region Mace
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Mace),
					ProperName = "Mace",
					Cost = new CostViewModel("5 gp"),
					Damage = new WeaponDamageViewModel("1d6 bludgeoning"),
					Weight = new WeightViewModel("4 lb."),
					Properties = "-",
				},
				#endregion

				#region Quarterstaff
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Quarterstaff),
					ProperName = "Quarterstaff",
					Cost = new CostViewModel("2 sp"),
					Damage = new WeaponDamageViewModel("1d6 bludgeoning"),
					Weight = new WeightViewModel("4 lb."),
					Properties = "Versatile (1d8)",
				},
				#endregion

				#region Sickle
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Sickle),
					ProperName = "Sickle",
					Cost = new CostViewModel("1 gp"),
					Damage = new WeaponDamageViewModel("1d4 slashing"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Light",
				},
				#endregion

				#region Spear
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleMeleeWeaponsEnum.Spear),
					ProperName = "Spear",
					Cost = new CostViewModel("1 gp"),
					Damage = new WeaponDamageViewModel("1d6 piercing"),
					Weight = new WeightViewModel("3 lb."),
					Properties = "Thrown (range 20/60), versatile (1d8)",
				},
				#endregion

			};
		}
	}
}
