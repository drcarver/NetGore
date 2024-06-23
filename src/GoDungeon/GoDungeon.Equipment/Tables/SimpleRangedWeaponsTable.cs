//
// Simple Ranged Weapons
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
					SimpleRangedWeapons = "Crossbow, light",
					Cost = "25 gp",
					Damage = "1d8 piercing",
					Weight = "5 lb.",
					Properties = "Ammunition (range 80/320), loading, two-handed",
				},
				#endregion

				#region Dart
				new SimpleRangedWeaponsTableEntryViewModel
				{
					SimpleRangedWeapons = "Dart",
					Cost = "5 cp",
					Damage = "1d4 piercing",
					Weight = "1/4 lb.",
					Properties = "Finesse, thrown (range 20/60)",
				},
				#endregion

				#region Shortbow
				new SimpleRangedWeaponsTableEntryViewModel
				{
					SimpleRangedWeapons = "Shortbow",
					Cost = "25 gp",
					Damage = "1d6 piercing",
					Weight = "2 lb.",
					Properties = "Ammunition (range 80/320), two-handed",
				},
				#endregion

				#region Sling
				new SimpleRangedWeaponsTableEntryViewModel
				{
					SimpleRangedWeapons = "Sling",
					Cost = "1 sp",
					Damage = "1d4 bludgeoning",
					Weight = "-",
					Properties = "Ammunition (range 30/120)",
				},
				#endregion

			};
		}
	}
}
