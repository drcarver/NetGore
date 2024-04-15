using D20.Character.Interfaces;
using D20.Character.PC.Barbarian;
using D20.Character.PC.Bard;
using D20.Character.PC.Cleric;
using D20.Core;
using D20.Core.Models;

using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;

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
        Table =
        [
            #region Barbarian
            new GameTableEntry
            {
                Name = nameof(Barbarian),
            },
            #endregion

            #region Bard
            new GameTableEntry
            {
                Name = nameof(Bard),
            },
            #endregion

            //#region Cleric
            //new GameTableEntry
            //{
            //    Name = nameof(Cleric),
            //},
            //#endregion

            //#region Druid
            //new GameTableEntry
            //{
            //    Name = nameof(Druid),
            //},
            //#endregion
                        
            //#region Fighter
            //new GameTableEntry
            //{
            //    Name = "Fighter",
            //},
            //#endregion

            //#region Monk
            //new GameTableEntry
            //{
            //    Name = nameof(Monk),
            //},
            //#endregion

            //#region Paladin
            //new GameTableEntry
            //{
            //    Name = nameof(Paladin),
            //},
            //#endregion

            //#region Ranger
            //new GameTableEntry
            //{
            //    Name = nameof(Ranger),
            //},
            //#endregion

            //#region Rogue
            //new GameTableEntry
            //{
            //    Name = "Rogue",
            //},
            //#endregion

            //#region Sorcerer
            //new GameTableEntry
            //{
            //    Name = nameof(Sorcerer),
            //},
            //#endregion

            //#region Warlock
            //new GameTableEntry
            //{
            //    Name = nameof(Warlock),
            //},
            //#endregion

            //#region Wizard
            //new GameTableEntry
            //{
            //    Name = nameof(Wizard),
            //},
            //#endregion
        ],
    };

    /// <summary>
    /// Set the class for the creature
    /// </summary>
    /// <param name="character">The character class</param>
    public void SetClass(ICharacter character)
    {
        var tableentry = ClassTable.GetRandomEntry();
        Logger.LogInformation($"Got random table entry Name={tableentry?.Name}");

        // Set the class on the creature
        //switch (tableentry?.Name)
        //{
        //    case nameof(Barbarian):
        //        character.CharacterClass = new Barbarian();
        //        character.Wealth = new Dice("3d6").Total * 10;
        //        break;
        //    case nameof(Bard):
        //        character.CharacterClass = new Bard();
        //        character.Wealth = new Dice("3d6").Total * 10;
        //        break;
        //    case nameof(Cleric):
        //        character.CharacterClass = new Cleric();
        //        character.Wealth = new Dice("4d6").Total * 10;
        //        break;
        //    case nameof(Druid):
        //        character.CharacterClass = new Druid();
        //        character.Wealth = new Dice("2d6").Total * 10;
        //        break;
        //    case nameof(Fighter):
        //        character.CharacterClass = new Fighter();
        //        character.Wealth = new Dice("5d6").Total * 10;
        //        break;
        //    case nameof(Monk):
        //        character.CharacterClass = new Monk();
        //        character.Wealth = new Dice("1d6").Total * 10;
        //        break;
        //    case nameof(Paladin):
        //        character.CharacterClass = new Paladin();
        //        character.Wealth = new Dice("5d6").Total * 10;
        //        break;
        //    case nameof(Ranger):
        //        character.CharacterClass = new Ranger();
        //        character.Wealth = new Dice("5d6").Total * 10;
        //        break;
        //    case nameof(Rogue):
        //        character.CharacterClass = new Rogue();
        //        character.Wealth = new Dice("4d6").Total * 10;
        //        break;
        //    case nameof(Sorcerer):
        //        character.CharacterClass = new Rogue();
        //        character.Wealth = new Dice("4d6").Total * 10;
        //        break;
        //    case nameof(Warlock):
        //        character.CharacterClass = new Warlock();
        //        character.Wealth = new Dice("2d6").Total * 10;
        //        break;
        //    case nameof(Wizard):
        //        character.CharacterClass = new Wizard();
        //        character.Wealth = new Dice("2d6").Total * 10;
        //        break;
        //}
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
