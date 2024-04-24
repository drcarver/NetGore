//using System.Diagnostics.CodeAnalysis;

//using D20.Character.Enum;
//using D20.Core.Enum;
//using D20.Core.Models;

//namespace D20.Character.PC.Monk;

///// <summary>
///// Monks excel at overcoming even the most daunting 
///// perils, striking where it’s least expected, and 
///// taking advantage of enemy vulnerabilities. Fleet 
///// of foot and skilled in combat, monks can navigate 
///// any battlefield with ease, aiding allies wherever 
///// they are needed most.
///// </summary>
//public class MonkLevelTable : GameTable, IMonkLevelTable
//{
//    /// <summary>
//    /// Constructor
//    /// </summary>
//    [SetsRequiredMembers]
//    public MonkLevelTable()
//    {
//        Name = nameof(MonkLevelTable);
//        ProperName = "Monk Features and Proficiencies by Level";
//        TableType = TableTypeEnum.CharacterTable;
//        Description =
//            "Monks excel at overcoming even the most daunting " +
//            "perils, striking where it’s least expected, and " +
//            "taking advantage of enemy vulnerabilities. Fleet " +
//            "of foot and skilled in combat, monks can navigate " +
//            "any battlefield with ease, aiding allies wherever " +
//            "they are needed most.";
//    }

//    /// <summary>
//    /// Initialize the game table.  This is a separate method 
//    /// so we can create a game table for it's meta properties
//    /// with out creating the actual able values.  A bit of 
//    /// optimization to conserve memory on big tables
//    /// </summary>
//    public override void InitializeTable()
//    {
//        Table =
//        [
//            #region 1st Level
//            new MonkFeatureLevelEntry
//            {
//                Level = 1,
//                BaseProficiency = 2,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.Rage,
//                    ClassFeatureEnum.UnarmoredDefense
//                ],
//            },
//            #endregion

//            #region 2nd Level
//            //2nd +2 Reckless Attack, Danger Sense 2 +2
//            new MonkFeatureLevelEntry
//            {
//                Level = 2,
//                BaseProficiency = 2,
//                Rages = 2,
//                RageDamage = 2,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.RecklessAttack,
//                    ClassFeatureEnum.DangerSense
//                ],
//            },
//            #endregion

//            #region 3rd Level
//            //3rd +2 Primal Path 3 +2
//            new MonkFeatureLevelEntry
//            {
//                Level = 3,
//                BaseProficiency = 2,
//                Rages = 3,
//                RageDamage = 2,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.PrimalPath,
//                    ClassFeatureEnum.PathoftheBerserker,
//                    ClassFeatureEnum.Frenzy,
//                ],
//            },
//            #endregion

//            #region 4th Level
//            //4th +2 Ability Score Improvement 3 +2
//            new MonkFeatureLevelEntry
//            {
//                Level = 4,
//                BaseProficiency = 2,
//                Rages = 3,
//                RageDamage = 2,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.AbilityScoreImprovement
//                ],
//            },
//            #endregion

//            #region 5th Level
//            //5th +3 Extra Attack, Fast Movement 3 +2
//            new MonkFeatureLevelEntry
//            {
//                Level = 5,
//                BaseProficiency = 3,
//                Rages = 3,
//                RageDamage = 2,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.ExtraAttack,
//                    ClassFeatureEnum.FastMovement,
//                ],
//            },
//            #endregion

//            #region 6th Level
//            //6th +3 Path feature 4 +2
//            new MonkFeatureLevelEntry
//            {
//                Level = 6,
//                BaseProficiency = 3,
//                Rages = 4,
//                RageDamage = 2,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.MindlessRage
//                ],
//            },
//            #endregion

//            #region 7th Level
//            //7th +3 Feral Instinct 4 +2
//            new MonkFeatureLevelEntry
//            {
//                Level = 7,
//                BaseProficiency = 3,
//                Rages = 4,
//                RageDamage = 2,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.FeralInstinct
//                ],
//            },
//            #endregion

