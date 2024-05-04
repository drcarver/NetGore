using CommunityToolkit.Mvvm.Input;

using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.Interfaces;

namespace GoDungeon.MAUI.Tables;

public partial class MainMenuTable : GameTable, IMainMenu
{
    /// <summary>
    /// Constructor
    /// </summary>
    public MainMenuTable()
    {
        Name = nameof(MainMenuTable);
        ProperName = "Main Menu";
        Description = "Available Tables";
    }

    /// <summary>
    /// Fired when the selection changes
    /// </summary>
    [RelayCommand]
    private void SelectionChanged()
    {
        if (SelectionChanged != null)
        {
            if (SelectedItem != null)
            {
                Shell.Current.GoToAsync(((GameNavigationEntryViewModel)SelectedItem).Route);
            }
        }
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
                    TableType = Core.Enum.TableTypeEnum.BackgroundTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Character Tables
                new GameNavigationEntryViewModel
                {
                    Name = "CharacterTable",
                    ProperName = "Character Game Tables",
                    Description = "Character tables for the game.",
                    TableType = Core.Enum.TableTypeEnum.CharacterTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Core Tables
                new GameNavigationEntryViewModel
                {
                    Name = "CoreGameTable",
                    ProperName = "Core Game Tables",
                    Description = "Core tables for the game.",
                    TableType = Core.Enum.TableTypeEnum.CoreTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Equipment Tables
                new GameNavigationEntryViewModel
                {
                    Name = "EquipmentTable",
                    ProperName = "Equipment Game Tables",
                    Description = "Equipment tables for the game.",
                    TableType = Core.Enum.TableTypeEnum.EquipmentTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Gaming Tables
                new GameNavigationEntryViewModel
                {
                    Name = "GamingTable",
                    ProperName = "Gaming Tables",
                    Description = "Gaming tables for the game.",
                    TableType = Core.Enum.TableTypeEnum.GamingTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Magic Item Tables
                new GameNavigationEntryViewModel
                {
                    Name = "MagicItemTable",
                    ProperName = "Magic Items Table",
                    Description = "Magic Items table for the game.",
                    TableType = Core.Enum.TableTypeEnum.MagicItemTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Monster Tables
                new GameNavigationEntryViewModel
                {
                    Name = "MonsterTables",
                    ProperName = "Monster Tables",
                    Description = "Monster tables for the game.",
                    TableType = Core.Enum.TableTypeEnum.MonsterTable,
                    Route = $"{nameof(MainMenuTable)}View"
                },
                #endregion

                #region Spell Tables
                new GameNavigationEntryViewModel
                {
                    Name = "SpellTables",
                    ProperName = "Spell Tables",
                    Description = "Spell tables for the game.",
                    TableType = Core.Enum.TableTypeEnum.SpellTable,
                    Route = $"{nameof(MainMenuTable)}View"
                }
                #endregion
            ];
        }
    }
}
