using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;
using D20.Goods.Enum;
using D20.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace D20.Character.Models;

public class D20Character : Creature, ICharacter
{
    /// <summary>
    /// The character class
    /// </summary>
    public ICharacterClass? CharacterClass { get; protected set; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    public List<EquipmentEnum> ArmorProficiency { get; } = [];

    /// <summary>
    /// THe weapon Proficiency for this class
    /// </summary>
    public List<EquipmentEnum> WeaponProficiency { get; } = [];

    /// <summary>
    /// Tools for the creation of the character
    /// </summary>
    public List<EquipmentEnum> ToolProficiency { get; } = [];

    /// <summary>
    /// The inventory for the creature
    /// </summary>
    public List<EquipmentEnum> Equipment { get; } = [];

    /// <summary>
    /// Saving Throws
    /// </summary>
    public List<AbilityEnum> SavingThrows { get; } = [];

    /// <summary>
    /// The inventory for the creature
    /// </summary>
    public Dictionary<IInventoryEntry, InventoryEntry> Inventory { get; } = [];

    /// <summary>
    /// The character level
    /// </summary>
    public int Level { get; protected set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The factory for logging messages</param>
    [SetsRequiredMembers]
    public D20Character(ILoggerFactory loggerFactory)
        : base()
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public D20Character()
        : base()
    {
    }
}
