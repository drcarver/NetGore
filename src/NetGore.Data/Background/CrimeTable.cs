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
public class CrimeTable : GameTable, ICrimeTable
{
    //Table: Crime
    //d%	Crime
    //01–10	Adultery
    //11–20	Arson
    //21–30	Burglary
    //31–40	Heresy
    //41–50	Minor offense(sumptuary law)
    //51–60	Murder
    //61–70	Rebellion/treason
    //71–80	Robbery
    //81–90	Smuggling
    //91–100	Unlawful use of magic
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public CrimeTable()
    {
        Name = "CrimeTable";
        DiceSides = 100;
        Description = "Crime Table";
        Table =
        [
            #region "Adultery"
            //01–10	Adultery
            new GameTableEntry
            {
                Range = new Range(01, 10),
                Name = nameof(CrimeEnum.Adultery),
            },
            #endregion

            #region "Arson"
            //11–20	Arson
            new GameTableEntry
            {
                Range = new Range(11, 20),
                Name = nameof(CrimeEnum.Arson),
            },
            #endregion

            #region "Burglary"
            //21–30	Burglary
            new GameTableEntry
            {
                Range = new Range(21, 30),
                Name = nameof(CrimeEnum.Burglary),
            },
            #endregion

            #region "Heresy"
            //31–40	Heresy
            new GameTableEntry
            {
                Range = new Range(31, 40),
                Name = nameof(CrimeEnum.Heresy),
            },
            #endregion

            #region "Minor offense(sumptuary law)"
            //41–50	Minor offense(sumptuary law)
            new GameTableEntry
            {
                Range = new Range(41, 50),
                Name = nameof(CrimeEnum.Minoroffense),
                ProperName = "Minor offense (sumptuary law)"
            },
            #endregion

            #region "Murder"
            //51–60	Murder
            new GameTableEntry
            {
                Range = new Range(51, 60),
                Name = nameof(CrimeEnum.Murder),
            },
            #endregion

            #region "Rebellion/treason"
            //61–70	Rebellion/treason
            new GameTableEntry
            {
                Range = new Range(61, 70),
                Name = nameof(CrimeEnum.RebellionorTreason),
                ProperName = "Rebellion or Treason",
            },
            #endregion

            #region "Robbery"
            //71–80	Robbery
            new GameTableEntry
            {
                Range = new Range(71, 80),
                Name = nameof(CrimeEnum.Robbery),
            },
            #endregion

            #region "Smuggling"
            //81–90	Smuggling
            new GameTableEntry
            {
                Range = new Range(81, 90),
                Name = nameof(CrimeEnum.Smuggling),
            },
            #endregion

            #region "Unlawful use of magic"
            //91–100	Unlawful use of magic
            new GameTableEntry
            {
                Range = new Range(91, 100),
                Name = nameof(CrimeEnum.Unlawfuluseofmagic),
                ProperName = "Unlawful use of magic",
            },
            #endregion
        ];
    }
}
