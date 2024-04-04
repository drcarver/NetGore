using Microsoft.Extensions.Logging;

using NetGore.Core;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Classes;
using NetGore.Data.Models;

namespace NetGore.Data.Services;

public class ClassService : IClassService
{
    /// <summary>
    /// The logger for this class
    /// </summary>
    private ILogger Logger { get; set; }

    /// <summary>
    /// The class table
    /// </summary>
    private static GameTable ClassTable { get; set; } = new()
    {
        DiceSides = 120,
        Table =
        [
            #region Barbarian
            new GameTableEntry
            {
                Range = new Range(01,10),
                Name = nameof(Barbarian),
            },
            #endregion

            #region Bard
            new GameTableEntry
            {
                Range = new Range(11,20),
                Name = nameof(Bard),
            },
            #endregion

            #region Cleric
            new GameTableEntry
            {
                Range = new Range(21,30),
                Name = nameof(Cleric),
            },
            #endregion

            #region Druid
            new GameTableEntry
            {
                Range = new Range(31,40),
                Name = nameof(Druid),
            },
            #endregion
                        
            #region Fighter
            new GameTableEntry
            {
                Range = new Range(41,50),
                Name = "Fighter",
            },
            #endregion

            #region Monk
            new GameTableEntry
            {
                Range = new Range(51,60),
                Name = nameof(Monk),
            },
            #endregion

            #region Paladin
            new GameTableEntry
            {
                Range = new Range(61,70),
                Name = nameof(Paladin),
            },
            #endregion

            #region Ranger
            new GameTableEntry
            {
                Range = new Range(71,80),
                Name = nameof(Ranger),
            },
            #endregion

            #region Rogue
            new GameTableEntry
            {
                Range = new Range(81,90),
                Name = "Rogue",
            },
            #endregion

            #region Sorcerer
            new GameTableEntry
            {
                Range = new Range(91,100),
                Name = nameof(Sorcerer),
            },
            #endregion

            #region Warlock
            new GameTableEntry
            {
                Range = new Range(101,110),
                Name = nameof(Warlock),
            },
            #endregion

            #region Wizard
            new GameTableEntry
            {
                Range = new Range(111,120),
                Name = nameof(Wizard),
            },
            #endregion
        ],
    };

    /// <summary>
    /// Set the class for the creature
    /// </summary>
    /// <param name="character">The character class</param>
    public void SetClass(Character character)
    {
        var tableentry = ClassTable.GetRandomEntry();
        Logger.LogInformation($"Got random table entry Name={tableentry?.Name}");

        // Set the class on the creature
        switch (tableentry?.Name)
        {
            case nameof(Barbarian):
                character.CharacterClass = new Barbarian();
                character.Wealth = new Dice("3d6").Total * 10;
                break;
            case nameof(Bard):
                character.CharacterClass = new Bard();
                character.Wealth = new Dice("3d6").Total * 10;
                break;
            case nameof(Cleric):
                character.CharacterClass = new Cleric();
                character.Wealth = new Dice("4d6").Total * 10;
                break;
            case nameof(Druid):
                character.CharacterClass = new Druid();
                character.Wealth = new Dice("2d6").Total * 10;
                break;
            case nameof(Fighter):
                character.CharacterClass = new Fighter();
                character.Wealth = new Dice("5d6").Total * 10;
                break;
            case nameof(Monk):
                character.CharacterClass = new Monk();
                character.Wealth = new Dice("1d6").Total * 10;
                break;
            case nameof(Paladin):
                character.CharacterClass = new Paladin();
                character.Wealth = new Dice("5d6").Total * 10;
                break;
            case nameof(Ranger):
                character.CharacterClass = new Ranger();
                character.Wealth = new Dice("5d6").Total * 10;
                break;
            case nameof(Rogue):
                character.CharacterClass = new Rogue();
                character.Wealth = new Dice("4d6").Total * 10;
                break;
            case nameof(Sorcerer):
                character.CharacterClass = new Rogue();
                character.Wealth = new Dice("4d6").Total * 10;
                break;
            case nameof(Warlock):
                character.CharacterClass = new Warlock();
                character.Wealth = new Dice("2d6").Total * 10;
                break;
            case nameof(Wizard):
                character.CharacterClass = new Wizard();
                character.Wealth = new Dice("2d6").Total * 10;
                break;
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The loggger factory</param>
    public ClassService(ILoggerFactory loggerFactory)
    {
        Logger = loggerFactory.CreateLogger<ClassService>();
    }
}
