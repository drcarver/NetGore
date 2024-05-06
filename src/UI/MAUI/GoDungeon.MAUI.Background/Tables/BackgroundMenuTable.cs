using GoDungeon.Background.Tables;
using GoDungeon.Core.Enum;
using GoDungeon.MAUI.Background.Interfaces;
using GoDungeon.MAUI.Background.Views;
using GoDungeon.MAUI.Core.ViewModels;

namespace GoDungeon.MAUI.Background.Tables;

public partial class BackgroundMenuTable : MenuTable, IBackgroundMenuTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    public BackgroundMenuTable()
    {
        Name = nameof(BackgroundMenuTable);
        ProperName = "Background Table Menu";
        Description = "Available Background Tables";
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
                #region Adopted Outside Your Race Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(AdoptedOutsideYourRaceTablePage),
                    ProperName = "Adopted Outside Your Race Table",
                    Description = "Adopted Outside Your Race Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(AdoptedOutsideYourRaceTablePage)
                },
                #endregion
 
                #region Character Drawback Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(CharacterDrawbackTablePage),
                    ProperName = "Character Drawback Table",
                    Description = "Character Drawback Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(CharacterDrawbackTablePage)
                },
                #endregion
            ];
        }
    }
}
