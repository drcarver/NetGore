//
// Typical Difficulty Classes
// Containing file rules\abilities\ability_checks.md
//
using System.Collections.ObjectModel;

using GoDungeon.Abilities.ViewModels;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Abilities.Tables;

/// <summary>
/// Typical Difficulty Classes
/// </summary>
public partial class TypicalDifficultyClassesTable : NamedTable, ITypicalDifficultyClassesTable
{
	/// <summary>
	/// Constructor
	/// </summary>
	public TypicalDifficultyClassesTable()
	{
		Name = nameof(TypicalDifficultyClassesTable);
		ProperName = "Typical Difficulty Classes Table";
		Description = "Typical Difficulty Classes";
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
				#region Very easy
				new TypicalDifficultyClassesViewModel
				{
					TaskDifficulty = "Very easy",
					DC = 5,
				},
				#endregion

				#region Easy
				new TypicalDifficultyClassesViewModel
				{
					TaskDifficulty = "Easy",
					DC = 10,
				},
				#endregion

				#region Medium
				new TypicalDifficultyClassesViewModel
				{
					TaskDifficulty = "Medium",
					DC = 15,
				},
				#endregion

				#region Hard
				new TypicalDifficultyClassesViewModel
				{
					TaskDifficulty = "Hard",
					DC = 20,
				},
				#endregion

				#region Very hard
				new TypicalDifficultyClassesViewModel
				{
					TaskDifficulty = "Very hard",
					DC = 25,
				},
				#endregion

				#region Nearly impossible
				new TypicalDifficultyClassesViewModel
				{
					TaskDifficulty = "Nearly impossible",
					DC = 30,
				},
				#endregion

			};
		}
	}
}
