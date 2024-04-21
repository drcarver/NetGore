using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core;
using D20.Core.Enum;
using D20.Goods.Enum;
using D20.Goods.Models;

namespace D20.Character.PC.Monk;

public class Monk : CharacterClassBase
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
        var MonkLevelTable = serviceProvider.GetService<IMonkLevelTable>();

        //Skills: Choose two
        int newSkillCount = 0;
        for (int i = 0; i < Skills.Count; i++)
        {
            var dice = new Dice($"1d{Skills.Count}").Total;
            if (!character.Skills.Contains(Skills[dice]))
            {
                newSkillCount++;
                if (newSkillCount > 2)
                {
                    break;
                }
                character.Skills.Add(Skills[dice]);
            }
        }

        //character.Equipment.Add(new Ammunition( )
        //Equipment
        //You start   with the following equipment,  in	addition
        //to  the equipment   granted by  your background:
        //• (a) a   shortsword or(b) any simple  weapon
        //• (a) a   dungeoneer’s pack    or(b) an explorer’s pack
        //• 10	darts
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Monk(IServiceProvider services, 
        IMonkBackgroundTable backgroundTable)
    {
        serviceProvider = services;
        Name = nameof(Monk);
        Description =
            "Monks excel at overcoming even the most daunting " +
            "perils, striking where it’s least expected, and " +
            "taking advantage of enemy vulnerabilities. Fleet " +
            "of foot and skilled in combat, monks can navigate " +
            "any battlefield with ease, aiding allies wherever " +
            "they are needed most.";
        HitDice = "1d8";
        ArmorProficiency =
        [
        ];
        WeaponProficiency =
        [
            WeaponProficiencyEnum.SimpleWeapons,
            WeaponProficiencyEnum.ShortSwords,
        ];
        //Tools:	Choose one type of  artisan’s tools   or one
        //musical instrument
        ToolProficiency =
        [

        ];
        SavingThrows =
        [
            AbilityEnum.Strength,
            AbilityEnum.Dexterity
        ];
        Skills =
        [
            SkillEnum.AnimalHandling,
            SkillEnum.Athletics,
            SkillEnum.History,
            SkillEnum.Insight,
            SkillEnum.Religion,
            SkillEnum.Stealth,
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
        Background = (IBackgroundTableEntry)backgroundTable.GetRandomRangeEntry();
    }
}
//The Monk
//Level Proficiency Bonus Martial Arts Ki Points Unarmored Movement Features
//1st +2 1d4 — — Unarmored Defense, Martial Arts
//2nd +2 1d4 2 +10	ft.Ki,	Unarmored Movement
//3rd +2 1d4 3 +10	ft.Monastic Tradition, Deflect Missiles
//4th +2 1d4 4 +10	ft.Ability Score   Improvement,	Slow Fall
//5th +3 1d6 5 +10	ft.Extra Attack, Stunning    Strike
//6th +3 1d6 6 +15	ft.Ki-Empowered Strikes, Monastic    Tradition feature
//7th +3 1d6 7 +15	ft.Evasion,	Stillness of  Mind
//8th +3 1d6 8 +15	ft.Ability Score   Improvement
//9th +4 1d6 9 +15	ft.Unarmored Movement    improvement
//10th +4 1d6 10 +20	ft.Purity of  Body
//11th +4 1d8 11 +20	ft.Monastic Tradition   feature
//12th +4 1d8 12 +20	ft.Ability Score   Improvement
//13th +5 1d8 13 +20	ft.Tongue of  the Sun and Moon
//14th +5 1d8 14 +25	ft.Diamond Soul
//15th +5 1d8 15 +25	ft.Timeless Body
//16th +5 1d8 16 +25	ft.Ability Score   Improvement
//17th +6 1d10 17 +25	ft.Monastic Tradition   feature
//18th +6 1d10 18 +30	ft.Empty Body
//19th +6 1d10 19 +30	ft.Ability Score   Improvement
//20th +6 1d10 20 +30	ft.Perfect Self
