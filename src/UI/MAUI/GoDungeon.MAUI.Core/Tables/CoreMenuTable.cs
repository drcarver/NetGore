using GoDungeon.Core.Enum;
using GoDungeon.Core.Tables;
using GoDungeon.MAUI.Core.Interfaces;
using GoDungeon.MAUI.Core.ViewModels;
using GoDungeon.MAUI.Core.Views;

namespace GoDungeon.MAUI.Core.Tables;

public partial class CoreMenuTable : MenuTable, ICoreMenuTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    public CoreMenuTable()
    {
        Name = nameof(CoreMenuTable);
        ProperName = "Core Table Menu";
        Description = "Available Core Tables";
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
                #region Acrobatics Modifier Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(AlignmentTable),
                    ProperName = "Acrobatics Modifier Table",
                    Description = "Acrobatics Modifier",
                    TableType = TableTypeEnum.CoreTable,
                    Route = nameof(AcrobaticsModifierTablePage)
                },
                #endregion

                #region Alignment Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(AlignmentTable),
                    ProperName = "Alignment Table",
                    Description = "Creature Alignment",
                    TableType = TableTypeEnum.CoreTable,
                    Route = nameof(AlignmentTablePage)
                },
                #endregion

                #region Gender Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(GenderTable),
                    ProperName = "Gender Table",
                    Description = "Creature Gender",
                    TableType = TableTypeEnum.CoreTable,
                    Route = nameof(GenderTablePage)
                },
                #endregion

                #region Language Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(LanguageTable),
                    ProperName = "Language Table",
                    Description = "Creature Languages",
                    TableType = TableTypeEnum.CoreTable,
                    Route = nameof(LanguageTablePage)
                },
                #endregion

                #region Spell Ability Modifier Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(SpellAbilityModifierTable),
                    ProperName = "Spell Ability Modifier Table",
                    Description = "Spell Ability Modifier Table",
                    TableType = TableTypeEnum.CoreTable,
                    Route = nameof(SpellAbilityModifierTablePage)
                },
                #endregion
            ];
        }
    }
}
