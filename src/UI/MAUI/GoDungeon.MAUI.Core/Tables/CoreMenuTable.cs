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
                #region Ability Modifier Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(AbilityModifierTable),
                    ProperName = "Ability Modifier Table",
                    Description = "Ability modifiers for Player Character.",
                    TableType = TableTypeEnum.CharacterTable,
                    Route = nameof(AbilityModifierTablePage)
                },
                #endregion

                #region Ability Modifier Table
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
