using System.Collections.ObjectModel;

using GoDungeon.Character.Enum;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Character.PC.Fighter
{
    /// <summary>
    /// Those who become fighters take up the sword for many reasons.
    /// Some fight for coin, others for duty, and others for survival. 
    /// </summary>
    public class FighterLevelTable : GameTable, IFighterLevelTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FighterLevelTable()
        {
            Name = nameof(FighterLevelTable);
            ProperName = "Fighter Features and Proficiencies by Level";
            TableType = TableTypeEnum.CharacterTable;
            Description =
                "Fighters excel at combat—defeating their enemies, " +
                "controlling the flow of battle, and surviving " +
                "such sorties themselves. While their specific " +
                "weapons and methods grant them a wide variety " +
                "of tactics, few can match fighters for sheer " +
                "battle prowess.";
        }

        //Level Proficiency Bonus Features
        //1st +2 Fighting Style, Second  Wind
        //2nd +2 Action Surge(one use)
        //3rd +2 Martial Archetype
        //4th +2 Ability Score   Improvement
        //5th +3 Extra Attack
        //6th +3 Ability Score   Improvement
        //7th +3 Martial Archetype   feature
        //8th +3 Ability Score   Improvement
        //9th +4 Indomitable(one use)
        //10th +4 Martial Archetype   feature
        //11th +4 Extra Attack(2)
        //12th +4 Ability Score   Improvement
        //13th +5 Indomitable(two uses)
        //14th +5 Ability Score   Improvement
        //15th +5 Martial Archetype   feature
        //16th +5 Ability Score   Improvement
        //17th +6 Action Surge(two uses),	
        //Indomitable(three uses)
        //18th +6 Martial Archetype   feature
        //19th +6 Ability Score   Improvement
        //20th +6 Extra Attack(3)
        /// <summary>
        /// Initialize the game table.  This is a separate method 
        /// so we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region 1st Level
                    //1st +2 Fighting Style, Second  Wind
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 1,
                        BaseProficiency = 2,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.FightingStyle,
                            ClassFeatureEnum.SecondWind
                        },
                    },
                    #endregion

                    #region 2nd Level
                    //2nd +2 Action Surge(one use)
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 2,
                        BaseProficiency = 2,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.ActionSurge,
                        },
                    },
                    #endregion

                    #region 3rd Level
                    //3rd +2 Martial Archetype
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 3,
                        BaseProficiency = 2,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.MartialArchetype,
                        },
                    },
                    #endregion

                    #region 4th Level
                    //4th +2 Ability Score Improvement
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 4,
                        BaseProficiency = 2,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.AbilityScoreImprovement
                        },
                    },
                    #endregion

                    #region 5th Level
                    //5th +3 Extra Attack
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 5,
                        BaseProficiency = 3,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.ExtraAttack,
                        },
                    },
                    #endregion

                    #region 6th Level
                    //6th +3 Ability Score   Improvement
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 6,
                        BaseProficiency = 3,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.AbilityScoreImprovement
                        },
                    },
                    #endregion

                    #region 7th Level
                    //7th +3 Martial Archetype   feature
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 7,
                        BaseProficiency = 3,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.MartialArchetype
                        },
                    },
                    #endregion

                    #region 8th Level
                    //8th +3 Ability Score   Improvement
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 8,
                        BaseProficiency = 3,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.AbilityScoreImprovement
                        },
                    },
                    #endregion

                    #region 9th Level
                    //9th +4 Indomitable(one use)
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 8,
                        BaseProficiency = 4,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.Indomitable
                        },
                    },
                    #endregion

                    #region 10th Level
                    //10th +4 Martial Archetype   feature
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 10,
                        BaseProficiency = 4,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.MartialArchetype
                        },
                    },
                    #endregion

                    #region 11th Level
                    //11th +4 Extra Attack(2)
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 11,
                        BaseProficiency = 4,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.ExtraAttack
                        },
                    },
                    #endregion

                    #region 12th Level
                    //12th +4 Ability Score   Improvement
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 12,
                        BaseProficiency = 4,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.AbilityScoreImprovement
                        },
                    },
                    #endregion

                    #region 13th Level
                    //13th +5 Indomitable(two uses)
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 13,
                        BaseProficiency = 5,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.Indomitable
                        },
                    },
                    #endregion

                    #region 14th Level
                    //14th +5 Ability Score   Improvement
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 14,
                        BaseProficiency = 5,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.AbilityScoreImprovement,
                        },
                    },
                    #endregion

                    #region 15th Level
                    //15th +5 Martial Archetype   feature
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 15,
                        BaseProficiency = 5,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.MartialArchetype
                        },
                    },
                    #endregion

                    #region 16th Level
                    //16th +5 Ability Score   Improvement
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 16,
                        BaseProficiency = 5,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.AbilityScoreImprovement
                        },
                    },
                    #endregion

                    #region 17th Level
                    //17th +6 Action Surge(two uses), Indomitable(three uses)
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 17,
                        BaseProficiency = 6,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.ActionSurge,
                            ClassFeatureEnum.Indomitable
                        },
                    },
                    #endregion

                    #region 18th Level
                    //18th +6 Martial Archetype   feature
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 18,
                        BaseProficiency = 6,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.MartialArchetype
                        },
                    },
                    #endregion

                    #region 19th Level
                    //19th +6 Ability Score   Improvement
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 19,
                        BaseProficiency = 6,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.AbilityScoreImprovement
                        },
                    },
                    #endregion

                    #region 20th Level
                    //20th +6 Extra Attack(3)
                    new FighterFeatureLevelEntryViewModel
                    {
                        Level = 20,
                        BaseProficiency = 6,
                        ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                        {
                            ClassFeatureEnum.ExtraAttack
                        },
                    },
                    #endregion
                };
            }
        }
    }
}
