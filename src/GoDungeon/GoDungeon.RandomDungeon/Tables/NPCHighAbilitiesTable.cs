using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.Tables
{
    /// <summary>
    /// You don't need to roll ability scores for the NPC, but
    /// note abilities that are above or below average- great
    /// strength or monumental stupidity, for example- and use
    /// them to inform the NPC's qualities. 
    /// </summary>
    public class NPCHighAbilitiesTable : RandomTable, INPCHighAbilitiesTable
    {
        /// <summary>
        /// </summary>
        public NPCHighAbilitiesTable()
        {
            Name = nameof(NPCHighAbilitiesTable);
            ProperName = "NPC High Abilities Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 6;
            Description = "You don't need to roll ability scores for the NPC, but note abilities that are above or below average- great strength or monumental stupidity, for example- and use them to inform the NPC's qualities.";
        }

        //NPC ABILITIES
        //d6 High Ability
        //1 Strength-powerful, brawny, strong as an ox
        //2 Dexterity-lithe, agile, graceful
        //3 Constitution-hardy, hale, healthy
        //4 Intelligence-studious, learned, inquisitive
        //5 Wisdom-perceptive, spiritual, insightful
        //6 Charisma-persuasive, forceful, born leader
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
                    #region 1 Strength-powerful, brawny, strong as an ox
                    //1 Strength-powerful, brawny, strong as an ox
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(AbilityEnum.Strength),
                        ProperName = "powerful",
                        Description = "Strength-powerful, brawny, strong as an ox",
                    },
                    #endregion

                    #region 2 Dexterity-lithe, agile, graceful
                    //2 Dexterity-lithe, agile, graceful
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(AbilityEnum.Dexterity),
                        ProperName = "graceful",
                        Description = "Dexterity-lithe, agile, graceful",
                    },
                    #endregion

                    #region 3 Constitution-hardy, hale, healthy
                    //3 Constitution-hardy, hale, healthy
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(AbilityEnum.Constitution),
                        ProperName = "hardy",
                        Description = "Constitution-hardy, hale, healthy",
                    },
                    #endregion

                    #region 4 Intelligence-studious, learned, inquisitive
                    //4 Intelligence-studious, learned, inquisitive
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(AbilityEnum.Intelligence),
                        ProperName = "studious",
                        Description = "Intelligence-studious, learned, inquisitive",
                    },
                    #endregion

                    #region 5 Wisdom-perceptive, spiritual, insightful
                    //5 Wisdom-perceptive, spiritual, insightful
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(AbilityEnum.Wisdom),
                        ProperName = "perceptive",
                        Description = "Wisdom-perceptive, spiritual, insightful",
                    },
                    #endregion

                    #region 6 Charisma-persuasive, forceful, born leader
                    //6 Charisma-persuasive, forceful, born leader
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(AbilityEnum.Charisma),
                        ProperName = "a born leader",
                        Description = "Charisma-persuasive, forceful, born leader",
                    },
                    #endregion
                };
            }
        }
    }

}

