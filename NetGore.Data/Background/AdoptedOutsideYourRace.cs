using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// Most of the time, your parents both come from 
/// the same social stratum. It’s uncommon, but 
/// not unheard of, for people to marry outside 
/// their caste. Roll on Table: Parent’s Profession 
/// to determine the principal profession of your 
/// parents.
/// </summary>
public partial class BackgroundTables
{
    //Table: Adopted Outside Your Race
    //d%	Result
    //01–05	Adopted by Dragons For its own purposes, a dragon raised you as its own.You have learned the language and history, wisdom, power, and might of dragonkind. You gain access to the Blood of Dragons bloodline race trait and the Magical Knack magic trait.
    /// <summary>
    /// Parents’ Profession
    /// </summary>
    public static RandomTable AdoptedOutsideYourRace { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Adopted by Dragons"
            //01–05	Adopted by Dragons For its own purposes, a dragon raised you as its own.You have learned the language and history, wisdom, power, and might of dragonkind. You gain access to the Blood of Dragons bloodline race trait and the Magical Knack magic trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 05,
                Name = "Adopted by Dragons",
                Description =
                    "For its own purposes, a dragon " +
                    "raised you as its own.You have " +
                    "learned the language and history, " +
                    "wisdom, power, and might of " +
                    "dragonkind. You gain access to " +
                    "the Blood of Dragons bloodline " +
                    "race trait and the Magical Knack " +
                    "magic trait.",
                RacialTraits =
                {
                    RacialTraitEnum.BloodofDragons,
                    RacialTraitEnum.MagicalKnack,
                },
            },
            #endregion
        ]
    };
}
//06–10	Adopted by the Fey  Your adoptive parents were fey creatures such as korreds, pixies, or a dryad.You gain access to the Charming social trait and the Magical Knack magic trait.
//11–13	Raised Among the Dead   Your adoptive parent is a nonliving creature, such as a spectre, ghost, lich, or vampire. You were likely raised in empty ruined halls, among tombs and crypts, by a creature that feeds on life.What its purpose was for raising you, none can say.You gain access to the Deathtouched bloodline race trait, the Magical Knack magic trait, and the Glimpse Beyond story feat.
//14–19	Raised by Angels Angels attended your birth and took you to live with them in the heavens. These cosmic beings expanded your view to encompass not just the world but the larger universe. You know that wherever you go, your angelic parents watch over you. You gain access to the Blessed faith trait.
//20–25	Raised by Beasts When you were separated from your biological parents, you were found and raised by wild beasts. Your ways are the ways of the wild, and along with your advanced survival instincts you’ve adopted the natural habits of a specific beast.You gain access to the Resilient combat trait and the Feral Heart story feat.
//26–70	Raised by Civilized Humanoids   You were raised by a community of civilized humanoids of a race different from your own (chosen by your GM). Your attitudes, beliefs, and values reflect that race, although characteristics of your true nature frequently emerge.You gain access to a race trait from the race that raised you.
//71–95	Raised by Savage Humanoids  You were raised by savage humanoids such as orcs, kobolds, gnolls, troglodytes, or lizardfolk.As a result, your values, customs, and traditions are those of your adoptive parents, though characteristics of your true nature frequently emerge.You gain access to the Savage social trait.
//96–100	Fiend Raised    You were separated from your natural parents and raised by a fiend who taught you the cruelty and malice of the gods and worked to fashion you into its own mortal instrument to corrupt innocent souls. You gain access to the Fiend Blood bloodline race trait and the Damned story feat.
