using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;

using D20.Character.Enum;
using D20.Core.Enum;
using D20.Core.Models;

using Microsoft.Maui.Controls;

using NetGore.Core.Models;

namespace D20.Character.PC.Druid;

public class DruidLevelTable : NamedTable, IDruidLevelTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public DruidLevelTable()
    {
        Name = nameof(DruidLevelTable);
        ProperName = "Druid Features and Proficiencies by Level";
        TableType = TableTypeEnum.CharacterTable;
        Description =
            "Druids come by their primal power in various ways. " +
            "One druid might receive her power from an elemental " +
            "creature, and another might learn it from a beast " +
            "or the fey.";
    }

    //The Druid
    //Proficiency Cantrips ̶Spell Slots   per Spell   Level̶
    //Level Bonus Features Known 1st 2nd 3rd 4th 5th 6th 7th 8th 9th
    //1st +2 Druidic,	Spellcasting 2 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
    //2nd +2 Wild Shape, Druid   Circle 2 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
    //3rd +2 ̶ 2 4 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶
    //4th +2 Wild Shape improvement, Ability Score Improvement 3 4 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶
    //5th +3 ̶ 3 4 3 2 ̶ ̶ ̶ ̶ ̶ ̶
    //6th +3 Druid Circle  feature 3 4 3 3 ̶ ̶ ̶ ̶ ̶ ̶
    //7th +3 ̶ 3 4 3 3 1 ̶ ̶ ̶ ̶ ̶
    //8th +3 Wild Shape   improvement, Ability Score Improvement 3 4 3 3 2 ̶ ̶ ̶ ̶ ̶
    //9th +4 ̶ 3 4 3 3 3 1 ̶ ̶ ̶ ̶
    //10th +4 Druid Circle  feature 4 4 3 3 3 2 ̶ ̶ ̶ ̶
    //11th +4 ̶ 4 4 3 3 3 2 1 ̶ ̶ ̶
    //12th +4 Ability Score   Improvement 4 4 3 3 3 2 1 ̶ ̶ ̶
    //13th +5 ̶ 4 4 3 3 3 2 1 1 ̶ ̶
    //14th +5 Druid Circle  feature 4 4 3 3 3 2 1 1 ̶ ̶
    //15th +5 ̶ 4 4 3 3 3 2 1 1 1 ̶
    //16th +5 Ability Score   Improvement 4 4 3 3 3 2 1 1 1 ̶
    //17th +6 ̶ 4 4 3 3 3 2 1 1 1 1
    //18th +6 Timeless Body, Beast   Spells 4 4 3 3 3 3 1 1 1 1
    //19th +6 Ability Score   Improvement 4 4 3 3 3 3 2 1 1 1
    //20th +6 Archdruid 4 4 3 3 3 3 2 2 1 1
    /// <summary>
    /// Initialize the game table.  This is a separate method 
    /// so we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region 1st Level
            //1st +2 Druidic, Spellcasting 2 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 1,
                BaseProficiency = 2,
                CantripsKnown = 2,
                SpellSlots = [2, 2, 0, 0, 0, 0, 0, 0, 0, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.Spellcasting,
                    ClassFeatureEnum.Druidic
                ],
            },
            #endregion

            #region 2nd Level
            //2nd +2 Wild Shape, Druid Circle 2 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 2,
                BaseProficiency = 2,
                CantripsKnown = 2,
                SpellSlots = [2, 3, 0, 0, 0, 0, 0, 0, 0, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.WildShape,
                    ClassFeatureEnum.DruidCircle
                ],
            },
            #endregion

            #region 3rd Level
            //3rd +2 ̶ 2 4 2 ̶ ̶ ̶ ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 3,
                BaseProficiency = 2,
                CantripsKnown = 2,
                SpellSlots = [2, 4, 2, 0, 0, 0, 0, 0, 0, 0],
                ClassFeatures =
                [
                ],
            },
            #endregion

            #region 4th Level
            //4th +2 Wild Shape improvement, Ability Score Improvement 3 4 3 ̶ ̶ ̶ ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 4,
                BaseProficiency = 2,
                CantripsKnown = 3,
                SpellSlots = [3, 4, 3, 0, 0, 0, 0, 0, 0, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.WildShapeImprovement,
                    ClassFeatureEnum.AbilityScoreImprovement
                ],
            },
            #endregion

            #region 5th Level
            //5th +3 ̶ 3 4 3 2 ̶ ̶ ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 5,
                BaseProficiency = 3,
                CantripsKnown = 3,
                SpellSlots = [3, 4, 3, 2, 0, 0, 0, 0, 0, 0],
                ClassFeatures =
                [
                ],
            },
            #endregion

            #region 6th Level
            //6th +3 Druid Circle  feature 3 4 3 3 ̶ ̶ ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 6,
                BaseProficiency = 3,
                CantripsKnown = 2,
                SpellSlots = [3, 4, 3, 3, 0, 0, 0, 0, 0, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.DruidCircleFeature,
                ],
            },
            #endregion

            #region 7th Level
            //7th +3 ̶ 3 4 3 3 1 ̶ ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 7,
                BaseProficiency = 3,
                CantripsKnown = 3,
                SpellSlots = [3, 4, 3, 3, 0, 0, 0, 0, 0, 0],
                ClassFeatures =
                [
                ],
            },
            #endregion

            #region 8th Level
            //8th +3 Wild Shape improvement, Ability Score Improvement 3 4 3 3 2 ̶ ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 8,
                BaseProficiency = 3,
                CantripsKnown = 3,
                SpellSlots = [3, 4, 3, 3, 2, 0, 0, 0, 0, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.WildShapeImprovement,
                    ClassFeatureEnum.AbilityScoreImprovement
                ],
            },
            #endregion

            #region 9th Level
            //9th +4 ̶ 3 4 3 3 3 1 ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 8,
                BaseProficiency = 4,
                CantripsKnown = 3,
                SpellSlots = [3, 4, 3, 3, 3, 1, 0, 0, 0, 0],
                ClassFeatures =
                [
                ],
            },
            #endregion

            #region 10th Level
            //10th +4 Druid Circle  feature 4 4 3 3 3 2 ̶ ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 10,
                BaseProficiency = 4,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 2, 0, 0, 0, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.DruidCircleFeature,
                ],
            },
            #endregion

            #region 11th Level
            //11th +4 ̶ 4 4 3 3 3 2 1 ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 11,
                BaseProficiency = 4,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 2, 1, 0, 0, 0],
                ClassFeatures =
                [
                ],
            },
            #endregion

            #region 12th Level
            //12th +4 Ability Score Improvement 4 4 3 3 3 2 1 ̶ ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 12,
                BaseProficiency = 4,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 2, 1, 0, 0, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.AbilityScoreImprovement
                ],
            },
            #endregion

            #region 13th Level
            //13th +5 ̶ 4 4 3 3 3 2 1 1 ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 13,
                BaseProficiency = 5,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 0, 0],
                ClassFeatures =
                [
                ],
            },
            #endregion

            #region 14th Level
            //14th +5 Druid Circle feature 4 4 3 3 3 2 1 1 ̶ ̶
            new DruidFeatureLevelEntry
            {
                Level = 14,
                BaseProficiency = 5,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 0, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.DruidCircleFeature,
                ],
            },
            #endregion

            #region 15th Level
            //15th +5 ̶ 4 4 3 3 3 2 1 1 1 ̶
            new DruidFeatureLevelEntry
            {
                Level = 15,
                BaseProficiency = 5,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 1, 0],
                ClassFeatures =
                [
                ],
            },
            #endregion

            #region 16th Level
            //16th +5 Ability Score Improvement 4 4 3 3 3 2 1 1 1 ̶
            new DruidFeatureLevelEntry
            {
                Level = 16,
                BaseProficiency = 5,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 1, 0],
                ClassFeatures =
                [
                    ClassFeatureEnum.AbilityScoreImprovement
                ],
            },
            #endregion

            #region 17th Level
            //17th +6 ̶ 4 4 3 3 3 2 1 1 1 1
            new DruidFeatureLevelEntry
            {
                Level = 17,
                BaseProficiency = 6,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 2, 1, 1, 1, 1],
                ClassFeatures =
                [
                    ClassFeatureEnum.SongofRest
                ],
            },
            #endregion

            #region 18th Level
            //18th +6 Timeless Body, Beast   Spells 4 4 3 3 3 3 1 1 1 1
            new DruidFeatureLevelEntry
            {
                Level = 18,
                BaseProficiency = 6,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 3, 1, 1, 1, 1],
                ClassFeatures =
                [
                    ClassFeatureEnum.TimelessBody,
                    ClassFeatureEnum.BeastSpells
                ],
            },
            #endregion

            #region 19th Level
            //19th +6 Ability Score Improvement 4 4 3 3 3 3 2 1 1 1
            new DruidFeatureLevelEntry
            {
                Level = 19,
                BaseProficiency = 6,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 3, 2, 1, 1, 1],
                ClassFeatures =
                [
                    ClassFeatureEnum.AbilityScoreImprovement
                ],
            },
            #endregion

            #region 20th Level
            //20th +6 Archdruid 4 4 3 3 3 3 2 2 1 1
            new DruidFeatureLevelEntry
            {
                Level = 20,
                BaseProficiency = 6,
                CantripsKnown = 4,
                SpellSlots = [4, 4, 3, 3, 3, 3, 2, 2, 1, 1],
                ClassFeatures =
                [
                    ClassFeatureEnum.Archdruid
                ],
            },
            #endregion
        ];
    }
}
