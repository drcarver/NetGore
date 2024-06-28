//
// Artisan's tools
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
					Name = nameof(ArtisanstoolsEnum.Alchemistssupplies),
					ProperName = "Alchemist's supplies",
					Cost = new CostViewModel("50 gp"),
					Weight = new WeightViewModel("8 lb."),
				},
				#endregion

				#region Brewer's supplies
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Brewerssupplies),
					ProperName = "Brewer's supplies",
					Cost = new CostViewModel("20 gp"),
					Weight = new WeightViewModel("9 lb."),
				},
				#endregion

				#region Calligrapher's supplies
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Calligrapherssupplies),
					ProperName = "Calligrapher's supplies",
					Cost = new CostViewModel("8 gp"),
					Weight = new WeightViewModel("5 lb."),
				},
				#endregion

				#region Carpenter's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Carpenterstools),
					ProperName = "Carpenter's tools",
					Cost = new CostViewModel("15 gp"),
					Weight = new WeightViewModel("6 lb."),
				},
				#endregion

				#region Cartographer's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Cartographerstools),
					ProperName = "Cartographer's tools",
					Cost = new CostViewModel("5 gp"),
					Weight = new WeightViewModel("6 lb."),
				},
				#endregion

				#region Cobbler's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Cobblerstools),
					ProperName = "Cobbler's tools",
					Cost = new CostViewModel("1 gp"),
					Weight = new WeightViewModel("5 lb."),
				},
				#endregion

				#region Cook's utensils
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Cooksutensils),
					ProperName = "Cook's utensils",
					Cost = new CostViewModel("30 gp"),
					Weight = new WeightViewModel("8 lb."),
				},
				#endregion

				#region Glassblower's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Glassblowerstools),
					ProperName = "Glassblower's tools",
					Cost = new CostViewModel("25 gp"),
					Weight = new WeightViewModel("5 lb."),
				},
				#endregion

				#region Jeweler's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Jewelerstools),
					ProperName = "Jeweler's tools",
					Cost = new CostViewModel("6 gp"),
					Weight = new WeightViewModel("2 lb."),
				},
				#endregion

				#region Leatherworker's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Leatherworkerstools),
					ProperName = "Leatherworker's tools",
					Cost = new CostViewModel("10 gp"),
					Weight = new WeightViewModel("5 lb."),
				},
				#endregion

				#region Mason's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Masonstools),
					ProperName = "Mason's tools",
					Cost = new CostViewModel("10 gp"),
					Weight = new WeightViewModel("8 lb."),
				},
				#endregion

				#region Painter's supplies
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Painterssupplies),
					ProperName = "Painter's supplies",
					Cost = new CostViewModel("10 gp"),
					Weight = new WeightViewModel("5 lb."),
				},
				#endregion

				#region Potter's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Potterstools),
					ProperName = "Potter's tools",
					Cost = new CostViewModel("10 gp"),
					Weight = new WeightViewModel("3 lb."),
				},
				#endregion

				#region Smith's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Smithstools),
					ProperName = "Smith's tools",
					Cost = new CostViewModel("20 gp"),
					Weight = new WeightViewModel("8 lb."),
				},
				#endregion

				#region Tinker's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Tinkerstools),
					ProperName = "Tinker's tools",
					Cost = new CostViewModel("50 gp"),
					Weight = new WeightViewModel("10 lb."),
				},
				#endregion

				#region Weaver's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Weaverstools),
					ProperName = "Weaver's tools",
					Cost = new CostViewModel("1 gp"),
					Weight = new WeightViewModel("5 lb."),
				},
				#endregion

				#region Woodcarver's tools
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Woodcarverstools),
					ProperName = "Woodcarver's tools",
					Cost = new CostViewModel("1 gp"),
					Weight = new WeightViewModel("5 lb."),
				},
				#endregion

				#region Disguise kit
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Disguisekit),
					ProperName = "Disguise kit",
					Cost = new CostViewModel("25 gp"),
					Weight = new WeightViewModel("3 lb."),
				},
				#endregion

				#region Forgery kit
				new ArtisanstoolsTableEntryViewModel
				{
					Name = nameof(ArtisanstoolsEnum.Forgerykit),
					ProperName = "Forgery kit",
					Cost = new CostViewModel("15 gp"),
					Weight = new WeightViewModel("5 lb."),
				},
				#endregion

			};
		}
	}
}
