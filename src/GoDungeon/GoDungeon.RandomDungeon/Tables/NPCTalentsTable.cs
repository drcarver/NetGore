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
    public class NPCTalentsTable  : RandomTable, INPCTalentsTable
    {
        /// <summary>
        /// In one sentence, describe something that your NPC can do that is 
        /// special, if anything..
        /// </summary>
        public NPCTalentsTable()
        {
            Name = nameof(NPCTalentsTable);
            ProperName = "NPC Talents Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "In one sentence, describe something that your NPC can do that is special, if anything.";
        }

        //NPC TALENTS
        //d20 Talent
        //1 Plays a musical instrument
        //2 Speaks several languages fluently
        //3 Unbelievably lucky
        //4 Perfect memory
        //5 Great with animals
        //6 Great with children
        //7 Great at solving puzzles
        //8 Great at one game
        //9 Great at impersonations
        //10 Draws beautifully
        //11 Paints beautifully
        //12 Sings beautifully
        //13 Drinks everyone under the table
        //14 Expert carpenter
        //15 Expert cook
        //16 Expert dart thrower and rock skipper
        //17 Expert juggler
        //18 Skilled actor and master of disguise
        //19 Skilled dancer
        //20 Knows thieves' cant 
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
                    #region 1 Plays a musical instrument
                    //1 Plays a musical instrument
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(NPCTalentEnum.PlaysInstrument),
                        ProperName = "Plays a musical instrument",
                        Description = "Plays a musical instrument"
                    },
                    #endregion

                    #region 2 Speaks several languages fluently
                    //2 Speaks several languages fluently
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(NPCTalentEnum.SpeaksLanguages),
                        ProperName = "Speaks several languages",
                        Description = "Speaks several languages fluently"
                    },
                    #endregion

                    #region 3 Unbelievably lucky
                    //3 Unbelievably lucky
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(NPCTalentEnum.UnbelievablyLucky),
                        ProperName = "Unbelievably lucky",
                        Description = "Unbelievably lucky"
                    },
                    #endregion

                    #region 4 Perfect memory
                    //4 Perfect memory
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(NPCTalentEnum.PerfectMemory),
                        ProperName = "Perfect memory",
                        Description = "Perfect memory"
                    },
                    #endregion

                    #region 5 Great with animals
                    //5 Great with animals
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(NPCTalentEnum.GreatWithAnimals),
                        ProperName = "Great with animals",
                        Description = "Great with animals"
                    },
                    #endregion

                    #region 6 Great with children
                    //6 Great with children
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(NPCTalentEnum.GreatWithChildren),
                        ProperName = "Great with children",
                        Description = "Great with children"
                    },
                    #endregion

                    #region 7 Great at solving puzzles
                    //7 Great at solving puzzles
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 07),
                        Name = nameof(NPCTalentEnum.GreatAtSolvingPuzzles),
                        ProperName = "Great at solving puzzles",
                        Description = "Great at solving puzzles"
                    },
                    #endregion

                    #region 8 Great at one game
                    //8 Great at one game
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(NPCTalentEnum.GreatAtOneGame),
                        ProperName = "Great at one game",
                        Description = "Great at one game"
                    },
                    #endregion

                    #region 9 Great at impersonations
                    //9 Great at impersonations
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(NPCTalentEnum.GreatAtImpersonations),
                        ProperName = "Great at impersonations",
                        Description = "Great at impersonations"
                    },
                    #endregion

                    #region 10 Draws beautifully
                    //10 Draws beautifully
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(NPCTalentEnum.DrawsBeautifully),
                        ProperName = "Draws beautifully",
                        Description = "Draws beautifully"
                    },
                    #endregion

                    #region 11 Paints beautifully
                    //11 Paints beautifully
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(NPCTalentEnum.PaintsBeautifully),
                        ProperName = "Paints beautifully",
                        Description = "Paints beautifully"
                    },
                    #endregion

                    #region 12 Sings beautifully
                    //12 Sings beautifully
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(NPCTalentEnum.SingsBeautifully),
                        ProperName = "Sings beautifully",
                        Description = "Sings beautifully"
                    },
                    #endregion

                    #region 13 Drinks everyone under the table
                    //13 Drinks everyone under the table
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(NPCTalentEnum.DrinksEveryoneUnderTable),
                        ProperName = "Drinks everyone under the table",
                        Description = "Drinks everyone under the table"
                    },
                    #endregion

                    #region 14 Expert carpenter
                    //14 Expert carpenter
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(NPCTalentEnum.ExpertCarpenter),
                        ProperName = "Expert carpenter",
                        Description = "Expert carpenter"
                    },
                    #endregion

                    #region 15 Expert cook
                    //15 Expert cook
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(NPCTalentEnum.ExpertCook),
                        ProperName = "Expert cook",
                        Description = "Expert cook"
                    },
                    #endregion

                    #region 16 Expert dart thrower and rock skipper
                    //16 Expert dart thrower and rock skipper
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(NPCTalentEnum.ExpertDartThrower),
                        ProperName = "Expert dart thrower",
                        Description = "Expert dart thrower and rock skipper"
                    },
                    #endregion

                    #region 17 Expert juggler
                    //17 Expert juggler
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(NPCTalentEnum.ExpertJuggler),
                        ProperName = "Expert juggler",
                        Description = "Expert juggler"
                    },
                    #endregion

                    #region 18 Skilled actor and master of disguise
                    //18 Skilled actor and master of disguise
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(NPCTalentEnum.SkilledActor),
                        ProperName = "Skilled actor",
                        Description = "Skilled actor and master of disguise"
                    },
                    #endregion

                    #region 19 Skilled dancer
                    //19 Skilled dancer
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(NPCTalentEnum.SkilledDancer),
                        ProperName = "Skilled dancer",
                        Description = "Skilled dancer"
                    },
                    #endregion

                    #region 20 Knows thieves' cant 
                    //20 Knows thieves' cant 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(NPCTalentEnum.KnowsThievesCant),
                        ProperName = "Knows thieves' cant",
                        Description = "Knows thieves' cant"
                    },
                    #endregion
                };
            }
        }
    }
}



    