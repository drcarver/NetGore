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
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Background.Enum;
using GoDungeon.Background.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Background.ViewModels
{
    public partial class TraitViewModel : DataObjectViewModel, ITrait
    {
        /// <summary>
        /// Effect of the trait
        /// </summary>
        [ObservableProperty]
        private ReadOnlyObservableCollection<ISavingThrowPenalty>? effect;

        /// <summary>
        /// The proper name of the trait with spaces and
        /// punctuation
        /// </summary>
        [ObservableProperty]
        private string? properName;

        /// <summary>
        /// The URL of the page with the full trait information
        /// </summary>
        [ObservableProperty]
        private Uri? url;

        /// <summary>
        /// The character class you have to be to have the trait 
        /// or any if non required
        /// </summary>
        [ObservableProperty]
        private ClassEnum characterClass = ClassEnum.Any;

        /// <summary>
        /// The race required for the trait or any if non
        /// required
        /// </summary>
        [ObservableProperty]
        private RaceEnum race = RaceEnum.Any;

        /// <summary>
        /// The type of trait
        /// </summary>
        [ObservableProperty]
        private TraitTypeEnum traitType;

        /// <summary>
        /// The category of the trait
        /// </summary>
        [ObservableProperty]
        private TraitCategoryEnum category;

        /// <summary>
        /// The terrain where the trait is active
        /// </summary>
        [ObservableProperty]
        private TerrainEnum terrain = TerrainEnum.Any;
    }
}
