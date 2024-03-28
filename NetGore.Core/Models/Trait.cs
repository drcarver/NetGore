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

using NetGore.Core.Base;
using NetGore.Core.Enum;

namespace NetGore.Core.Models;

public class Trait : DataObject
{
    public List<SavingThrowPenality> Effect { get; set; }

    /// <summary>
    /// The proper name of the trait with spaces and
    /// punctuation
    /// </summary>
    public string ProperName { get; set; }

    /// <summary>
    /// The URL of the page with the full trait information
    /// </summary>
    public Uri URL { get; set; }

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
    /// THe terrain where the trait is active
    /// </summary>
    public TerrainEnum Terrain { get; set; } = TerrainEnum.Any;

    /// <summary>
    /// The constructor
    /// </summary>
    [SetsRequiredMembers]
    public Trait()
    {
    }
}
