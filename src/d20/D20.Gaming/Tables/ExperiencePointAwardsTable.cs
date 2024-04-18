using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Gaming.Enum;
using D20.Gaming.Interfaces;
using D20.Gaming.Models;

namespace D20.Character.PC.Bard;

/// <summary>
/// Determine the total XP award for the encounter by looking it 
/// up by its CR on Table: Experience Point Awards.This gives 
/// you an “XP budget” for the encounter. Every creature, trap, 
/// and hazard is worth an amount of XP determined by its CR. 
/// To build your encounter, simply add creatures, traps, 
/// and hazards whose combined XP does not exceed the total 
/// XP budget for your encounter. It’s easiest to add the 
/// highest CR challenges to the encounter first, filling 
/// out the remaining total with lesser challenges.
/// </summary>
public class ExperiencePointAwardsTable : GameTable, IExperiencePointAwardsTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ExperiencePointAwardsTable()
    {
        Name = nameof(ExperiencePointAwardsTable);
        ProperName = "Experience Point Awards Table";
        TableType = TableTypeEnum.GamingTable;
        Description =
            "Determine the total XP award for the encounter by " +
            "looking it up by its CR. This gives you an “XP budget” " +
            "for the encounter. Every creature, trap, and hazard " +
            "is worth an amount of XP determined by its CR, " +
            "as noted on Table: Experience Point Awards. To build " +
            "your encounter, simply add creatures, traps, and " +
            "hazards whose combined XP does not exceed the " +
            "total XP budget for your encounter. It’s easiest " +
            "to add the highest CR challenges to the encounter " +
            "first, filling out the remaining total with lesser " +
            "challenges.";
    }

    //Table: Experience Point Awards
    //CR  Total XP    Individual XP
    //      Total    1-3 4-5	6+
    //1/8	50	    15	 15	    10
    //1/6	65	20	15	10
    //1/4	100	35	25	15
    //1/3	135	45	35	25
    //1/2	200	65	50	35
    //1	400	135	100	65
    //2	600	200	150	100
    //3	800	265	200	135
    //4	1,200	400	300	200
    //5	1,600	535	400	265
    //6	2,400	800	600	400
    //7	3,200	1,070	800	535
    //8	4,800	1,600	1,200	800
    //9	6,400	2,130	1,600	1,070
    //10	9,600	3,200	2,400	1,600
    //11	12,800	4,270	3,200	2,130
    //12	19,200	6,400	4,800	3,200
    //13	25,600	8,530	6,400	4,270
    //14	38,400	12,800	9,600	6,400
    //15	51,200	17,100	12,800	8,530
    //16	76,800	25,600	19,200	12,800
    //17	102,400	34,100	25,600	17,100
    //18	153,600	51,200	38,400	25,600
    //19	204,800	68,300	51,200	34,100
    //20	307,200	102,000	76,800	51,200
    //21	409,600	137,000	102,400	68,300
    //22	614,400	205,000	153,600	102,400
    //23	819,200	273,000	204,800	137,000
    //24	1,228,800	410,000	307,200	204,800
    //25	1,638,400	546,000	409,600	273,000
    //26	2,457,600	820,000	614,400	409,600
    //27	3,276,800	1,092,000	819,200	546,000
    //28	4,915,200	1,640,000	1,228,800	819,200
    //29	6,553,600	2,184,000	1,638,400	1,092,000
    //30	9,830,400	3,280,000	2,457,600	1,638,400
    /// <summary>
    /// Initialize the game table.  This is a separate method so 
    /// we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region Easy
            //Easy APL –1
            new EncounterDesignEntry
            {
                Name = nameof(DifficultyEnum.Easy),
                ChallengeRatingEquals = -1,
            },
            #endregion

            #region Average
            //Average APL
            new EncounterDesignEntry
            {
                Name = nameof(DifficultyEnum.Average),
                ChallengeRatingEquals = 0,
            },
            #endregion

            #region Challenging
            //Challenging APL +1
            new EncounterDesignEntry
            {
                Name = nameof(DifficultyEnum.Challenging),
                ChallengeRatingEquals = 1,
            },
            #endregion

            #region Hard
            //Hard APL +2
            new EncounterDesignEntry
            {
                Name = nameof(DifficultyEnum.Hard),
                ChallengeRatingEquals = 2,
            },
            #endregion

            #region Epic
            //Epic APL +3
            new EncounterDesignEntry
            {
                Name = nameof(DifficultyEnum.Epic),
                ChallengeRatingEquals = 3,
            },
            #endregion
        ];
    }
}
