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
    public class OtherGoalsTable : RandomTable, IOtherGoalsTable
    {
        /// <summary>
        /// The Other goals table suggests location-based adventures that
        /// don't fit neatly into the first two categories.
        /// </summary>
        public OtherGoalsTable()
        {
            Name = nameof(OtherGoalsTable);
            ProperName = "Other Goals Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 12;
            Description = "The Other goals table suggests location-based adventures that don't fit neatly into the first two categories.";
        }

        //Other Goals
        //d12 Goal
        //1 Seize control of a fortified location such as a
        //fortress, town, or ship.
        //2 Defend a location from attackers.
        //3 Retrieve an object from inside a secure location in
        //a settlement.
        //4 Retrieve an object from a caravan.
        //5 Salvage an object or goods from a lost vessel or
        //caravan.
        //6 Break a prisoner out of a jail or prison camp.
        //7 Escape from a jail or prison camp.
        //8 Successfully travel through an obstacle course to
        //gain recognition or reward .
        //9 Infiltrate a fortified location.
        //10 Find the source of strange occurrences in a
        //haunted house or other location.
        //11 Interfere with the operation of a business.
        //12 Rescue a character, monster, or object from a
        //natural or unnatural disaster.        
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
                    #region 1. Seize control of a fortified location such as a fortress, town, or ship.
                    //1. Seize control of a fortified location such as a fortress, town, or ship.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(OtherGoalEnum.SeizeControl),
                        ProperName = "Seize control of a fortified location",
                        Description = "Seize control of a fortified location such as a fortress, town, or ship."
                    },
                    #endregion

                    #region 2 Defend a location from attackers.
                    //2 Defend a location from attackers.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(OtherGoalEnum.DefendALocation),
                        ProperName = "Defend a location",
                        Description = "Defend a location from attackers."
                    },
                    #endregion

                    #region 3 Retrieve an object from inside a secure location in a settlement.
                    //3 Retrieve an object from inside a secure location in a settlement.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(OtherGoalEnum.RetrieveAnObject),
                        ProperName = "Retrieve an object",
                        Description = "Retrieve an object from inside a secure location in a settlement."
                    },
                    #endregion

                    #region 4 Retrieve an object from a caravan.
                    //4 Retrieve an object from a caravan.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(OtherGoalEnum.RetrieveFromACaravan),
                        ProperName = "Retrieve from a caravan.",
                        Description = "Retrieve an object from a caravan."
                    },
                    #endregion

                    #region 5 Salvage an object or goods from a lost vessel or caravan.
                    //5 Salvage an object or goods from a lost vessel or caravan.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(OtherGoalEnum.SalvageGoods),
                        ProperName = "Salvage goods",
                        Description = "Salvage an object or goods from a lost vessel or caravan."
                    },
                    #endregion

                    #region 6 Break a prisoner out of a jail or prison camp.
                    //6 Break a prisoner out of a jail or prison camp.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(OtherGoalEnum.BreakAPrisonerOut),
                        ProperName = "Break a prisoner out",
                        Description = "Break a prisoner out of a jail or prison camp."
                    },
                    #endregion

                    #region 7 Escape from a jail or prison camp.
                    //7 Escape from a jail or prison camp.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 07),
                        Name = nameof(OtherGoalEnum.EscapeFromAJail),
                        ProperName = "Escape from a jail",
                        Description = "Escape from a jail or prison camp."
                    },
                    #endregion

                    #region 8 Successfully travel through an obstacle course to gain recognition or reward.
                    //8 Successfully travel through an obstacle course to gain recognition or reward.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(OtherGoalEnum.ObstacleCourse),
                        ProperName = "Successfully travel through an obstacle course",
                        Description = "Successfully travel through an obstacle course to gain recognition or reward."
                    },
                    #endregion

                    #region 9 Infiltrate a fortified location.
                    //9 Infiltrate a fortified location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(OtherGoalEnum.InfiltrateALocation),
                        ProperName = "Infiltrate a location.",
                        Description = "Infiltrate a fortified location."
                    },
                    #endregion

                    #region 10 Find the source of strange occurrences in a haunted house or other location.
                    //10 Find the source of strange occurrences in a haunted house or other location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(OtherGoalEnum.StrangeOccurrences),
                        ProperName = "Strange occurrences in a haunted house",
                        Description = "Find the source of strange occurrences in a haunted house or other location."
                    },
                    #endregion

                    #region 11 Interfere with the operation of a business.
                    //11 Interfere with the operation of a business.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(OtherGoalEnum.InterfereWithABusiness),
                        ProperName = "Interfere with a business.",
                        Description = "Interfere with the operation of a business."
                    },
                    #endregion

                    #region 12 Rescue a character, monster, or object from a natural or unnatural disaster.
                    //12 Rescue a character, monster, or object from a natural or unnatural disaster.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(OtherGoalEnum.RescueACharacter),
                        ProperName = "Rescue a character",
                        Description = "Rescue a character, monster, or object from a natural or unnatural disaster."
                    },
                    #endregion
                };
            }
        }
    }
}


