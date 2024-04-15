#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.d20pfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
//
// Pathfinder Roleplaying Game: Ultimate Campaign.
// ©2013, Paizo Publishing, LLC;
// Authors: Jesse Benner, Benjamin Bruck, Jason Bulmahn,
// Ryan Costello, Adam Daigle, Matt Goetz, Tim Hitchcock,
// James Jacobs, Ryan Macklin, Colin McComb,
// Jason Nelson, Richard Pett, Stephen Radney-MacFarland,
// Patrick Renie, Sean K Reynolds, F. Wesley Schneider,
// James L.Sutter, Russ Taylor, and Stephen Townshend.
//
#endregion

using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Character.Tables;

/// <summary>
/// Determine the circumstances of your birth.
/// </summary>
public class CircumstanceofBirthTable : RandomTable, ICircumstanceofBirthTable
{
    /// <summary>
    /// Determine the circumstances of your birth.
    /// </summary>
    [SetsRequiredMembers]
    public CircumstanceofBirthTable()
    {
        Name = nameof(CircumstanceofBirthTable);
        ProperName = "Circumstance of Birth Table";
        TableType = TableTypeEnum.BackgroundTable;
        Description = "Roll once on Table: Circumstance of Birth to determine the circumstances of your birth.";
        DiceSides = 100;
    }

    //Table: Circumstance of Birth
    //d%	Result
    //01–40	Lower-Class Birth   You were born among peasants or slum denizens.You grew up working the land around a village or manor, practicing a rudimentary trade, or begging in a settlement. You gain access to the Poverty-Stricken social trait.Roll 2d20 on Table: Parents’ Profession to determine your parents’ occupation, instead of rolling d%.
    //41–65	Middle-Class Birth  You were born to the middle class, which includes merchants, artisans, and tradespeople.You likely grew up in a good-sized settlement, and one of your parents is likely associated with a guild or other trade organization.As a free person, you don’t experience the bondage of serfdom or peasantry, but you also lack the privilege of the nobility.You gain access to the Artisan social trait and the Merchant social trait.
    //66–70	Noble Birth You were born to privilege among the nobility. Unless one of your parents is the regent, your family serves a higher-ranked noble but lesser nobles serve your family in turn.You gain access to the Influence social trait and the Rich Parents social trait. Roll on Table: Nobility to determine your family’s noble rank.
    //71–72	Adopted Outside Your Race   You were not raised by your birth family and grew up in a family of a different race than your own.Roll on Table: Adopted Outside Your Race.
    //73–77	Adopted You were not raised by your birth family, but taken in by another family within your race or culture. Roll twice instead of once on Table: Parents’ Profession—once for your birth family and a second time for your adoptive family.You gain access to traits granted by both sets of parents.
    //78–81	Bastard Born    Your parents had a tryst that resulted in your birth out of wedlock. You know one of your parents, but the other remains unknown or a distant presence at best.You gain access to the Bastard social trait and the Shamed story feat.
    //82	Blessed Birth   When you were born, you were blessed by a being of great power such as an angel, azata, or genie. This blessing has protected you from certain peril or marked you as special to some deity.You gain access to the Blessed faith trait and the Birthmark faith trait.
    //83–84	Born of Violence Your birth was caused by violent, unwilling means. You have one parent, and the other likely remains unknown. You gain access to the Axe to Grind combat trait and the Bastard social trait.
    //85	Born out of Time    You were born in a different era, either the distant past or the far future. Some event has displaced you from your time, and the ways and customs of the present seem strange and alien to you.You gain access to the Scholar of the Great Beyond faith trait.
    //86–87	Born into Bondage You were born into slavery or servitude. Your parents are likely slaves or servants, or you were sold into slavery as an infant. You gain access to the Life of Toil social trait.
    //88	Cursed Birth    When you were born, a powerful fiendish entity tainted your blood in some way and cursed you as an agent of dark prophecy.You gain access to the Fiend Blood bloodline race trait and the Accursed story feat.
    //89–90	Dishonored Family   You were born into a family that once was honored among your society but has since fallen into disgrace.Now your family name is loathed and maligned by those who know it, putting you on your guard.You gain access to the Reactionary combat trait, the Lost Legacy story feat, and the Redemption story feat.
    //91–92	Heir to a Legacy    You are the heir to a family with an old name and a distinguished past.Your family might be wealthy or middle class, but your name itself is worth twice your fortunes.You gain access to the Influence social trait and the Rich Parents social trait.
    //93–94	Left to Die When you were born you were left to die, but by some twist of circumstance you survived. You gain access to the Courageous combat trait, the Savage social trait, and the Arisen story feat.
    //95	Marked by the Gods  A deity has marked you.That mark can be on your body or your soul. You gain access to the Birthmark faith trait, the Sacred Touch faith trait, and the Prophet story feat.
    //96	Energy Infused  During your birth you were exposed to potent source of divine energy. You gain access to the Sacred Conduit faith trait and the Sacred Touch faith trait.
    //97	Progeny of Power You were born during a particularly powerful conjunction or in some other time of power.You gain access to the Magical Talent magic trait, the Charming social trait, and the Sacred Touch faith trait.
    //98	Prophesied Your birth was foretold, as recently as during the last generation to as far back as thousands of years ago. You gain access to the Prophesied faith trait.
    //99	Reincarnated You have been reborn in many cycles, and may be reborn in many more until you accomplish the ultimate task for which you are destined. You gain access to the Reincarnated faith trait, the Arisen story feat, and the Forgotten Past story feat.
    //100	The Omen    The sages, priests, or wizards of your society decreed your birth an omen of a coming age or event—perhaps you are an omen of promise, perhaps one of dark times ahead. You gain access to the Omen faith trait.
    /// <summary>
    /// Initialize the game table.  This is a seperate method so we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of optimiation to conserve memeory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region "Lower-Class Birth"
            //01–40	Lower-Class Birth   You were born among peasants or slum denizens.You grew up working the land around a village or manor, practicing a rudimentary trade, or begging in a settlement. You gain access to the Poverty-Stricken social trait.Roll 2d20 on Table: Parents’ Profession to determine your parents’ occupation, instead of rolling d%.
            new BackgroundTableEntry
            {
                Range = new Range(01, 40),
                Name = nameof(CircumstanceofBirthEnum.LowerClassBirth),
                ProperName = "Lower-Class Birth",
                Description =
                    "You were born among peasants or " +
                    "slum denizens.You grew up working " +
                    "the land around a village or manor, " +
                    "practicing a rudimentary trade, " +
                    "or begging in a settlement. You " +
                    "gain access to the Poverty-Stricken " +
                    "social trait. Roll 2d20 on Table: " +
                    "Parents’ Profession to determine " +
                    "your parents’ occupation, instead " +
                    "of rolling d%.",
                Traits =
                {
                    TraitEnum.PovertyStricken,
                },
                AlternateTable = typeof(ProfessionTable),
            },
            #endregion

