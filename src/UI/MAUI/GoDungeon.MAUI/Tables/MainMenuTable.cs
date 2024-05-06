using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.MAUI.Background.Views;
using GoDungeon.MAUI.Core.ViewModels;
using GoDungeon.MAUI.Core.Views;
using GoDungeon.MAUI.Interfaces;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.Tables;

namespace GoDungeon.MAUI.Tables;

public partial class MainMenuTable : MenuTable, IMainMenuTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    public MainMenuTable(IServiceProvider services)
        : base(services)
    {
        Name = nameof(MainMenuTable);
        ProperName = "Main Menu";
        Description = "Available Tables";

        IHumanoidRaceTable? raceTable = services.GetService<IHumanoidRaceTable>();
        if (raceTable == null)
        {
            raceTable = new HumanoidRaceTable();
        }

        IHumanoidRaceFactory? raceFactory = services.GetService<IHumanoidRaceFactory>();
        var halfling = raceFactory?.Create(RaceEnum.Halfling);
        var randomRace = raceFactory?.CreateRandom();
        var gametables = services.GetServices<IRandomTable>().ToList();
    }

    /// <summary>
    /// The main menu
    /// </summary>
    public override void InitializeTable()
    {
        if (Table == null || Table.Count == 0)
        {
            Table =
            [
                #region Background Tables
                new GameNavigationEntryViewModel
                {
                    Name = "BackgroundTable",
                    ProperName = "Background Game Tables",
                    Description = "Background tables for the game.",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundMenuTablePage)
                },
                #endregion

                #region Character Tables
                new GameNavigationEntryViewModel
                {
                    Name = "CharacterTable",
                    ProperName = "Character Game Tables",
                    Description = "Character tables for the game.",
                    TableType = TableTypeEnum.CharacterTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Core Tables
                new GameNavigationEntryViewModel
                {
                    Name = "CoreGameTable",
                    ProperName = "Core Game Tables",
                    Description = "Core tables for the game.",
                    TableType = TableTypeEnum.CoreTable,
                    Route = nameof(CoreMenuTablePage)
                },
                #endregion

                #region Equipment Tables
                new GameNavigationEntryViewModel
                {
                    Name = "EquipmentTable",
                    ProperName = "Equipment Game Tables",
                    Description = "Equipment tables for the game.",
                    TableType = TableTypeEnum.EquipmentTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Gaming Tables
                new GameNavigationEntryViewModel
                {
                    Name = "GamingTable",
                    ProperName = "Gaming Tables",
                    Description = "Gaming tables for the game.",
                    TableType = TableTypeEnum.GamingTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Magic Item Tables
                new GameNavigationEntryViewModel
                {
                    Name = "MagicItemTable",
                    ProperName = "Magic Items Table",
                    Description = "Magic Items table for the game.",
                    TableType = TableTypeEnum.MagicItemTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Monster Tables
                new GameNavigationEntryViewModel
                {
                    Name = "MonsterTables",
                    ProperName = "Monster Tables",
                    Description = "Monster tables for the game.",
                    TableType = TableTypeEnum.MonsterTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Spell Tables
                new GameNavigationEntryViewModel
                {
                    Name = "SpellTables",
                    ProperName = "Spell Tables",
                    Description = "Spell tables for the game.",
                    TableType = TableTypeEnum.SpellTable,
                    Route = $"{nameof(MainMenuTable)}View"
                }
                #endregion
            ];
        }
    }
}
