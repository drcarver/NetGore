using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// If you made a roll that determined your character 
/// was adopted outside your race, roll on 
/// Table: Adopted Outside Your Race to determine 
/// the type of creature that raised you.
/// </summary>
public partial class BackgroundTables
{
    //Table: Adopted Outside Your Race
    //d%	Result
    //01–05	Adopted by Dragons For its own purposes, a dragon raised you as its own.You have learned the language and history, wisdom, power, and might of dragonkind. You gain access to the Blood of Dragons bloodline race trait and the Magical Knack magic trait.
    //06–10	Adopted by the Fey  Your adoptive parents were fey creatures such as korreds, pixies, or a dryad.You gain access to the Charming social trait and the Magical Knack magic trait.
    //11–13	Raised Among the Dead   Your adoptive parent is a nonliving creature, such as a spectre, ghost, lich, or vampire. You were likely raised in empty ruined halls, among tombs and crypts, by a creature that feeds on life.What its purpose was for raising you, none can say.You gain access to the Deathtouched bloodline race trait, the Magical Knack magic trait, and the Glimpse Beyond story feat.
    //14–19	Raised by Angels Angels attended your birth and took you to live with them in the heavens. These cosmic beings expanded your view to encompass not just the world but the larger universe. You know that wherever you go, your angelic parents watch over you. You gain access to the Blessed faith trait.
    //20–25	Raised by Beasts When you were separated from your biological parents, you were found and raised by wild beasts. Your ways are the ways of the wild, and along with your advanced survival instincts you’ve adopted the natural habits of a specific beast.You gain access to the Resilient combat trait and the Feral Heart story feat.
    //26–70	Raised by Civilized Humanoids   You were raised by a community of civilized humanoids of a race different from your own (chosen by your GM). Your attitudes, beliefs, and values reflect that race, although characteristics of your true nature frequently emerge.You gain access to a race trait from the race that raised you.
    //71–95	Raised by Savage Humanoids  You were raised by savage humanoids such as orcs, kobolds, gnolls, troglodytes, or lizardfolk.As a result, your values, customs, and traditions are those of your adoptive parents, though characteristics of your true nature frequently emerge.You gain access to the Savage social trait.
    //96–100	Fiend Raised    You were separated from your natural parents and raised by a fiend who taught you the cruelty and malice of the gods and worked to fashion you into its own mortal instrument to corrupt innocent souls. You gain access to the Fiend Blood bloodline race trait and the Damned story feat.
    /// <summary>
    /// Adopted Outside Your Race
    /// </summary>
    public static RandomTable AdoptedOutsideYourRaceTable { get; } = new()
    {
        Name = "Adopted Outside Your Race Table",
        DiceSides = 100,
        Table =
        [
            #region "Adopted by Dragons"
            //01–05	Adopted by Dragons For its own purposes, a dragon raised you as its own.You have learned the language and history, wisdom, power, and might of dragonkind. You gain access to the Blood of Dragons bloodline race trait and the Magical Knack magic trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 05,
                Name = nameof(AdoptedOutsideYourRaceEnum.AdoptedbyDragons),
                ProperName = "Adopted by Dragons",
                Description =
                    "For its own purposes, a dragon " +
                    "raised you as its own.You have " +
                    "learned the language and history, " +
                    "wisdom, power, and might of " +
                    "dragonkind. You gain access to " +
                    "the Blood of Dragons bloodline " +
                    "race trait and the Magical Knack " +
                    "magic trait.",
                Traits =
                {
                    TraitEnum.BloodofDragons,
                    TraitEnum.MagicalKnack,
                },
            },
            #endregion

            #region "Adopted by the Fey"
            //06–10	Adopted by the Fey  Your adoptive parents were fey creatures such as korreds, pixies, or a dryad.You gain access to the Charming social trait and the Magical Knack magic trait.
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 10,
                Name = nameof(AdoptedOutsideYourRaceEnum.AdoptedbytheFey),
                ProperName = "Adopted by the Fey",
                Description =
                    "Your adoptive parents were fey " +
                    "creatures such as korreds, " +
                    "pixies, or a dryad. You gain " +
                    "access to the Charming social " +
                    "trait and the Magical Knack " +
                    "magic trait.",
                Traits =
                {
                    TraitEnum.Charming,
                    TraitEnum.MagicalKnack,
                },
            },
            #endregion