            #region "Middle-Class Birth"
            //41–65	Middle-Class Birth  You were born to the middle class, which includes merchants, artisans, and tradespeople.You likely grew up in a good-sized settlement, and one of your parents is likely associated with a guild or other trade organization.As a free person, you don’t experience the bondage of serfdom or peasantry, but you also lack the privilege of the nobility.You gain access to the Artisan social trait and the Merchant social trait.
            new BackgroundTableEntry
            {
                Range = new Range(41, 65),
                Name = nameof(CircumstanceofBirthEnum.MiddleClassBirth),
                ProperName = "Middle-Class Birth",
                Description =
                    "You were born to the middle class, " +
                    "which includes merchants, artisans, " +
                    "and tradespeople. You likely grew " +
                    "up in a good-sized settlement, and " +
                    "one of your parents is likely " +
                    "associated with a guild or other " +
                    "trade organization.As a free person, " +
                    "you don’t experience the bondage of " +
                    "serfdom or peasantry, but you also " +
                    "lack the privilege of the nobility. " +
                    "You gain access to the Artisan social " +
                    "trait and the Merchant social trait.",
                Traits =
                {
                    TraitEnum.Artisan,
                    TraitEnum.Merchant,
                },
            },
            #endregion

            #region "Noble Birth"
            //66–70	Noble Birth You were born to privilege among the nobility. Unless one of your parents is the regent, your family serves a higher-ranked noble but lesser nobles serve your family in turn.You gain access to the Influence social trait and the Rich Parents social trait. Roll on Table: Nobility to determine your family’s noble rank.
            new BackgroundTableEntry
            {
                Range = new Range(66, 70),
                Name = nameof(CircumstanceofBirthEnum.NobleBirth),
                ProperName = "Noble Birth",
                Description =
                    "You were born to privilege among " +
                    "the nobility. Unless one of your " +
                    "parents is the regent, your " +
                    "family serves a higher-ranked " +
                    "noble but lesser nobles serve " +
                    "your family in turn. You gain " +
                    "access to the Influence social " +
                    "trait and the Rich Parents social " +
                    "trait. Roll on Table: Nobility to " +
                    "determine your family’s noble rank.",
                Traits =
                {
                    TraitEnum.Influence,
                    TraitEnum.RichParents,
                },
                AlternateTable = typeof(NobilityTable),
            },
            #endregion

