using System;
using System.Collections.ObjectModel;
using System.Linq;

using GoDungeon.Character.Interfaces;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Character.Tables
{
    /// <summary>
    /// Beyond 1st Level
    /// </summary>
    public class CharacterAdvancementTable : NamedTable, ICharacterAdvancementTable
    {
        /// <summary>
        /// Determine the character advancement.
        /// </summary>
        public CharacterAdvancementTable()
        {
            Name = nameof(CharacterAdvancementTable);
            ProperName = "Character Advancement Table";
            Description = "As your character goes on " +
                "adventures and  overcomes challenges, " +
                "they gain experience,  represented by " +
                "experience points. A character who  " +
                "reaches a specified experience point " +
                "total advances  in capability. This " +
                "advancement is called gaining a  level";
            TableType = TableTypeEnum.CharacterTable;
        }

        /// <summary>
        /// Get a entry from the table by it's experience points
        /// </summary>
        /// <returns>The selected CharacterAdvancementEntryViewModel.</returns>
        public ICharacterAdvancementEntry GetEntryByExperiencePoints(int number)
        {
            var te = Table.Cast<ICharacterAdvancementEntry>()
                .First(t =>
                            t.ExperiencePoints.Start.Value <= number
                        &&  t.ExperiencePoints.End.Value >= number);
            return te;
        }

        //Character Advancement
        //Experience Points Level Proficiency Bonus
        //0 1 +2
        //300 2 +2
        //900 3 +2
        //2,700 4 +2
        //6,500 5 +3
        //14,000 6 +3
        //23,000 7 +3
        //34,000 8 +3
        //48,000 9 +4
        //64,000 10 +4
        //85,000 11 +4
        //100,000 12 +4
        //120,000 13 +5
        //140,000 14 +5
        //165,000 15 +5
        //195,000 16 +5
        //225,000 17 +6
        //265,000 18 +6
        //305,000 19 +6
        //355,000 20 +6
        /// <summary>
        /// Initialize the game table.  This is a separate method so 
        /// we can create a game table for it's meta properties
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
                    //0-299 1 +2
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(0, 299),
                        ProficiencyBonus = 2,
                        Level = 1,
                    },
                    #endregion

                    #region 2nd Level
                    //300-899 2 +2
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(300, 899),
                        ProficiencyBonus = 2,
                        Level = 2,
                    },
                    #endregion

                    #region 3rd Level
                    //900-2699 3 +2
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(900, 2699),
                        ProficiencyBonus = 2,
                        Level = 3,
                    },
                    #endregion

                    #region 4th Level
                    //2700-6499 4 +2
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(2700, 6499),
                        ProficiencyBonus = 2,
                        Level = 4,
                    },
                    #endregion

                    #region 5th Level
                    //6500-13999 5 +3
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(6500, 13999),
                        ProficiencyBonus = 3,
                        Level = 5,
                    },
                    #endregion

                    #region 6th Level
                    //14000-22999 6 +3
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(14000, 22999),
                        ProficiencyBonus = 3,
                        Level = 6,
                    },
                    #endregion

                    #region 7th Level
                    //23000-33999 7 +3
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(23000, 33999),
                        ProficiencyBonus = 3,
                        Level = 7,
                    },
                    #endregion

                    #region 8th Level
                    //34000-47999 8 +3
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(34000, 47999),
                        ProficiencyBonus = 3,
                        Level = 8,
                    },
                    #endregion

                    #region 9th Level
                    //48000-63999 9 +4
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(48000, 63999),
                        ProficiencyBonus = 4,
                        Level = 9,
                    },
                    #endregion

                    #region 10th Level
                    //64000-85999 10 +4
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(64000, 84999),
                        ProficiencyBonus = 4,
                        Level = 10,
                    },
                    #endregion

                    #region 11th Level
                    //85000-99999 11 +4
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(85000, 99999),
                        ProficiencyBonus = 4,
                        Level = 11,
                    },
                    #endregion

                    #region 12th Level
                    //100,000-119999 12 +4
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(100000, 119999),
                        ProficiencyBonus = 4,
                        Level = 12,
                    },
                    #endregion

                    #region 13th Level
                    //120,000-139,999 13 +5
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(120000, 139999),
                        ProficiencyBonus = 5,
                        Level = 13,
                    },
                    #endregion

                    #region 14th Level
                    //140,000-164,999 14 +5
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(140000, 164999),
                        ProficiencyBonus = 5,
                        Level = 14,
                    },
                    #endregion

                    #region 15th Level
                    //165,000-194,999 15 +5
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(165000, 194999),
                        ProficiencyBonus = 5,
                        Level = 15,
                    },
                    #endregion

                    #region 16th Level
                    //195,000-224,999 16 +5
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(195000, 224999),
                        ProficiencyBonus = 5,
                        Level = 16,
                    },
                    #endregion

                    #region 17th Level
                    //225000-264999 16 +5
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(225000, 264999),
                        ProficiencyBonus = 6,
                        Level = 17,
                    },
                    #endregion

                    #region 18th Level
                    //265000-304999 18 +6
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(265000, 304999),
                        ProficiencyBonus = 6,
                        Level = 18,
                    },
                    #endregion

                    #region 19th Level
                    //305,000-304999 19 +6
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(305000, 354999),
                        ProficiencyBonus = 6,
                        Level = 19,
                    },
                    #endregion

                    #region 20th Level
                    //355000-int.MaxValue 20 +6
                    new CharacterAdvancementEntryViewModel
                    {
                        ExperiencePoints = new Range(355000, int.MaxValue),
                        ProficiencyBonus = 6,
                        Level = 20,
                    },
                    #endregion
                };
            }
        }
    }
}
