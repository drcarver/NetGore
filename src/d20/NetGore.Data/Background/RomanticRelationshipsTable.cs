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

using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Data.Background;

/// <summary>
/// Roll on Table: Romantic Relationships to determine 
/// the kinds of romantic relationships you have had 
/// in the past. You might have a background that 
/// requires you to roll a d12 on this table instead 
/// of a d20.
/// </summary>
public class RomanticRelationshipsTable : RandomTable, IRomanticRelationshipsTable
{
    //Table: Romantic Relationships
    //d20 Result
    //1–2	One Significant Relationship You had a true love once, but that time has passed.
    //3–6	a Few Significant Relationships You’ve tried to make deep connections with individuals on several occasions, but it’s never worked out.
    //7–9	Several Significant Relationships You’ve engaged in a number of partnerships, but for some reason or another your relationships always fail.
    //10–12	Current Lover   You are currently involved in a romantic relationship.You gain access to the True Love story feat.
    //13–16	Several Inconsequential Relationships You have had many lovers but no long-lasting, meaningful relationships.
    //17–18	Experience but No Substantial Relationships You’ve had a fling or two, but have so far shied away from any ties or commitments.
    //19–20	No Experience   You have never experienced any kind of romantic connection whatsoever.
    /// <summary>
    /// Romantic Relationships
    /// </summary>
    [SetsRequiredMembers]
    public RomanticRelationshipsTable()
    {
        Name = nameof(RomanticRelationshipsTable);
        ProperName = "Romantic Relationships Table";
        TableType = TableTypeEnum.GameTable;
        Description = "Roll on Table: Romantic Relationships to determine the kinds of romantic relationships you have had in the past. You might have a background that requires you to roll a d12 on this table instead of a d20.";
        DiceSides = 20;
        Table =
        [
            #region "One Significant Relationship"
            //1–2	One Significant Relationship You had a true love once, but that time has passed.
            new RandomTableEntry
            {
                Range = new Range(01,02),
                Name = nameof(RomanticRelationshipsEnum.OneSignificantRelationship),
                ProperName = "One Significant Relationship",
                Description =
                    "You had a true love once, but " +
                    "that time has passed.",
            },
            #endregion

            #region "A Few Significant Relationships"
            //3–6	A Few Significant Relationships You’ve tried to make deep connections with individuals on several occasions, but it’s never worked out.
            new RandomTableEntry
            {
                Range = new Range(03,06),
                Name = nameof(RomanticRelationshipsEnum.AFewSignificantRelationships),
                ProperName = "A Few Significant Relationships",
                Description =
                    "You’ve tried to make deep " +
                    "connections with individuals on " +
                    "several occasions, but it’s " +
                    "never worked out.",
            },
            #endregion

            #region "Several Significant Relationships"
            //7–9	Several Significant Relationships You’ve engaged in a number of partnerships, but for some reason or another your relationships always fail.
            new RandomTableEntry
            {
                Range = new Range(07,09),
                Name = nameof(RomanticRelationshipsEnum.SeveralSignificantRelationships),
                ProperName = "Several Significant Relationships",
                Description =
                    "You’ve engaged in a number of " +
                    "partnerships, but for some " +
                    "reason or another your " +
                    "relationships always fail.",
            },
            #endregion

            #region "Current Lover"
            //10–12	Current Lover You are currently involved in a romantic relationship.You gain access to the True Love story feat.
            new RandomTableEntry
            {
                Range = new Range(10,12),
                Name = nameof(RomanticRelationshipsEnum.CurrentLover),
                ProperName = "Current Lover",
                Description =
                    "You are currently involved in a " +
                    "romantic relationship. You gain " +
                    "access to the True Love story feat.",
            },
            #endregion

            #region "Several Inconsequential Relationships"
            //13–16	Several Inconsequential Relationships You have had many lovers but no long-lasting, meaningful relationships.
            new RandomTableEntry
            {
                Range = new Range(13,16),
                Name = nameof(RomanticRelationshipsEnum.SeveralInconsequentialRelationships),
                ProperName = "Several Inconsequential Relationships",
                Description =
                    "You have had many lovers but no " +
                    "long-lasting, meaningful relationships.",
            },
            #endregion

            #region "Experience but No Substantial Relationships"
            //17–18	Experience but No Substantial Relationships You’ve had a fling or two, but have so far shied away from any ties or commitments.
            new RandomTableEntry
            {
                Range = new Range(17,18),
                Name = nameof(RomanticRelationshipsEnum.ExperiencebutNoSubstantialRelationships),
                ProperName = "Experience but No Substantial Relationships",
                Description =
                    "You’ve had a fling or two, but " +
                    "have so far shied away from any " +
                    "ties or commitments.",
            },
            #endregion

            #region "No Experience"
            //19–20	No Experience You have never experienced any kind of romantic connection whatsoever.
            new RandomTableEntry
            {
                Range = new Range(19,20),
                Name = nameof(RomanticRelationshipsEnum.NoExperience),
                ProperName = "No Experience",
                Description =
                    "You have never experienced any " +
                    "kind of romantic connection " +
                    "whatsoever.",
            },
            #endregion
        ];
    }
}

