using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Tables;

/// <summary>
/// You can pick weather to fit your campaign or roll on the
/// Weather table to determine the weather for a given day, adjusting for 
/// the terrain and season as appropriate.
/// </summary>
public class TemperatureTable : RandomTable, ITemperatureTable
{
    public TemperatureTable()
    {
        Name = nameof(TemperatureTable);
        ProperName = "Temperature Table";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 20;
        Description = "Temperature Table";
    }

    //WEATHER
    //d20 Temperature
    //1-14 Normal for the season
    //15-17 1d4 x 10 degrees Fahrenheit colder than normal
    //18-20 1d4 x 10 degrees Fahrenheit hotter than normal
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
                #region 1-14 Normal for the season
                //1-14 Normal for the season
                new RandomTableEntryViewModel
                {
                    Range = new Range(01, 14),
                    Name = nameof(WeatherEnum.Normal),
                    ProperName = "Normal",
                    Description = "Normal for the season"
                },
                #endregion

                #region 15-17 1d4 x 10 degrees Fahrenheit colder than normal
                //15-17 1d4 x 10 degrees Fahrenheit colder than normal
                new RandomTableEntryViewModel
                {
                    Range = new Range(15, 17),
                    Name = nameof(WeatherEnum.Colder),
                    ProperName = "Colder",
                    Description = "1d4 x 10 degrees Fahrenheit colder than normal"
                },
                #endregion

                #region 18-20 1d4 x 10 degrees Fahrenheit hotter than normal
                //18-20 1d4 x 10 degrees Fahrenheit hotter than normal
                new RandomTableEntryViewModel
                {
                    Range = new Range(18, 20),
                    Name = nameof(WeatherEnum.Hotter),
                    ProperName = "Hotter",
                    Description = "1d4 x 10 degrees Fahrenheit hotter than normal"
                },
                #endregion
            };
        }
    }
}
