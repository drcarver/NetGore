using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Character.PC.Druid;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC.Druid;

/// <summary>
/// Druids have a talent for song and story, and they come to 
/// their careers by developing this talent as they pick up 
/// on a smattering of other skills. 
/// </summary>
public class Druid : CharacterClassBase
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
        var DruidLevelTable = serviceProvider.GetService<IDruidLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Druid(IServiceProvider services,
        IDruidBackgroundTable backgroundTable)
    {
        serviceProvider = services;
        Name = nameof(Druid);
        Description =
            "Druids have a talent for song and story, and they come to " +
            "their careers by developing this talent as they pick up " +
            "on a smattering of other skills.";
        HitDice = "1d8";
        ArmorProficiency =
        [
            EquipmentCategoryEnum.LightArmor,
        ];
        WeaponProficiency =
        [
            WeaponProficiencyEnum.SimpleWeapons,
            WeaponProficiencyEnum.HandCrossbows,
            WeaponProficiencyEnum.LongSwords,
            WeaponProficiencyEnum.Rapiers,
            WeaponProficiencyEnum.ShortSwords,
        ];
        SavingThrows =
        [
            AbilityEnum.Dexterity,
            AbilityEnum.Charisma,
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
            EquipmentEnum.Dagger
        ];
        Armor =
        [
            EquipmentEnum.Leather
        ];

        // Generate the class background
        var classBackground = backgroundTable.GetRandomRangeEntry();
        BackgroundDescription = classBackground.Description;
    }
}
