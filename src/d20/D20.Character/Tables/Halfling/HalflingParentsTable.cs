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

using D20.Character.Enum;
using D20.Character.Models;
using D20.Core.Models;

namespace D20.Character.Tables.Halfling;

public class HalflingParentsTable : RandomTable, IHalflingParentsTable
{
    //Table: Halfling Parents
    //d%	Result
    //01–70	Both parents living.
    //71–80	Only your father is alive.
    //81–90	Only your mother is alive.
    //91–100	Both of your parents are dead.You gain access to the Orphaned social trait
    /// <summary>
    /// The parents table
    /// </summary>
    [SetsRequiredMembers]
    public HalflingParentsTable()
    {
        DiceSides = 100;
        Table =
        [
            #region "Both"
            //01–70	Both of your parents are alive.
            new BackgroundTableEntry
            {
                Range = new Range(01,70),
                Name = nameof(ParentsEnum.BothAlive),
                ProperName = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //71–80	Only your father is alive.
            new BackgroundTableEntry
            {
                Range = new Range(71,80),
                Name = nameof(ParentsEnum.FatherOnly),
                ProperName = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //81–90	Only your mother is alive.
            new BackgroundTableEntry
            {
                Range = new Range(81,90),
                Name = nameof(ParentsEnum.MotherOnly),
                ProperName = "Mother Only",
                Description = "Only your mother is alive.",
            },
            #endregion

            #region "Both Dead"
            //91–100 Both of your parents are dead.
            //You gain access to the Orphaned social
            //trait.
            new BackgroundTableEntry
            {
                Range = new Range(91,100),
                Name = nameof(ParentsEnum.BothDead),
                ProperName = "Both Dead",
                Description =
                    "Both of your parents are dead. " +
                    "You gain access to the Orphaned " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.Orphaned,
                },
            },
            #endregion
        ];
    }
}
