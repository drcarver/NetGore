using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.Tables
{
    /// <summary>
    /// </summary>
    public class RaceRelationsTable : RandomTable, IRaceRelationsTable
    {
        /// <summary>
        /// </summary>
        public RaceRelationsTable()
        {
            Name = nameof(RaceRelationsTable);
            ProperName = "Race Relations Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "Race relationship table";
        }

        //RACE RELATIONS
        //d20 Result
        //1-10  Harmony
        //11-14  Tension or rivalry
        //15-16  Racial majority are conquerors
        //17  Racial minority are rulers
        //18  Racial minority are refugees
        //19  Racial majority oppresses minority
        //20  Racial minority oppresses majority
        /// <summary>
        /// Initialize the game table.  This is a separate method so we 
        /// can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region 1-10  Harmony
                    //1-10  Harmony
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 10),
                        Name = nameof(RaceRelationsEnum.Harmony),
                        ProperName = "Harmony",
                        Description = "Harmony",
                    },
                    #endregion

                    #region 11-14  Tension or rivalry
                    //11-14  Tension or rivalry
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 14),
                        Name = nameof(RaceRelationsEnum.Tension),
                        ProperName = "Tension",
                        Description = "Tension or rivalry",
                    },
                    #endregion

                    #region 15-16  Racial majority are conquerors
                    //15-16  Racial majority are conquerors
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 16),
                        Name = nameof(RaceRelationsEnum.MajorityConquerors),
                        ProperName = "Majority are conquerors",
                        Description = "Racial majority are conquerors",
                    },
                    #endregion

                    #region 17  Racial minority are rulers
                    //17  Racial minority are rulers
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(RaceRelationsEnum.MinorityRule),
                        ProperName = "Minority are rulers",
                        Description = "Racial minority are rulers",
                    },
                    #endregion

                    #region 18  Racial minority are refugees
                    //18  Racial minority are refugees
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(RaceRelationsEnum.Refugees),
                        ProperName = "Refugees",
                        Description = "Racial minority are refugees",
                    },
                    #endregion

                    #region 19  Racial majority oppresses minority
                    //19  Racial majority oppresses minority
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(RaceRelationsEnum.MajorityOppressors),
                        ProperName = "Majority Oppressors",
                        Description = "Racial majority oppresses minority",
                    },
                    #endregion

                    #region 20  Racial minority oppresses majority
                    //20  Racial minority oppresses majority
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(RaceRelationsEnum.MinorityOppressors),
                        ProperName = "Minority Oppressors",
                        Description = "Racial minority oppresses majority",
                    },
                    #endregion
                };
            }
        }
    }

}
