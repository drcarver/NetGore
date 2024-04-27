using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Gaming.Interfaces;
using GoDungeon.Gaming.ViewModels;

namespace GoDungeon.Gaming.Tables
{
    /// <summary>
    /// Character wealth by level 
    /// </summary>
    public class CharacterWealthByLevelTable : GameTable, ICharacterWealthByLevelTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CharacterWealthByLevelTable()
        {
            Name = nameof(CharacterWealthByLevelTable);
            ProperName = "Character Wealth By Level Table";
            TableType = TableTypeEnum.GamingTable;
            Description = "Character wealth by level.";
        }

        //Table: Character Wealth by Level
        //PC Level* Wealth
        //2	1,000 gp
        //3	3,000 gp
        //4	6,000 gp
        //5	10,500 gp
        //6	16,000 gp
        //7	23,500 gp
        //8	33,000 gp
        //9	46,000 gp
        //10	62,000 gp
        //11	82,000 gp
        //12	108,000 gp
        //13	140,000 gp
        //14	185,000 gp
        //15	240,000 gp
        //16	315,000 gp
        //17	410,000 gp
        //18	530,000 gp
        //19	685,000 gp
        //20	880,000 gp    
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
                    #region 2 1,000 gp
                    //2	1,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 2,
                        Wealth = 1000
                    },
                    #endregion

                    #region 3 3,000 gp
                    //3	3,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 3,
                        Wealth = 3000
                    },
                    #endregion

                    #region 4 6,000 gp
                    //4	6,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 4,
                        Wealth = 6000
                    },
                    #endregion

                    #region 5 10,500 gp
                    //5	10,500 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 5,
                        Wealth = 10500
                    },
                    #endregion

                    #region 6 16,000 gp
                    //6	16,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 6,
                        Wealth = 16000
                    },
                    #endregion

                    #region 7 23,500 gp
                    //7	23,500 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 7,
                        Wealth = 23500
                    },
                    #endregion

                    #region 8 33,000 gp
                    //8	33,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 8,
                        Wealth = 33000
                    },
                    #endregion

                    #region 9 46,000 gp
                    //9	46,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 9,
                        Wealth = 46000
                    },
                    #endregion

                    #region 10 62,000 gp
                    //10	62,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 10,
                        Wealth = 62000
                    },
                    #endregion

                    #region 11 82,000 gp
                    //11	82,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 11,
                        Wealth = 82000
                    },
                    #endregion

                    #region 12 108,000 gp
                    //12	108,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 12,
                        Wealth = 108000
                    },
                    #endregion

                    #region 13 140,000 gp
                    //13	140,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 13,
                        Wealth = 140000
                    },
                    #endregion

                    #region 14 185,000 gp
                    //14	185,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 14,
                        Wealth = 185000
                    },
                    #endregion

                    #region 15 240,000 gp
                    //15	240,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 15,
                        Wealth = 240000
                    },
                    #endregion

                    #region 16 315,000 gp
                    //16 315,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 16,
                        Wealth = 315000
                    },
                    #endregion

                    #region 17 410,000 gp
                    //17	410,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 17,
                        Wealth = 410000
                    },
                    #endregion

                    #region 18 530,000 gp
                    //18	530,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 18,
                        Wealth = 530000
                    },
                    #endregion

                    #region 19 685,000 gp
                    //19	685,000 gp
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 19,
                        Wealth = 685000
                    },
                    #endregion

                    #region 20 880,000 gp
                    //20	880,000 gp    
                    new CharacterWealthByLevelEntryViewModel
                    {
                        Level = 20,
                        Wealth = 880000
                    },
                    #endregion
                };
            }
        }
    }
}
