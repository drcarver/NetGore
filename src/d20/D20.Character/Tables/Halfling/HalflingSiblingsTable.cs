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

public class HalflingSiblingsTable : RandomTable, IHalflingSiblingsTable
{
    //Table: Halfling Siblings
    //d%	Result
    //01–30	1d2 siblings.With two siblings, you gain access to the Kin Guardian combat trait.
    //31–90	1d4+1 siblings.You gain access to the Kin Guardian combat trait.
    //91–100	No siblings.
    /// <summary>
    /// The siblings table
    /// </summary>
    [SetsRequiredMembers]
    public HalflingSiblingsTable()
    {
        DiceSides = 100;
        Table =
        [
            #region "1d2"
            //01–30	1d2 siblings.With two siblings,
            //you gain access to the Kin Guardian
            //combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(01,30),
                Name = "1d2",
                Description = "1d2 siblings. With two siblings, you gain access to the Kin Guardian combat trait.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d4+1"
            //1d4+1 siblings. You gain access to the
            //Kin Guardian combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(31,90),
                Name = "1d4+1",
                Description =
                    "1d4+1 siblings. You gain access to the Kin Guardian combat trait.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "No siblings"
            //91–100	No siblings.
            new BackgroundTableEntry
            {
                Range = new Range(91,100),
                Name = "No siblings",
                Description = "No siblings",
            },
            #endregion
        ];
    }
}
