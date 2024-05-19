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
    public class ExitLocationTable : RandomTable, IExitLocationTable
    {
        public ExitLocationTable()
        {
            Name = nameof(ExitLocationTable);
            ProperName = "Exit Location Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description =
                " For each exit, roll on the Exit Location and Exit Type tables to determine the nature and placement of the exit.";
        }

        //EXIT LOCATION
        //d20 Location
        //1-7  Wall opposite entrance
        //8-12  Wall left of entrance
        //13-17  Wall right of entrance
        //18-20  Same wall as entrance
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
                    #region 1-7  Wall opposite entrance
                    //1-7  Wall opposite entrance
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 07),
                        Name = nameof(ExitLocationEnum.WallOpposite),
                        ProperName = "Wall opposite entrance",
                        Description = "Wall opposite entrance",
                    },
                    #endregion

                    #region 8-12  Wall left of entrance
                    //8-12  Wall left of entrance
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 12),
                        Name = nameof(ExitLocationEnum.WallLeft),
                        ProperName = "Wall left of entrance",
                        Description = "Wall left of entrance",
                    },
                    #endregion

                    #region 13-17  Wall right of entrance
                    //13-17  Wall right of entrance
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 17),
                        Name = nameof(ExitLocationEnum.WallRight),
                        ProperName = "Wall right of entrance",
                        Description = "Wall right of entrance",
                    },
                    #endregion

                    #region 18-20  Same wall as entrance
                    //18-20  Same wall as entrance
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 20),
                        Name = nameof(ExitLocationEnum.SameWall),
                        ProperName = "Same wall as entrance",
                        Description = "Same wall as entrance",
                    },
                    #endregion
                };
            }
        }
    }
}
