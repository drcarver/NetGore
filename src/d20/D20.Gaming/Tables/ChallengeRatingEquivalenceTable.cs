using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Gaming.Interfaces;
using D20.Gaming.Models;

namespace D20.Character.PC.Bard;

/// <summary>
/// High CR Encounters: The XP values for high-CR encounters 
/// can seem quite daunting.Table: CR Equivalences provides 
/// some simple formulas to help you manage these large numbers.
/// When using a large number of identical creatures, this 
/// chart can help simplify the math by combining them into 
/// one CR, making it easier to find their total XP value.
/// For example, using this chart, four CR 8 creatures 
/// (worth 4,800 XP each) are equivalent to a CR 12 creature 
/// (worth 19,200 XP).
/// </summary>
public class ChallengeRatingEquivalenceTable : GameTable, IEncounterDesignTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ChallengeRatingEquivalenceTable()
    {
        Name = nameof(ChallengeRatingEquivalenceTable);
        ProperName = "Challenge Rating Equivalence Table";
        TableType = TableTypeEnum.GamingTable;
        Description =
            "High CR Encounters: The XP values for high-CR " +
            "encounters can seem quite daunting.This table " +
            "provides some simple formulas to help you manage " +
            "these large numbers.When using a large number " +
            "of identical creatures, this table can help simplify " +
            "the math by combining them into one CR, making " +
            "it easier to find their total XP value. For example, " +
            "using this table, four CR 8 creatures (worth 4,800 XP each) " +
            "are equivalent to a CR 12 creature (worth 19,200 XP).";
    }

    //Table: CR Equivalences
    //Number of Creatures Equal to
    //1 Creature CR
    //2 Creatures CR +2
    //3 Creatures CR +3
    //4 Creatures CR +4
    //6 Creatures CR +5
    //8 Creatures CR +6
    //12 Creatures CR +7
    //16 Creatures CR +8
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
            #region 1 Creature CR
            //1 Creature CR
            new ChallengeRatingEquivalenceEntry
            {
                NumberOfCreatures = 1,
                ChallengeRatingEquivalence = 1
            },
            #endregion

            #region 2 Creatures CR +2
            //2 Creatures CR +2
            new ChallengeRatingEquivalenceEntry
            {
                NumberOfCreatures = 2,
                ChallengeRatingEquivalence = 2
            },
            #endregion

            #region 3 Creatures CR +3
            //3 Creatures CR +3
            new ChallengeRatingEquivalenceEntry
            {
                NumberOfCreatures = 3,
                ChallengeRatingEquivalence = 3
            },
            #endregion

            #region 4 Creatures CR +4
            //4 Creatures CR +4
            new ChallengeRatingEquivalenceEntry
            {
                NumberOfCreatures = 4,
                ChallengeRatingEquivalence = 4
            },
            #endregion

            #region 6 Creatures CR +5
            //6 Creatures CR +5
            new ChallengeRatingEquivalenceEntry
            {
                NumberOfCreatures = 6,
                ChallengeRatingEquivalence = 5
            },
            #endregion

            #region 8 Creatures CR +6
            //8 Creatures CR +6
            new ChallengeRatingEquivalenceEntry
            {
                NumberOfCreatures = 8,
                ChallengeRatingEquivalence = 6
            },
            #endregion

            #region 12 Creatures CR +7
            //12 Creatures CR +7
            new ChallengeRatingEquivalenceEntry
            {
                NumberOfCreatures = 12,
                ChallengeRatingEquivalence = 7
            },
            #endregion

            #region 16 Creatures CR +8
            //16 Creatures CR +8
            new ChallengeRatingEquivalenceEntry
            {
                NumberOfCreatures = 16,
                ChallengeRatingEquivalence = 8
            },
            #endregion
        ];
    }
}
