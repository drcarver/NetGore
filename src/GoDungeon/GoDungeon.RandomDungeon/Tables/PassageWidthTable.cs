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
    public class PassageWidthTable : RandomTable, IPassageWidthTable
    {
        /// <summary>
        /// When generating passages and corridors, roll on the Passage table multiple 
        /// times, extending the length and branches of any open passage on the map
        /// until you arrive at a door or chamber.  Whenever you create a new passage, 
        /// roll to determine its width. If the passage branches from another
        /// passage roll a d12 on the Passage Width table. If it comes from a chamber, 
        /// roll a d20 on that table, but the width of the passage must be at least 
        /// 5 feet smaller than the longest dimension of the chamber.
        /// </summary>
        public PassageWidthTable()
        {
            Name = nameof(PassageWidthTable);
            ProperName = "Passage Width Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description =
                "If the passage branches from another passage roll a d12 on the Passage Width table. If it comes from a chamber, roll a d20 on that table, but the width of the passage must be at least 5 feet smaller than the longest dimension of the chamber.";
        }

        /// PASSAGE WIDTH
        /// d20 Width
        /// 1-2  5 ft.
        /// 3-12  10 ft.
        /// 13-14  20 ft.
        /// 15-16  30 ft.
        /// 17  40 ft., with row of pillars down the middle
        /// 18  40 ft., with double row of pillars
        /// 19  40 ft.wide, 20 ft.high
        /// 20   40 ft.wide, 20 ft.high, gallery 10 ft.above floor
        /// allows access to level above
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
                    #region 1-2  5 ft.
                    // 1-2  5 ft.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 02),
                        Name = nameof(PassageWidthEnum.ft5),
                        ProperName = "5 ft.",
                        Description = "5 ft."
                    },
                    #endregion

                    #region 3-12  10 ft.
                    // 3-12  10 ft.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 12),
                        Name = nameof(PassageWidthEnum.ft10),
                        ProperName = "10 ft.",
                        Description = "10 ft."
                    },
                    #endregion

                    #region 13-14  20 ft
                    // 13-14  20 ft
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 14),
                        Name = nameof(PassageWidthEnum.ft20),
                        ProperName = "20 ft.",
                        Description = "20 ft."
                    },
                    #endregion

                    #region 15-16  20 ft
                    // 15-16  30 ft
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 16),
                        Name = nameof(PassageWidthEnum.ft30),
                        ProperName = "30 ft.",
                        Description = "30 ft."
                    },
                    #endregion

                    #region 17  40 ft., with row of pillars down the middle
                    // 17  40 ft., with row of pillars down the middle
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(PassageWidthEnum.ft40Pillars),
                        ProperName = "40 ft., with pillars",
                        Description = "40 ft., with row of pillars down the middle"
                    },
                    #endregion

                    #region 18  40 ft., with double row of pillars
                    // 18  40 ft., with double row of pillars
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(PassageWidthEnum.ft40DoublePillars),
                        ProperName = "40 ft., double pillars",
                        Description = "40 ft., with double row of pillars"
                    },
                    #endregion

                    #region 19  40 ft.wide, 20 ft.high
                    //19  40 ft.wide, 20 ft.high
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(PassageWidthEnum.ft40Wide20ftHigh),
                        ProperName = "40 ft.wide, 20 ft.high",
                        Description = "40 ft.wide, 20 ft.high"
                    },
                    #endregion

                    #region 20   40 ft.wide, 20 ft.high, gallery 10 ft.above floor
                    //20   40 ft.wide, 20 ft.high, gallery 10 ft.above floor
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(PassageWidthEnum.ft40WideGallery),
                        ProperName = "40 ft.wide, with gallery",
                        Description = "40 ft.wide, 20 ft.high, gallery 10 ft.above floor"
                    },
                    #endregion
                };
            }
        }
    }
}
