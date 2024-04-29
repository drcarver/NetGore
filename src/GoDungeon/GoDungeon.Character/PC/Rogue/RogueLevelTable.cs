using System.Collections.ObjectModel;

using GoDungeon.Character.Enum;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Character.PC.Rogue;

/// <summary>
/// Life is an endless adventure for those who live by
/// their wits.Ever just one step ahead of danger, rogues
/// bank on their cunning, skill, and charm to bend fate
/// to their favor. Never knowing what to expect, they
/// prepare for everything, becoming masters of a wide
/// variety of skills, training themselves to be adept
/// manipulators, agile acrobats, shadowy stalkers, or
/// masters of any of dozens of other professions or
/// talents.Thieves and gamblers, fast talkers and
/// diplomats, bandits and bounty hunters, and explorers
/// and investigators all might be considered rogues,
/// as well as countless other professions that rely
/// upon wits, prowess, or luck. Although many rogues
/// favor cities and the innumerable opportunities of
/// civilization, some embrace lives on the road, journeying
/// far, meeting exotic people, and facing fantastic danger
/// in pursuit of equally fantastic riches.In the end,
/// any who desire to shape their fates and live life on
/// their own terms might come to be called rogues.
/// </summary>
public class RogueLevelTable : GameTable, IRogueLevelTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    public RogueLevelTable()
    {
        Name = nameof(RogueLevelTable);
        ProperName = "Rogue Features and Proficiencies by Level";
        TableType = TableTypeEnum.CharacterTable;
        Description =
            "Life is an endless adventure for those who live by " +
            "their wits.Ever just one step ahead of danger, rogues " +
             "bank on their cunning, skill, and charm to bend fate " +
            "to their favor. Never knowing what to expect, they prepare " +
            "for everything, becoming masters of a wide variety of skills, " +
            "training themselves to be adept manipulators, agile acrobats, " +
            "shadowy stalkers, or masters of any of dozens of other " +
            "professions or talents. Thieves and gamblers, fast talkers " +
            "and diplomats, bandits and bounty hunters, and explorers " +
            "and investigators all might be considered rogues, as well " +
            "as countless other professions that rely upon wits, prowess, " +
            "or luck. Although many rogues favor cities and the " +
            "innumerable opportunities of civilization, some embrace " +
            "lives on the road, journeying far, meeting exotic people, " +
            "and facing fantastic danger in pursuit of equally fantastic " +
            "riches. In the end, any who desire to shape their fates and " +
            "live life on their own terms might come to be called rogues.";    
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
            //1st +2 1d6 Expertise,	Sneak Attack, Thievesʼ Cant
            new RogueFeatureLevelEntryViewModel
            {
                Level = 1,
                BaseProficiency = 2,
                SneakAttack = "1d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.Expertise,
                    ClassFeatureEnum.SneakAttack,
                    ClassFeatureEnum.ThievesCant
                },
            },
            #endregion

            #region 2nd Level
            //2nd +2 1d6 Cunning Action
            new RogueFeatureLevelEntryViewModel
            {
                Level = 2,
                BaseProficiency = 2,
                SneakAttack = "1d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.CunningAction,
                },
            },
            #endregion

            #region 3rd Level
            //3rd +2 2d6 Roguish Archetype
            new RogueFeatureLevelEntryViewModel
            {
                Level = 3,
                BaseProficiency = 2,
                SneakAttack = "2d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.RoguishArchetype,
                },
            },
            #endregion

            #region 4th Level
            //4th +2 2d6 Ability Score Improvement
            new RogueFeatureLevelEntryViewModel
            {
                Level = 4,
                BaseProficiency = 2,
                SneakAttack = "2d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.AbilityScoreImprovement
                },
            },
            #endregion

            #region 5th Level
            //5th +3 3d6 Uncanny Dodge
            new RogueFeatureLevelEntryViewModel
            {
                Level = 5,
                BaseProficiency = 3,
                SneakAttack = "3d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.UncannyDodge,
                },
            },
            #endregion

            #region 6th Level
            //6th +3 3d6 Expertise
            new RogueFeatureLevelEntryViewModel
            {
                Level = 6,
                BaseProficiency = 3,
                SneakAttack = "3d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.Expertise,
                },
            },
            #endregion

            #region 7th Level
            //7th +3 4d6 Evasion
            new RogueFeatureLevelEntryViewModel
            {
                Level = 7,
                BaseProficiency = 3,
                SneakAttack = "4d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.Evasion
                },
            },
            #endregion

            #region 8th Level
            //8th +3 4d6 Ability Score Improvement
            new RogueFeatureLevelEntryViewModel
            {
                Level = 8,
                BaseProficiency = 3,
                SneakAttack = "4d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.AbilityScoreImprovement
                },
            },
            #endregion

            #region 9th Level
            //9th +4 5d6 Roguish Archetype feature
            new RogueFeatureLevelEntryViewModel
            {
                Level = 8,
                BaseProficiency = 4,
                SneakAttack = "5d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.RoguishArchetype
                },
            },
            #endregion

            #region 10th Level
            //10th +4 5d6 Ability Score Improvement
            new RogueFeatureLevelEntryViewModel
            {
                Level = 10,
                BaseProficiency = 4,
                SneakAttack = "5d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.AbilityScoreImprovement
                },
            },
            #endregion

            #region 11th Level
            //11th +4 6d6 Reliable Talent
            new RogueFeatureLevelEntryViewModel
            {
                Level = 11,
                BaseProficiency = 4,
                SneakAttack = "6d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.ReliableTalent
                },
            },
            #endregion

            #region 12th Level
            //12th +4 6d6 Ability Score Improvement
            new RogueFeatureLevelEntryViewModel
            {
                Level = 12,
                BaseProficiency = 4,
                SneakAttack = "6d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.AbilityScoreImprovement
                },
            },
            #endregion

            #region 13th Level
            //13th +5 7d6 Roguish Archetype feature
            new RogueFeatureLevelEntryViewModel
            {
                Level = 13,
                BaseProficiency = 5,
                SneakAttack = "7d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.RoguishArchetype
                },
            },
            #endregion

            #region 14th Level
            //14th +5 7d6 Blindsense
            new RogueFeatureLevelEntryViewModel
            {
                Level = 14,
                BaseProficiency = 5,
                SneakAttack = "7d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.Blindsense,
                },
            },
            #endregion

            #region 15th Level
            //15th +5 8d6 Slippery Mind
            new RogueFeatureLevelEntryViewModel
            {
                Level = 15,
                BaseProficiency = 5,
                SneakAttack = "8d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.SlipperyMind
                },
            },
            #endregion

            #region 16th Level
            //16th +5 8d6 Ability Score Improvement
            new RogueFeatureLevelEntryViewModel
            {
                Level = 16,
                BaseProficiency = 5,
                SneakAttack = "8d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.AbilityScoreImprovement
                },
            },
            #endregion

            #region 17th Level
            //17th +6 9d6 Roguish Archetype feature
            new RogueFeatureLevelEntryViewModel
            {
                Level = 17,
                BaseProficiency = 6,
                SneakAttack = "9d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.RoguishArchetype
                },
            },
            #endregion

            #region 18th Level
            //18th +6 9d6 Elusive
            new RogueFeatureLevelEntryViewModel
            {
                Level = 18,
                BaseProficiency = 6,
                SneakAttack = "9d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.Elusive
                },
            },
            #endregion

            #region 19th Level
            //19th +6 10d6 Ability Score Improvement
            new RogueFeatureLevelEntryViewModel
            {
                Level = 19,
                BaseProficiency = 6,
                SneakAttack = "10d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.AbilityScoreImprovement
                },
            },
            #endregion

            #region 20th Level
            //20th +6 10d6 Stroke of  Luck
            new RogueFeatureLevelEntryViewModel
            {
                Level = 20,
                BaseProficiency = 6,
                SneakAttack = "10d6",
                ClassFeatures = new ObservableCollection<ClassFeatureEnum>
                {
                    ClassFeatureEnum.StrokeofLuck
                },
            },
            #endregion
        };
    }
}
