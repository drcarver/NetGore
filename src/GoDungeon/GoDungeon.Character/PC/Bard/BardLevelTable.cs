using System.Collections.ObjectModel;

using GoDungeon.Character.Enum;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Character.PC.Bard
{
    public class BardLevelTable : GameTable, IBardLevelTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BardLevelTable()
        {
            Name = nameof(BardLevelTable);
            ProperName = "Bard Features and Proficiencies by Level";
            TableType = TableTypeEnum.CharacterTable;
            Description =
                "Bards have a talent for song and story, and they " +
                "come to their careers by developing this talent " +
                "as they pick up on a smattering of other skills.";
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method so 
        /// we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region 1st Level
                //1st +2 Spellcasting, Bardic Inspiration (d6)
                new BardFeatureLevelEntryViewModel
                {
                    Level = 1,
                    BaseProficiency = 2,
                    SpellsKnown = 4,
                    CantripsKnown = 2,
                    SpellSlots = new int[] {2, 2, 0, 0, 0, 0, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.Spellcasting,
                        ClassFeatureEnum.BardicInspiration
                    },
                },
                #endregion

                #region 2nd Level
                //2nd +2 Jack of  All Trades, Song of Rest (d6)
                //2 5 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 2,
                    BaseProficiency = 2,
                    CantripsKnown = 2,
                    SpellsKnown = 5,
                    SpellSlots = new int[] {2, 3, 0, 0, 0, 0, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.JackofAllTrades,
                        ClassFeatureEnum.SongofRest
                    },
                },
                #endregion

                #region 3rd Level
                //3rd +2 Bard College,    Expertise 2 6 4 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 3,
                    BaseProficiency = 2,
                    CantripsKnown = 2,
                    SpellsKnown = 6,
                    SpellSlots = new int[] {2, 4, 2, 0, 0, 0, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.BardCollege,
                        ClassFeatureEnum.Expertise,
                    },
                },
                #endregion

                #region 4th Level
                //4th +2 Ability  Score   Improvement 3 7 4 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 4,
                    BaseProficiency = 2,
                    CantripsKnown = 3,
                    SpellsKnown = 7,
                    SpellSlots = new int[] {3, 4, 3, 0, 0, 0, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 5th Level
                //5th +3 Bardic Inspiration (d8), Font of Inspiration
                //3 8 4 3 2 ̶ ̶ ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 5,
                    BaseProficiency = 3,
                    CantripsKnown = 3,
                    SpellsKnown = 8,
                    SpellSlots = new int[] {3, 4, 3, 2, 0, 0, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.BardicInspiration,
                        ClassFeatureEnum.FontofInspiration,
                    },
                },
                #endregion

                #region 6th Level
                //6th +3 Countercharm, Bard College feature
                //3 9 4 3 3 ̶ ̶ ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 6,
                    BaseProficiency = 3,
                    CantripsKnown = 2,
                    SpellsKnown = 9,
                    SpellSlots = new int[] {3, 4, 3, 3, 0, 0, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.CounterCharm,
                        ClassFeatureEnum.BardCollegeFeature,
                    },
                },
                #endregion

                #region 7th Level
                //7th +3 ̶ 3 10 4 3 3 1 ̶ ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 7,
                    BaseProficiency = 3,
                    CantripsKnown = 3,
                    SpellsKnown = 10,
                    SpellSlots = new int[] {3, 4, 3, 3, 0, 0, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                    },
                },
                #endregion

                #region 8th Level
                //8th +3 Ability Score Improvement 3 11 4 3 3 2 ̶ ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 8,
                    BaseProficiency = 3,
                    CantripsKnown = 3,
                    SpellsKnown = 11,
                    SpellSlots = new int[] {3, 4, 3, 3, 2, 0, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 9th Level
                //9th +4 Song of Rest (d8) 3 12 4 3 3 3 1 ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 8,
                    BaseProficiency = 4,
                    CantripsKnown = 3,
                    SpellsKnown = 12,
                    SpellSlots = new int[] {3, 4, 3, 3, 3, 1, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.SongofRest
                    },
                },
                #endregion

                #region 10th Level
                //10th +4 Bardic Inspiration, Expertise, Magical Secrets
                //4 14 4 3 3 3 2 ̶ ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 10,
                    BaseProficiency = 4,
                    CantripsKnown = 4,
                    SpellsKnown = 14,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 2, 0, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.BardicInspiration,
                        ClassFeatureEnum.Expertise,
                        ClassFeatureEnum.MagicalSecrets
                    },
                },
                #endregion

                #region 11th Level
                //11th +4 ̶ 4 15 4 3 3 3 2 1 ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 11,
                    BaseProficiency = 4,
                    CantripsKnown = 4,
                    SpellsKnown = 15,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 2, 1, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                    },
                },
                #endregion

                #region 12th Level
                //12th +4 Ability Score Improvement 4 15 4 3 3 3 2 1 ̶ ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 12,
                    BaseProficiency = 4,
                    CantripsKnown = 4,
                    SpellsKnown = 15,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 2, 1, 0, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 13th Level
                //13th +5 Song of Rest (d10) 4 16 4 3 3 3 2 1 1 ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 13,
                    BaseProficiency = 5,
                    CantripsKnown = 4,
                    SpellsKnown = 16,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 2, 1, 1, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.SongofRest
                    },
                },
                #endregion

                #region 14th Level
                //14th +5 Magical Secrets, Bard College feature
                //4 18 4 3 3 3 2 1 1 ̶ ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 14,
                    BaseProficiency = 5,
                    CantripsKnown = 4,
                    SpellsKnown = 18,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 2, 1, 1, 0, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.MagicalSecrets,
                        ClassFeatureEnum.BardCollegeFeature
                    },
                },
                #endregion

                #region 15th Level
                //15th +5 Bardic  Inspiration (d12) 4 19 4 3 3 3 2 1 1 1 ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 15,
                    BaseProficiency = 5,
                    CantripsKnown = 4,
                    SpellsKnown = 19,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 2, 1, 1, 1, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.BardicInspiration
                    },
                },
                #endregion

                #region 16th Level
                //16th +5 Ability Score Improvement 4 19 4 3 3 3 2 1 1 1 ̶
                new BardFeatureLevelEntryViewModel
                {
                    Level = 16,
                    BaseProficiency = 5,
                    CantripsKnown = 4,
                    SpellsKnown = 19,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 2, 1, 1, 1, 0},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 17th Level
                //17th +6 Song of Rest (d12) 4 20 4 3 3 3 2 1 1 1 1
                new BardFeatureLevelEntryViewModel
                {
                    Level = 17,
                    BaseProficiency = 6,
                    CantripsKnown = 4,
                    SpellsKnown = 20,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 2, 1, 1, 1, 1},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.SongofRest
                    },
                },
                #endregion

                #region 18th Level
                //18th +6 Magical Secrets 4 22 4 3 3 3 3 1 1 1 1
                new BardFeatureLevelEntryViewModel
                {
                    Level = 18,
                    BaseProficiency = 6,
                    CantripsKnown = 4,
                    SpellsKnown = 22,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 3, 1, 1, 1, 1},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.MagicalSecrets
                    },
                },
                #endregion

                #region 19th Level
                //19th +6 Ability Score Improvement
                //4 22 4 3 3 3 3 2 1 1 1
                new BardFeatureLevelEntryViewModel
                {
                    Level = 19,
                    BaseProficiency = 6,
                    CantripsKnown = 4,
                    SpellsKnown = 22,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 3, 2, 1, 1, 1},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 20th Level
                //20th +6 Superior Inspiration
                //4 22 4 3 3 3 3 2 2 1 1    
                new BardFeatureLevelEntryViewModel
                {
                    Level = 20,
                    BaseProficiency = 6,
                    CantripsKnown = 4,
                    SpellsKnown = 22,
                    SpellSlots = new int[] {4, 4, 3, 3, 3, 3, 2, 2, 1, 1},
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.SuperiorInspiration
                    },
                },
                #endregion
            };
        }
    }
}
