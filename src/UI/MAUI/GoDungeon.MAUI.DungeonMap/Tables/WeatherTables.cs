using System.Collections.ObjectModel;
using System.Reflection.PortableExecutable;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

using static GoDungeon.MAUI.DungeonMap.Tables.WeatherTables;

namespace GoDungeon.MAUI.DungeonMap.Tables;

/// <summary>
/// You can pick weather to fit your campaign or roll on the
/// Weather table to determine the weather for a given day, adjusting for 
/// the terrain and season as appropriate.
/// </summary>
public class WeatherTables
{
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

    public class WindTable : RandomTable, IWindTable
    {
        public WindTable()
        {
            Name = nameof(WindTable);
            ProperName = "Wind Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "Wind Table";
        }

        //WEATHER
        //d20 Wind
        //1-12 None 
        //13-17 Light 
        //18-20 Strong
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
                    #region 1-12 No Wind
                    //1-12 No Wind
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 12),
                        Name = nameof(WeatherEnum.NoWind),
                        ProperName = "No Wind",
                        Description = "No Wind"
                    },
                    #endregion

                    #region 13-17 Light wind
                    //13-17 Light wind
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 17),
                        Name = nameof(WeatherEnum.LightWind),
                        ProperName = "Light Wind",
                        Description = "Light Wind"
                    },
                    #endregion

                    #region 18-20 Strong Wind
                    //18-20 Strong Wind
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 20),
                        Name = nameof(WeatherEnum.StrongWind),
                        ProperName = "Strong wind",
                        Description = "Strong wind"
                    },
                    #endregion
                };
            }
        }
    }

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
}
