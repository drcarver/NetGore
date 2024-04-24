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

public class MainNavigationTable : NamedTable, IMainNavigationTable
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
    }

    /// <summary>
    /// Initialize the game table.  This is a separate method so we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
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
                ProperName = "Character races tables",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.RaceTable
            },
            new GameNavigationTableEntry
            {
                Name = nameof(TableType.CoreTable),
                ProperName = "Core Game tables",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.CoreTable
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
                ProperName = "Spell tables by class",
                Route = nameof(GameTableAdminPage),
                TableType = TableTypeEnum.SpellTable
            },
        ];
    }
}
