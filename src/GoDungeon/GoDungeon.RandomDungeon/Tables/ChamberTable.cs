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
    public class ChamberTable : RandomTable, IChamberTable
    {
        /// <summary>
        /// Whenever a roll on a table indicates a chamber, use the Chamber 
        /// table to define its dimensions.Then roll on the Chamber Exits 
        /// table to determine the number of exits.For each exit, roll on 
        /// the Exit Location and Exit Type tables to determine the
        /// nature and placement of the exit.
        /// </summary>
        public ChamberTable()
        {
            Name = nameof(ChamberTable);
            ProperName = "Chamber Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description =
                "The dungeon chambers";
        }

        //CHAMBER
        //d20  Chamber
        //1-2  Square, 20 x 20 ft.1
        //3-4  Square, 30 x 30 ft.1
        //5-6  Square, 40 x 40 ft.1
        //7-9  Rectangle, 20 x 30 ft.¹
        //10-12  Rectangle, 30 x 40 ft.1
        //13-14  Rectangle, 40 x 50 ft.2
        //15  Rectangle, 50 x 80 ft.²
        //16  Circle, 30 ft.diameter¹
        //17  Circle, 50 ft.diameter2
        //18  Octagon, 40 x 40 ft.2
        //19  Octagon, 60 x 60 ft.2
        //20  Trapezoid, roughly 40 x 60 ft.2
        //¹ Use the Normal Chamber column on the Chamber Exits table.
        //² Use the Large Chamber column on the Chamber Exits table.
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
                    #region 1-2  Square, 20 x 20 ft.
                    //1-2  Square, 20 x 20 ft.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 02),
                        Name = nameof(ChamberEnum.Square20ft),
                        ProperName = "Square, 20 x 20 ft.",
                        Description = "Square, 20 x 20 ft.",
                    },
                    #endregion

                    #region 3-4  Square, 30 x 30 ft.
                    //3-4  Square, 30 x 30 ft.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 04),
                        Name = nameof(ChamberEnum.Square30ft),
                        ProperName = "Square, 30 x 30 ft.",
                        Description = "Square, 30 x 30 ft.",
                    },
                    #endregion

                    #region 5-6  Square, 40 x 40 ft.
                    //5-6  Square, 40 x 40 ft.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 06),
                        Name = nameof(ChamberEnum.Square40ft),
                        ProperName = "Square, 40 x 40 ft.",
                        Description = "Square, 40 x 40 ft.",
                    },
                    #endregion

                    #region 7-9  Rectangle, 20 x 30 ft.¹
                    //7-9  Rectangle, 20 x 30 ft.¹
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 09),
                        Name = nameof(ChamberEnum.Rectangle20x30ft),
                        ProperName = "Rectangle, 20 x 30 ft",
                        Description = "Rectangle, 20 x 30 ft",
                    },
                    #endregion

                    #region 10-12  Rectangle, 30 x 40 ft.1
                    //10-12  Rectangle, 30 x 40 ft.1
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 12),
                        Name = nameof(ChamberEnum.Rectangle30x40ft),
                        ProperName = "Rectangle, 30 x 40 ft",
                        Description = "Rectangle, 30 x 40 ft",
                    },
                    #endregion

                    #region 13-14  Rectangle, 40 x 50 ft.2
                    //13-14  Rectangle, 40 x 50 ft.2
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 14),
                        Name = nameof(ChamberEnum.Rectangle40x50ft),
                        ProperName = "Rectangle, 40 x 50 ft.2",
                        Description = "Rectangle, 40 x 50 ft.2",
                    },
                    #endregion

                    #region 15  Rectangle, 50 x 80 ft.²
                    //15  Rectangle, 50 x 80 ft.²
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(ChamberEnum.Rectangle50x80ft),
                        ProperName = "Rectangle, 50 x 80 ft.2",
                        Description = "Rectangle, 50 x 80 ft.2",
                    },
                    #endregion

                    #region 16  Circle, 30 ft.diameter¹
                    //16  Circle, 30 ft.diameter¹
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(ChamberEnum.Circle30ftDiameter),
                        ProperName = "Circle, 30 ft.diameter",
                        Description = "Circle, 30 ft.diameter",
                    },
                    #endregion

                    #region 17  Circle, 50 ft.diameter2
                    //17  Circle, 50 ft.diameter2
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(ChamberEnum.Circle50ftDiameter),
                        ProperName = "Circle, 50 ft.diameter",
                        Description = "Circle, 50 ft.diameter",
                    },
                    #endregion

                    #region 18 Octagon, 40 x 40 ft.2
                    //18  Octagon, 40 x 40 ft.2
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(ChamberEnum.Octagon40x40ft),
                        ProperName = "Octagon, 40 x 40 ft.",
                        Description = "Octagon, 40 x 40 ft.",
                    },
                    #endregion

                    #region 19 Octagon, 60 x 60 ft.2
                    //19  Octagon, 60 x 60 ft.2
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(ChamberEnum.Octagon60x60ft),
                        ProperName = "Octagon, 60 x 60 ft.",
                        Description = "Octagon, 60 x 60 ft.",
                    },
                    #endregion

                    #region 20  Trapezoid, roughly 40 x 60 ft.2
                    //20  Trapezoid, roughly 40 x 60 ft.2
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(ChamberEnum.Trapezoid40x60ft),
                        ProperName = "Trapezoid 40 x 60 ft.",
                        Description = "Trapezoid, roughly 40 x 60 ft.",
                    },
                    #endregion
                };
            }
        }
    }
}
