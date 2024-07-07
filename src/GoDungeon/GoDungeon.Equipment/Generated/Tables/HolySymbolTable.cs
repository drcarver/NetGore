//
// Holy Symbol
// Containing file adventuring\equipment\adventuring_gear.md
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
/// Holy Symbol
/// </summary>
public partial class HolySymbolTable : NamedTable, IHolySymbolTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public HolySymbolTable()
	{
		Name = nameof(HolySymbolTable);
		ProperName = "Holy Symbol Table";
		Description = "Holy Symbol";
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
				#region Amulet
				new HolySymbolTableEntryViewModel
				{
					Name = nameof(HolySymbolEnum.Amulet),
					ProperName = "Amulet",
					Cost = new CostViewModel("5 gp"),
					Weight = new WeightViewModel("1 lb."),
				},
				#endregion

				#region Emblem
				new HolySymbolTableEntryViewModel
				{
					Name = nameof(HolySymbolEnum.Emblem),
					ProperName = "Emblem",
					Cost = new CostViewModel("5 gp"),
					Weight = new WeightViewModel("-"),
				},
				#endregion

				#region Reliquary
				new HolySymbolTableEntryViewModel
				{
					Name = nameof(HolySymbolEnum.Reliquary),
					ProperName = "Reliquary",
					Cost = new CostViewModel("5 gp"),
					Weight = new WeightViewModel("2 lb."),
				},
				#endregion

			};
		}
	}
}
