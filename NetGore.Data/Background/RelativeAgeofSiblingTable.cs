using NetGore.Core.Models;
using NetGore.Data.Services;

namespace NetGore.Data.Background;

/// <summary>
/// If you have at least one sibling, roll on Table: 
/// Relative Age of Sibling to determine the relative 
/// age of each sibling.For each adopted sibling, 
/// roll on Table: RaceTable to determine that 
/// sibling’s race.
public partial class BackgroundTables
{
    //Table: Relative Age of Sibling
    //d%	Result
    //01–48	Your sibling is older than you.
    //49–96	Your sibling is younger than you.
    //97–100	You and a sibling are twins (identical or fraternal, your choice). Roll on this table again. If you roll this result again, you are one of triplets; otherwise, your sibling’s relative age determines which of you emerged first.
    /// <summary>
    /// Relative Age of Sibling Table
    /// </summary>
    public static RandomTable RelativeAgeofSiblingTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region Older
            //01–48	Your sibling is older than you.
            new BackgroundTableEntry
            {
                LowerRange = 01,
                UpperRange = 48,
                Name = "Older",
                Description =
                    "Your sibling is older than you.",
            },
            #endregion

            #region Younger
            //49–96	Your sibling is younger than you.
            new BackgroundTableEntry
            {
                LowerRange = 49,
                UpperRange = 96,
                Name = "Younger",
                Description =
                    "Your sibling is younger than you.",
            },
            #endregion

            #region Twins
            //97–100 You and a sibling are twins (identical or fraternal, your choice). Roll on this table again. If you roll this result again, you are one of triplets; otherwise, your sibling’s relative age determines which of you emerged first.
            new BackgroundTableEntry
            {
                LowerRange = 97,
                UpperRange = 100,
                Name = "Twins",
                Description =
                    "You and a sibling are twins " +
                    "(identical or fraternal, your " +
                    "choice). Roll on this table again. " +
                    "If you roll this result again, " +
                    "you are one of triplets; otherwise, " +
                    "your sibling’s relative age " +
                    "determines which of you emerged first.",
                AlternateTable = RaceService.RaceTable
            },
            #endregion
        ],
    };
}
