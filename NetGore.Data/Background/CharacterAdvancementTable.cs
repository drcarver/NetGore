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
using NetGore.Core.Models;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Data.Background;

/// <summary>
/// Determine the circumstances of your birth.
/// </summary>
public class CharacterAdvancementTable : CharacterAdvancement, ICharacterAdvancement
{
    //Character Advancement
    //Experience Points Level Proficiency    Bonus
    //0 1 +2
    //300 2 +2
    //900 3 +2
    //2,700 4 +2
    //6,500 5 +3
    //14,000 6 +3
    //23,000 7 +3
    //34,000 8 +3
    //48,000 9 +4
    //64,000 10 +4
    //85,000 11 +4
    //100,000 12 +4
    //120,000 13 +5
    //140,000 14 +5
    //165,000 15 +5
    //195,000 16 +5
    //225,000 17 +6
    //265,000 18 +6
    //305,000 19 +6
    //355,000 20 +6
    /// <summary>
    /// Determine the character advancement.
    /// </summary>
    [SetsRequiredMembers]
    public CharacterAdvancementTable()
    {
        Name = nameof(CharacterAdvancementTable);
        Description = "As your character goes on " +
            "adventures and  overcomes challenges, " +
            "they gain experience,  represented by " +
            "experience points. A character who  " +
            "reaches a specified experience point " +
            "total advances  in capability. This " +
            "advancement is called gaining a  level";
        DiceSides = 20;
        Table =
        [
            #region 1st Level
            //0-299 1 +2
            new CharacterAdvancementEntry
            {
                ExperiencePoints = new Range(0, 299),
                ProficiencyBonus = 1,
                Level = 1,
            },
            #endregion

            #region 2nd Level
            //300-899 2 +2
            new CharacterAdvancementEntry
            {
                ExperiencePoints = new Range(300, 899),
                ProficiencyBonus = 2,
                Level = 2,
            },
            #endregion

            #region 3rd Level
            //900-2699 3 +2
            new CharacterAdvancementEntry
            {
                ExperiencePoints = new Range(900, 2699),
                ProficiencyBonus = 2,
                Level = 3,
            },
            #endregion
        ];
    }
}
