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
using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Character.Tables.Halfling;

/// <summary>
/// The homeland table
/// </summary>
public class HalflingHomelandTable : RandomTable, IHalflingHomelandTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public HalflingHomelandTable()
    {
        DiceSides = 100;
        Name = nameof(HalflingHomelandTable);
        ProperName = "Halfling Homeland Table";
        TableType = TableTypeEnum.RaceTable;
    }

    //Table: Halfling Homeland
    //d%	Result
    //01–50	Halfling Settlement You gain access to the Civilized social trait and the Well-Informed race trait.
    //51–80	Human Settlement    You gain access to the Child of the Streets social trait and the Well-Informed race trait.
    //81–95	Traveling Band or Caravan   You gain access to the Friend in Every Town social trait.
    //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
    /// <summary>
    /// Initialize the game table.  This is a separate method so 
    /// we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region "Halfling Settlement"
            //01–50	Halfling Settlement You gain access to the Civilized social trait and the Well-Informed race trait.
            new BackgroundTableEntry
            {
                Range = new Range(01,50),
                Name = nameof(HalflingHomelandEnum.HalflingSettlement),
                ProperName = "Halfling Settlement",
                Description =
                    "You gain access to the Civilized " +
                    "social trait and the Well-Informed " +
                    "race trait.",
                Traits =
                {
                    TraitEnum.Civilized,
                    TraitEnum.WellInformed,
                },
            },
            #endregion

            #region "Human Settlement"
            //51–80	Human Settlement You gain access to the Child of the Streets social trait and the Well-Informed race trait.
            new BackgroundTableEntry
            {
                Range = new Range(51,80),
                Name = nameof(HalflingHomelandEnum.HumanHomeland),
                ProperName = "Human Settlement",
                Description =
                    "You gain access to the Child of the Streets social trait and the Well-Informed race trait.",
                Traits =
                {
                    TraitEnum.ChildoftheStreets,
                    TraitEnum.WellInformed,
                },
            },
            #endregion

            #region "Traveling Band or Caravan"
            //81–95	Traveling Band or Caravan You gain
            //access to the Friend in Every Town social
            //trait.
            new BackgroundTableEntry
            {
                Range = new Range(81,95),
                Name = nameof(HalflingHomelandEnum.TravelingBandorCaravan),
                ProperName = "Traveling Band or Caravan",
                Description =
                    "You gain access to the Friend in Every Town social trait.",
                Traits =
                {
                    TraitEnum.FriendinEveryTown,
                },
            },
            #endregion
                        
            #region "Unusual Homeland."
            //96–100 Unusual Homeland.	Roll on Table:
            //Unusual Homeland.
            new BackgroundTableEntry
            {
                Range = new Range(96,100),
                Name = nameof(HalflingHomelandEnum.UnusualHomeland),
                ProperName = "Unusual Homeland",
                AlternateTable = typeof(UnusualHomelandTable),
            },
            #endregion
        ];
    }
}
