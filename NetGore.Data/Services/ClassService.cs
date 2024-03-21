using Microsoft.Extensions.Logging;

using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Classes;
using NetGore.Data.Race;

namespace NetGore.Data.Services;

public class ClassService
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
                Name = "Barbarian",
                Description = "Barbarians excel in " +
                    "combat, possessing the martial " +
                    "prowess and fortitude to take " +
                    "on foes seemingly far superior " +
                    "to themselves. With rage granting " +
                    "them boldness and daring beyond " +
                    "that of most other warriors, " +
                    "barbarians charge furiously into " +
                    "battle and ruin all who would " +
                    "stand in their way.",
            },
            #endregion

            #region Bard
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 20,
                Name = "Bard",
                Description = "Bards capably confuse " +
                    "and confound their foes while " +
                    "inspiring their allies to " +
                    "ever-greater daring. While " +
                    "accomplished with both weapons " +
                    "and magic, the true strength of " +
                    "bards lies outside melee, where " +
                    "they can support their companions " +
                    "and undermine their foes without " +
                    "fear of interruptions to their " +
                    "performances.",
            },
            #endregion

            #region Cleric
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 30,
                Name = "Cleric",
                Description = "More than capable of " +
                    "upholding the honor of their " +
                    "deities in battle, clerics often " +
                    "prove stalwart and capable " +
                    "combatants. Their true strength " +
                    "lies in their capability to draw " +
                    "upon the power of their deities, " +
                    "whether to increase their own and " +
                    "their allies’ prowess in battle, " +
                    "to vex their foes with divine " +
                    "magic, or to lend healing to " +
                    "companions in need. As their " +
                    "powers are influenced by their " +
                    "faith, all clerics must focus " +
                    "their worship upon a divine source. " +
                    "While the vast majority of clerics " +
                    "revere a specific deity, a small " +
                    "number dedicate themselves to a " +
                    "divine concept worthy of devotion—such " +
                    "as battle, death, justice, or " +
                    "knowledge—free of a deific abstraction. ",
            },
            #endregion

            #region Druid
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 40,
                Name = "Druid",
                Description = "While some druids might " +
                    "keep to the fringe of battle, " +
                    "allowing companions and summoned " +
                    "creatures to fight while they " +
                    "confound foes with the powers of " +
                    "nature, others transform into " +
                    "deadly beasts and savagely wade " +
                    "into combat. Druids worship " +
                    "personifications of elemental " +
                    "forces, natural powers, or nature " +
                    "itself. Typically this means " +
                    "devotion to a nature deity, though " +
                    "druids are just as likely to revere " +
                    "vague spirits, animalistic demigods, " +
                    "or even specific awe-inspiring natural " +
                    "wonders.",
            },
            #endregion
                        
            #region Fighter
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 50,
                Name = "Fighter",
                Description = "Fighters excel at " +
                    "combat—defeating their enemies, " +
                    "controlling the flow of battle, " +
                    "and surviving such sorties " +
                    "themselves. While their specific " +
                    "weapons and methods grant them a " +
                    "wide variety of tactics, few can " +
                    "match fighters for sheer battle " +
                    "prowess.",
            },
            #endregion

            #region Monk
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 60,
                Name = "Mpnk",
                Description = "Monks excel at " +
                    "overcoming even the most daunting " +
                    "perils, striking where it’s least " +
                    "expected, and taking advantage of " +
                    "enemy vulnerabilities. Fleet of " +
                    "foot and skilled in combat, monks " +
                    "can navigate any battlefield with " +
                    "ease, aiding allies wherever they " +
                    "are needed most.",
            },
            #endregion

            #region Paladin
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 70,
                Name = "Paladin",
                Description = " Paladins serve as " +
                    "beacons for their allies within " +
                    "the chaos of battle. While " + 
                    "deadly opponents of evil, they " +
                    "can also empower goodly souls " +
                    "to aid in their crusades. Their " +
                    "magic and martial skills also " +
                    "make them well suited to defending " +
                    "others and blessing the fallen " +
                    "with the strength to continue " +
                    "fighting.",
            },
            #endregion

            #region Ranger
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 80,
                Name = "Ranger",
                Description = "Ranger are deft skirmishers, " +
                    "either in melee or at range, capable of "
                    "skillfully dancing in and out of " +
                    "battle. Their abilities allow " +
                    "them to deal significant harm " +
                    "to specific types of foes, but " +
                    "their skills are valuable against " +
                    "all manner of enemies.",
            },
            #endregion

            #region Rogue
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 90,
                Name = "Rogue",
                Description = "Rogues excel at moving " +
                    "about unseen and catching foes " +
                    "unaware, and tend to avoid " +
                    "head-to-head combat. Their " +
                    "varied skills and abilities " +
                    "allow them to be highly versatile, " +
                    "with great variations in expertise " +
                    "existing between different rogues. " +
                    "Most, however, excel in overcoming " +
                    "hindrances of all types, from " +
                    "unlocking doors and disarming traps " +
                    "to outwitting magical hazards and " +
                    "conning dull-witted opponents.",
            },
            #endregion

            #region Sorcerer
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 100,
                Name = "Sorcerer",
                Description = "Sorcerers excel at " +
                    "casting a selection of favored " +
                    "spells frequently, making them " +
                    "powerful battle mages. As they " +
                    "become familiar with a specific " +
                    "and ever-widening set of spells, " +
                    "sorcerers often discover new and " +
                    "versatile ways of making use of " +
                    "magics other spellcasters might " +
                    "overlook. Their bloodlines also " +
                    "grant them additional abilities, " +
                    "assuring that no two sorcerers " +
                    "are ever quite alike",
            },
            #endregion

            #region Warlock
            new RandomTableEntry
            {
                LowerRange = 101,
                UpperRange = 110,
                Name = "Warlock",
                Description = "Warlocks cast spells with", +
                    "with their charisma modifier and otherworldly" +
                    "Patrons",
            },
            #endregion

            #region Wizard
            new RandomTableEntry
            {
                LowerRange = 111,
                UpperRange = 120,
                Name = "Wizard",
                Description = "While universalist " +
                    "wizards might study to prepare " +
                    "themselves for any manner of " +
                    "danger, specialist wizards " +
                    "research schools of magic that " +
                    "make them exceptionally skilled " +
                    "within a specific focus. Yet no " +
                    "matter their specialty, all " +
                    "wizards are masters of the " +
                    "impossible and can aid their " +
                    "allies in overcoming any danger.",
            },
            #endregion
        ],
    };

    /// <summary>
    /// Set the class for the creature
    /// </summary>
    /// <param name="creature">The creature class</param>
    public void SetClass(Creature creature)
    {
        var tableentry = ClassTable.GetRandomEntry();

        Logger.LogInformation($"Got random table entry number {RaceTable.Total}, Name={tableentry?.Name}");

        // Set the class on the creature
        switch (tableentry?.Name)
        {
            case "Barbarian":
                _ = new Barbarian(creature, tableentry);
                break;
            case "Bard":
                _ = new Bard(creature, tableentry);
                break;
            case "Cleric":
                _ = new Cleric(creature, tableentry);
                break;
            case "Druid":
                _ = new Druid(creature, tableentry);
                break;
            case "Fighter":
                _ = new Fighter(creature, tableentry);
                break;
            case "Monk":
                _ = new Monk(creature, tableentry);
                break;
            case "Paladin":
                _ = new Paladin(creature, tableentry);
                break;
            case "Ranger":
                _ = new Ranger(creature, tableentry);
                break;
            case "Rogue":
                _ = new Rogue(creature, tableentry);
                break;
            case "Sorcerer":
                _ = new Sorcerer(creature, tableentry);
                break;
            case "Warlock":
                _ = new Warlock(creature, tableentry);
                break;
            case "Wizard":
                _ = new Wizard(creature, tableentry);
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
