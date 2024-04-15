using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC.Bard;

/// <summary>
/// Bards have a talent for song and story, and they come to 
/// their careers by developing this talent as they pick up 
/// on a smattering of other skills. 
/// </summary>
public class Bard : CharacterClassBase
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
        var bardLevelTable = serviceProvider.GetService<IBardLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Bard(IServiceProvider services,
        IBardBackgroundTable backgroundTable)
    {
        serviceProvider = services;
        Name = nameof(Bard);
        Description =
            "Bards have a talent for song and story, and they come to " +
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
        
//Tools: Three musical instruments of  your choice
//Skills: Choose any three
//Equipment
//You start   with the following equipment,  in	addition
//to  the equipment   granted by  your background:
//• (a) a   rapier,	(b) a   longsword,	or(c) any simple
//weapon
//• (a) a   diplomat’s pack    or(b) an entertainer’s pack
//• (a) a   lute or(b) any other   musical instrument
//• Leather armor   and a   dagger
//The Bard
