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
    public class DoorTypeTable : RandomTable, IDoorTypeTable
    {
        /// <summary>
        /// Whenever a table roll indicates a door roll on the Door Type table to 
        /// determine its nature... then roll on the Beyond a Door table to see 
        /// what lies on the other side of it. If a door is barred you decide
        /// which side of the door the bar is on. Unlocked doors can also be stuck,
        /// at your discretion.
        /// </summary>
        public DoorTypeTable()
        {
            Name = nameof(DoorTypeTable);
            ProperName = "Door Type Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "Determine the type of door";
        }

        //DOOR TYPE
        //d20 Door Type
        //1-10  Wooden
        //11-12  Wooden, barred or locked
        //13  Stone
        //14  Stone, barred or locked
        //15  Iron
        //16  Iron, barred or locked
        //17  Portcullis
        //18  Portcullis, locked in place
        //19  Secret door
        //20  Secret door, barred or locked
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
                    #region 1-10  Wooden
                    //1-10  Wooden
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 10),
                        Name = nameof(DoorTypeEnum.Wooden),
                        ProperName = nameof(DoorTypeEnum.Wooden),
                        Description = "Wooden"
                    },
                    #endregion

                    #region 11-12  Wooden, barred or locked
                    //11-12  Wooden, barred or locked
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 12),
                        Name = nameof(DoorTypeEnum.WoodenBarredOrLocked),
                        ProperName = "Wooden, barred or locked",
                        Description = "Wooden, barred or locked"
                    },
                    #endregion

                    #region 13  Stone
                    //13  Stone
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(DoorTypeEnum.Stone),
                        ProperName = "Stone",
                        Description = "Stone"
                    },
                    #endregion

                    #region 14  Stone, barred or locked
                    //14  Stone, barred or locked
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(DoorTypeEnum.Stonebarredorlocked),
                        ProperName = "Stone, barred or locked",
                        Description = "Stone, barred or locked"
                    },
                    #endregion

                    #region 15  Iron
                    //15  Iron
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(DoorTypeEnum.Iron),
                        ProperName = "Iron",
                        Description = "Iron"
                    },
                    #endregion

                    #region 16  Iron, barred or locked
                    //16  Iron, barred or locked
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(DoorTypeEnum.Ironbarredorlocked),
                        ProperName = "Iron, barred or locked",
                        Description = "Iron, barred or locked"
                    },
                    #endregion

                    #region 17 Portcullis
                    //17 Portcullis
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(DoorTypeEnum.Portcullis),
                        ProperName = "Portcullis",
                        Description = "Portcullis"
                    },
                    #endregion

                    #region 18  Portcullis, barred or locked
                    //18  Portcullis, barred or locked
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(DoorTypeEnum.Portcullisbarredorlocked),
                        ProperName = "Portcullis, barred or locked",
                        Description = "Portcullis, barred or locked"
                    },
                    #endregion

                    #region 19  Secret door
                    //19  Secret door
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(DoorTypeEnum.Secretdoor),
                        ProperName = "Secret door",
                        Description = "Secret door"
                    },
                    #endregion

                    #region 20  Secret door, barred or locked
                    //20  Secret door, barred or locked
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(DoorTypeEnum.Secretdoorbarredorlocked),
                        ProperName = "Secret door, barred or locked",
                        Description = "Secret door, barred or locked"
                    },
                    #endregion
                };
            }
        }
    }
}
