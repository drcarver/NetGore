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
    /// <summary>
    /// Roll on the Beyond a Door table to see what lies on the other side of it.
    /// </summary>
    public class AdventureVillainsTable : RandomTable, IAdventureVillainsTable
    {
        /// <summary>
        /// </summary>
        public AdventureVillainsTable()
        {
            Name = nameof(BeyondADoorTable);
            ProperName = "Adventure Villains";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "Use the Adventure Villains, Adventure Allies, and Adventure Patrons tables to help you identify these NPCs";
        }

        //ADVENTURE VILLAINS
        //d20 Villain
        //1 Beast or monstrosity with no particular agenda
        //2 Aberration bent on corruption or domination
        //3 Fiend bent on corruption or destruction
        //4 Dragon bent on domination and plunder
        //5 Giant bent on plunder
        //6-7 Undead with any agenda
        //8 Fey with a mysterious goal
        //9-10 Humanoid cultist
        //11-12 Humanoid conqueror
        //13 Humanoid seeking revenge
        //14-15 Humanoid schemer seeking to rule
        //16 Humanoid criminal mastermind
        //17-18 Humanoid raider or ravager
        //19 Humanoid under a curse
        //20 Misguided humanoid zealot
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
                    #region 1 Beast or monstrosity with no particular agenda
                    //1 Beast or monstrosity with no particular agenda
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(AdventureVillainEnum.Beast),
                        ProperName = "Beast or monstrosity",
                        Description = "Beast or monstrosity with no particular agenda",
                    },
                    #endregion

                    #region 2 Aberration bent on corruption or domination
                    //2 Aberration bent on corruption or domination
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(AdventureVillainEnum.Aberration),
                        ProperName = "Aberration",
                        Description = "Aberration bent on corruption or domination",
                    },
                    #endregion

                    #region 3 Fiend bent on corruption or destruction
                    //3 Fiend bent on corruption or destruction
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(AdventureVillainEnum.Fiend),
                        ProperName = "Fiend",
                        Description = "Fiend bent on corruption or destruction",
                    },
                    #endregion

                    #region 4 Dragon bent on domination and plunder
                    //4 Dragon bent on domination and plunder
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(AdventureVillainEnum.Fiend),
                        ProperName = "Dragon",
                        Description = "Dragon bent on domination and plunder",
                    },
                    #endregion

                    #region 5 Giant bent on plunder
                    //5 Giant bent on plunder
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(AdventureVillainEnum.Giant),
                        ProperName = "Giant",
                        Description = "Giant bent on plunder",
                    },
                    #endregion

                    #region 6-7 Undead with any agenda
                    //6-7 Undead with any agenda
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 07),
                        Name = nameof(AdventureVillainEnum.Undead),
                        ProperName = "Undead",
                        Description = "Undead with any agenda",
                    },
                    #endregion

                    #region 8 Fey with a mysterious goal
                    //8 Fey with a mysterious goal
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(AdventureVillainEnum.Fey),
                        ProperName = "Fey",
                        Description = "Fey with a mysterious goal",
                    },
                    #endregion

                    #region 9-10 Humanoid cultist
                    //9-10 Humanoid cultist
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 10),
                        Name = nameof(AdventureVillainEnum.HumanoidCultist),
                        ProperName = "Humanoid cultist",
                        Description = "Humanoid cultist",
                    },
                    #endregion

                    #region 11-12 Humanoid conqueror
                    //11-12 Humanoid conqueror
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 12),
                        Name = nameof(AdventureVillainEnum.HumanoidConqueror),
                        ProperName = "Humanoid conqueror",
                        Description = "Humanoid conqueror",
                    },
                    #endregion

                    #region 13 Humanoid seeking revenge
                    //13 Humanoid seeking revenge
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(AdventureVillainEnum.HumanoidSeekingRevenge),
                        ProperName = "Humanoid seeking revenge",
                        Description = "Humanoid seeking revenge",
                    },
                    #endregion

                    #region 14-15 Humanoid schemer seeking to rule
                    //14-15 Humanoid schemer seeking to rule
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 15),
                        Name = nameof(AdventureVillainEnum.HumanoidSeekingToRule),
                        ProperName = "Humanoid seeking to rule",
                        Description = "Humanoid schemer seeking to rule",
                    },
                    #endregion

                    #region 16 Humanoid criminal mastermind
                    //16 Humanoid criminal mastermind
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(AdventureVillainEnum.HumanoidCriminalMastermind),
                        ProperName = "Humanoid criminal mastermind",
                        Description = "Humanoid criminal mastermind",
                    },
                    #endregion

                    #region 17-18 Humanoid raider or ravager
                    //17-18 Humanoid raider or ravager
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 18),
                        Name = nameof(AdventureVillainEnum.HumanoidRaider),
                        ProperName = "Humanoid raider",
                        Description = "Humanoid raider or ravager",
                    },
                    #endregion

                    #region 19 Humanoid under a curse
                    //19 Humanoid under a curse
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(AdventureVillainEnum.CursedHumanoid),
                        ProperName = "Humanoid under a curse",
                        Description = "Humanoid under a curse",
                    },
                    #endregion

                    #region 20 Misguided humanoid zealot
                    //20 Misguided humanoid zealot
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(AdventureVillainEnum.MisguidedZealot),
                        ProperName = "Misguided humanoid zealot",
                        Description = "Misguided humanoid zealot",
                    },
                    #endregion
                };
            }
        }
    }

}


