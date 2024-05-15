using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Tables;

public class PrecipitationTable : RandomTable, IPrecipitationTable
{
    public PrecipitationTable()
    {
        Name = nameof(PrecipitationTable);
        ProperName = "Precipitation Table";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 20;
        Description = "Precipitation Table";
    }

    //d20 Precipitation
    //1-12 None
    //13-17 Light rain or light snowfall
    //18-20 Heavy rain or heavy snowfall
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
                #region 1-12 None
                //1-12 None
                new RandomTableEntryViewModel
                {
                    Range = new Range(01, 12),
                    Name = nameof(WeatherEnum.None),
                    ProperName = "None",
                    Description = "None"
                },
                #endregion

                #region 13-17 Light rain or light snowfall
                //13-17 Light rain or light snowfall
                new RandomTableEntryViewModel
                {
                    Range = new Range(13, 17),
                    Name = nameof(WeatherEnum.LightRain),
                    ProperName = "Light rain",
                    Description = "Light rain or light snowfall"
                },
                #endregion

                #region 18-20 Heavy rain or heavy snowfall
                //18-20 Heavy rain or heavy snowfall
                new RandomTableEntryViewModel
                {
                    Range = new Range(18, 20),
                    Name = nameof(WeatherEnum.HeavyRain),
                    ProperName = "Heavy rain",
                    Description = "Heavy rain or heavy snowfall"
                },
                #endregion
            };
        }
    }
}
