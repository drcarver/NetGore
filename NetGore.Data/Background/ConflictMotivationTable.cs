using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// To determine the source of your motivation for 
/// the conflict, roll on Table: Motivation. If 
/// the campaign allows the full spectrum of 
/// alignments, roll a d10 on this table. If 
/// the campaign allows only nonevil alignments, 
/// roll a d8. If you’re a paladin, roll a d4. 
/// The motivation affects the CP gained from 
/// the conflict.
/// </summary>
public partial class BackgroundTables
{
    //Table: Motivation
    //d10 Result CP
    //1	Justice	1
    //2	Love	1
    //3	Pressured or Manipulated	2
    //4	Religion	2
    //5	Family	3
    //6	Money	3
    //7	Jealousy	4
    //8	Hatred or Malice	4
    //9	Pleasure	5
    //10	Amusement or Entertainment	5    
    /// <summary>
    /// Conflict Subject Table
    /// </summary>
    public static RandomTable ConflictMotivationTable { get; } = new()
    {
        Name = "The Conflict Motivation Table",
        DiceSides = 10,
        Table =
        [
            #region Justice
            //1	Justice	1
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 01,
                Name = nameof(ConflictMotivationEnum.Justice),
                ConflictPoints = 1
            },
            #endregion

            #region Love
            //2	Love	1
            new RandomTableEntry
            {
                LowerRange = 02,
                UpperRange = 02,
                Name = nameof(ConflictMotivationEnum.Love),
                ConflictPoints = 1
            },
            #endregion

            #region Pressured or Manipulated
            //3	Pressured or Manipulated	2
            new RandomTableEntry
            {
                LowerRange = 03,
                UpperRange = 03,
                Name = nameof(ConflictMotivationEnum.PressuredorManipulated),
                ProperName = "Pressured or Manipulated",
                ConflictPoints = 2
            },
            #endregion

            #region Religion
            //4	Religion	2
            new RandomTableEntry
            {
                LowerRange = 04,
                UpperRange = 04,
                Name = nameof(ConflictMotivationEnum.Religion),
                ProperName = "Religion",
                ConflictPoints = 2
            },
            #endregion

            #region Family
            //5	Family	3
            new RandomTableEntry
            {
                LowerRange = 05,
                UpperRange = 05,
                Name = nameof(ConflictMotivationEnum.Family),
                ProperName = "Family",
                ConflictPoints = 3
            },
            #endregion

            #region Money
            //6	Money	3
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 06,
                Name = nameof(ConflictMotivationEnum.Money),
                ProperName = "Money",
                ConflictPoints = 3
            },
            #endregion

            #region Jealousy
            //7	Jealousy	4
            new RandomTableEntry
            {
                LowerRange = 07,
                UpperRange = 07,
                Name = nameof(ConflictMotivationEnum.Jealousy),
                ProperName = "Jealousy",
                ConflictPoints = 4
            },
            #endregion

            #region Hatred or Malice
            //8	Hatred or Malice	4
            new RandomTableEntry
            {
                LowerRange = 08,
                UpperRange = 08,
                Name = nameof(ConflictMotivationEnum.HatredorMalice),
                ProperName = "Hatred or Malice",
                ConflictPoints = 4
            },
            #endregion

            #region Pleasure
            //9	Pleasure	5
            new RandomTableEntry
            {
                LowerRange = 09,
                UpperRange = 09,
                Name = nameof(ConflictMotivationEnum.Pleasure),
                ProperName = "Pleasure",
                ConflictPoints = 5
            },
            #endregion

            #region Amusement or Entertainment
            //10	Amusement or Entertainment	5    
            new RandomTableEntry
            {
                LowerRange = 10,
                UpperRange = 10,
                Name = nameof(ConflictMotivationEnum.AmusementorEntertainment),
                ProperName = "Pleasure",
                ConflictPoints = 5
            },
            #endregion
        ],
    };
}
