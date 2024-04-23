using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core.Tables;

/// <summary>
/// The gender table.  
/// </summary>
public class RandomAlignmentTable : RandomTable, IRandomAlignmentTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public RandomAlignmentTable()
    {
        Name = nameof(RandomAlignmentTable);
        ProperName = "Random Table for generating alignment";
        TableType = TableTypeEnum.CoreTable;
        DiceSides = 20;
    }

    //d20 Alignment
    //1–2 Chaotic evil
    //3–4 Chaotic neutral
    //5–7 Chaotic good
    //8–9 Neutral evil
    //10–11 Neutral
    //12–13 Neutral good
    //14–15 Lawful evil
    //16–17 Lawful neutral
    //18–20 Lawful good
    /// <summary>
    /// Initialize the game table.  This is a separate method 
    /// so we can create a game table for it;s meta properties
    /// with out creating the table.  A bit of optimization to 
    /// conserve memory
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region Chaotic evil
            // 1–2 Chaotic evil
            new AlignmentTableEntry
            {
                Range = new Range(1, 2),
                Name = nameof(AlignmentEnum.ChaoticEvil),
                Description = "Chaotic Evil",
                Alignment = AlignmentEnum.ChaoticEvil
            },
            #endregion

            #region Chaotic neutral
            //3–4 Chaotic neutral
            new AlignmentTableEntry
            {
                Range = new Range(3, 4),
                Name = nameof(AlignmentEnum.ChaoticNeutral),
                Description = "Chaotic neutral",
                Alignment = AlignmentEnum.ChaoticNeutral
            },
            #endregion

            #region Chaotic good
            //5–7 Chaotic good
            new AlignmentTableEntry
            {
                Range = new Range(5, 7),
                Name = nameof(AlignmentEnum.ChaoticGood),
                Description = "Chaotic good",
                Alignment = AlignmentEnum.ChaoticGood
            },
            #endregion

            #region Neutral evil
            //8–9 Neutral evil
            new AlignmentTableEntry
            {
                Range = new Range(8, 9),
                Name = nameof(AlignmentEnum.NeutralEvil),
                Description = "Neutral evil",
                Alignment = AlignmentEnum.NeutralEvil
            },
            #endregion

            #region Neutral
            //10–11 Neutral
            new AlignmentTableEntry
            {
                Range = new Range(10, 11),
                Name = nameof(AlignmentEnum.Neutral),
                Description = "Neutral",
                Alignment = AlignmentEnum.Neutral
            },
            #endregion

            #region Neutral good
            //12–13 Neutral good
            new AlignmentTableEntry
            {
                Range = new Range(12, 13),
                Name = nameof(AlignmentEnum.NeutralGood),
                Description = "Neutral good",
                Alignment = AlignmentEnum.NeutralGood
            },
            #endregion

            #region Lawful evil
            //14–15 Lawful evil
            new AlignmentTableEntry
            {
                Range = new Range(14, 15),
                Name = nameof(AlignmentEnum.LawfulEvil),
                Description = "Lawful evil",
                Alignment = AlignmentEnum.LawfulEvil
            },
            #endregion

            #region Lawful neutral
            //16–17 Lawful neutral
            new AlignmentTableEntry
            {
                Range = new Range(16, 17),
                Name = nameof(AlignmentEnum.LawfulNeutral),
                Description = "Lawful neutral",
                Alignment = AlignmentEnum.LawfulNeutral
            },
            #endregion

            #region Lawful good
            //18–20 Lawful good
            new AlignmentTableEntry
            {
                Range = new Range(18, 20),
                Name = nameof(AlignmentEnum.LawfulGood),
                Description = "Lawful good",
                Alignment = AlignmentEnum.LawfulGood
            },
            #endregion
        ];
    }
}
