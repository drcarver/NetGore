using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC.Barbarian;

public class Barbarian : CharacterClassBase, ICharacterClass
{
    /// <summary>
    /// The DI service provider
    /// </summary>
    private readonly IServiceProvider serviceProvider;

    /// <summary>
    /// Level up the character with this class
    /// </summary>
    /// <param name="character"></param>
    public override void LevelUp(ICharacter character)
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Barbarian(IServiceProvider services, 
        IBarbarianLevelTable levelTable,
        IBarbarianBackgroundTable backgroundTable)
    {
        serviceProvider = services;
        Name = nameof(Barbarian);
        Description = "Barbarians excel in " +
            "combat, possessing the martial " +
            "prowess and fortitude to take " +
            "on foes seemingly far superior " +
            "to themselves. With rage granting " +
            "them boldness and daring beyond " +
            "that of most other warriors, " +
            "barbarians charge furiously into " +
            "battle and ruin all who would " +
            "stand in their way.";
        HitDice = "1d12";
        ArmorProficiency =
        [
            EquipmentCategoryEnum.LightArmor,
            EquipmentCategoryEnum.MediumArmor,
            EquipmentCategoryEnum.Shields,
        ];
        WeaponProficiency =
        [
            WeaponProficiencyEnum.SimpleWeapons,
            WeaponProficiencyEnum.MartialWeapons,
        ];
        SavingThrows =
        [
            AbilityEnum.Strength,
            AbilityEnum.Constitution
        ];
        Skills =
        [
            SkillEnum.AnimalHandling,
            SkillEnum.Athletics,
            SkillEnum.Intimidation,
            SkillEnum.Nature,
            SkillEnum.Perception,
            SkillEnum.Survival,
        ];

        // Generate the class background entry
        Background = (BackgroundTableEntry) backgroundTable.GetRandomRangeEntry();

        // Set the class level table
        ClassLevelTable = levelTable;
    }
}
