//
// Typical Difficulty Classes
//
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables;

/// <summary>
/// Typical Difficulty Classes
/// </summary>
public partial class TypicalDifficultyClassesTable : NamedTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    public TypicalDifficultyClassesTable()
    {
        Name = nameof(TypicalDifficultyClassesTable);
        ProperName = "Typical Difficulty Classes Table";
        TableType = TableTypeEnum.GamingTable;
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
                    Name = nameof(TypicalDifficultyClassesEnum.Veryeasy),
                    ProperName = "Very easy",
                    TaskDifficulty = "Very easy",
                    DC = 5,
                },
				#endregion

				#region Easy
				new TypicalDifficultyClassesViewModel
                {
                    Name = nameof(TypicalDifficultyClassesEnum.Easy),
                    ProperName = "Easy",
                    TaskDifficulty = "Easy",
                    DC = 10,
                },
				#endregion

				#region Medium
				new TypicalDifficultyClassesViewModel
                {
                    Name = nameof(TypicalDifficultyClassesEnum.Medium),
                    ProperName = "Medium",
                    TaskDifficulty = "Medium",
                    DC = 15,
                },
				#endregion

				#region Hard
				new TypicalDifficultyClassesViewModel
                {
                    Name = nameof(TypicalDifficultyClassesEnum.Hard),
                    ProperName = "Hard",
                    TaskDifficulty = "Hard",
                    DC = 20,
                },
				#endregion

				#region Very hard
				new TypicalDifficultyClassesViewModel
                {
                    Name = nameof(TypicalDifficultyClassesEnum.Veryhard),
                    ProperName = "Very hard",
                    TaskDifficulty = "Very hard",
                    DC = 25,
                },
				#endregion

				#region Nearly impossible
				new TypicalDifficultyClassesViewModel
                {
                    Name = nameof(TypicalDifficultyClassesEnum.Nearlyimpossible),
                    ProperName = "Nearly impossible",
                    TaskDifficulty = "Nearly impossible",
                    DC = 30,
                },
				#endregion

			};
        }
    }
}
