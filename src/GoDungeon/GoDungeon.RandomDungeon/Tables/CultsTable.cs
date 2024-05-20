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
    public class CultsTable : RandomTable, ICultsTable
    {
        /// <summary>
        /// A dungeon reflects its creators. A lost temple of the
        /// yuan-ti, choked by overgrown jungle plants, might
        /// feature ramps instead of stairs. Caverns carved by a
        /// beholder·s disintegration eye ray have walls that are
        /// un naturally smooth, and the beholder's lair might
        /// include vertical shafts connecting different levels.
        /// Amphibious monsters such as kuo-toa and aboleths use
        /// water to protect the innermost reaches of their lairs
        /// from air-breathing intruders.
        /// </summary>
        public CultsTable()
        {
            Name = nameof(CultsTable);
            ProperName = "Cults and religious groups Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "A dungeon reflects its creators.";
        }

        //CULTS AND RELIGIOUS GROUPS
        //d20 Cult or Religious Group
        //1 Demon-worshiping cult
        //2 Devil-worshiping cult
        //3-4 Elemental Air cult
        //5-6 Elemental Earth cult
        //7-8 Elemental Fire cult
        //9-10 Elemental Water cult
        //11-15 Worshipers of an evil deity
        //16-17 Worshipers of a good deity
        //18-20 Worshipers of a neutral deity
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
                    #region 1 Demon-worshiping cult
                    //1 Demon-worshiping cult
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(CultEnum.DemonWorshipingCult),
                        ProperName = "Demon-worshiping cult",
                        Description = "Demon-worshiping cult"
                    },
                    #endregion

                    #region 2 Devil-worshiping cult
                    //2 Devil-worshiping cult
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(CultEnum.DevilWorshipingCult),
                        ProperName = "Devil-worshiping cult",
                        Description = "Devil-worshiping cult"
                    },
                    #endregion

                    #region 3-4 Elemental Air cult
                    //3-4 Elemental Air cult
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 04),
                        Name = nameof(CultEnum.ElementalAirCult),
                        ProperName = "Elemental Air cult",
                        Description = "Elemental Air cult"
                    },
                    #endregion

                    #region 5-6 Elemental Earth cult
                    //5-6 Elemental Earth cult
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 06),
                        Name = nameof(CultEnum.ElementalEarthCult),
                        ProperName = "Elemental Earth cult",
                        Description = "Elemental Earth cult"
                    },
                    #endregion

                    #region 7-8 Elemental Fire cult
                    //7-8 Elemental Fire cult
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 08),
                        Name = nameof(CultEnum.ElementalFireCult),
                        ProperName = "Elemental Fire cult",
                        Description = "Elemental Fire cult"
                    },
                    #endregion

                    #region 9-10 Elemental Water cult
                    //9-10 Elemental Water cult
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 10),
                        Name = nameof(CultEnum.ElementalWaterCult),
                        ProperName = "Elemental Water cult",
                        Description = "Elemental Water cult"
                    },
                    #endregion

                    #region 11-15 Worshipers of an evil deity
                    //11-15 Worshipers of an evil deity
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 15),
                        Name = nameof(CultEnum.WorshipersEvilDeity),
                        ProperName = "Worshipers of an evil deity",
                        Description = "Worshipers of an evil deity"
                    },
                    #endregion

                    #region 16-17 Worshipers of a good deity
                    //16-17 Worshipers of a good deity
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 17),
                        Name = nameof(CultEnum.WorshipersGoodDeity),
                        ProperName = "Worshipers of a good deity",
                        Description = "Worshipers of a good deity"
                    },
                    #endregion

                    #region 18-20 Worshipers of a neutral deity
                    //18-20 Worshipers of a neutral deity
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 20),
                        Name = nameof(CultEnum.WorshipersNeutralDeity),
                        ProperName = "Worshipers of a neutral deity",
                        Description = "Worshipers of a neutral deity"
                    },
                    #endregion
                };
            }
        }
    }
}

