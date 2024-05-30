using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.Core.Interfaces;
using GoDungeon.MAUI.Core.ViewModels;
using GoDungeon.MAUI.Core.Views;
using GoDungeon.MAUI.DungeonMap.Views;
using GoDungeon.MAUI.Interfaces;
using GoDungeon.MAUI.PlayerCharacter.Views;
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
                #region Generate a Random Dungeon
                new GameNavigationEntryViewModel
                {
                    Name = "Generate a Random Dungeon",
                    ProperName = "Generate a Random Dungeon",
                    Description = "Generate a Random Dungeon.",
                    TableType = TableTypeEnum.RandomDungeonTable,
                    Route = nameof(DungeonMapPage),
                },
                #endregion

                #region Create a Character
                new GameNavigationEntryViewModel
                {
                    Name = "Create a Player Character",
                    ProperName = "Create a Player Character",
                    Description = "Create a Player Character for your account.",
                    TableType = TableTypeEnum.CharacterTable,
                    Route = nameof(CreatePlayerCharacterPage),
                },
                #endregion

                #region Background Tables
                new GameNavigationEntryViewModel
                {
                    Name = "BackgroundTable",
                    ProperName = "Background Game Tables",
                    Description = "Background tables for the game.",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(MenuTablePage),
                    PageDetailType = typeof(IBackgroundMenuTable)
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
