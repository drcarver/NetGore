//
// Simple Melee Weapons
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
					SimpleMeleeWeapons = "Club",
					Cost = "1 sp",
					Damage = "1d4 bludgeoning",
					Weight = "2 lb.",
					Properties = "Light",
				},
				#endregion

				#region Dagger
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Dagger",
					Cost = "2 gp",
					Damage = "1d4 piercing",
					Weight = "1 lb.",
					Properties = "Finesse, light, thrown (range 20/60)",
				},
				#endregion

				#region Greatclub
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Greatclub",
					Cost = "2 sp",
					Damage = "1d8 bludgeoning",
					Weight = "10 lb.",
					Properties = "Two-handed",
				},
				#endregion

				#region Handaxe
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Handaxe",
					Cost = "5 gp",
					Damage = "1d6 slashing",
					Weight = "2 lb.",
					Properties = "Light, thrown (range 20/60)",
				},
				#endregion

				#region Javelin
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Javelin",
					Cost = "5 sp",
					Damage = "1d6 piercing",
					Weight = "2 lb.",
					Properties = "Thrown (range 30/120)",
				},
				#endregion

				#region Light hammer
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Light hammer",
					Cost = "2 gp",
					Damage = "1d4 bludgeoning",
					Weight = "2 lb.",
					Properties = "Light, thrown (range 20/60)",
				},
				#endregion

				#region Mace
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Mace",
					Cost = "5 gp",
					Damage = "1d6 bludgeoning",
					Weight = "4 lb.",
					Properties = "-",
				},
				#endregion

				#region Quarterstaff
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Quarterstaff",
					Cost = "2 sp",
					Damage = "1d6 bludgeoning",
					Weight = "4 lb.",
					Properties = "Versatile (1d8)",
				},
				#endregion

				#region Sickle
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Sickle",
					Cost = "1 gp",
					Damage = "1d4 slashing",
					Weight = "2 lb.",
					Properties = "Light",
				},
				#endregion

				#region Spear
				new SimpleMeleeWeaponsTableEntryViewModel
				{
					SimpleMeleeWeapons = "Spear",
					Cost = "1 gp",
					Damage = "1d6 piercing",
					Weight = "3 lb.",
					Properties = "Thrown (range 20/60), versatile (1d8)",
				},
				#endregion

			};
		}
	}
}
