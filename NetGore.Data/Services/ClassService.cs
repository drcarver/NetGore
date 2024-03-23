using Microsoft.Extensions.Logging;

using NetGore.Core;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Classes;

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
    private static RandomTable ClassTable { get; set; } = new()
    {
        DiceSides = 120,
        Table =
        [
            #region Barbarian
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 10,
                Name = nameof(Barbarian),
            },
            #endregion

            #region Bard
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 20,
                Name = nameof(Bard),
            },
            #endregion

            #region Cleric
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 30,
                Name = nameof(Cleric),
            },
            #endregion

            #region Druid
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 40,
                Name = nameof(Druid),
            },
            #endregion
                        
            #region Fighter
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 50,
                Name = "Fighter",
            },
            #endregion

            #region Monk
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 60,
                Name = nameof(Monk),
            },
            #endregion

            #region Paladin
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 70,
                Name = nameof(Paladin),
            },
            #endregion

            #region Ranger
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 80,
                Name = nameof(Ranger),
            },
            #endregion

            #region Rogue
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 90,
                Name = "Rogue",
            },
            #endregion

            #region Sorcerer
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 100,
                Name = nameof(Sorcerer),
            },
            #endregion

            #region Warlock
            new RandomTableEntry
            {
                LowerRange = 101,
                UpperRange = 110,
                Name = nameof(Warlock),
            },
            #endregion

            #region Wizard
            new RandomTableEntry
            {
                LowerRange = 111,
                UpperRange = 120,
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

        Logger.LogInformation($"Got random table entry number {ClassTable.Total}, Name={tableentry?.Name}");

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
