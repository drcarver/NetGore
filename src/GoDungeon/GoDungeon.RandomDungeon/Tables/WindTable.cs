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
}
