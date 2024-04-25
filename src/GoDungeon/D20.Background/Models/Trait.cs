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

using System;
using System.Collections.Generic;

using D20.Background.Enum;
using D20.Background.Interfaces;
using D20.Core.Base;
using D20.Core.Enum;

namespace D20.Background.Models
{
    public class Trait : DataObject, ITrait
    {
        /// <summary>
        /// Effect of the trait
        /// </summary>
        public List<SavingThrowPenalty> Effect { get; } = new List<SavingThrowPenalty>();

        /// <summary>
        /// The proper name of the trait with spaces and
        /// punctuation
        /// </summary>
        public string? ProperName { get; set; }

        /// <summary>
        /// The URL of the page with the full trait information
        /// </summary>
        public Uri? URL { get; set; }

        /// <summary>
        /// The character class you have to be to have the trait 
        /// or any if non required
        /// </summary>
        public ClassEnum CharacterClass { get; set; } = ClassEnum.Any;

        /// <summary>
        /// The race required for the trait or any if non
        /// required
        /// </summary>
        public RaceEnum Race { get; set; } = RaceEnum.Any;

        /// <summary>
        /// The type of trait
        /// </summary>
        public TraitTypeEnum TraitType { get; set; }

        /// <summary>
        /// The category of the trait
        /// </summary>
        public TraitCategoryEnum Category { get; set; }

        /// <summary>
        /// The terrain where the trait is active
        /// </summary>
        public TerrainEnum Terrain { get; set; } = TerrainEnum.Any;
    }
}
