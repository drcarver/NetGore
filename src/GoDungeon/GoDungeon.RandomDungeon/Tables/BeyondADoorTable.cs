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
    public class BeyondADoorTable : RandomTable, IBeyondADoorTable
    {
        /// <summary>
        /// </summary>
        public BeyondADoorTable()
        {
            Name = nameof(BeyondADoorTable);
            ProperName = "Beyond A Door Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "What is on the other side of a door";
        }

        //BEYOND A DOOR
        //d20 Feature
        //1-2   Passage extending 10 ft., then T intersection extending 10 ft.to the right and left
        //3-8  Passage 20 ft.straight ahead
        //9-18  Chamber (roll on the Chamber table)
        //19  Stairs(roll on the Stairs table)
        //20  False door with trap
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
                    #region 1-2   Passage extending 10 ft., then T intersection extending 10 ft.to the right and left
                    //1-2   Passage extending 10 ft., then T intersection extending 10 ft.to the right and left
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 02),
                        Name = nameof(BeyondADoorEnum.PassageExtending10ft),
                        ProperName = "Passage extending 10 ft., then T intersection.",
                        Description = "Passage extending 10 ft., then T intersection extending 10 ft.to the right and left.",
                    },
                    #endregion

                    #region 3-8  Passage 20 ft.straight ahead
                    //3-8  Passage 20 ft.straight ahead
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 08),
                        Name = nameof(BeyondADoorEnum.PassageExtending10ft),
                        ProperName = "Passage 20 ft.straight ahead",
                        Description = "Passage 20 ft.straight ahead",
                    },
                    #endregion

                    #region 9-18  Chamber (roll on the Chamber table)
                    //9-18  Chamber (roll on the Chamber table)
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 18),
                        Name = nameof(BeyondADoorEnum.Chamber),
                        ProperName = "Chamber (roll on the Chamber table)",
                        Description = "Chamber (roll on the Chamber table)",
                    },
                    #endregion

                    #region 19  Stairs(roll on the Stairs table)
                    //19  Stairs(roll on the Stairs table)
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(BeyondADoorEnum.Stairs),
                        ProperName = "Stairs (roll on the Stairs table)",
                        Description = "Stairs (roll on the Stairs table)",
                    },
                    #endregion

                    #region 20  False door with trap
                    //20  False door with trap
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(BeyondADoorEnum.Trap),
                        ProperName = "False door with trap",
                        Description = "False door with trap",
                    },
                    #endregion
                };
            }
        }
    }

}
