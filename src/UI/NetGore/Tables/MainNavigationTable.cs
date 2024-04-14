using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using D20.Core.Enum;
using D20.Core.Models;
using NetGore.Interfaces;
using NetGore.UI.Admin.ViewModel;
using NetGore.UI.Admin.Views;
using NetGore.Views;

namespace NetGore.Tables;

public class MainNavigationTable : GameTable, IMainNavigationTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public MainNavigationTable()
    {
        Name = nameof(MainPage);
        Description = "Available Game Tables";
        ProperName = "Main Menu";
        Table =
        [
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.BackgroundTable),
                ProperName = "Character background tables",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.BackgroundTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.CharacterTable),
                ProperName = "Character tables",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.CharacterTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.ConflictTable),
                ProperName = "Character Conflict tables",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.ConflictTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.RaceTable),
                ProperName = "Characer races tables",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.RaceTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.GameTable),
                ProperName = "Misc Game tables",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.GameTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.GoodsTable),
                ProperName = "Equipment and goods tables",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.GoodsTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.MagicItemTable),
                ProperName = "Magic Items A-Z",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.MagicItemTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.MonsterTable),
                ProperName = "Monster tables A-Z",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.MonsterTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.PantheonTable),
                ProperName = "Pantheon tables.  The gods and goddesses",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.PantheonTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.SpellTable),
                ProperName = "Spell table by classs",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.SpellTable
            },
        ];
    }
}
