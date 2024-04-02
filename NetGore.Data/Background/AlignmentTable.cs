using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Data.Background;

/// <summary>
/// Determine your character's alignment
/// </summary>
public class AlignmentTable : RandomRangeTable, IAlignmentTable
{
    //d9 Alignment
    //1	LG(Lawful Good)
    //2	NG(Neutral Good)
    //3	CG(Chaotic Good)
    //4	LN(Lawful Neutral)
    //5	N(Neutral)
    //6	CN(Chaotic Neutral)
    //7	LE(Lawful Evil)
    //8	NE(Neutral Evil)
    //9	CE(Chaotic Evil)
    /// <summary>
    /// Alignment Table
    /// </summary>
    [SetsRequiredMembers]
    public AlignmentTable()
    {
        Name = nameof(AlignmentTable);
        Description = "Alignment Table";
        DiceSides = 9;
        Table =
        [
            #region Lawful Good
            //1	LG(Lawful Good)
            new RandomTableRangeEntry
            {
                Range = new Range(1, 1),
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
            //2	NG(Neutral Good)
            new RandomTableRangeEntry
            {
                Range = new Range(2, 2),
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
            //3	CG(Chaotic Good)
            new RandomTableRangeEntry
            {
                Range = new Range(3, 3),
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
            //4	LN(Lawful Neutral)
            new RandomTableRangeEntry
            {
                Range = new Range(4,4),
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
            //5	N(Neutral)
            new RandomTableRangeEntry
            {
                Range = new Range(5,5),
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
            //6	CN(Chaotic Neutral)
            new RandomTableRangeEntry
            {
                Range = new Range(6,6),
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
            //7	LE(Lawful Evil)
            new RandomTableRangeEntry
            {
                Range = new Range(7,7),
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
            //8	NE(Neutral Evil)
            new RandomTableRangeEntry
            {
                Range = new Range(8,8),
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
            //9	CE(Chaotic Evil)
            new RandomTableRangeEntry
            {
                Range = new Range(9,9),
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
