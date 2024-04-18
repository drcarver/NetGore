using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

using Microsoft.Maui.Controls;

namespace D20.Character.PC.Cleric;

/// <summary>
/// Clerics are not merely people of religious faith—they are 
/// devoted servants who wield true divine power from their 
/// deities. The particular path that steers a cleric toward 
/// their faith can mean the difference between a demon-worshiping 
/// cultist and a lawful harbinger of her deity’s blessed faith.
/// </summary>
public class Cleric : CharacterClassBase
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
        var ClericLevelTable = serviceProvider.GetService<IClericLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Cleric(IServiceProvider services,
        IClericBackgroundTable backgroundTable)
    {
        serviceProvider = services;
        Name = nameof(Cleric);
        Description =
            "Clerics are not merely people of religious " +
            "faith—they are devoted servants who wield true " +
            "divine power from their deities. The particular " +
            "path that steers a cleric toward her faith can " +
            "mean the difference between a demon-worshiping " +
            "cultist and a lawful harbinger of her deity’s " +
            "blessed faith.";
        HitDice = "1d8";

        //Armor: Light armor, medium  armor,	shields
        ArmorProficiency =
        [
            EquipmentCategoryEnum.LightArmor,
            EquipmentCategoryEnum.MediumArmor,
            EquipmentCategoryEnum.Shields,
        ];
        WeaponProficiency =
        [
            WeaponProficiencyEnum.SimpleWeapons,
        ];
        ToolProficiency =
        [
            // None
        ];
        //Saving  Throws:	Wisdom,	Charisma
        SavingThrows =
        [
            AbilityEnum.Wisdom,
            AbilityEnum.Charisma,
        ];
        //Skills: Choose two from History, Insight, Medicine,
        //Persuasion, and Religion
        Skills =
        [
            SkillEnum.History,
            SkillEnum.Insight,
            SkillEnum.Medicine,
            SkillEnum.Persuasion,
            SkillEnum.Religion,
        ];

        // Generate the class background
        Background = (IBackgroundTableEntry) backgroundTable.GetRandomRangeEntry();
    }
}
//Equipment
//You start   with the following equipment,  in	addition
//to  the equipment   granted by  your background:
//• (a) a   mace or(b) a warhammer(if	proficient)
//• (a) scale   mail,	(b) leather armor,	or(c) chain mail
//(if	proficient)
//• (a) a   light crossbow    and	20	bolts or(b) any simple
//weapon
//• (a) a   priest’s pack    or(b) an explorer’s pack
//• A shield  and a   holy symbol