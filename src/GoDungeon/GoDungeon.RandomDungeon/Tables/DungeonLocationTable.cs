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
    public class DungeonLocationTable : RandomTable, IDungeonLocationTable
    {
        public DungeonLocationTable()
        {
            Name = nameof(DungeonLocationTable);
            ProperName = "Dungeon Location Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 100;
            Description =
                "You can use the Dungeon Location table to determine the locale of your dungeon. You can roll on the table or choose an entry that inspires you.";
        }

        //d1OO Location 
        //01-04 A building in a city 
        //05-08 Catacombs or sewers beneath a city 
        //09-12 Beneath a farmhouse 
        //13-16 Beneath a graveyard 
        //17-22 Beneath a ruined castle 
        //23-26 Beneath a ruined city 
        //27-30 Beneath a temple 
        //31-34 In a chasm 
        //35-38 In a cliff face 
        //39-42 In a desert 
        //43-46 In a forest 
        //47-50 In a glacier 
        //51-54 In a gorge 
        //55-58 In a jungle 
        //59-62 In a mountain pass 
        //63-66 In a swamp 
        //67-70 Beneath or on top of a mesa 
        //71-74 In sea caves 
        //75-78 In several connected mesas 
        //79-82 On a mountain peak 
        //83-86 On a promontory 
        //87-90 On an island 
        //91-95 Underwater 
        //96-00 Roll on the Exotic Location table
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
                    #region 01-04 A building in a city 
                    //01-04 A building in a city
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 04),
                        Name = nameof(DungeonLocationEnum.CityBuilding),
                        ProperName = "City building",
                        Description = "A building in a city",
                    },
                    #endregion

                    #region 05-08 Catacombs or sewers beneath a city 
                    //05-08 Catacombs or sewers beneath a city
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 08),
                        Name = nameof(DungeonLocationEnum.CityCatacombs),
                        ProperName = "City Catacombs",
                        Description = "Catacombs or sewers beneath a city",
                    },
                    #endregion

                    #region 09-12 Beneath a farmhouse 
                    //09-12 Beneath a farmhouse 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 12),
                        Name = nameof(DungeonLocationEnum.BeneathAFarmhouse),
                        ProperName = "Beneath a farmhouse",
                        Description = "Beneath a farmhouse",
                    },
                    #endregion

                    #region 13-16 Beneath a graveyard  
                    //13-16 Beneath a graveyard 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 16),
                        Name = nameof(DungeonLocationEnum.BeneathAGraveyard),
                        ProperName = "Beneath a graveyard",
                        Description = "Beneath a graveyard",
                    },
                    #endregion

                    #region 17-22 Beneath a ruined castle  
                    //17-22 Beneath a ruined castle 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 22),
                        Name = nameof(DungeonLocationEnum.BeneathARuinedCastle),
                        ProperName = "Beneath a ruined castle",
                        Description = "Beneath a ruined castle",
                    },
                    #endregion

                    #region 23-26 Beneath a ruined city  
                    //23-26 Beneath a ruined city
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(23, 26),
                        Name = nameof(DungeonLocationEnum.BeneathARuinedCity),
                        ProperName = "Beneath a ruined city",
                        Description = "Beneath a ruined city",
                    },
                    #endregion

                    #region 27-30 Beneath a temple  
                    //27-30 Beneath a temple
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(27, 30),
                        Name = nameof(DungeonLocationEnum.BeneathATemple),
                        ProperName = "Beneath a temple",
                        Description = "Beneath a temple",
                    },
                    #endregion

                    #region 31-34 In a chasm   
                    //31-34 In a chasm 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(31, 34),
                        Name = nameof(DungeonLocationEnum.InAChasm),
                        ProperName = "In a chasm",
                        Description = "In a chasm",
                    },
                    #endregion

                    #region 35-38 In a cliff face    
                    //35-38 In a cliff face 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(35, 38),
                        Name = nameof(DungeonLocationEnum.InACliffFace),
                        ProperName = "In a cliff face",
                        Description = "In a cliff face",
                    },
                    #endregion

                    #region 39-42 In a desert    
                    //39-42 In a desert 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(39, 42),
                        Name = nameof(DungeonLocationEnum.InADesert),
                        ProperName = "In a desert",
                        Description = "In a desert",
                    },
                    #endregion

                    #region 43-46 In a forest    
                    //43-46 In a forest 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(43, 46),
                        Name = nameof(DungeonLocationEnum.InAForest),
                        ProperName = "In a forest",
                        Description = "In a forest",
                    },
                    #endregion

                    #region 47-50 In a glacier    
                    //47-50 In a glacier
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(47, 50),
                        Name = nameof(DungeonLocationEnum.InAGlacier),
                        ProperName = "In a glacier",
                        Description = "In a glacier",
                    },
                    #endregion

                    #region 51-54 In a gorge    
                    //51-54 In a gorge
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(51, 54),
                        Name = nameof(DungeonLocationEnum.InAGorge),
                        ProperName = "In a gorge",
                        Description = "In a gorge",
                    },
                    #endregion

                    #region 55-58 In a jungle     
                    //55-58 In a jungle 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(55, 58),
                        Name = nameof(DungeonLocationEnum.InAJungle),
                        ProperName = "In a jungle ",
                        Description = "In a jungle ",
                    },
                    #endregion

                    #region 59-62 In a mountain pass     
                    //59-62 In a mountain pass
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(59, 62),
                        Name = nameof(DungeonLocationEnum.InAMountainPass),
                        ProperName = "In a mountain pass",
                        Description = "In a mountain pass",
                    },
                    #endregion

                    #region 63-66 In a swamp      
                    //63-66 In a swamp
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(63, 66),
                        Name = nameof(DungeonLocationEnum.InASwamp),
                        ProperName = "In a swamp",
                        Description = "In a swamp",
                    },
                    #endregion

                    #region 67-70 Beneath or on top of a mesa      
                    //67-70 Beneath or on top of a mesa
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(67, 70),
                        Name = nameof(DungeonLocationEnum.BeneathAMesa),
                        ProperName = "Beneath a mesa",
                        Description = "Beneath or on top of a mesa",
                    },
                    #endregion

                    #region 71-74 In sea caves      
                    //71-74 In sea caves
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(71, 74),
                        Name = nameof(DungeonLocationEnum.InSeaCaves),
                        ProperName = "In sea caves",
                        Description = "In sea caves",
                    },
                    #endregion

                    #region 75-78 In several connected mesas      
                    //75-78 In several connected mesas
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(75, 78),
                        Name = nameof(DungeonLocationEnum.InConnectedMesas),
                        ProperName = "In connected mesas",
                        Description = "In several connected mesas",
                    },
                    #endregion

                    #region 79-82 On a mountain peak      
                    //79-82 On a mountain peak
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(79, 82),
                        Name = nameof(DungeonLocationEnum.OnAMountainPeak),
                        ProperName = "On a mountain peak",
                        Description = "On a mountain peak",
                    },
                    #endregion

                    #region 83-86 On a promontory      
                    //83-86 On a promontory
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(83, 86),
                        Name = nameof(DungeonLocationEnum.OnAPromontory),
                        ProperName = "On a promontory",
                        Description = "On a promontory",
                    },
                    #endregion

                    #region 87-90 On an island      
                    //87-90 On an island
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(87, 90),
                        Name = nameof(DungeonLocationEnum.OnAnIsland),
                        ProperName = "On an island",
                        Description = "On an island",
                    },
                    #endregion

                    #region 91-95 Underwater      
                    //91-95 Underwater
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(91, 95),
                        Name = nameof(DungeonLocationEnum.Underwater),
                        ProperName = "Underwater",
                        Description = "Underwater",
                    },
                    #endregion

                    #region 96-100 Roll on the Exotic Location table      
                    //96-100 Roll on the Exotic Location table
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(96, 100),
                        Name = nameof(DungeonLocationEnum.ExoticLocationTable),
                        ProperName = "The Exotic Location table",
                        Description = "Roll on the Exotic Location table",
                    },
                    #endregion
                };
            }
        }
    }
}