//            #region 8th Level
//            //8th +3 Ability Score Improvement 4 +2
//            new MonkFeatureLevelEntry
//            {
//                Level = 8,
//                BaseProficiency = 3,
//                Rages = 4,
//                RageDamage = 2,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.AbilityScoreImprovement
//                ],
//            },
//            #endregion

//            #region 9th Level
//            //9th +4 Brutal Critical (1	die) 4 +3
//            new MonkFeatureLevelEntry
//            {
//                Level = 8,
//                BaseProficiency = 4,
//                Rages = 4,
//                RageDamage = 3,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.BrutalCritical
//                ],
//            },
//            #endregion

//            #region 10th Level
//            //10th +4 Path feature 4 +3
//            new MonkFeatureLevelEntry
//            {
//                Level = 10,
//                BaseProficiency = 4,
//                Rages = 4,
//                RageDamage = 3,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.IntimidatingPresence
//                ],
//            },
//        #endregion

//            #region 11th Level
//            //11th +4 Relentless	 4 +3
//            new MonkFeatureLevelEntry
//            {
//                Level = 11,
//                BaseProficiency = 4,
//                Rages = 4,
//                RageDamage = 3,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.Relentless
//                ],
//            },
//        #endregion

//            #region 12th Level
//            //12th +4 Ability Score Improvement 5 +3
//            new MonkFeatureLevelEntry
//            {
//                Level = 12,
//                BaseProficiency = 4,
//                Rages = 5,
//                RageDamage = 3,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.AbilityScoreImprovement
//                ],
//            },
//        #endregion

//            #region 13th Level
//            //13th +5 Brutal Critical (2 dice) 5 +3
//            new MonkFeatureLevelEntry
//            {
//                Level = 13,
//                BaseProficiency = 5,
//                Rages = 5,
//                RageDamage = 3,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.BrutalCritical
//                ],
//            },
//            #endregion

//            #region 14th Level
//            //14th +5 Path feature 5 +3
//            new MonkFeatureLevelEntry
//            {
//                Level = 14,
//                BaseProficiency = 5,
//                Rages = 5,
//                RageDamage = 3,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.Retaliation,
//                ],
//            },
//            #endregion

//            #region 15th Level
//            //15th +5 Persistent Rage 5 +3
//            new MonkFeatureLevelEntry
//            {
//                Level = 15,
//                BaseProficiency = 5,
//                Rages = 5,
//                RageDamage = 3,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.PersistentRage
//                ],
//            },
//            #endregion

//            #region 16th Level
//            //16th +5 Ability Score Improvement 5 +4
//            new MonkFeatureLevelEntry
//            {
//                Level = 16,
//                BaseProficiency = 5,
//                Rages = 5,
//                RageDamage = 4,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.AbilityScoreImprovement
//                ],
//            },
//            #endregion

//            #region 17th Level
//            //17th +6 Brutal Critical (3 dice) 6 +4
//            new MonkFeatureLevelEntry
//            {
//                Level = 17,
//                BaseProficiency = 6,
//                Rages = 6,
//                RageDamage = 4,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.BrutalCritical
//                ],
//            },
//            #endregion

//            #region 18th Level
//            // 18th +6 Indomitable Might 6 +4
//            new MonkFeatureLevelEntry
//            {
//                Level = 18,
//                BaseProficiency = 6,
//                Rages = 6,
//                RageDamage = 4,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.IndomitableMight
//                ],
//            },
//            #endregion

//            #region 19th Level
//            //19th +6 Ability Score Improvement 6 +4
//            new MonkFeatureLevelEntry
//            {
//                Level = 19,
//                BaseProficiency = 6,
//                Rages = 6,
//                RageDamage = 4,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.AbilityScoreImprovement
//                ],
//            },
//            #endregion

//            #region 20th Level
//            //20th +6 Primal Champion Unlimited +4
//            new MonkFeatureLevelEntry
//            {
//                Level = 20,
//                BaseProficiency = 6,
//                Rages = 6,
//                RageDamage = 4,
//                ClassFeatures =
//                [
//                    ClassFeatureEnum.PrimalChampionUnlimited
//                ],
//            },
//            #endregion
//        ];
//    }
//}

