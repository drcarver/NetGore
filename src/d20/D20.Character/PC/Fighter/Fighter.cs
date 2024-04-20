using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC.Fighter;

public class Fighter : CharacterClassBase
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
        var FighterLevelTable = serviceProvider.GetService<IFighterLevelTable>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Fighter(IServiceProvider services, 
        IFighterBackgroundTable backgroundTable)
    {
        serviceProvider = services;
        Name = nameof(Fighter);
        Description =
            "Fighters excel at combat—defeating their enemies, " +
            "controlling the flow of battle, and surviving " +
            "such sorties themselves. While their specific " +
            "weapons and methods grant them a wide variety " +
            "of tactics, few can match fighters for sheer " +
            "battle prowess.";
        HitDice = "1d10";
        ArmorProficiency =
        [
            EquipmentCategoryEnum.LightArmor,
            EquipmentCategoryEnum.MediumArmor,
            EquipmentCategoryEnum.HeavyArmor,
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
            SkillEnum.Acrobatics,
            SkillEnum.AnimalHandling,
            SkillEnum.Athletics,
            SkillEnum.History,
            SkillEnum.Insight,
            SkillEnum.Intimidation,
            SkillEnum.Perception,
            SkillEnum.Survival,
        ];
        Equipment =
        [
        ];

        // Generate the class background
        Background = (IBackgroundTableEntry) backgroundTable.GetRandomRangeEntry();
    }
}

//Equipment
//You start   with the following equipment,  in	addition
//to  the equipment   granted by  your background:
//• (a) chain   mail or(b) leather armor, longbow, and
//20	arrows
//• (a) a   martial weapon  and a   shield or(b) two
//martial weapons
//• (a) a   light crossbow    and	20	bolts or(b) two
//handaxes
//• (a) a   dungeoneer’s pack    or(b) an explorer’s pack
//Fighting Style
//You adopt   a particular  style of  fighting	as	your
//specialty.Choose  one of  the following   options.You
//can’t take    a Fighting    Style option  more than    once,
//even    if	you later   get to  choose again.
//Archery
//You gain a	+2	bonus to  attack rolls   you make    with
//ranged  weapons.
//Defense
//While   you are wearing armor, you gain    a   +1	bonus to
//AC.
//Dueling
//When    you are wielding a   melee weapon  in one hand
//and no  other weapons, you gain    a   +2	bonus to
//damage rolls   with that    weapon.
//Great Weapon Fighting
//When    you roll    a   1	or  2	on a   damage die	for	an attack
//you make    with a   melee weapon  that you are
//wielding    with two hands, you can reroll the die and
//must use the new roll,	even	if	the new roll	is	a	1	or a
//2. The weapon  must have    the two-handed or
//versatile property    for	you to  gain this    benefit.
//Protection
//When    a creature    you can see attacks a target  other
//than    you that	is	within  5	feet of  you, you can use
//your    reaction to  impose disadvantage    on the attack
//roll.	You must    be wielding    a shield.
//Two-Weapon Fighting
//When you engage  in two-weapon fighting, you can
//add your    ability modifier    to the damage of  the
//second  attack.
