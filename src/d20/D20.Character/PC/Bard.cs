using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.PC;

public class Bard : CharacterClassBase
{
    /// <summary>
    /// The class features by level
    /// </summary>
    public List<ClassFeatureLevelEntry> ClassFeatures { get; set; } =
    [
        #region 1st Level
        //1st +2 Spellcasting, Bardic Inspiration (d6)
        new BardFeatureLevelEntry
        {
            Level = 1,
            BaseProficiency = 2,
            SpellsKnown = 4,
            CantripsKnown = 2,
            SpellSlots = [2, 2, 0, 0, 0, 0, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.Spellcasting,
                ClassFeatureEnum.BardicInspiration
            ],
        },
        #endregion

        #region 2nd Level
        //2nd +2 Jack of  All Trades, Song of Rest (d6)
        //2 5 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 2,
            BaseProficiency = 2,
            CantripsKnown = 2,
            SpellsKnown = 5,
            SpellSlots = [2, 3, 0, 0, 0, 0, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.JackofAllTrades,
                ClassFeatureEnum.SongofRest
            ],
        },
        #endregion

        #region 3rd Level
        //3rd +2 Bard College,    Expertise 2 6 4 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 3,
            BaseProficiency = 2,
            CantripsKnown = 2,
            SpellsKnown = 6,
            SpellSlots = [2, 4, 2, 0, 0, 0, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.BardCollege,
                ClassFeatureEnum.Expertise,
            ],
        },
        #endregion

        #region 4th Level
        //4th +2 Ability  Score   Improvement 3 7 4 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 4,
            BaseProficiency = 2,
            CantripsKnown = 3,
            SpellsKnown = 7,
            SpellSlots = [3, 4, 3, 0, 0, 0, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
        #endregion

        #region 5th Level
        //5th +3 Bardic Inspiration (d8), Font of Inspiration
        //3 8 4 3 2 ̶ ̶ ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 5,
            BaseProficiency = 3,
            CantripsKnown = 3,
            SpellsKnown = 8,
            SpellSlots = [3, 4, 3, 2, 0, 0, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.BardicInspiration,
                ClassFeatureEnum.FontofInspiration,
            ],
        },
        #endregion

        #region 6th Level
        //6th +3 Countercharm, Bard College feature
        //3 9 4 3 3 ̶ ̶ ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 6,
            BaseProficiency = 3,
            CantripsKnown = 2,
            SpellsKnown = 9,
            SpellSlots = [3, 4, 3, 3, 0, 0, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.CounterCharm,
                ClassFeatureEnum.BardCollegeFeature,
            ],
        },
        #endregion

        #region 7th Level
        //7th +3 ̶ 3 10 4 3 3 1 ̶ ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 7,
            BaseProficiency = 3,
            CantripsKnown = 3,
            SpellsKnown = 10,
            SpellSlots = [2, 4, 3, 3, 0, 0, 0, 0, 0, 0],
            ClassFeatures =
            [
            ],
        },
        #endregion

        #region 8th Level
        //8th +3 Ability Score Improvement 3 11 4 3 3 2 ̶ ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 8,
            BaseProficiency = 3,
            CantripsKnown = 3,
            SpellsKnown = 11,
            SpellSlots = [3, 4, 3, 3, 2, 0, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
        #endregion

        #region 9th Level
        //9th +4 Song of Rest (d8) 3 12 4 3 3 3 1 ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 8,
            BaseProficiency = 4,
            CantripsKnown = 3,
            SpellsKnown = 12,
            SpellSlots = [3, 4, 3, 3, 3, 1, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.SongofRest
            ],
        },
        #endregion

        #region 10th Level
        //10th +4 Bardic Inspiration, Expertise, Magical Secrets
        //4 14 4 3 3 3 2 ̶ ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 10,
            BaseProficiency = 4,
            CantripsKnown = 4,
            SpellsKnown = 14,
            SpellSlots = [4, 4, 3, 3, 3, 2, 0, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.BardicInspiration,
                ClassFeatureEnum.Expertise,
                ClassFeatureEnum.MagicalSecrets
            ],
        },
        #endregion

        #region 11th Level
        //11th +4 ̶ 4 15 4 3 3 3 2 1 ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 11,
            BaseProficiency = 4,
            CantripsKnown = 4,
            SpellsKnown = 15,
            SpellSlots = [4, 4, 3, 3, 3, 2, 1, 0, 0, 0],
            ClassFeatures =
            [
            ],
        },
        #endregion

        #region 12th Level
        //12th +4 Ability Score Improvement 4 15 4 3 3 3 2 1 ̶ ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 12,
            BaseProficiency = 4,
            CantripsKnown = 4,
            SpellsKnown = 15,
            SpellSlots = [4, 4, 3, 3, 3, 2, 1, 0, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
        #endregion

        #region 13th Level
        //13th +5 Song of Rest (d10) 4 16 4 3 3 3 2 1 1 ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 13,
            BaseProficiency = 5,
            CantripsKnown = 4,
            SpellsKnown = 16,
            SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.SongofRest
            ],
        },
        #endregion

        #region 14th Level
        //14th +5 Magical Secrets, Bard College feature
        //4 18 4 3 3 3 2 1 1 ̶ ̶
        new BardFeatureLevelEntry
        {
            Level = 14,
            BaseProficiency = 5,
            CantripsKnown = 4,
            SpellsKnown = 18,
            SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 0, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.MagicalSecrets,
                ClassFeatureEnum.BardCollegeFeature
            ],
        },
        #endregion

        #region 15th Level
        //15th +5 Bardic  Inspiration (d12) 4 19 4 3 3 3 2 1 1 1 ̶
        new BardFeatureLevelEntry
        {
            Level = 15,
            BaseProficiency = 5,
            CantripsKnown = 4,
            SpellsKnown = 19,
            SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 1, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.BardicInspiration
            ],
        },
        #endregion

        #region 16th Level
        //16th +5 Ability Score Improvement 4 19 4 3 3 3 2 1 1 1 ̶
        new BardFeatureLevelEntry
        {
            Level = 16,
            BaseProficiency = 5,
            CantripsKnown = 4,
            SpellsKnown = 19,
            SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 1, 0],
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
        #endregion

        #region 17th Level
        //17th +6 Song of Rest (d12) 4 20 4 3 3 3 2 1 1 1 1
        new BardFeatureLevelEntry
        {
            Level = 17,
            BaseProficiency = 6,
            CantripsKnown = 4,
            SpellsKnown = 20,
            SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 1, 1],
            ClassFeatures =
            [
                ClassFeatureEnum.SongofRest
            ],
        },
        #endregion

        #region 18th Level
        //18th +6 Magical Secrets 4 22 4 3 3 3 3 1 1 1 1
        new BardFeatureLevelEntry
        {
            Level = 18,
            BaseProficiency = 6,
            CantripsKnown = 4,
            SpellsKnown = 22,
            SpellSlots = [4, 4, 3, 3, 3, 3, 1, 1, 1, 1],
            ClassFeatures =
            [
                ClassFeatureEnum.MagicalSecrets
            ],
        },
        #endregion

        #region 19th Level
        //19th +6 Ability Score Improvement
        //4 22 4 3 3 3 3 2 1 1 1
        new BardFeatureLevelEntry
        {
            Level = 19,
            BaseProficiency = 6,
            CantripsKnown = 4,
            SpellsKnown = 22,
            SpellSlots = [4, 4, 3, 3, 3, 3, 2, 1, 1, 1],
            ClassFeatures =
            [
                ClassFeatureEnum.AbilityScoreImprovement
            ],
        },
        #endregion

        #region 20th Level
        //20th +6 Superior Inspiration
        //4 22 4 3 3 3 3 2 2 1 1    
        new BardFeatureLevelEntry
        {
            Level = 20,
            BaseProficiency = 6,
            CantripsKnown = 4,
            SpellsKnown = 22,
            SpellSlots = [4, 4, 3, 3, 3, 3, 2, 2, 1, 1],
            ClassFeatures =
            [
                ClassFeatureEnum.SuperiorInspiration
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
