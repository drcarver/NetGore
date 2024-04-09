using System.Diagnostics.CodeAnalysis;

using NetGore.CharacterClasses.Enum;
using NetGore.Data.Enum;

namespace NetGore.CharacterClasses.Models;

public class Bard : CharacterClassBase
{
    /// <summary>
    /// The class features by level
    /// </summary>
    public List<ClassFeatureLevelEntry> ClassFeatures { get; set; } =
    [
        #region 1st Level
        // 1st +2 Rage, Unarmored Defense, 2 +2
        new BarbarianFeatureLevelEntry
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
                ClassFeatureEnum.PrimalPath
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
            Level = 19,
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
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Bard() 
    {
        Name = nameof(Bard);
        Description = "";
        HitDice = "1d8";
        ArmorCategory =
        [
            ArmorCategoryEnum.LightArmor,
        ];
        WeaponProficiency =
        [
            WeaponProficiencyEnum.SimpleWeapons,
            WeaponProficiencyEnum.MartialWeapons,
        ];
        SavingThrows =
        [
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
        ];
    }

}

//Proficiencies
//Weapons: Simple weapons, hand    crossbows,	
//longswords,	rapiers,	shortswords
//Tools: Three musical instruments of  your choice
//Saving Throws: Dexterity,	Charisma
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
//Proficiency Cantrips Spells —Spell  Slots   per Spell   Level—
//Level Bonus Features Known Known 1st 2nd 3rd 4th 5th 6th 7th 8th 9th
//1st +2 Spellcasting,    Bardic  Inspiration
//(d6)
//2 4 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
//2nd +2 Jack of  All Trades, Song    of  Rest
//(d6)
//2 5 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
//3rd +2 Bard College,    Expertise 2 6 4 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶
//4th +2 Ability  Score   Improvement 3 7 4 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶
//5th +3 Bardic   Inspiration (d8), Font  of
//Inspiration
//3 8 4 3 2 ̶ ̶ ̶ ̶ ̶ ̶
//6th +3 Countercharm,    Bard    College
//feature
//3 9 4 3 3 ̶ ̶ ̶ ̶ ̶ ̶
//7th +3 ̶ 3 10 4 3 3 1 ̶ ̶ ̶ ̶ ̶
//8th +3 Ability  Score   Improvement 3 11 4 3 3 2 ̶ ̶ ̶ ̶ ̶
//9th +4 Song of  Rest    (d8) 3 12 4 3 3 3 1 ̶ ̶ ̶ ̶
//10th +4 Bardic  Inspiration (d10),
//Expertise, Magical  Secrets
//4 14 4 3 3 3 2 ̶ ̶ ̶ ̶
//11th +4 ̶ 4 15 4 3 3 3 2 1 ̶ ̶ ̶
//12th +4 Ability Score   Improvement 4 15 4 3 3 3 2 1 ̶ ̶ ̶
//13th +5 Song    of  Rest    (d10) 4 16 4 3 3 3 2 1 1 ̶ ̶
//14th +5 Magical Secrets,    Bard    College
//feature
//4 18 4 3 3 3 2 1 1 ̶ ̶
//15th +5 Bardic  Inspiration (d12) 4 19 4 3 3 3 2 1 1 1 ̶
//16th +5 Ability Score   Improvement 4 19 4 3 3 3 2 1 1 1 ̶
//17th +6 Song    of  Rest    (d12) 4 20 4 3 3 3 2 1 1 1 1
//18th +6 Magical Secrets 4 22 4 3 3 3 3 1 1 1 1
//19th +6 Ability Score   Improvement 4 22 4 3 3 3 3 2 1 1 1
//20th +6 Superior    Inspiration 4 22 4 3 3 3 3 2 2 1 1    ];
