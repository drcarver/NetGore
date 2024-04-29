using System;
using System.Collections.ObjectModel;

using GoDungeon.Background.Enum;

using GoDungeon.Background.Interfaces;
using GoDungeon.Core.Enum;

namespace GoDungeon.Background.Interfaces
{
    public interface ITrait
    {
        /// <summary>
        /// Effect of the trait
        /// </summary>
        ReadOnlyObservableCollection<ISavingThrowPenalty>? Effect { get; set; }

        /// <summary>
        /// The proper name of the trait with spaces and
        /// punctuation
        /// </summary>
        string? ProperName { get; set; }

        /// <summary>
        /// The URL of the page with the full trait information
        /// </summary>
        Uri? Url { get; set; }

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