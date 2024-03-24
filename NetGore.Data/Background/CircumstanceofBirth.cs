using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// 
/// </summary>
public partial class BackgroundTables
{
    //Table: Circumstance of Birth
    //d%	Result
    //01–40	Lower-Class Birth   You were born among peasants or slum denizens.You grew up working the land around a village or manor, practicing a rudimentary trade, or begging in a settlement. You gain access to the Poverty-Stricken social trait.Roll 2d20 on Table: Parents’ Profession to determine your parents’ occupation, instead of rolling d%.
    /// <summary>
    /// Determine the circumstances of your birth.
    /// </summary>
    public static RandomTable CircumstanceofBirth { get; } = new()
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
                Name = "Lower-Class Birth",
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
        ]
    };
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
}
