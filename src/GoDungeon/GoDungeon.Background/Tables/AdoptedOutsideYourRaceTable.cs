#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.GoDungeonpfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
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

using System;
using System.Collections.ObjectModel;

using GoDungeon.Background.Enum;
using GoDungeon.Background.Interfaces;
using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Background.Tables
{
    /// <summary>
    /// If you made a roll that determined your character 
    /// was adopted outside your race, roll on 
    /// Table: Adopted Outside Your Race to determine 
    /// the type of creature that raised you.
    /// </summary>
    public class AdoptedOutsideYourRaceTable : RandomTable, IAdoptedOutsideYourRaceTable
    {
        /// <summary>
        /// Adopted Outside Your Race
        /// </summary>
        public AdoptedOutsideYourRaceTable()
        {
            Name = nameof(AdoptedOutsideYourRaceTable);
            ProperName = "Adopted Outside Your Race Table";
            TableType = TableTypeEnum.BackgroundTable;
            Description = "If you made a roll that determined your character was adopted outside your race, roll on Table: Adopted Outside Your Race to determine the type of creature that raised you.";
            DiceSides = 100;
        }

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
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region Adopted by Dragons
                    //01–05	Adopted by Dragons For its own purposes, a dragon raised you as its own.You have learned the language and history, wisdom, power, and might of dragonkind. You gain access to the Blood of Dragons bloodline race trait and the Magical Knack magic trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01, 05),
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
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.BloodofDragons,
                            TraitEnum.MagicalKnack,
                        },
                    },
                    #endregion

                    #region Adopted by the Fey
                    //06–10	Adopted by the Fey  Your adoptive parents were fey creatures such as korreds, pixies, or a dryad.You gain access to the Charming social trait and the Magical Knack magic trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(06, 10),
                        Name = nameof(AdoptedOutsideYourRaceEnum.AdoptedbytheFey),
                        ProperName = "Adopted by the Fey",
                        Description =
                            "Your adoptive parents were fey " +
                            "creatures such as korreds, " +
                            "pixies, or a dryad. You gain " +
                            "access to the Charming social " +
                            "trait and the Magical Knack " +
                            "magic trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Charming,
                            TraitEnum.MagicalKnack,
                        },
                    },
                    #endregion

                    #region Raised Among the Dead
                    //11–13	Raised Among the Dead Your adoptive parent is a nonliving creature, such as a spectre, ghost, lich, or vampire. You were likely raised in empty ruined halls, among tombs and crypts, by a creature that feeds on life.What its purpose was for raising you, none can say.You gain access to the Deathtouched bloodline race trait, the Magical Knack magic trait, and the Glimpse Beyond story feat.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(11, 13),
                        Name = nameof(AdoptedOutsideYourRaceEnum.RaisedAmongtheDead),
                        ProperName = "Raised Among the Dead",
                        Description =
                            "Your adoptive parent is a " +
                            "nonliving creature, such as a " +
                            "specter, ghost, lich, or vampire. " +
                            "You were likely raised in empty " +
                            "ruined halls, among tombs and " +
                            "crypts, by a creature that feeds " +
                            "on life. What its purpose was for " +
                            "raising you, none can say. You " +
                            "gain access to the Deathtouched " +
                            "bloodline race trait, the " +
                            "Magical Knack magic trait, and " +
                            "the Glimpse Beyond story feat.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Deathtouched,
                            TraitEnum.MagicalKnack,
                            TraitEnum.GlimpseBeyond,
                        },
                    },
                    #endregion

                    #region Raised by Angels
                    //14–19	Raised by Angels Angels attended your birth and took you to live with them in the heavens. These cosmic beings expanded your view to encompass not just the world but the larger universe. You know that wherever you go, your angelic parents watch over you. You gain access to the Blessed faith trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(14, 19),
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
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Blessed,
                        },
                    },
                    #endregion

                    #region Raised by Beasts
                    //20–25	Raised by Beasts When you were separated from your biological parents, you were found and raised by wild beasts. Your ways are the ways of the wild, and along with your advanced survival instincts you’ve adopted the natural habits of a specific beast.You gain access to the Resilient combat trait and the Feral Heart story feat.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(20, 25),
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
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Resilient,
                            TraitEnum.FeralHeart,
                        },
                    },
                    #endregion

                    #region Raised by Civilized Humanoids
                    //26–70	Raised by Civilized Humanoids You were raised by a community of civilized humanoids of a race different from your own (chosen by your GM). Your attitudes, beliefs, and values reflect that race, although characteristics of your true nature frequently emerge.You gain access to a race trait from the race that raised you.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(26, 70),
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

                    #region Raised by Savage Humanoids
                    //71–95	Raised by Savage Humanoids You were raised by savage humanoids such as orcs, kobolds, gnolls, troglodytes, or lizardfolk.As a result, your values, customs, and traditions are those of your adoptive parents, though characteristics of your true nature frequently emerge.You gain access to the Savage social trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(71, 95),
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
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Savage,
                        },
                    },
                    #endregion

                    #region "Fiend Raised"
                    //96–100 Fiend Raised You were separated from your natural parents and raised by a fiend who taught you the cruelty and malice of the gods and worked to fashion you into its own mortal instrument to corrupt innocent souls. You gain access to the Fiend Blood bloodline race trait and the Damned story feat.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(96, 100),
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
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.FiendBlood,
                            TraitEnum.Damned,
                        },
                    },
                    #endregion
                };
            }
        }
    }
}
