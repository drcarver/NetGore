using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables
{
    public class LanguageTable : NamedTable, ILanguageTable
    {
        /// <summary>
        /// The Language Table
        /// </summary>
        public LanguageTable()
        {
            Name = nameof(LanguageTable);
            ProperName = "Language Table";
            Description = "Your race indicates the " +
                "languages your character can  speak by " +
                "default, and your background might give " +
                "you access to one or more additional " +
                "languages of  your choice.";
            TableType = TableTypeEnum.CharacterTable;
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
                    #region Common
                    // Common
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Common),
                    },
                    #endregion

                    #region Dwarvish
                    // Dwarvish
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Dwarvish),
                    },
                    #endregion

                    #region Elvish
                    // Elvish
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Elvish),
                    },
                    #endregion

                    #region Giant
                    // Giant
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Giant),
                    },
                    #endregion

                    #region Gnomish
                    // Gnomish
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Gnomish),
                    },
                    #endregion

                    #region Goblin
                    // Goblin
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Goblin),
                    },
                    #endregion

                    #region Halfling
                    // Halfling
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Halfling),
                    },
                    #endregion

                    #region Orc
                    // Orc
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Orc),
                    },
                    #endregion

                    #region Abyssal
                    // Abyssal
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Abyssal),
                    },
                    #endregion

                    #region Celestial
                    // Celestial
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Celestial),
                    },
                    #endregion

                    #region Draconic
                    // Draconic
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Draconic),
                    },
                    #endregion

                    #region Deep
                    // Deep
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Deep),
                    },
                    #endregion

                    #region Infernal
                    // Infernal
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Infernal),
                    },
                    #endregion

                    #region Primordial
                    // Primordial
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Primordial),
                    },
                    #endregion

                    #region Sylvan
                    // Sylvan
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Sylvan),
                    },
                    #endregion

                    #region Undercommon
                    // Undercommon
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Undercommon),
                    },
                    #endregion

                    #region Aquan
                    // Aquan
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Aquan),
                    },
                    #endregion

                    #region Gnoll
                    // Gnoll
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Gnoll),
                    },
                    #endregion

                    #region Auran
                    // Auran
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Auran),
                    },
                    #endregion

                    #region Terran
                    // Terran
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Terran),
                    },
                    #endregion
                };
            }
        }
    }
}