            #region "Adopted Outside Your Race"
            //71–72	Adopted Outside Your Race   You were not raised by your birth family and grew up in a family of a different race than your own.Roll on Table: Adopted Outside Your Race.
            new BackgroundTableEntry
            {
                Range = new Range(71, 72),
                Name = nameof(CircumstanceofBirthEnum.AdoptedOutsideYourRace),
                ProperName = "Adopted Outside Your Race",
                Description =
                    "You were not raised by your birth " +
                    "family and grew up in a family of " +
                    "a different race than your own. " +
                    "Roll on Table: Race.",
                //AlternateTable = typeof(RaceTable),
            },
            #endregion

            #region "Adopted"
            //73–77	Adopted You were not raised by your birth family, but taken in by another family within your race or culture. Roll twice instead of once on Table: Parents’ Profession—once for your birth family and a second time for your adoptive family.You gain access to traits granted by both sets of parents.
            new BackgroundTableEntry
            {
                Range = new Range(73, 77),
                Name = nameof(CircumstanceofBirthEnum.Adopted),
                ProperName = "Adopted",
                Description =
                    "You were not raised by your birth " +
                    "family, but taken in by another " +
                    "family within your race or culture. " +
                    "Roll twice instead of once on Table: " +
                    "Parents’ Profession—once for your " +
                    "birth family and a second time for " +
                    "your adoptive family.You gain access " +
                    "to traits granted by both sets of parents.",
                AlternateTable = typeof(ProfessionTable),
            },
            #endregion

            #region "Bastard Born"
            //78–81	Bastard Born Your parents had a tryst that resulted in your birth out of wedlock. You know one of your parents, but the other remains unknown or a distant presence at best.You gain access to the Bastard social trait and the Shamed story feat.
            new BackgroundTableEntry
            {
                Range = new Range(78, 81),
                Name = nameof(CircumstanceofBirthEnum.BastardBorn),
                ProperName = "Bastard Born",
                Description =
                    "Your parents had a tryst that " +
                    "resulted in your birth out of " +
                    "wedlock. You know one of your " +
                    "parents, but the other remains " +
                    "unknown or a distant presence " +
                    "at best. You gain access to the " +
                    "Bastard social trait and the Shamed story feat.",
                Traits =
                {
                    TraitEnum.Bastard,
                },
            },
            #endregion

