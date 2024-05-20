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
    public class RulerStatusTable : RandomTable, IRulerStatusTable
    {
        /// <summary>
        /// </summary>
        public RulerStatusTable()
        {
            Name = nameof(RulerStatusTable);
            ProperName = "Ruler's Status Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "Ruler's Status Table";
        }

        //RULER'S STATUS
        //d20 Ruler
        //1-5 Respected, fair, and just
        //6-8 Feared tyrant
        //9 Weakling manipulated by others
        //10 Illegitimate ruler, simmering civil war
        //11 Ruled or controlled by a powerful monster
        //12 Mysterious, anonymous cabal
        //13 Contested leadership, open fighting
        //14 Cabal seized power openly
        //15 Doltish lout
        //16 On deathbed, claimants compete for power
        //17-18 Iron-willed but respected
        //19-20 Religious leader 
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
                    #region 1-5 Respected, fair, and just
                    //1-5 Respected, fair, and just
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 05),
                        Name = nameof(RulerStatusEnum.Respected),
                        ProperName = "Respected, fair, and just",
                        Description = "Respected, fair, and just",
                    },
                    #endregion

                    #region 6-8 Feared tyrant
                    //6-8 Feared tyrant
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 08),
                        Name = nameof(RulerStatusEnum.FearedTyrant),
                        ProperName = "Feared tyrant",
                        Description = "Feared tyrant",
                    },
                    #endregion

                    #region 9 Weakling manipulated by others
                    //9 Weakling manipulated by others
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(RulerStatusEnum.Weakling),
                        ProperName = "Weakling",
                        Description = "Weakling manipulated by others",
                    },
                    #endregion

                    #region 10 Illegitimate ruler, simmering civil war
                    //10 Illegitimate ruler, simmering civil war
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(RulerStatusEnum.IllegitimateRuler),
                        ProperName = "Illegitimate Ruler",
                        Description = "Illegitimate ruler, simmering civil war",
                    },
                    #endregion

                    #region 11 Ruled or controlled by a powerful monster
                    //11 Ruled or controlled by a powerful monster
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(RulerStatusEnum.Monster),
                        ProperName = "Monster",
                        Description = "Ruled or controlled by a powerful monster",
                    },
                    #endregion

                    #region 12 Mysterious, anonymous cabal
                    //12 Mysterious, anonymous cabal
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(RulerStatusEnum.MysteriousCabal),
                        ProperName = "Mysterious Cabal",
                        Description = "Mysterious, anonymous cabal",
                    },
                    #endregion

                    #region 13 Contested leadership, open fighting
                    //13 Contested leadership, open fighting
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(RulerStatusEnum.ContestedLeadership),
                        ProperName = "Contested leadership",
                        Description = "Contested leadership, open fighting",
                    },
                    #endregion

                    #region 14 Cabal seized power openly
                    //14 Cabal seized power openly
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(RulerStatusEnum.Cabal),
                        ProperName = "Cabal seized power openly",
                        Description = "Cabal seized power openly",
                    },
                    #endregion

                    #region 15 Doltish lout
                    //15 Doltish lout
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(RulerStatusEnum.DoltishLout),
                        ProperName = "Doltish lout",
                        Description = "Doltish lout",
                    },
                    #endregion

                    #region 16 On deathbed, claimants compete for power
                    //16 On deathbed, claimants compete for power
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(RulerStatusEnum.OnDeathbed),
                        ProperName = "On deathbed",
                        Description = "On deathbed, claimants compete for power",
                    },
                    #endregion

                    #region 17-18 Iron-willed but respected
                    //17-18 Iron-willed but respected
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 18),
                        Name = nameof(RulerStatusEnum.IronWilled),
                        ProperName = "Iron-willed",
                        Description = "Iron-willed but respected",
                    },
                    #endregion

                    #region 19-20 Religious leader
                    //19-20 Religious leader
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 20),
                        Name = nameof(RulerStatusEnum.ReligiousLeader),
                        ProperName = "Religious leader",
                        Description = "Religious leader",
                    },
                    #endregion
                };
            }
        }
    }

}
