using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Data.d20;

public class LanguageTable : GameTable, ILanguageTable
{
    /// <summary>
    /// The Language Table
    /// </summary>
    [SetsRequiredMembers]
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
        Table =
        [
            #region Common
            // Common
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Common),
            },
            #endregion

            #region Dwarvish
            // Dwarvish
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Dwarvish),
            },
            #endregion

            #region Elvish
            // Elvish
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Elvish),
            },
            #endregion

            #region Giant
            // Giant
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Giant),
            },
            #endregion

            #region Gnomish
            // Gnomish
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Gnomish),
            },
            #endregion

            #region Goblin
            // Goblin
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Goblin),
            },
            #endregion

            #region Halfling
            // Halfling
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Halfling),
            },
            #endregion

            #region Orc
            // Orc
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Orc),
            },
            #endregion

            #region Abyssal
            // Abyssal
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Abyssal),
            },
            #endregion

            #region Celestial
            // Celestial
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Celestial),
            },
            #endregion

            #region Draconic
            // Draconic
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Draconic),
            },
            #endregion

            #region Deep
            // Deep
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Deep),
            },
            #endregion

            #region Infernal
            // Infernal
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Infernal),
            },
            #endregion

            #region Primordial
            // Primordial
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Primordial),
            },
            #endregion

            #region Sylvan
            // Sylvan
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Sylvan),
            },
            #endregion

            #region Undercommon
            // Undercommon
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Undercommon),
            },
            #endregion

            #region Aquan
            // Aquan
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Aquan),
            },
            #endregion

            #region Gnoll
            // Gnoll
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Gnoll),
            },
            #endregion

            #region Auran
            // Auran
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Auran),
            },
            #endregion

            #region Terran
            // Terran
            new GameTableEntry
            {
                Name = nameof(LanguageEnum.Terran),
            },
            #endregion
        ];
    }
}
