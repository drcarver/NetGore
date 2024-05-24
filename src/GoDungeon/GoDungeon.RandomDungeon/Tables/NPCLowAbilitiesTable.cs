using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.RandomDungeon.Tables
{
    /// <summary>
    /// You don't need to roll ability scores for the NPC, but
    /// note abilities that are above or below average- great
    /// strength or monumental stupidity, for example- and use
    /// them to inform the NPC's qualities. 
    /// </summary>
    public class NPCLowAbilitiesTable : RandomTable, INPCLowAbilitiesTable
    {
        /// <summary>
        /// </summary>
        public NPCLowAbilitiesTable()
        {
            Name = nameof(NPCLowAbilitiesTable);
            ProperName = "NPC Low Abilities Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 6;
            Description = "You don't need to roll ability scores for the NPC, but note abilities that are above or below average- great strength or monumental stupidity, for example- and use them to inform the NPC's qualities.";
        }

        //NPC ABILITIES
        //d6 High Ability
        //NPC ABILITIES
        //d6 Low Ability
        //1 Strength-feeble, scrawny
        //2 Dexterity-clumsy, fumbling
        //3 Constitution-sickly, pale
        //4 Intelligence-dim-witted, slow
        //5 Wisdom-oblivious, absentminded
        //6 Charisma-dull, boring
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
                    #region 1 Strength-feeble, scrawny
                    //1 Strength-feeble, scrawny
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(AbilityEnum.Strength),
                        ProperName = "feeble",
                        Description = "Strength-feeble, scrawny",
                    },
                    #endregion

                    #region 2 Dexterity-clumsy, fumbling
                    //2 Dexterity-clumsy, fumbling
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(AbilityEnum.Dexterity),
                        ProperName = "clumsy",
                        Description = "Dexterity-clumsy, fumbling",
                    },
                    #endregion

                    #region 3 Constitution-sickly, pale
                    //3 Constitution-sickly, pale
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(AbilityEnum.Constitution),
                        ProperName = "sickly",
                        Description = "Constitution-sickly, pale",
                    },
                    #endregion

                    #region 4 Intelligence-dim-witted, slow
                    //4 Intelligence-dim-witted, slow
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(AbilityEnum.Intelligence),
                        ProperName = "dim-witted",
                        Description = "Intelligence-dim-witted, slow",
                    },
                    #endregion

                    #region 5 Wisdom-oblivious, absentminded
                    //5 Wisdom-oblivious, absentminded
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(AbilityEnum.Wisdom),
                        ProperName = "absentminded",
                        Description = "Wisdom-oblivious, absentminded",
                    },
                    #endregion

                    #region 6 Charisma-dull, boring
                    //6 Charisma-dull, boring
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(AbilityEnum.Charisma),
                        ProperName = "dull",
                        Description = "Charisma-dull, boring",
                    },
                    #endregion
                };
            }
        }
    }

}


