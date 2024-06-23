//
// Musical instrument
// Containing file adventuring\equipment\tools.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

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
					Item = "Bagpipes",
					Cost = "30 gp",
					Weight = "6 lb.",
				},
				#endregion

				#region Drum
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Drum",
					Cost = "6 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Dulcimer
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Dulcimer",
					Cost = "25 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Flute
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Flute",
					Cost = "2 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Lute
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Lute",
					Cost = "35 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Lyre
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Lyre",
					Cost = "30 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Horn
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Horn",
					Cost = "3 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Pan flute
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Pan flute",
					Cost = "12 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Shawm
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Shawm",
					Cost = "2 gp",
					Weight = "1 lb.",
				},
				#endregion

				#region Viol
				new MusicalinstrumentTableEntryViewModel
				{
					Item = "Viol",
					Cost = "30 gp",
					Weight = "1 lb.",
				},
				#endregion

			};
		}
	}
}
