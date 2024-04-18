using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Gaming.Enum;
using D20.Gaming.Interfaces;
using D20.Gaming.Models;

namespace D20.Character.PC.Bard;

/// <summary>
/// Challenge Rating (or CR) is a convenient number used 
/// to indicate the relative danger presented by a monster, 
/// trap, hazard, or other encounter—the higher the CR, 
/// the more dangerous the encounter.
/// </summary>
public class EncounterDesignTable : GameTable, IEncounterDesignTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public EncounterDesignTable()
    {
        Name = nameof(EncounterDesignTable);
        ProperName = "Encounter Design Table";
        TableType = TableTypeEnum.GamingTable;
        Description =
            "Challenge Rating (or CR) is a convenient number " +
            "used to indicate the relative danger presented " +
            "by a monster, trap, hazard, or other encounter—the " +
            "higher the CR, the more dangerous the encounter.";   
    }

    //Table: Encounter Design
    //Difficulty Challenge Rating Equals
    //Easy APL –1
    //Average APL
    //Challenging APL +1
    //Hard APL +2
    //Epic APL +3
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
