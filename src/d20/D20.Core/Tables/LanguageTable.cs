using System.Collections.Generic;

using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core.Tables
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
            if (Table.Count == 0) 
            {
                Table = new List<IGameTableEntry>
                {
                    #region Common
                    // Common
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Common),
                    },
                    #endregion

                    #region Dwarvish
                    // Dwarvish
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Dwarvish),
                    },
                    #endregion

                    #region Elvish
                    // Elvish
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Elvish),
                    },
                    #endregion

                    #region Giant
                    // Giant
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Giant),
                    },
                    #endregion

                    #region Gnomish
                    // Gnomish
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Gnomish),
                    },
                    #endregion

                    #region Goblin
                    // Goblin
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Goblin),
                    },
                    #endregion

                    #region Halfling
                    // Halfling
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Halfling),
                    },
                    #endregion

                    #region Orc
                    // Orc
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Orc),
                    },
                    #endregion

                    #region Abyssal
                    // Abyssal
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Abyssal),
                    },
                    #endregion

                    #region Celestial
                    // Celestial
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Celestial),
                    },
                    #endregion

                    #region Draconic
                    // Draconic
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Draconic),
                    },
                    #endregion

                    #region Deep
                    // Deep
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Deep),
                    },
                    #endregion

                    #region Infernal
                    // Infernal
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Infernal),
                    },
                    #endregion

                    #region Primordial
                    // Primordial
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Primordial),
                    },
                    #endregion

                    #region Sylvan
                    // Sylvan
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Sylvan),
                    },
                    #endregion

                    #region Undercommon
                    // Undercommon
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Undercommon),
                    },
                    #endregion

                    #region Aquan
                    // Aquan
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Aquan),
                    },
                    #endregion

                    #region Gnoll
                    // Gnoll
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Gnoll),
                    },
                    #endregion

                    #region Auran
                    // Auran
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Auran),
                    },
                    #endregion

                    #region Terran
                    // Terran
                    new StandardTableEntry
                    {
                        Name = nameof(LanguageEnum.Terran),
                    },
                    #endregion
                };
            }
        }
    }
}
