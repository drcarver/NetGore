//
// Shield
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
/// Shield
/// </summary>
public partial class ShieldTable : NamedTable, IShieldTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public ShieldTable()
	{
		Name = nameof(ShieldTable);
		ProperName = "Shield Table";
		Description = "Shield";
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
				#region Shield
				new ShieldTableEntryViewModel
				{
					Name = nameof(ShieldEnum.Shield),
					ProperName = "Shield",
					Cost = new CostViewModel("10 gp"),
					ArmorClassAC = Convert.ToInt32(+2),
					Strength = "-",
					Stealth = "-",
					Weight = new WeightViewModel("6  lb."),
				},
				#endregion

			};
		}
	}
}
