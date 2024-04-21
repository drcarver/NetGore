using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Character.PC.Druid;
using D20.Character.Race;
using D20.Core.Enum;
using D20.Goods.Enum;

using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D20.Character.PC.Druid;

/// <summary>
/// Druids come by their primal power in various ways. One 
/// druid might receive her power from an elemental creature, 
/// and another might learn it from a beast or the fey. 
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
            "Druids come by their primal power in various " +
            "ways. One druid might receive her power from " +
            "an elemental creature, and another might learn " +
            "it from a beast or the fey.";
        HitDice = "1d8";
        ArmorProficiency =
        [
            EquipmentCategoryEnum.LightArmor,
            EquipmentCategoryEnum.MediumArmor,
            EquipmentCategoryEnum.Shields,
        ];
        WeaponProficiency =
        [
            WeaponProficiencyEnum.Clubs,
            WeaponProficiencyEnum.Daggers,
            WeaponProficiencyEnum.Darts,
            WeaponProficiencyEnum.Javelins,
            WeaponProficiencyEnum.Maces,
            WeaponProficiencyEnum.Quarterstaffs,
            WeaponProficiencyEnum.Scimitars,
            WeaponProficiencyEnum.Sickles,
            WeaponProficiencyEnum.Slings,
            WeaponProficiencyEnum.Spears,
        ];
        SavingThrows =
        [
            AbilityEnum.Intelligence,
            AbilityEnum.Wisdom,
        ];
        ToolProficiency =
        [
            EquipmentEnum.Bagpipes
        ];
        Skills =
        [
            SkillEnum.Arcana,
            SkillEnum.AnimalHandling,
            SkillEnum.Insight,
            SkillEnum.Medicine,
            SkillEnum.Nature,
            SkillEnum.Perception,
            SkillEnum.Religion,
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
        Background = (IBackgroundTableEntry) backgroundTable.GetRandomRangeEntry();
    }
}
//Equipment
//You start with    the following   equipment,	in	addition
//to  the equipment   granted by  your background:
//• (a) a   wooden shield  or(b) any simple  weapon
//• (a) a   scimitar or(b) any simple  melee weapon
//• Leather armor, an  explorer’s pack, and a druidic
//focus