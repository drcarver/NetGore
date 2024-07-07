//
// Ability Scores and Modifiers
// Containing file rules\abilities\ability_scores.md
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables;

/// <summary>
/// Ability Scores and Modifiers
/// </summary>
public partial class AbilityScoresandModifiersTable : NamedTable, IAbilityScoresandModifiersTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    public AbilityScoresandModifiersTable()
    {
        Name = nameof(AbilityScoresandModifiersTable);
        ProperName = "Ability Scores and Modifiers Table";
        Description = "Ability Scores and Modifiers";
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
				#region 1
				new AbilityScoresandModifiersViewModel
                {
                    Score = 1,
                    Modifier = -5,
                },
				#endregion

				#region 2-3
				new AbilityScoresandModifiersViewModel
                {
                    Score = 2-3,
                    Modifier = -4,
                },
				#endregion

				#region 4-5
				new AbilityScoresandModifiersViewModel
                {
                    Score = 4-5,
                    Modifier = -3,
                },
				#endregion

				#region 6-7
				new AbilityScoresandModifiersViewModel
                {
                    Score = 6-7,
                    Modifier = -2,
                },
				#endregion

				#region 8-9
				new AbilityScoresandModifiersViewModel
                {
                    Score = 8-9,
                    Modifier = -1,
                },
				#endregion

				#region 10-11
				new AbilityScoresandModifiersViewModel
                {
                    Score = 10-11,
                    Modifier = +0,
                },
				#endregion

				#region 12-13
				new AbilityScoresandModifiersViewModel
                {
                    Score = 12-13,
                    Modifier = +1,
                },
				#endregion

				#region 14-15
				new AbilityScoresandModifiersViewModel
                {
                    Score = 14-15,
                    Modifier = +2,
                },
				#endregion

				#region 16-17
				new AbilityScoresandModifiersViewModel
                {
                    Score = 16-17,
                    Modifier = +3,
                },
				#endregion

				#region 18-19
				new AbilityScoresandModifiersViewModel
                {
                    Score = 18-19,
                    Modifier = +4,
                },
				#endregion

				#region 20-21
				new AbilityScoresandModifiersViewModel
                {
                    Score = 20-21,
                    Modifier = +5,
                },
				#endregion

				#region 22-23
				new AbilityScoresandModifiersViewModel
                {
                    Score = 22-23,
                    Modifier = +6,
                },
				#endregion

				#region 24-25
				new AbilityScoresandModifiersViewModel
                {
                    Score = 24-25,
                    Modifier = +7,
                },
				#endregion

				#region 26-27
				new AbilityScoresandModifiersViewModel
                {
                    Score = 26-27,
                    Modifier = +8,
                },
				#endregion

				#region 28-29
				new AbilityScoresandModifiersViewModel
                {
                    Score = 28-29,
                    Modifier = +9,
                },
				#endregion

				#region 30
				new AbilityScoresandModifiersViewModel
                {
                    Score = 30,
                    Modifier = +10,
                },
				#endregion

			};
        }
    }
}
