//
// Artisan's tools
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
/// Artisan's tools
/// </summary>
public partial class ArtisanstoolsTable : NamedTable, IArtisanstoolsTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public ArtisanstoolsTable()
	{
		Name = nameof(ArtisanstoolsTable);
		ProperName = "Artisan's tools Table";
		Description = "Artisan's tools";
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
				#region Alchemist's supplies
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Alchemist's supplies",
					Cost = "50 gp",
					Weight = "8 lb.",
				},
				#endregion

				#region Brewer's supplies
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Brewer's supplies",
					Cost = "20 gp",
					Weight = "9 lb.",
				},
				#endregion

				#region Calligrapher's supplies
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Calligrapher's supplies",
					Cost = "8 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Carpenter's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Carpenter's tools",
					Cost = "15 gp",
					Weight = "6 lb.",
				},
				#endregion

				#region Cartographer's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Cartographer's tools",
					Cost = "5 gp",
					Weight = "6 lb.",
				},
				#endregion

				#region Cobbler's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Cobbler's tools",
					Cost = "1 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Cook's utensils
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Cook's utensils",
					Cost = "30 gp",
					Weight = "8 lb.",
				},
				#endregion

				#region Glassblower's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Glassblower's tools",
					Cost = "25 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Jeweler's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Jeweler's tools",
					Cost = "6 gp",
					Weight = "2 lb.",
				},
				#endregion

				#region Leatherworker's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Leatherworker's tools",
					Cost = "10 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Mason's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Mason's tools",
					Cost = "10 gp",
					Weight = "8 lb.",
				},
				#endregion

				#region Painter's supplies
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Painter's supplies",
					Cost = "10 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Potter's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Potter's tools",
					Cost = "10 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Smith's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Smith's tools",
					Cost = "20 gp",
					Weight = "8 lb.",
				},
				#endregion

				#region Tinker's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Tinker's tools",
					Cost = "50 gp",
					Weight = "10 lb.",
				},
				#endregion

				#region Weaver's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Weaver's tools",
					Cost = "1 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Woodcarver's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Woodcarver's tools",
					Cost = "1 gp",
					Weight = "5 lb.",
				},
				#endregion

				#region Disguise kit
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Disguise kit",
					Cost = "25 gp",
					Weight = "3 lb.",
				},
				#endregion

				#region Forgery kit
				new ArtisanstoolsTableEntryViewModel
				{
					Item = "Forgery kit",
					Cost = "15 gp",
					Weight = "5 lb.",
				},
				#endregion

			};
		}
	}
}