            #region "Raised Among the Dead"
            //11–13	Raised Among the Dead Your adoptive parent is a nonliving creature, such as a spectre, ghost, lich, or vampire. You were likely raised in empty ruined halls, among tombs and crypts, by a creature that feeds on life.What its purpose was for raising you, none can say.You gain access to the Deathtouched bloodline race trait, the Magical Knack magic trait, and the Glimpse Beyond story feat.
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 13,
                Name = nameof(AdoptedOutsideYourRaceEnum.RaisedAmongtheDead),
                ProperName = "Raised Among the Dead",
                Description =
                    "Your adoptive parent is a " +
                    "nonliving creature, such as a " +
                    "spectre, ghost, lich, or vampire. " +
                    "You were likely raised in empty " +
                    "ruined halls, among tombs and " +
                    "crypts, by a creature that feeds " +
                    "on life. What its purpose was for " +
                    "raising you, none can say. You " +
                    "gain access to the Deathtouched " +
                    "bloodline race trait, the " +
                    "Magical Knack magic trait, and " +
                    "the Glimpse Beyond story feat.",
                Traits =
                {
                    TraitEnum.Deathtouched,
                    TraitEnum.MagicalKnack,
                    //TraitEnum.GlimpseBeyond,
                },
            },
            #endregion

            #region "Raised by Angels"
            //14–19	Raised by Angels Angels attended your birth and took you to live with them in the heavens. These cosmic beings expanded your view to encompass not just the world but the larger universe. You know that wherever you go, your angelic parents watch over you. You gain access to the Blessed faith trait.
            new RandomTableEntry
            {
                LowerRange = 14,
                UpperRange = 19,
                Name = nameof(AdoptedOutsideYourRaceEnum.RaisedbyAngels),
                ProperName = "Raised by Angels",
                Description =
                    "Angels attended your birth and " +
                    "took you to live with them in " +
                    "the heavens. These cosmic beings " +
                    "expanded your view to encompass " +
                    "not just the world but the " +
                    "larger universe. You know that " +
                    "wherever you go, your angelic " +
                    "parents watch over you. You gain " +
                    "access to the Blessed faith trait.",
                Traits =
                {
                    TraitEnum.Blessed,
                },
            },
            #endregion

            #region "Raised by Beasts"
            //20–25	Raised by Beasts When you were separated from your biological parents, you were found and raised by wild beasts. Your ways are the ways of the wild, and along with your advanced survival instincts you’ve adopted the natural habits of a specific beast.You gain access to the Resilient combat trait and the Feral Heart story feat.
            new RandomTableEntry
            {
                LowerRange = 20,
                UpperRange = 25,
                Name = nameof(AdoptedOutsideYourRaceEnum.RaisedbyBeasts),
                ProperName = "Raised by Beasts",
                Description =
                    "When you were separated from your " +
                    "biological parents, you were " +
                    "found and raised by wild beasts. " +
                    "Your ways are the ways of the " +
                    "wild, and along with your advanced " +
                    "survival instincts you’ve " +
                    "adopted the natural habits of a " +
                    "specific beast. You gain access " +
                    "to the Resilient combat trait " +
                    "and the Feral Heart story feat.",
                Traits =
                {
                    TraitEnum.Resilient,
                    //TraitEnum.FeralHeart,
                },
            },
            #endregion

            #region "Raised by Civilized Humanoids"
            //26–70	Raised by Civilized Humanoids You were raised by a community of civilized humanoids of a race different from your own (chosen by your GM). Your attitudes, beliefs, and values reflect that race, although characteristics of your true nature frequently emerge.You gain access to a race trait from the race that raised you.
            new RandomTableEntry
            {
                LowerRange = 26,
                UpperRange = 70,
                Name = nameof(AdoptedOutsideYourRaceEnum.RaisedbyCivilizedHumanoids),
                ProperName = "Raised by Civilized Humanoids",
                Description =
                    "You were raised by a community " +
                    "of civilized humanoids of a race " +
                    "different from your own. Your " +
                    "attitudes, beliefs, and values " +
                    "reflect that race, although " +
                    "characteristics of your true " +
                    "nature frequently emerge. You " +
                    "gain access to a race trait " +
                    "from the race that raised you.",
            },
            #endregion

            #region "Raised by Savage Humanoids"
            //71–95	Raised by Savage Humanoids You were raised by savage humanoids such as orcs, kobolds, gnolls, troglodytes, or lizardfolk.As a result, your values, customs, and traditions are those of your adoptive parents, though characteristics of your true nature frequently emerge.You gain access to the Savage social trait.
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 95,
                Name = nameof(AdoptedOutsideYourRaceEnum.RaisedbySavageHumanoids),
                ProperName = "Raised by Savage Humanoids",
                Description =
                    "You were raised by savage " +
                    "humanoids such as orcs, kobolds, " +
                    "gnolls, troglodytes, or lizardfolk. " +
                    "As a result, your values, " +
                    "customs, and traditions are " +
                    "those of your adoptive parents, " +
                    "though characteristics of your " +
                    "true nature frequently emerge. " +
                    "You gain access to the Savage " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.Savage,
                },
            },
            #endregion

            #region "Fiend Raised"
            //96–100 Fiend Raised You were separated from your natural parents and raised by a fiend who taught you the cruelty and malice of the gods and worked to fashion you into its own mortal instrument to corrupt innocent souls. You gain access to the Fiend Blood bloodline race trait and the Damned story feat.
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
                Name = nameof(AdoptedOutsideYourRaceEnum.FiendRaised),
                Description =
                    "You were separated from your " +
                    "natural parents and raised by " +
                    "a fiend who taught you the " +
                    "cruelty and malice of the gods " +
                    "and worked to fashion you into " +
                    "its own mortal instrument to " +
                    "corrupt innocent souls. You " +
                    "gain access to the Fiend Blood " +
                    "bloodline race trait and the " +
                    "Damned story feat.",
                Traits =
                {
                    TraitEnum.FiendBlood,
                    //T/raitEnum.Damned,
                },
            },
            #endregion
        ]
    };
}
