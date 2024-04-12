using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;
using D20.Goods.Enum;

using Microsoft.Extensions.Logging;

namespace D20.Character.Models;

public class D20Character : Creature, ICharacter
{
    /// <summary>
    /// Get the character class
    /// </summary>
    private IClassService ClassService { get; }

    /// <summary>
    /// The character class
    /// </summary>
    public ICharacterClass? CharacterClass { get; set; }

    /// <summary>
    /// The characters homeland.  Automatically generated
    /// </summary>
    public string? Homeland { get; set; }

    /// <summary>
    /// The character racial traits
    /// </summary>
    public List<TraitEnum> Traits { get; set; } = [];

    /// <summary>
    /// The player character parents
    /// </summary>
    public string? Parents { get; set; }

    /// <summary>
    /// The characters siblings
    /// </summary>
    public List<ICreature> Siblings { get; set; } = [];

    /// <summary>
    /// Hit Dice
    /// </summary>
    public string? HitDice { get; set; }

    /// <summary>
    /// Armor Proficiency
    /// </summary>
    public List<EquipmentCategoryEnum> ArmorProficiency { get; set; }

    /// <summary>
    /// THe weapon Proficiency for this class
    /// </summary>
    public List<WeaponProficiencyEnum> WeaponProficiency { get; set; }

    /// <summary>
    /// Tools for the creation of the character
    /// </summary>
    public List<ToolProficiencyEnum> ToolProficiency { get; set; }

    /// <summary>
    /// The inventory for the creature
    /// </summary>
    public List<EquipmentEnum> Equipment { get; set; }

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
