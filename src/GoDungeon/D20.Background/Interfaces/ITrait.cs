using System;
using System.Collections.Generic;

using D20.Background.Enum;
using D20.Background.Models;
using D20.Core.Enum;

namespace D20.Background.Interfaces
{
    public interface ITrait
    {
        /// <summary>
        /// Effect of the trait
        /// </summary>
        List<SavingThrowPenalty>? Effect { get; set; }

        /// <summary>
        /// The proper name of the trait with spaces and
        /// punctuation
        /// </summary>
        string? ProperName { get; set; }

        /// <summary>
        /// The URL of the page with the full trait information
        /// </summary>
        Uri? URL { get; set; }

        /// <summary>
        /// The character class you have to be to have the trait 
        /// or any if non required
        /// </summary>
        ClassEnum CharacterClass { get; set; }

        /// <summary>
        /// The race required for the trait or any if non
        /// required
        /// </summary>
        RaceEnum Race { get; set; }

        /// <summary>
        /// The type of trait
        /// </summary>
        TraitTypeEnum TraitType { get; set; }

        /// <summary>
        /// The category of the trait
        /// </summary>
        TraitCategoryEnum Category { get; set; }

        /// <summary>
        /// The terrain where the trait is active
        /// </summary>
        TerrainEnum Terrain { get; set; }
    }
}