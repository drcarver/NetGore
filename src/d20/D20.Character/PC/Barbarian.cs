using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC;

public class Barbarian : CharacterClassBase
{
    /// <summary>
    /// The class features by level
    /// </summary>
    public List<ClassFeatureLevelEntry> ClassFeatures { get; set; } =
    [
        #region 1st Level
        new BarbarianFeatureLevelEntry
        {
            Level = 1,
            BaseProficiency = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.Rage,
                ClassFeatureEnum.UnarmoredDefense
            ],
        },
        #endregion

        #region 2nd Level
        //2nd +2 Reckless Attack, Danger Sense 2 +2
        new BarbarianFeatureLevelEntry
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
        new BarbarianFeatureLevelEntry
        {
            Level = 3,
            BaseProficiency = 2,
            Rages = 3,
            RageDamage = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.PrimalPath,
                ClassFeatureEnum.PathoftheBerserker,
                ClassFeatureEnum.Frenzy,
            ],
        },
        #endregion

        #region 4th Level
        //4th +2 Ability Score Improvement 3 +2
        new BarbarianFeatureLevelEntry
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
        new BarbarianFeatureLevelEntry
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
        new BarbarianFeatureLevelEntry
        {
            Level = 6,
            BaseProficiency = 3,
            Rages = 4,
            RageDamage = 2,
            ClassFeatures =
            [
                ClassFeatureEnum.MindlessRage
            ],
        },
        #endregion

        #region 7th Level
        //7th +3 Feral Instinct 4 +2
        new BarbarianFeatureLevelEntry
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
        new BarbarianFeatureLevelEntry
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
        new BarbarianFeatureLevelEntry
        {
            Level = 8,
            BaseProficiency = 4,
            Rages = 4,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.BrutalCritical
            ],
        },
        #endregion

        #region 10th Level
        //10th +4 Path feature 4 +3
        new BarbarianFeatureLevelEntry
        {
            Level = 10,
            BaseProficiency = 4,
            Rages = 4,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.IntimidatingPresence
            ],
        },
    #endregion

        #region 11th Level
        //11th +4 Relentless	 4 +3
        new BarbarianFeatureLevelEntry
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
        new BarbarianFeatureLevelEntry
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
        new BarbarianFeatureLevelEntry
        {
            Level = 13,
            BaseProficiency = 5,
            Rages = 5,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.BrutalCritical
            ],
        },
        #endregion

        #region 14th Level
        //14th +5 Path feature 5 +3
        new BarbarianFeatureLevelEntry
        {
            Level = 14,
            BaseProficiency = 5,
            Rages = 5,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.Retaliation,
            ],
        },
        #endregion

        #region 15th Level
        //15th +5 Persistent Rage 5 +3
        new BarbarianFeatureLevelEntry
        {
            Level = 15,
            BaseProficiency = 5,
            Rages = 5,
            RageDamage = 3,
            ClassFeatures =
            [
                ClassFeatureEnum.PersistentRage
            ],
        },
        #endregion

        #region 16th Level
        //16th +5 Ability Score Improvement 5 +4
        new BarbarianFeatureLevelEntry
        {
            Level = 16,
            BaseProficiency = 5,
            Rages = 5,
            RageDamage = 4,
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
        #endregion

        #region 17th Level
        //17th +6 Brutal Critical (3 dice) 6 +4
        new BarbarianFeatureLevelEntry
        {
            Level = 17,
            BaseProficiency = 6,
            Rages = 6,
            RageDamage = 4,
            ClassFeatures =
            [
                ClassFeatureEnum.BrutalCritical
            ],
        },
        #endregion

        #region 18th Level
        // 18th +6 Indomitable Might 6 +4
        new BarbarianFeatureLevelEntry
        {
            Level = 18,
            BaseProficiency = 6,
            Rages = 6,
            RageDamage = 4,
            ClassFeatures =
            [
                ClassFeatureEnum.IndomitableMight
            ],
        },
        #endregion

        #region 19th Level
        //19th +6 Ability Score Improvement 6 +4
        new BarbarianFeatureLevelEntry
        {
            Level = 19,
            BaseProficiency = 6,
            Rages = 6,
            RageDamage = 4,
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
        #endregion

        #region 20th Level
        //20th +6 Primal Champion Unlimited +4
        new BarbarianFeatureLevelEntry
        {
            Level = 20,
            BaseProficiency = 6,
            Rages = 6,
            RageDamage = 4,
            ClassFeatures =
            [
                ClassFeatureEnum.PrimalChampionUnlimited
            ],
        },
        #endregion
    ];

    /// <summary>
    /// Level up the character with this class
    /// </summary>
    /// <param name="character"></param>
    public void LevelUp(ICharacter character)
    {
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Barbarian()
    {
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
    }
}

