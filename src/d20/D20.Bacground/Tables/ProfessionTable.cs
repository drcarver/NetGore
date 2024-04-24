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
using System.Security.Cryptography;

using D20.Background.Enum;
using D20.Background.Interfaces;
using D20.Background.Models;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Background.Tables;

/// <summary>
/// Most of the time, your parents both come from 
/// the same social stratum. It’s uncommon, but 
/// not unheard of, for people to marry outside 
/// their caste. Roll on Table: Profession 
/// to determine the principal profession of your 
/// parents.
/// </summary>
public class ProfessionTable : RandomTable, IProfessionTable
{
    /// <summary>
    /// Profession Table
    /// </summary>
    [SetsRequiredMembers]
    public ProfessionTable()
    {
        Name = nameof(ProfessionTable);
        ProperName = "Profession Table";
        TableType = TableTypeEnum.BackgroundTable;
        Description = "Most of the time, your parents both come from the same social stratum. It’s uncommon, but not unheard of, for people to marry outside their caste. Roll on Table: Profession to determine the principal profession of your parents.";
        DiceSides = 100;
    }
    /// <summary>
    /// Override GetRandomRangeEntry to allow for us to get 
    /// slave/serfs/peasants separately from everyone else
    /// </summary>
    /// <param name="dice">The dice to roll</param>
    /// <returns>The profession</returns>
    public override IRandomTableEntry GetRandomRangeEntry(int dice = 0)
    {
        int diceSides = dice > 0 ? dice : 75;
        int starting = dice <= 20 ? 1 : 26;
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            return GetRangeEntryByNumber(RandomNumberGenerator.GetInt32(diceSides) + starting);
        }
    }

    //Table: Profession
    //d%	Result
    //01–05	Slaves You gain access to the Life of Toil social trait.
    //06–25	Serfs/Peasants You gain access to the Poverty-Stricken social trait.
    //26–30	Entertainers You gain access to the Talented social trait.
    //31–34	Soldiers You gain access to the Tactician combat trait.
    //35–37	Sailors You gain access to the Worldly social trait.
    //38–40	Thieves You gain access to the Child of the Streets social trait.
    //41–55	Yeomen You gain access to the Savanna Child regional trait.
    //56–70	Tradespeople You gain access to the Artisan social trait and the Life of Toil social trait.
    //71–85	Artisans You gain access to the Artisan social trait.
    //86–95	Merchants You gain access to the Merchant social trait.
    //96–100	Clergy or Cultists You gain access to the Child of the Temple faith trait.}
    /// <summary>
    /// Initialize the game table.  This is a separate method so 
    /// we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        if (Table.Count == 0)
        {
            Table =
            [
                #region "Slaves"
                //01–05	Slaves You gain access to the Life of Toil social trait.
                new BackgroundTableEntry
                {
                    Range = new Range(01, 05),
                    Name = nameof(ProfessionEnum.Slaves),
                    Description =
                        "You gain access to the Life of Toil social " +
                        "trait.",
                    Traits =
                    {
                        TraitEnum.LifeofToil,
                    },
                },
                #endregion

                #region "Serfs/Peasants"
                //06–25	Serfs/Peasants You gain access to the Poverty-Stricken social trait.
                new BackgroundTableEntry
                {
                    Range = new Range(06, 25),
                    Name = nameof(ProfessionEnum.SerfsPeasants),
                    ProperName = "Serfs/Peasants",
                    Description =
                        "You gain access to the " +
                        "Poverty-Stricken social trait.",
                    Traits =
                    {
                        TraitEnum.PovertyStricken,
                    },
                },
                #endregion

                #region "Entertainers"
                //26–30	Entertainers You gain access to the Talented social trait.
                new BackgroundTableEntry
                {
                    Range = new Range(26, 30),
                    Name = nameof(ProfessionEnum.Entertainers),
                    Description =
                        "You gain access to the Talented social trait.",
                    Traits =
                    {
                        TraitEnum.Talented,
                    },
                },
                #endregion

                #region "Soldiers"
                //31–34	Soldiers You gain access to the Tactician combat trait.
                new BackgroundTableEntry
                {
                    Range = new Range(31, 34),
                    Name = nameof(ProfessionEnum.Soldiers),
                    Description =
                        "You gain access to the Tactician combat trait.",
                    Traits =
                    {
                        TraitEnum.Tactician,
                    },
                },
                #endregion

                #region "Sailors"
                //35–37	Sailors You gain access to the Worldly social trait.
                new BackgroundTableEntry
                {
                    Range = new Range(35, 37),
                    Name = nameof(ProfessionEnum.Sailors),
                    Description =
                        "You gain access to the Worldly social trait.",
                    Traits =
                    {
                        TraitEnum.Worldly,
                    },
                },
                #endregion

                #region "Thieves"
                //38–40	Thieves You gain access to the Child of the Streets social trait.
                new BackgroundTableEntry
                {
                    Range = new Range(38, 40),
                    Name = nameof(ProfessionEnum.Thieves),
                    Description =
                        "You gain access to the Child of " +
                        "the Streets social trait.",
                    Traits =
                    {
                        TraitEnum.ChildoftheStreets,
                    },
                },
                #endregion

                #region "Yeomen"
                //41–55	Yeomen You gain access to the Savanna Child regional trait.
                new BackgroundTableEntry
                {
                    Range = new Range(41, 55),
                    Name = nameof(ProfessionEnum.Yeomen),
                    Description =
                        "You gain access to the " +
                        "Savanna Child regional trait.",
                    Traits =
                    {
                        TraitEnum.SavannahChild
                    },
                },
                #endregion

                #region "Tradespeople"
                //56–70	Tradespeople You gain access to the Artisan social trait and the Life of Toil social trait.
                new BackgroundTableEntry
                {
                    Range = new Range(56, 70),
                    Name = nameof(ProfessionEnum.Tradespeople),
                    Description =
                        "You gain access to the Artisan " +
                        "social trait and the Life of Toil " +
                        "social trait.",
                    Traits =
                    {
                        TraitEnum.Artisan,
                        TraitEnum.LifeofToil,
                    },
                },
                #endregion

                #region "Artisans"
                //71–85	Artisans	You gain access to the Artisan social trait..
                new BackgroundTableEntry
                {
                    Range = new Range(71, 85),
                    Name = nameof(ProfessionEnum.Artisans),
                    Description =
                        "You gain access to the Artisan social trait.",
                    Traits =
                    {
                        TraitEnum.Artisan,
                    },
                },
                #endregion

                #region "Merchants"
                //86–95	Merchants You gain access to the Merchant social trait.
                new BackgroundTableEntry
                {
                    Range = new Range(86, 95),
                    Name = nameof(ProfessionEnum.Merchants),
                    Description =
                        "You gain access to the Merchant social trait.",
                    Traits =
                    {
                        TraitEnum.Merchant,
                    },
                },
                #endregion

                #region "Clergy or Cultists"
                //96–100 Clergy or Cultists You gain access to the Child of the Temple faith trait.
                new BackgroundTableEntry
                {
                    Range = new Range(96, 100),
                    Name = nameof(ProfessionEnum.ClergyorCultists),
                    ProperName = "Clergy or Cultists",
                    Description =
                        "You gain access to the Child of " +
                        "the Temple faith trait.",
                    Traits =
                    {
                        TraitEnum.ChildoftheTemple,
                    },
                },
                #endregion
            ];
        }
    }
}
