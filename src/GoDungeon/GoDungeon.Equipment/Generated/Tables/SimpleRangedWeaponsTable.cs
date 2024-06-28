//
// Simple Ranged Weapons
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
/// Simple Ranged Weapons
/// </summary>
public partial class SimpleRangedWeaponsTable : NamedTable, ISimpleRangedWeaponsTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public SimpleRangedWeaponsTable()
	{
		Name = nameof(SimpleRangedWeaponsTable);
		ProperName = "Simple Ranged Weapons Table";
		Description = "Simple Ranged Weapons";
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
				#region Crossbow, light
				new SimpleRangedWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleRangedWeaponsEnum.Crossbowlight),
					ProperName = "Crossbow, light",
					Cost = new CostViewModel("25 gp"),
					Damage = new WeaponDamageViewModel("1d8 piercing"),
					Weight = new WeightViewModel("5 lb."),
					Properties = "Ammunition (range 80/320), loading, two-handed",
				},
				#endregion

				#region Dart
				new SimpleRangedWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleRangedWeaponsEnum.Dart),
					ProperName = "Dart",
					Cost = new CostViewModel("5 cp"),
					Damage = new WeaponDamageViewModel("1d4 piercing"),
					Weight = new WeightViewModel("1/4 lb."),
					Properties = "Finesse, thrown (range 20/60)",
				},
				#endregion

				#region Shortbow
				new SimpleRangedWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleRangedWeaponsEnum.Shortbow),
					ProperName = "Shortbow",
					Cost = new CostViewModel("25 gp"),
					Damage = new WeaponDamageViewModel("1d6 piercing"),
					Weight = new WeightViewModel("2 lb."),
					Properties = "Ammunition (range 80/320), two-handed",
				},
				#endregion

				#region Sling
				new SimpleRangedWeaponsTableEntryViewModel
				{
					Name = nameof(SimpleRangedWeaponsEnum.Sling),
					ProperName = "Sling",
					Cost = new CostViewModel("1 sp"),
					Damage = new WeaponDamageViewModel("1d4 bludgeoning"),
					Weight = new WeightViewModel("-"),
					Properties = "Ammunition (range 30/120)",
				},
				#endregion

			};
		}
	}
}
