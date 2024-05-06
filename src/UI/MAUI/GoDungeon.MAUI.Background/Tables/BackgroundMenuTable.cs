using GoDungeon.Background.Interfaces;
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
    public BackgroundMenuTable(IServiceProvider services)
        : base(services)
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
                    Name = nameof(AdoptedOutsideYourRaceTable),
                    ProperName = "Adopted Outside Your Race Table",
                    Description = "Adopted Outside Your Race Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IAdoptedOutsideYourRaceTable)
                },
                #endregion
 
                #region Character Drawback Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(CharacterDrawbackTable),
                    ProperName = "Character Drawback Table",
                    Description = "Character Drawback Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(ICharacterDrawbackTable)
                },
                #endregion
 
                #region Circumstance of Birth Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(CircumstanceofBirthTable),
                    ProperName = "Circumstance of Birth Table",
                    Description = "Circumstance of Birth Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(ICircumstanceofBirthTable)
                },
                #endregion
            ];
        }
    }
}
