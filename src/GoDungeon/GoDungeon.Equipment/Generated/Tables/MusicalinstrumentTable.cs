//
// Musical instrument
// Containing file adventuring\equipment\tools.md
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
/// Musical instrument
/// </summary>
public partial class MusicalinstrumentTable : NamedTable, IMusicalinstrumentTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public MusicalinstrumentTable()
	{
		Name = nameof(MusicalinstrumentTable);
		ProperName = "Musical instrument Table";
		Description = "Musical instrument";
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
				#region Bagpipes
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Bagpipes),
					ProperName = "Bagpipes",
					Cost = new CostViewModel("30 gp"),
					Weight = new WeightViewModel("6 lb."),
				},
				#endregion

				#region Drum
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Drum),
					ProperName = "Drum",
					Cost = new CostViewModel("6 gp"),
					Weight = new WeightViewModel("3 lb."),
				},
				#endregion

				#region Dulcimer
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Dulcimer),
					ProperName = "Dulcimer",
					Cost = new CostViewModel("25 gp"),
					Weight = new WeightViewModel("10 lb."),
				},
				#endregion

				#region Flute
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Flute),
					ProperName = "Flute",
					Cost = new CostViewModel("2 gp"),
					Weight = new WeightViewModel("1 lb."),
				},
				#endregion

				#region Lute
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Lute),
					ProperName = "Lute",
					Cost = new CostViewModel("35 gp"),
					Weight = new WeightViewModel("2 lb."),
				},
				#endregion

				#region Lyre
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Lyre),
					ProperName = "Lyre",
					Cost = new CostViewModel("30 gp"),
					Weight = new WeightViewModel("2 lb."),
				},
				#endregion

				#region Horn
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Horn),
					ProperName = "Horn",
					Cost = new CostViewModel("3 gp"),
					Weight = new WeightViewModel("2 lb."),
				},
				#endregion

				#region Pan flute
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Panflute),
					ProperName = "Pan flute",
					Cost = new CostViewModel("12 gp"),
					Weight = new WeightViewModel("2 lb."),
				},
				#endregion

				#region Shawm
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Shawm),
					ProperName = "Shawm",
					Cost = new CostViewModel("2 gp"),
					Weight = new WeightViewModel("1 lb."),
				},
				#endregion

				#region Viol
				new MusicalinstrumentTableEntryViewModel
				{
					Name = nameof(MusicalinstrumentEnum.Viol),
					ProperName = "Viol",
					Cost = new CostViewModel("30 gp"),
					Weight = new WeightViewModel("1 lb."),
				},
				#endregion

			};
		}
	}
}
