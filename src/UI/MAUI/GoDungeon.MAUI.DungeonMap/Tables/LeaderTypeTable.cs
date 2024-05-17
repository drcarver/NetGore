using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Tables;

public class LeaderTypeTable : RandomTable, ILeaderTypeTable
{
    /// <summary>
    /// Eras are often defined by the prominent leaders, innovators, and tyrants
    /// of the day.These people change the world and etch their signatures
    /// indelibly on the pages of history. When they rise to power, they shape
    /// the time and place where they live in monumental ways. When they fall
    /// from power or pass away, the ghost of their presence lingers.
    /// </summary>
    public LeaderTypeTable()
    {
        Name = nameof(LeaderTypeTable);
        ProperName = "Leader Type Table";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 6;
        Description = "Eras are often defined by the prominent leaders, innovators, and tyrants of the day. These people change the world and etch their signatures indelibly on the pages of history. When they rise to power, they shape the time and place where they live in monumental ways. When they fall from power or pass away, the ghost of their presence lingers.";
    }

    //LEADER TYPES
    //d6 Leader Type Political
    //1 Political
    //2  Religious
    //3  Military
    //4  Crime/underworld
    //5  Art/culture
    //6  Philosophy/learning/magic
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
                #region 1 Political
                //1 Political
                new RandomTableEntryViewModel
                {
                    Range = new Range(01, 01),
                    Name = nameof(LeaderTypeEnum.Political),
                    ProperName = "Political",
                    Description = "Political"
                },
                #endregion

                #region 2  Religious
                //2  Religious
                new RandomTableEntryViewModel
                {
                    Range = new Range(02, 02),
                    Name = nameof(LeaderTypeEnum.Religious),
                    ProperName = "Religious",
                    Description = "Religious"
                },
                #endregion

                #region 3  Military
                //3  Military
                new RandomTableEntryViewModel
                {
                    Range = new Range(03, 03),
                    Name = nameof(LeaderTypeEnum.Military),
                    ProperName = "Military",
                    Description = "Military"
                },
                #endregion

                #region 4  Crime/underworld
                //4  Crime/underworld
                new RandomTableEntryViewModel
                {
                    Range = new Range(04, 04),
                    Name = nameof(LeaderTypeEnum.Crime),
                    ProperName = "Crime/underworld",
                    Description = "Crime/underworld"
                },
                #endregion

                #region 5  Art/culture
                //5  Art/culture
                new RandomTableEntryViewModel
                {
                    Range = new Range(05, 05),
                    Name = nameof(LeaderTypeEnum.Art),
                    ProperName = "Art/culture",
                    Description = "Art/culture"
                },
                #endregion

                #region 6  Philosophy/learning/magic
                //6  Philosophy/learning/magic
                new RandomTableEntryViewModel
                {
                    Range = new Range(06, 06),
                    Name = nameof(LeaderTypeEnum.Philosophy),
                    ProperName = "Philosophy/learning/magic",
                    Description = "Philosophy/learning/magic"
                },
                #endregion
            };
        }
    }
}
