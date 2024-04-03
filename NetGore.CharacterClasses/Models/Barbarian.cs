using System.Diagnostics.CodeAnalysis;

using NetGore.CharacterClasses.Enum;
using NetGore.Core;
using NetGore.Core.Abilities;

namespace NetGore.CharacterClasses.Models;

public class Barbarian : CharacterClassBase
{
    public List<ClassFeatureLevelEntry> ClassFeatures { get; set; } =
    [
        #region 1st Level
        // 1st +2 Rage, Unarmored Defense, 2 +2
        new BarbarianClassFeatureLevelEntry
        {
            Level = 1,
            BaseProficiency = 2,
            Rages = 2,
            RageDamage = 2,
            ClassFeatures = 
            [
                ClassFeatureEnum.Rage,
                ClassFeatureEnum.UnarmoredDefense
            ],
        },
    #endregion

        #region 2nd Level
        //2nd +2 Reckless Attack, Danger Sense 2 +2
        new BarbarianClassFeatureLevelEntry
        {
            Level = 2,
            BaseProficiency = 2,
            Rages = 2,
            RageDamage = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.RecklessAttack,
                ClassFeatureEnum.DangerSense
            ],
        },
        #endregion

        #region 3rd Level
        //3rd +2 Primal Path 3 +2
        new BarbarianClassFeatureLevelEntry
        {
            Level = 3,
            BaseProficiency = 2,
            Rages = 3,
            RageDamage = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.PrimalPath
            ],
        },
    #endregion

        #region 4th Level
        //4th +2 Ability Score Improvement 3 +2
        new BarbarianClassFeatureLevelEntry
        {
            Level = 4,
            BaseProficiency = 2,
            Rages = 3,
            RageDamage = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
    #endregion

        #region 5th Level
        //5th +3 Extra Attack, Fast Movement 3 +2
        new BarbarianClassFeatureLevelEntry
        {
            Level = 5,
            BaseProficiency = 3,
            Rages = 3,
            RageDamage = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.ExtraAttack,
                ClassFeatureEnum.FastMovement,
            ],
        },
    #endregion

        #region 6th Level
        //6th +3 Path feature 4 +2
        new BarbarianClassFeatureLevelEntry
        {
            Level = 6,
            BaseProficiency = 3,
            Rages = 4,
            RageDamage = 2,
            ClassFeatures =
            [
            ],
        },
        #endregion

        #region 7th Level
        //7th +3 Feral Instinct 4 +2
        new BarbarianClassFeatureLevelEntry
        {
            Level = 7,
            BaseProficiency = 3,
            Rages = 4,
            RageDamage = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.FeralInstinct
            ],
        },
    #endregion

        #region 8th Level
        //8th +3 Ability Score Improvement 4 +2
        new BarbarianClassFeatureLevelEntry
        {
            Level = 8,
            BaseProficiency = 3,
            Rages = 4,
            RageDamage = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
    #endregion

        #region 9th Level
        //9th +4 Brutal Critical (1	die) 4 +3
        new BarbarianClassFeatureLevelEntry
        {
            Level = 8,
            BaseProficiency = 4,
            Rages = 4,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.BrutalCritical1die
            ],
        },
    #endregion

        #region 10th Level
        //10th +4 Path feature 4 +3
        new BarbarianClassFeatureLevelEntry
        {
            Level = 10,
            BaseProficiency = 4,
            Rages = 4,
            RageDamage = 3,
            ClassFeatures =
            [
            ],
        },
    #endregion

        #region 11th Level
        //11th +4 Relentless	 4 +3
        new BarbarianClassFeatureLevelEntry
        {
            Level = 11,
            BaseProficiency = 4,
            Rages = 4,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.Relentless
            ],
        },
    #endregion

        #region 12th Level
        //12th +4 Ability Score Improvement 5 +3
        new BarbarianClassFeatureLevelEntry
        {
            Level = 12,
            BaseProficiency = 4,
            Rages = 5,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
    #endregion

        #region 13th Level
        //13th +5 Brutal Critical (2 dice) 5 +3
        new BarbarianClassFeatureLevelEntry
        {
            Level = 13,
            BaseProficiency = 5,
            Rages = 5,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.BrutalCritical2die
            ],
        },
        #endregion

    ];
//14th +5 Path feature 5 +3
//15th +5 Persistent
//Rage
//5 +3
//16th +5 Ability Score
//Improvement
//5 +4
//17th +6 Brutal Critical
//(3	dice)
//6 +4
//18th +6 Indomitable
//Might
//6 +4
//19th +6 Ability Score
//Improvement
//6 +4
//20th +6 Primal
//Champion
//Unlimited +4

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Barbarian() 
    {
        Name = nameof(Barbarian);
        Description = "";
        HitDice = "1d12";
        ArmorProficiency =
        [
            ArmorProficiencyEnum.LightArmor,
            ArmorProficiencyEnum.MediumArmor,
            ArmorProficiencyEnum.Shields,
        ];
        WeaponProficiency =
        [
            WeaponProficiencyEnum.SimpleWeapons,
            WeaponProficiencyEnum.MartialWeapons,
        ];
        SavingThrows =
        [
            ""
        ];
    }

}
//Saving  Throws: Strength,	Constitution
//Skills:	Choose two from Animal  Handling,	Athletics,	
//Intimidation,	Nature,	Perception,	and Survival
//Equipment
//You start with    the following   equipment,	in	addition
//to  the equipment   granted by  your background:
//• (a) a   greataxe or(b) any martial melee weapon
//• (a) two   handaxes or(b) any simple  weapon
//• An explorer’s pack    and four    javelins