            #region "Blessed Birth"
            //82	Blessed Birth   When you were born, you were blessed by a being of great power such as an angel, azata, or genie. This blessing has protected you from certain peril or marked you as special to some deity.You gain access to the Blessed faith trait and the Birthmark faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(82, 82),
                Name = nameof(CircumstanceofBirthEnum.BlessedBirth),
                ProperName = "Blessed Birth",
                Description =
                    "When you were born, you were blessed by " +
                    "a being of great power such as an angel, " +
                    "azata, or genie. This blessing has " +
                    "protected you from certain peril or " +
                    "marked you as special to some deity. " +
                    "You gain access to the Blessed faith " +
                    "trait and the Birthmark faith trait.",
                Traits =
                {
                    TraitEnum.Blessed,
                    TraitEnum.Birthmark,
                },
            },
            #endregion

            #region "Born of Violence"
            //83–84	Born of Violence Your birth was caused by violent, unwilling means. You have one parent, and the other likely remains unknown. You gain access to the Axe to Grind combat trait and the Bastard social trait.
            new BackgroundTableEntry
            {
                Range = new Range(83, 84),
                Name = nameof(CircumstanceofBirthEnum.BornofViolence),
                ProperName = "Born of Violence",
                Description =
                    "Your birth was caused by violent, " +
                    "unwilling means. You have one " +
                    "parent, and the other likely " +
                    "remains unknown. You gain access " +
                    "to the Axe to Grind combat trait " +
                    "and the Bastard social trait.",
                Traits =
                {
                    TraitEnum.AxetoGrind,
                    TraitEnum.Bastard,
                },
            },
            #endregion

            #region "Born out of Time"
            //85	Born out of Time    You were born in a different era, either the distant past or the far future. Some event has displaced you from your time, and the ways and customs of the present seem strange and alien to you.You gain access to the Scholar of the Great Beyond faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(85, 85),
                Name = nameof(CircumstanceofBirthEnum.BornoutofTime),
                ProperName = "Born out of Time",
                Description =
                    "You were born in a different era, " +
                    "either the distant past or the far " +
                    "future. Some event has displaced you " +
                    "from your time, and the ways and " +
                    "customs of the present seem strange " +
                    "and alien to you. You gain access to " +
                    "the Scholar of the Great Beyond " +
                    "faith trait.",
                Traits =
                {
                    TraitEnum.ScholaroftheGreatBeyond,
                },
            },
            #endregion

            #region "Born into Bondage"
            //86–87	Born into Bondage You were born into slavery or servitude. Your parents are likely slaves or servants, or you were sold into slavery as an infant. You gain access to the Life of Toil social trait.
            new BackgroundTableEntry
            {
                Range = new Range(86, 87),
                Name = nameof(CircumstanceofBirthEnum.BornintoBondage),
                ProperName = "Born into Bondage",
                Description =
                    "You were born into slavery or servitude. " +
                    "Your parents are likely slaves or servants, " +
                    "or you were sold into slavery as an infant. " +
                    "You gain access to the Life of Toil social " +
                    "trait.",
                Traits =
                {
                    TraitEnum.LifeofToil,
                },
            },
            #endregion

            #region "Cursed Birth"
            //88	Cursed Birth    When you were born, a powerful fiendish entity tainted your blood in some way and cursed you as an agent of dark prophecy.You gain access to the Fiend Blood bloodline race trait and the Accursed story feat.
            new BackgroundTableEntry
            {
                Range = new Range(88, 88),
                Name = nameof(CircumstanceofBirthEnum.CursedBirth),
                ProperName = "Cursed Birth",
                Description =
                    "When you were born, a powerful " +
                    "fiendish entity tainted your blood " +
                    "in some way and cursed you as an " +
                    "agent of dark prophecy. You gain " +
                    "access to the Fiend Blood bloodline " +
                    "race trait and the Accursed story feat.",
                Traits =
                {
                    TraitEnum.FiendBlood,
                    //TraitEnum.Accursed,
                },
            },
            #endregion

            #region "Dishonored Family"
            //89–90	Dishonored Family   You were born into a family that once was honored among your society but has since fallen into disgrace.Now your family name is loathed and maligned by those who know it, putting you on your guard.You gain access to the Reactionary combat trait, the Lost Legacy story feat, and the Redemption story feat.
            new BackgroundTableEntry
            {
                Range = new Range(89, 90),
                Name = nameof(CircumstanceofBirthEnum.DishonoredFamily),
                ProperName = "Dishonored Family",
                Description =
                    "You were born into a family that " +
                    "once was honored among your " +
                    "society but has since fallen " +
                    "into disgrace. Now your family " +
                    "name is loathed and maligned by " +
                    "those who know it, putting you " +
                    "on your guard. You gain access " +
                    "to the Reactionary combat trait, " +
                    "the Lost Legacy story feat, " +
                    "and the Redemption story feat.",
                Traits =
                {
                    TraitEnum.Reactionary,
                },
            },
            #endregion

            #region "Heir to a Legacy"
            //91–92	Heir to a Legacy    You are the heir to a family with an old name and a distinguished past.Your family might be wealthy or middle class, but your name itself is worth twice your fortunes.You gain access to the Influence social trait and the Rich Parents social trait.
            new BackgroundTableEntry
            {
                Range = new Range(91, 92),
                Name = nameof(CircumstanceofBirthEnum.HeirtoaLegacy),
                ProperName = "Heir to a Legacy",
                Description =
                    "You are the heir to a family " +
                    "with an old name and a " +
                    "distinguished past. Your " +
                    "family might be wealthy or " +
                    "middle class, but your name " +
                    "itself is worth twice your " +
                    "fortunes. You gain access to " +
                    "the Influence social trait " +
                    "and the Rich Parents social trait.",
                Traits =
                {
                    TraitEnum.Influence,
                    TraitEnum.RichParents,
                },
            },
            #endregion

            #region "Left to Die"
            //93–94	Left to Die When you were born you were left to die, but by some twist of circumstance you survived. You gain access to the Courageous combat trait, the Savage social trait, and the Arisen story feat.
            new BackgroundTableEntry
            {
                Range = new Range(93, 94),
                Name = nameof(CircumstanceofBirthEnum.LefttoDie),
                ProperName = "Left to Die",
                Description =
                    "When you were born you were left " +
                    "to die, but by some twist of " +
                    "circumstance you survived. You " +
                    "gain access to the Courageous " +
                    "combat trait, the Savage social " +
                    "trait, and the Arisen story feat.",
                Traits =
                {
                    TraitEnum.Courageous,
                    TraitEnum.Savage,
                },
            },
            #endregion

            #region "Marked by the Gods"
            //95	Marked by the Gods  A deity has marked you.That mark can be on your body or your soul. You gain access to the Birthmark faith trait, the Sacred Touch faith trait, and the Prophet story feat.
            new BackgroundTableEntry
            {
                Range = new Range(95, 95),
                Name = nameof(CircumstanceofBirthEnum.MarkedbytheGods),
                ProperName = "Marked by the Gods",
                Description =
                    "A deity has marked you. That mark " +
                    "can be on your body or your soul. " +
                    "You gain access to the Birthmark " +
                    "faith trait, the Sacred Touch " +
                    "faith trait, and the Prophet " +
                    "story feat.",
                Traits =
                {
                    TraitEnum.Birthmark,
                    TraitEnum.SacredTouch,
                },
            },
            #endregion

            #region "Energy Infused"
            //96	Energy Infused  During your birth you were exposed to potent source of divine energy. You gain access to the Sacred Conduit faith trait and the Sacred Touch faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(96, 96),
                Name = nameof(CircumstanceofBirthEnum.EnergyInfused),
                ProperName = "Energy Infused",
                Description =
                    "During your birth you were exposed " +
                    "to potent source of divine energy. " +
                    "You gain access to the Sacred Conduit " +
                    "faith trait and the Sacred Touch " +
                    "faith trait.",
                Traits =
                {
                    TraitEnum.SacredConduit,
                    TraitEnum.SacredTouch,
                },
            },
            #endregion

            #region "Progeny of Power"
            //97	Progeny of Power You were born during a particularly powerful conjunction or in some other time of power.You gain access to the Magical Talent magic trait, the Charming social trait, and the Sacred Touch faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(97, 97),
                Name = nameof(CircumstanceofBirthEnum.ProgenyofPower),
                ProperName = "Progeny of Power",
                Description =
                    "You were born during a particularly " +
                    "powerful conjunction or in some other " +
                    "time of power. You gain access to the " +
                    "Magical Talent magic trait, the Charming " +
                    "social trait, and the Sacred Touch faith trait.",
                Traits =
                {
                    TraitEnum.MagicalTalent,
                    TraitEnum.Charming,
                    TraitEnum.SacredTouch,                },
            },
            #endregion

            #region "Prophesied"
            //98	Prophesied Your birth was foretold, as recently as during the last generation to as far back as thousands of years ago. You gain access to the Prophesied faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(98, 98),
                Name = nameof(CircumstanceofBirthEnum.Prophesied),
                ProperName = "Prophesied",
                Description =
                    "Your birth was foretold, as " +
                    "recently as during the last " +
                    "generation to as far back as " +
                    "thousands of years ago. You " +
                    "gain access to the Prophesied " +
                    "faith trait.",
                Traits =
                {
                    TraitEnum.Prophesied,
                }
            },
            #endregion

            #region "Reincarnated"
            //99	Reincarnated You have been reborn in many cycles, and may be reborn in many more until you accomplish the ultimate task for which you are destined. You gain access to the Reincarnated faith trait, the Arisen story feat, and the Forgotten Past story feat.
            new BackgroundTableEntry
            {
                Range = new Range(99, 99),
                Name = nameof(CircumstanceofBirthEnum.Reincarnated),
                ProperName = "Reincarnated",
                Description =
                    "You have been reborn in many " +
                    "cycles, and may be reborn in " +
                    "many more until you accomplish " +
                    "the ultimate task for which " +
                    "you are destined. You gain " +
                    "access to the Reincarnated " +
                    "faith trait, the Arisen story " +
                    "feat, and the Forgotten Past story feat.",
                Traits =
                {
                    TraitEnum.Reincarnated,
                    //TraitEnum.Arisen,
                    //TraitEnum.ForgottenPast,
                }
            },
            #endregion

            #region "The Omen"
            //100	The Omen    The sages, priests, or wizards of your society decreed your birth an omen of a coming age or event—perhaps you are an omen of promise, perhaps one of dark times ahead. You gain access to the Omen faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(100, 100),
                Name = nameof(CircumstanceofBirthEnum.TheOmen),
                ProperName = "The Omen",
                Description =
                    "The sages, priests, or wizards of " +
                    "your society decreed your birth an " +
                    "omen of a coming age or event—perhaps " +
                    "you are an omen of promise, perhaps " +
                    "one of dark times ahead. You gain " +
                    "access to the Omen faith trait.",
                Traits =
                {
                    TraitEnum.Omen,
                }
            },
            #endregion
        ];
    }
}
