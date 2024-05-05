using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables
{
    /// <summary>
    /// Determine a creature's skills
    /// </summary>
    public class SkillTable : NamedTable, ISkillTable
    {
        /// <summary>
        /// Skill Table
        /// </summary>
        public SkillTable()
        {
            Name = nameof(SkillTable);
            ProperName = "Skill Table";
            TableType = TableTypeEnum.CoreTable;
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method 
        /// so we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    // Acrobatics
                    new SkillTableEntryViewModel
                    {
                        Name = nameof(SkillEnum.Acrobatics),
                        ProperName = "Acrobatics",
                        Ability = AbilityEnum.Dexterity,
                        Description =
                            "You can keep your balance while traversing " +
                            "narrow or treacherous surfaces. You can " +
                            "also dive, flip, jump, and roll, avoiding " +
                            "attacks and confusing your opponents.",
                        ArmorCheckPenalty = 0
                    },

                    // Appraise
                    new SkillTableEntryViewModel
                    {
                        Name = nameof(SkillEnum.Appraise),
                        ProperName = "Appraise",
                        Ability = AbilityEnum.Intelligence,
                        Description =
                            "A DC 20 Appraise check determines the " +
                            "value of a common item. If you succeed " +
                            "by 5 or more, you also determine if " +
                            "the item has magic properties, although " +
                            "this success does not grant knowledge " +
                            "of the magic item’s abilities. If you " +
                            "fail the check by less than 5, you " +
                            "determine the price of that item to " +
                            "within 20% of its actual value. If you " +
                            "fail this check by 5 or more, the price " +
                            "is wildly inaccurate. Particularly rare " +
                            "or exotic items might increase the DC " +
                            "of this check by 5 or more.",
                        Action = "Appraising an item takes 1 standard " +
                            "action. Determining the most valuable " +
                            "object in a treasure hoard takes 1 " +
                            "full-round action.",
                        TryAgain = "Additional attempts to Appraise an " +
                            "item reveal the same result.",
                    },

                    // Diplomacy
                    new SkillTableEntryViewModel
                    {
                        Name = nameof(SkillEnum.Diplomacy),
                        ProperName = "Diplomacy",
                        Ability = AbilityEnum.Charisma,
                        Description =
                            "You can use this skill to persuade others " +
                            "to agree with your arguments, to resolve " +
                            "differences, and to gather valuable " +
                            "information or rumors from people. This " +
                            "skill is also used to negotiate conflicts " +
                            "by using the proper etiquette and manners " +
                            "suitable to the problem."
                    },
                };
            }
        }
    }
}
