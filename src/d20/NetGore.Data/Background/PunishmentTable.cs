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
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Data.Background;

/// <summary>
/// If you have the Criminal social trait, roll on 
/// Table: Crime to determine the crime for which 
/// you were accused or convicted. After determining 
/// the crime, roll on Table: Punishment to learn 
/// the severity of the punishment you received—or 
/// have yet to receive—for having been judged guilty.
/// </summary>
public class PunishmentTable : GameTable, IPunishmentTable
{
    //Table: Punishment
    //d%	Punishment
    //01–10	Beating
    //11–20	Branding
    //21–30	Exile
    //31–40	Fine
    //41–50	Imprisonment
    //51–60	Stocks
    //61–70	Torture
    //71–80	Trial by combat
    //81–90	Trial by fire
    //91–100	Trial by water
    /// <summary>
    /// Punishment
    /// </summary>
    [SetsRequiredMembers]
    public PunishmentTable()
    {
        Name = nameof(PunishmentTable);
        Description = "Punishment";
        DiceSides = 100;
        Table =
        [
            #region "Beating"
            //01–10	Beating
            new BackgroundTableEntry
            {
                Range = new Range(01,10),
                Name = nameof(PunishmentEnum.Beating),
            },
            #endregion

            #region "Branding"
            //11–20	Branding
            new BackgroundTableEntry
            {
                Range = new Range(11,20),
                Name = nameof(PunishmentEnum.Branding),
            },
            #endregion

            #region "Exile"
            //21–30	Exile
            new BackgroundTableEntry
            {
                Range = new Range(21,30),
                Name = nameof(PunishmentEnum.Exile),
            },
            #endregion

            #region "Fine"
            //31–40	Fine
            new BackgroundTableEntry
            {
                Range = new Range(31,40),
                Name = nameof(PunishmentEnum.Fine),
            },
            #endregion

            #region "Imprisonment"
            //41–50	Imprisonment
            new BackgroundTableEntry
            {
                Range = new Range(41,50),
                Name = nameof(PunishmentEnum.Imprisonment),
            },
            #endregion

            #region "Stocks"
            //51–60	Stocks
            new BackgroundTableEntry
            {
                Range = new Range(51,60),
                Name = nameof(PunishmentEnum.Stocks),
            },
            #endregion

            #region "Torture"
            //61–70	Torture
            new BackgroundTableEntry
            {
                Range = new Range(61,70),
                Name = nameof(PunishmentEnum.Torture),
            },
            #endregion

            #region "Trial by combat"
            //71–80	Trial by combat
            new BackgroundTableEntry
            {
                Range = new Range(71,80),
                Name = nameof(PunishmentEnum.Trialbycombat),
                ProperName = "Trial by combat",
            },
            #endregion

            #region "Trial by fire"
            //81–90	Trial by fire
            new BackgroundTableEntry
            {
                Range = new Range(81,90),
                Name = nameof(PunishmentEnum.Trialbyfire),
                ProperName = "Trial by fire",
            },
            #endregion

            #region "Trial by water"
            //91–100 Trial by water
            new BackgroundTableEntry
            {
                Range = new Range(91,100),
                Name = nameof(PunishmentEnum.Trialbywater),
                ProperName = "Trial by water",
            },
            #endregion
        ];
    }
}

