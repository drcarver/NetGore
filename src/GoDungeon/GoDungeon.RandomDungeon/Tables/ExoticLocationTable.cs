using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.Tables
{
    public class ExoticLocationTable : RandomTable, IExoticLocationTable
    {
        public ExoticLocationTable()
        {
            Name = nameof(ExoticLocationTable);
            ProperName = "Exotic Location Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "The dungeon is in a exotic location";
        }

        //EXOTIC LOCATION 
        //d20 Location 
        //1 Among the branches of a tree 
        //2 Around a geyser 
        //3 Behind a waterfall 
        //4 Buried in an avalanche 
        //5 Buried in a sandstorm
        //6 Buried in volcanic ash 
        //7 Castle or structure sunken in a swamp
        //8 Castle or structure at the bottom of a sinkhole
        //9 Floating on the sea 
        //10 In a meteorite  
        //11 On a demiplane or in a pocket dimension 
        //12 In an area devastated by a magical catastrophe 
        //13 On a cloud 
        //14 In the Feywild
        //15 In the Shadowfell 
        //16 On an island in an underground sea 
        //17 In a volcano 
        //18 On the back of a Gargantuan living creature 
        //19 Sealed inside a magical dome of force 
        //20 Inside a Mordenkainen's magnificent mansion         
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
                    #region 1 Among the branches of a tree
                    //1 Among the branches of a tree
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(ExoticLocationEnum.InTreeBranches),
                        ProperName = "In Tree branches",
                        Description = "Among the branches of a tree",
                    },
                    #endregion

                    #region 2 Around a geyser
                    //2 Around a geyser
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(ExoticLocationEnum.AroundAGeyser),
                        ProperName = "Around a geyser",
                        Description = "Around a geyser",
                    },
                    #endregion

                    #region 3 Behind a waterfall
                    //3 Behind a waterfall
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(ExoticLocationEnum.BehindAWaterfall),
                        ProperName = "Behind a waterfall",
                        Description = "Behind a waterfall",
                    },
                    #endregion

                    #region 4 Buried in an avalanche
                    //4 Buried in an avalanche
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(ExoticLocationEnum.BuriedInAnAvalanche),
                        ProperName = "Buried in an avalanche",
                        Description = "Buried in an avalanche",
                    },
                    #endregion

                    #region 5 Buried in a sandstorm
                    //5 Buried in a sandstorm
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(ExoticLocationEnum.BuriedInASandstorm),
                        ProperName = "Buried in a sandstorm",
                        Description = "Buried in a sandstorm",
                    },
                    #endregion

                    #region 6 Buried in volcanic ash
                    //6 Buried in volcanic ash
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(ExoticLocationEnum.BuriedInVolcanicAsh),
                        ProperName = "Buried in volcanic ash",
                        Description = "Buried in volcanic ash",
                    },
                    #endregion

                    #region 7 Castle or structure sunken in a swamp
                    //7 Castle or structure sunken in a swamp
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 07),
                        Name = nameof(ExoticLocationEnum.CastleSunkenInASwamp),
                        ProperName = "Castle sunken in a swamp",
                        Description = "Castle or structure sunken in a swamp",
                    },
                    #endregion

                    #region 8 Castle or structure at the bottom of a sinkhole
                    //8 Castle or structure at the bottom of a sinkhole
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(ExoticLocationEnum.CastleinASinkhole),
                        ProperName = "Castle in a sinkhole",
                        Description = "Castle or structure at the bottom of a sinkhole",
                    },
                    #endregion

                    #region 9 Floating on the sea
                    //9 Floating on the sea
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(ExoticLocationEnum.FloatingOnTheSea),
                        ProperName = "Floating on the sea",
                        Description = "Floating on the sea",
                    },
                    #endregion

                    #region 10 In a meteorite
                    //10 In a meteorite
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(ExoticLocationEnum.InAMeteorite),
                        ProperName = "In a meteorite",
                        Description = "In a meteorite",
                    },
                    #endregion

                    #region 11 On a demiplane or in a pocket dimension
                    //11 On a demiplane or in a pocket dimension
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(ExoticLocationEnum.OnAdemiplane),
                        ProperName = "On a demiplane",
                        Description = "On a demiplane or in a pocket dimension",
                    },
                    #endregion

                    #region 12 In an area devastated by a magical catastrophe
                    //12 In an area devastated by a magical catastrophe
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(ExoticLocationEnum.InAMagicalCatastrophe),
                        ProperName = "In a magical catastrophe",
                        Description = "In an area devastated by a magical catastrophe",
                    },
                    #endregion

                    #region 13 On a cloud
                    //13 On a cloud
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(ExoticLocationEnum.OnACloud),
                        ProperName = "On a cloud",
                        Description = "On a cloud",
                    },
                    #endregion

                    #region 14 In the Feywild
                    //14 In the Feywild
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(ExoticLocationEnum.InTheFeywild),
                        ProperName = "In the Feywild",
                        Description = "In the Feywild",
                    },
                    #endregion

                    #region 15 In the Shadowfell
                    //15 In the Shadowfell
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(ExoticLocationEnum.InTheShadowfell),
                        ProperName = "In the Shadowfell",
                        Description = "In the Shadowfell",
                    },
                    #endregion

                    #region 16 On an island in an underground sea
                    //16 On an island in an underground sea
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(ExoticLocationEnum.AnIslandInUndergroundSea),
                        ProperName = "An Island In an Underground Sea",
                        Description = "On an island in an underground sea",
                    },
                    #endregion

                    #region 17 In a volcano
                    //17 In a volcano
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(ExoticLocationEnum.InAVolcano),
                        ProperName = "In a volcano",
                        Description = "In a volcano",
                    },
                    #endregion

                    #region 18 On the back of a Gargantuan living creature
                    //18 On the back of a Gargantuan living creature
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(ExoticLocationEnum.OnAGargantuanCreature),
                        ProperName = "On a Gargantuan Creature",
                        Description = "On the back of a Gargantuan living creature",
                    },
                    #endregion

                    #region 19 Sealed inside a magical dome of force
                    //19 Sealed inside a magical dome of force
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(ExoticLocationEnum.SealedInsideADomeOfForce),
                        ProperName = "Sealed inside a dome of force",
                        Description = "Sealed inside a magical dome of force",
                    },
                    #endregion

                    #region 20 Inside a Mordenkainen's magnificent mansion 
                    //20 Inside a Mordenkainen's magnificent mansion 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(ExoticLocationEnum.InsideMordenkainensMansion),
                        ProperName = "Inside Mordenkainens Mansion ",
                        Description = "Inside a Mordenkainen's magnificent mansion ",
                    },
                    #endregion
                };
            }
        }
    }
}

 