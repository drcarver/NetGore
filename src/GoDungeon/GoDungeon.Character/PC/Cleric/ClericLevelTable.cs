using System.Collections.ObjectModel;

using GoDungeon.Character.Enum;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Character.PC.Cleric
{
    public class ClericLevelTable : GameTable, IClericLevelTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ClericLevelTable()
        {
            Name = nameof(ClericLevelTable);
            ProperName = "Cleric Features and Proficiencies by Level";
            TableType = TableTypeEnum.CharacterTable;
            Description =
                "Clerics are not merely people of religious " +
                "faith—they are devoted servants who wield true " +
                "divine power from their deities. The particular " +
                "path that steers a cleric toward her faith can " +
                "mean the difference between a demon-worshiping " +
                "cultist and a lawful harbinger of her deity’s " +
                "blessed faith.";
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
                //1st +2 Spellcasting,	Divine Domain 3 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 1,
                    BaseProficiency = 2,
                    CantripsKnown = 3,
                    SpellSlots = [3, 2, 0, 0, 0, 0, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.Spellcasting,
                        ClassFeatureEnum.DivineDomain
                    },
                },
                #endregion

                #region 2nd Level
                //2nd +2 Channel Divinity(1/rest),	Divine Domain feature
                //3 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 2,
                    BaseProficiency = 2,
                    CantripsKnown = 3,
                    SpellSlots = [3, 3, 0, 0, 0, 0, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.ChannelDivinity,
                        ClassFeatureEnum.DivineDomain
                    },
                },
                #endregion

                #region 3rd Level
                //3rd +2 ̶ 3 4 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 3,
                    BaseProficiency = 2,
                    CantripsKnown = 3,
                    SpellSlots = [3, 4, 2, 0, 0, 0, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                    },
                },
                #endregion

                #region 4th Level
                //4th +2 Ability Score Improvement 4 4 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 4,
                    BaseProficiency = 2,
                    CantripsKnown = 4,
                    SpellSlots = [4, 4, 3, 0, 0, 0, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 5th Level
                //5th +3 Destroy Undead(CR 1/2) 4 4 3 2 ̶ ̶ ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 5,
                    BaseProficiency = 3,
                    CantripsKnown = 4,
                    SpellSlots = [4, 4, 3, 2, 0, 0, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.DestroyUndead,
                    },
                },
                #endregion

                #region 6th Level
                //6th +3 Channel Divinity(2/rest),	Divine Domain feature
                //4 4 3 3 ̶ ̶ ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 6,
                    BaseProficiency = 4,
                    CantripsKnown = 4,
                    SpellSlots = [4, 4, 3, 3, 0, 0, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.ChannelDivinity,
                        ClassFeatureEnum.DivineDomain,
                    },
                },
                #endregion

                #region 7th Level
                //7th +3 ̶ 4 4 3 3 1 ̶ ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 7,
                    BaseProficiency = 3,
                    CantripsKnown = 4,
                    SpellSlots = [4, 4, 3, 3, 1, 0, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                    },
                },
                #endregion

                #region 8th Level
                //8th +3 Ability Score Improvement, Destroy Undead (CR 1), Divine Domain feature
                //4 4 3 3 2 ̶ ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 8,
                    BaseProficiency = 3,
                    CantripsKnown = 4,
                    SpellSlots = [4, 4, 3, 3, 2, 0, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement,
                        ClassFeatureEnum.DestroyUndead,
                        ClassFeatureEnum.DivineDomain
                    },
                },
                #endregion

                #region 9th Level
                //9th +4 ̶ 4 4 3 3 3 1 ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 8,
                    BaseProficiency = 4,
                    CantripsKnown = 4,
                    SpellSlots = [4, 4, 3, 3, 3, 1, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.SongofRest
                    },
                },
                #endregion

                #region 10th Level
                //10th +4 Divine Intervention 5 4 3 3 3 2 ̶ ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 10,
                    BaseProficiency = 4,
                    CantripsKnown = 4,
                    SpellSlots = [5, 4, 3, 3, 3, 2, 0, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.DivineIntervention,
                    },
                },
                #endregion

                #region 11th Level
                //11th +4 Destroy Undead(CR 2) 5 4 3 3 3 2 1 ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 11,
                    BaseProficiency = 4,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 2, 1, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.DestroyUndead,
                    },
                },
                #endregion

                #region 12th Level
                //12th +4 Ability Score   Improvement 5 4 3 3 3 2 1 ̶ ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 12,
                    BaseProficiency = 4,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 2, 1, 0, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 13th Level
                //13th +5 ̶ 5 4 3 3 3 2 1 1 ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 13,
                    BaseProficiency = 5,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 2, 1, 1, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                    },
                },
                #endregion

                #region 14th Level
                //14th +5 Destroy Undead(CR 3) 5 4 3 3 3 2 1 1 ̶ ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 14,
                    BaseProficiency = 5,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 2, 1, 1, 0, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.DestroyUndead,
                    },
                },
                #endregion

                #region 15th Level
                //15th +5 ̶ 5 4 3 3 3 2 1 1 1 ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 15,
                    BaseProficiency = 5,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 2, 1, 1, 1, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                    },
                },
                #endregion

                #region 16th Level
                //16th +5 Ability Score Improvement 5 4 3 3 3 2 1 1 1 ̶
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 16,
                    BaseProficiency = 5,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 2, 1, 1, 1, 0 ],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 17th Level
                //17th +6 Destroy Undead(CR 4),	Divine Domain feature
                //5 4 3 3 3 2 1 1 1 1
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 17,
                    BaseProficiency = 6,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 2, 1, 1, 1, 1],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.DestroyUndead,
                        ClassFeatureEnum.DivineDomain
                    },
                },
                #endregion

                #region 18th Level
                //18th +6 Channel Divinity(3/rest) 5 4 3 3 3 3 1 1 1 1
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 18,
                    BaseProficiency = 6,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 3, 1, 1, 1, 1],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.ChannelDivinity
                    },
                },
                #endregion

                #region 19th Level
                //19th +6 Ability Score Improvement 5 4 3 3 3 3 2 1 1 1
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 19,
                    BaseProficiency = 6,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 3, 2, 1, 1, 1],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.AbilityScoreImprovement
                    },
                },
                #endregion

                #region 20th Level
                //20th +6 Divine Intervention improvement
                //5 4 3 3 3 3 2 2 1 1
                new ClericFeatureLevelEntryViewModel
                {
                    Level = 20,
                    BaseProficiency = 6,
                    CantripsKnown = 5,
                    SpellSlots = [5, 4, 3, 3, 3, 3, 2, 2, 1, 1],
                    ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                    {
                        ClassFeatureEnum.DivineIntervention
                    },
                },
                #endregion
            };
        }
    }
}
