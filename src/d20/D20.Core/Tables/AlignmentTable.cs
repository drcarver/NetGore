using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core.Tables;

/// <summary>
/// Determine your character's alignment
/// </summary>
public class AlignmentTable : NamedTable, IAlignmentTable
{
    /// <summary>
    /// Alignment Table
    /// </summary>
    [SetsRequiredMembers]
    public AlignmentTable()
    {
        Name = nameof(AlignmentTable);
        ProperName = "Alignment Table";
        TableType = TableTypeEnum.CoreTable;
    }

    /// <summary>
    /// Initialize the game table.  This is a separate method 
    /// so we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        if (Table.Count == 0)
        {
            Table =
            [
                #region Lawful Good
                // LG(Lawful Good)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.LawfulGood),
                    ProperName = "Lawful Good",
                    Description =
                        "A lawful good character acts as " +
                        "a good person is expected or " +
                        "required to act. They combine a " +
                        "commitment to oppose evil with " +
                        "the discipline to fight " +
                        "relentlessly. They tell the " +
                        "truth, keeps their word, help " +
                        "those in need, and speak out " +
                        "against injustice. A lawful " +
                        "good character hates to see " +
                        "the guilty go unpunished.",
                },
                #endregion

                #region Neutral Good
                // NG(Neutral Good)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.NeutralGood),
                    ProperName = "Neutral Good",
                    Description =
                        "A neutral good character does " +
                        "the best that a good person " +
                        "can do. They are devoted to " +
                        "helping others. They work with " +
                        "kings and magistrates but do " +
                        "not feel beholden to them.",
                },
                #endregion

                #region Chaotic Good
                // CG(Chaotic Good)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.ChaoticGood),
                    ProperName = "Chaotic Good",
                    Description =
                        "A chaotic good character acts " +
                        "as their conscience directs them " +
                        "with little regard for what " +
                        "others expect of them. They " +
                        "make their own way, but are " +
                        "kind and benevolent. They " +
                        "believe in goodness and right " +
                        "but have little use for laws " +
                        "and regulations. They hate it " +
                        "when people try to intimidate " +
                        "others and tell them what to do. " +
                        "They follow their own moral " +
                        "compass, which, although good, " +
                        "may not agree with that of society.",
                },
                #endregion

                #region Lawful Neutral
                // LN(Lawful Neutral)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.LawfulNeutral),
                    ProperName = "Lawful Neutral",
                    Description =
                        "A lawful neutral character acts " +
                        "as law, tradition, or a personal " +
                        "code directs them. Order and " +
                        "organization are paramount. They " +
                        "may believe in personal order " +
                        "and live by a code or standard, " +
                        "or they may believe in order " +
                        "for all and favor a strong, " +
                        "organized government.",
                },
                #endregion

                #region Neutral
                // N(Neutral)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.Neutral),
                    ProperName = "Neutral",
                    Description =
                        "A neutral character does what " +
                        "seems to be a good idea. They " +
                        "don’t feel strongly one way or " +
                        "the other when it comes to " +
                        "good vs. evil or law vs. chaos " +
                        "(and thus neutral is sometimes " +
                        "called “true neutral”). Most " +
                        "neutral characters exhibit a " +
                        "lack of conviction or bias " +
                        "rather than a commitment to " +
                        "neutrality. Such a character " +
                        "probably thinks of good as " +
                        "better than evil—after all, " +
                        "they would rather have good " +
                        "neighbors and rulers than evil " +
                        "ones. Still, their not personally " +
                        "committed to upholding good in " +
                        "any abstract or universal way.",
                },
                #endregion

                #region Chaotic Neutral
                // CN(Chaotic Neutral)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.ChaoticNeutral),
                    ProperName = "Chaotic Neutral",
                    Description =
                        "A chaotic neutral character " +
                        "follows their whims. They are " +
                        "individualist first and last. " +
                        "They values their own liberty " +
                        "but don’t strive to protect " +
                        "others’ freedom. They avoid " +
                        "authority, resent restrictions, " +
                        "and challenge traditions. A " +
                        "chaotic neutral character does " +
                        "not intentionally disrupt " +
                        "organizations as part of a " +
                        "campaign of anarchy. To do so, " +
                        "they would have to be motivated " +
                        "either by good (and a desire " +
                        "to liberate others) or evil " +
                        "(and a desire to make those " +
                        "others suffer). a chaotic " +
                        "neutral character may be " +
                        "unpredictable, but their behavior " +
                        "is not totally random. They are " +
                        "not likely to jump off a bridge " +
                        "as they is to cross it.",
                },
                #endregion

                #region Lawful Evil
                // LE(Lawful Evil)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.LawfulEvil),
                    ProperName = "Lawful Evil",
                    Description =
                        "A lawful evil villain methodically " +
                        "takes what they want within the " +
                        "limits of his code of conduct " +
                        "without regard for whom it hurts. " +
                        "They care about tradition, loyalty, " +
                        "and order, but not about freedom, " +
                        "dignity, or life. They play by the " +
                        "rules but without mercy or " +
                        "compassion. They are comfortable " +
                        "in a hierarchy and would like to " +
                        "rule, but are willing to serve. They " +
                        "condemn others not according to " +
                        "their actions but according to race, " +
                        "religion, homeland, or social rank. " +
                        "They are loath to break laws or " +
                        "promises.",
                },
                #endregion

                #region Neutral Evil
                // NE(Neutral Evil)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.NeutralEvil),
                    ProperName = "Neutral Evil",
                    Description =
                        "A lawful evil villain methodically " +
                        "takes what they want within the " +
                        "limits of his code of conduct " +
                        "without regard for whom it hurts. " +
                        "They care about tradition, loyalty, " +
                        "and order, but not about freedom, " +
                        "dignity, or life. They play by the " +
                        "rules but without mercy or " +
                        "compassion. They are comfortable " +
                        "in a hierarchy and would like to " +
                        "rule, but are willing to serve. They " +
                        "condemn others not according to " +
                        "their actions but according to race, " +
                        "religion, homeland, or social rank. " +
                        "They are loath to break laws or " +
                        "promises.",
                },
                #endregion

                #region Chaotic Evil
                // CE(Chaotic Evil)
                new StandardTableEntry
                {
                    Name = nameof(AlignmentEnum.ChaoticEvil),
                    ProperName = "Chaotic Evil",
                    Description =
                        "A chaotic evil character does " +
                        "what their greed, hatred, and " +
                        "lust for destruction drive them " +
                        "to do. They are vicious, " +
                        "arbitrarily violent, and " +
                        "unpredictable. If they are " +
                        "simply out for whatever their " +
                        "can get, They are ruthless and " +
                        "brutal. If they are committed " +
                        "to the spread of evil and " +
                        "chaos, they are even worse. " +
                        "Thankfully, their plans are " +
                        "haphazard, and any groups they " +
                        "join are forms are likely to " +
                        "be poorly organized. Typically, " +
                        "chaotic evil people can be " +
                        "made to work together only " +
                        "by force, and their leader " +
                        "lasts only as long as they can " +
                        "thwart attempts to topple or " +
                        "assassinate him.",
                },
                #endregion
            ];
        }
    }
}
