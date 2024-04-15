using System.Diagnostics.CodeAnalysis;
using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC.Barbarian;

public class Barbarian : CharacterClassBase
{
    /// <summary>
    /// The DI service provider
    /// </summary>
    private readonly IServiceProvider serviceProvider;

    /// <summary>
    /// Level up the character with this class
    /// </summary>
    /// <param name="character"></param>
    public void LevelUp(ICharacter character)
    {
        var barbarianLevelTable = serviceProvider.GetService<IBarbarianLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Barbarian(IServiceProvider services, 
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
        Equipment =
        [
            EquipmentEnum.GreatAxe,
            EquipmentEnum.HandAxe,
            EquipmentEnum.HandAxe,
            EquipmentEnum.Javelin,
            EquipmentEnum.Javelin,
            EquipmentEnum.Javelin,
            EquipmentEnum.Javelin,
            EquipmentEnum.ExplorersPack,
        ];

        // Generate the class background
        var classBackground = backgroundTable.GetRandomRangeEntry();
        BackgroundDescription = classBackground.Description;
    }
}
