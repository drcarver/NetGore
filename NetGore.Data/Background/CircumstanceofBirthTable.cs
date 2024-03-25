using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// Determine the circumstances of your birth.
/// </summary>
public partial class BackgroundTables
{
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
    /// Determine the circumstances of your birth.
    /// </summary>
    public static RandomTable CircumstanceofBirthTable { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Lower-Class Birth"
            //01–40	Lower-Class Birth   You were born among peasants or slum denizens.You grew up working the land around a village or manor, practicing a rudimentary trade, or begging in a settlement. You gain access to the Poverty-Stricken social trait.Roll 2d20 on Table: Parents’ Profession to determine your parents’ occupation, instead of rolling d%.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 40,
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
                RacialTraits =
                {
                    RacialTraitEnum.PovertyStricken,
                },
            },
            #endregion

            #region "Middle-Class Birth"
            //41–65	Middle-Class Birth  You were born to the middle class, which includes merchants, artisans, and tradespeople.You likely grew up in a good-sized settlement, and one of your parents is likely associated with a guild or other trade organization.As a free person, you don’t experience the bondage of serfdom or peasantry, but you also lack the privilege of the nobility.You gain access to the Artisan social trait and the Merchant social trait.
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 65,
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
                RacialTraits =
                {
                    RacialTraitEnum.Artisan,
                    RacialTraitEnum.Merchant,
                },
            },
            #endregion

            #region "Noble Birth"
            //66–70	Noble Birth You were born to privilege among the nobility. Unless one of your parents is the regent, your family serves a higher-ranked noble but lesser nobles serve your family in turn.You gain access to the Influence social trait and the Rich Parents social trait. Roll on Table: Nobility to determine your family’s noble rank.
            new RandomTableEntry
            {
                LowerRange = 66,
                UpperRange = 70,
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
                RacialTraits =
                {
                    RacialTraitEnum.Influence,
                    RacialTraitEnum.RichParents,
                },
                AlternateTable = NobilityTable
            },
            #endregion

            #region "Adopted Outside Your Race"
            //71–72	Adopted Outside Your Race   You were not raised by your birth family and grew up in a family of a different race than your own.Roll on Table: Adopted Outside Your Race.
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 72,
                Name = nameof(CircumstanceofBirthEnum.AdoptedOutsideYourRace),
                ProperName = "Adopted Outside Your Race",
                Description =
                    "You were not raised by your birth " +
                    "family and grew up in a family of " +
                    "a different race than your own. " +
                    "Roll on Table: Race.",
                RacialTraits =
                {
                    RacialTraitEnum.Influence,
                    RacialTraitEnum.RichParents,
                },
                AlternateTable = RaceTable
            },
            #endregion

            #region "Adopted"
            //73–77	Adopted You were not raised by your birth family, but taken in by another family within your race or culture. Roll twice instead of once on Table: Parents’ Profession—once for your birth family and a second time for your adoptive family.You gain access to traits granted by both sets of parents.
            new RandomTableEntry
            {
                LowerRange = 73,
                UpperRange = 77,
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
                AlternateTable = ParentsProfessionTable
            },
            #endregion

            #region "Bastard Born"
            //78–81	Bastard Born Your parents had a tryst that resulted in your birth out of wedlock. You know one of your parents, but the other remains unknown or a distant presence at best.You gain access to the Bastard social trait and the Shamed story feat.
            new RandomTableEntry
            {
                LowerRange = 78,
                UpperRange = 81,
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
                RacialTraits =
                {
                    RacialTraitEnum.Bastard,
                    RacialTraitEnum.Shamed,
                },
            },
            #endregion

            #region "Blessed Birth"
            //82	Blessed Birth   When you were born, you were blessed by a being of great power such as an angel, azata, or genie. This blessing has protected you from certain peril or marked you as special to some deity.You gain access to the Blessed faith trait and the Birthmark faith trait.
            new RandomTableEntry
            {
                LowerRange = 82,
                UpperRange = 82,
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
                RacialTraits =
                {
                    RacialTraitEnum.Blessed,
                    RacialTraitEnum.Birthmark,
                },
            },
            #endregion

            #region "Born of Violence"
            //83–84	Born of Violence Your birth was caused by violent, unwilling means. You have one parent, and the other likely remains unknown. You gain access to the Axe to Grind combat trait and the Bastard social trait.
            new RandomTableEntry
            {
                LowerRange = 83,
                UpperRange = 84,
                Name = nameof(CircumstanceofBirthEnum.BornofViolence),
                ProperName = "Born of Violence",
                Description =
                    "Your birth was caused by violent, " +
                    "unwilling means. You have one " +
                    "parent, and the other likely " +
                    "remains unknown. You gain access " +
                    "to the Axe to Grind combat trait " +
                    "and the Bastard social trait.",
                RacialTraits =
                {
                    RacialTraitEnum.AxetoGrind,
                    RacialTraitEnum.Bastard,
                },
            },
            #endregion

            #region "Born out of Time"
            //85	Born out of Time    You were born in a different era, either the distant past or the far future. Some event has displaced you from your time, and the ways and customs of the present seem strange and alien to you.You gain access to the Scholar of the Great Beyond faith trait.
            new RandomTableEntry
            {
                LowerRange = 85,
                UpperRange = 85,
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
                RacialTraits =
                {
                    RacialTraitEnum.ScholaroftheGreatBeyond,
                },
            },
            #endregion

            #region "Born into Bondage"
            //86–87	Born into Bondage You were born into slavery or servitude. Your parents are likely slaves or servants, or you were sold into slavery as an infant. You gain access to the Life of Toil social trait.
            new RandomTableEntry
            {
                LowerRange = 86,
                UpperRange = 87,
                Name = nameof(CircumstanceofBirthEnum.BornintoBondage),
                ProperName = "Born into Bondage",
                Description =
                    "You were born into slavery or servitude. " +
                    "Your parents are likely slaves or servants, " +
                    "or you were sold into slavery as an infant. " +
                    "You gain access to the Life of Toil social " +
                    "trait.",
                RacialTraits =
                {
                    RacialTraitEnum.LifeofToil,
                },
            },
            #endregion

            #region "Cursed Birth"
            //88	Cursed Birth    When you were born, a powerful fiendish entity tainted your blood in some way and cursed you as an agent of dark prophecy.You gain access to the Fiend Blood bloodline race trait and the Accursed story feat.
            new RandomTableEntry
            {
                LowerRange = 88,
                UpperRange = 88,
                Name = nameof(CircumstanceofBirthEnum.CursedBirth),
                ProperName = "Cursed Birth",
                Description =
                    "When you were born, a powerful " +
                    "fiendish entity tainted your blood " +
                    "in some way and cursed you as an " +
                    "agent of dark prophecy. You gain " +
                    "access to the Fiend Blood bloodline " +
                    "race trait and the Accursed story feat.",
                RacialTraits =
                {
                    RacialTraitEnum.FiendBlood,
                    RacialTraitEnum.Accursed,
                },
            },
            #endregion

            #region "Dishonored Family"
            //89–90	Dishonored Family   You were born into a family that once was honored among your society but has since fallen into disgrace.Now your family name is loathed and maligned by those who know it, putting you on your guard.You gain access to the Reactionary combat trait, the Lost Legacy story feat, and the Redemption story feat.
            new RandomTableEntry
            {
                LowerRange = 89,
                UpperRange = 90,
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
                RacialTraits =
                {
                    RacialTraitEnum.Reactionary,
                    RacialTraitEnum.LostLegacy,
                    RacialTraitEnum.Redemption,
                },
            },
            #endregion

            #region "Heir to a Legacy"
            //91–92	Heir to a Legacy    You are the heir to a family with an old name and a distinguished past.Your family might be wealthy or middle class, but your name itself is worth twice your fortunes.You gain access to the Influence social trait and the Rich Parents social trait.
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 92,
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
                RacialTraits =
                {
                    RacialTraitEnum.Influence,
                    RacialTraitEnum.RichParents,
                },
            },
            #endregion

            #region "Left to Die"
            //93–94	Left to Die When you were born you were left to die, but by some twist of circumstance you survived. You gain access to the Courageous combat trait, the Savage social trait, and the Arisen story feat.
            new RandomTableEntry
            {
                LowerRange = 93,
                UpperRange = 94,
                Name = nameof(CircumstanceofBirthEnum.LefttoDie),
                ProperName = "Left to Die",
                Description =
                    "When you were born you were left " +
                    "to die, but by some twist of " +
                    "circumstance you survived. You " +
                    "gain access to the Courageous " +
                    "combat trait, the Savage social " +
                    "trait, and the Arisen story feat.",
                RacialTraits =
                {
                    RacialTraitEnum.Courageous,
                    RacialTraitEnum.Savage,
                    RacialTraitEnum.Arisen,
                },
            },
            #endregion

            #region "Marked by the Gods"
            //95	Marked by the Gods  A deity has marked you.That mark can be on your body or your soul. You gain access to the Birthmark faith trait, the Sacred Touch faith trait, and the Prophet story feat.
            new RandomTableEntry
            {
                LowerRange = 95,
                UpperRange = 95,
                Name = nameof(CircumstanceofBirthEnum.MarkedbytheGods),
                ProperName = "Marked by the Gods",
                Description =
                    "A deity has marked you. That mark " +
                    "can be on your body or your soul. " +
                    "You gain access to the Birthmark " +
                    "faith trait, the Sacred Touch " +
                    "faith trait, and the Prophet " +
                    "story feat.",
                RacialTraits =
                {
                    RacialTraitEnum.Birthmark,
                    RacialTraitEnum.SacredTouch,
                    RacialTraitEnum.Prophet,
                },
            },
            #endregion

            #region "Energy Infused"
            //96	Energy Infused  During your birth you were exposed to potent source of divine energy. You gain access to the Sacred Conduit faith trait and the Sacred Touch faith trait.
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 96,
                Name = nameof(CircumstanceofBirthEnum.EnergyInfused),
                ProperName = "Energy Infused",
                Description =
                    "During your birth you were exposed " +
                    "to potent source of divine energy. " +
                    "You gain access to the Sacred Conduit " +
                    "faith trait and the Sacred Touch " +
                    "faith trait.",
                RacialTraits =
                {
                    RacialTraitEnum.SacredConduit,
                    RacialTraitEnum.SacredTouch,
                },
            },
            #endregion

            #region "Progeny of Power"
            //97	Progeny of Power You were born during a particularly powerful conjunction or in some other time of power.You gain access to the Magical Talent magic trait, the Charming social trait, and the Sacred Touch faith trait.
            new RandomTableEntry
            {
                LowerRange = 97,
                UpperRange = 97,
                Name = nameof(CircumstanceofBirthEnum.ProgenyofPower),
                ProperName = "Progeny of Power",
                Description =
                    "You were born during a particularly " +
                    "powerful conjunction or in some other " +
                    "time of power. You gain access to the " +
                    "Magical Talent magic trait, the Charming " +
                    "social trait, and the Sacred Touch faith trait.",
                RacialTraits =
                {
                    RacialTraitEnum.MagicalTalent,
                    RacialTraitEnum.Charming,
                    RacialTraitEnum.SacredTouch,                },
            },
            #endregion

            #region "Prophesied"
            //98	Prophesied Your birth was foretold, as recently as during the last generation to as far back as thousands of years ago. You gain access to the Prophesied faith trait.
            new RandomTableEntry
            {
                LowerRange = 98,
                UpperRange = 98,
                Name = nameof(CircumstanceofBirthEnum.Prophesied),
                ProperName = "Prophesied",
                Description =
                    "Your birth was foretold, as " +
                    "recently as during the last " +
                    "generation to as far back as " +
                    "thousands of years ago. You " +
                    "gain access to the Prophesied " +
                    "faith trait.",
                RacialTraits =
                {
                    RacialTraitEnum.Prophesied,
                }
            },
            #endregion

            #region "Reincarnated"
            //99	Reincarnated You have been reborn in many cycles, and may be reborn in many more until you accomplish the ultimate task for which you are destined. You gain access to the Reincarnated faith trait, the Arisen story feat, and the Forgotten Past story feat.
            new RandomTableEntry
            {
                LowerRange = 99,
                UpperRange = 99,
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
                RacialTraits =
                {
                    RacialTraitEnum.Reincarnated,
                    RacialTraitEnum.Arisen,
                    RacialTraitEnum.ForgottenPast,
                }
            },
            #endregion

            #region "The Omen"
            //100	The Omen    The sages, priests, or wizards of your society decreed your birth an omen of a coming age or event—perhaps you are an omen of promise, perhaps one of dark times ahead. You gain access to the Omen faith trait.
            new RandomTableEntry
            {
                LowerRange = 100,
                UpperRange = 100,
                Name = nameof(CircumstanceofBirthEnum.TheOmen),
                ProperName = "The Omen",
                Description =
                    "The sages, priests, or wizards of " +
                    "your society decreed your birth an " +
                    "omen of a coming age or event—perhaps " +
                    "you are an omen of promise, perhaps " +
                    "one of dark times ahead. You gain " +
                    "access to the Omen faith trait.",
                RacialTraits =
                {
                    RacialTraitEnum.Omen,
                }
            },
            #endregion
        ]
    };
}
