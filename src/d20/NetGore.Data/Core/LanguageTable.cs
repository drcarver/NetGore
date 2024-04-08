using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Data.Core;

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
        TableType = TableTypeEnum.GameTable;
        DiceSides = 20;
        Table =
        [
            #region Common
            //01	Common
            new GameTableEntry
            {
                Range = new Range(01, 01),
                Name = nameof(LanguageEnum.Common),
            },
            #endregion

            #region Dwarvish
            //02	Dwarvish
            new GameTableEntry
            {
                Range = new Range(02, 02),
                Name = nameof(LanguageEnum.Dwarvish),
            },
            #endregion

            #region Elvish
            //03	Elvish
            new GameTableEntry
            {
                Range = new Range(03, 03),
                Name = nameof(LanguageEnum.Elvish),
            },
            #endregion

            #region Giant
            //04	Giant
            new GameTableEntry
            {
                Range = new Range(04, 04),
                Name = nameof(LanguageEnum.Giant),
            },
            #endregion

            #region Gnomish
            //05	Gnomish
            new GameTableEntry
            {
                Range = new Range(05, 05),
                Name = nameof(LanguageEnum.Gnomish),
            },
            #endregion

            #region Goblin
            //06	Goblin
            new GameTableEntry
            {
                Range = new Range(06, 06),
                Name = nameof(LanguageEnum.Goblin),
            },
            #endregion

            #region Halfling
            //07	Halfling
            new GameTableEntry
            {
                Range = new Range(07, 07),
                Name = nameof(LanguageEnum.Halfling),
            },
            #endregion

            #region Orc
            //08	Orc
            new GameTableEntry
            {
                Range = new Range(08, 08),
                Name = nameof(LanguageEnum.Orc),
            },
            #endregion

            #region Abyssal
            //09	Abyssal
            new GameTableEntry
            {
                Range = new Range(09, 09),
                Name = nameof(LanguageEnum.Abyssal),
            },
            #endregion

            #region Celestial
            //10	Celestial
            new GameTableEntry
            {
                Range = new Range(10, 10),
                Name = nameof(LanguageEnum.Celestial),
            },
            #endregion

            #region Draconic
            //11	Draconic
            new GameTableEntry
            {
                Range = new Range(11, 11),
                Name = nameof(LanguageEnum.Draconic),
            },
            #endregion

            #region Deep
            //12	Deep
            new GameTableEntry
            {
                Range = new Range(12, 12),
                Name = nameof(LanguageEnum.Deep),
            },
            #endregion

            #region Infernal
            //13	Infernal
            new GameTableEntry
            {
                Range = new Range(13, 13),
                Name = nameof(LanguageEnum.Infernal),
            },
            #endregion

            #region Primordial
            //14	Primordial
            new GameTableEntry
            {
                Range = new Range(14, 14),
                Name = nameof(LanguageEnum.Primordial),
            },
            #endregion

            #region Sylvan
            //15	Sylvan
            new GameTableEntry
            {
                Range = new Range(15, 15),
                Name = nameof(LanguageEnum.Sylvan),
            },
            #endregion

            #region Undercommon
            //16	Undercommon
            new GameTableEntry
            {
                Range = new Range(16, 16),
                Name = nameof(LanguageEnum.Undercommon),
            },
            #endregion

            #region Aquan
            //17	Aquan
            new GameTableEntry
            {
                Range = new Range(17, 17),
                Name = nameof(LanguageEnum.Aquan),
            },
            #endregion

            #region Gnoll
            //18	Gnoll
            new GameTableEntry
            {
                Range = new Range(18, 18),
                Name = nameof(LanguageEnum.Gnoll),
            },
            #endregion

            #region Auran
            //19	Auran
            new GameTableEntry
            {
                Range = new Range(19, 19),
                Name = nameof(LanguageEnum.Auran),
            },
            #endregion

            #region Terran
            //20	Terran
            new GameTableEntry
            {
                Range = new Range(20, 20),
                Name = nameof(LanguageEnum.Terran),
            },
            #endregion
        ];
    }
}
