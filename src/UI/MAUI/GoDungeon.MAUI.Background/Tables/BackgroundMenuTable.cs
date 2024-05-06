using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables;
using GoDungeon.Core.Enum;
using GoDungeon.MAUI.Background.Interfaces;
using GoDungeon.MAUI.Background.Views;
using GoDungeon.MAUI.Core.ViewModels;
using GoDungeon.MAUI.Core.Views;

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
                #region Racial Background Menu Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(RacialBackgroundMenuTable),
                    ProperName = "Racial Background Menu",
                    Description = "Racial Background Menu",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(MenuTablePage),
                    PageDetailType = typeof(IRacialBackgroundMenuTable)
                },
                #endregion

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
 
                #region Conflict Motivation Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(ConflictMotivationTable),
                    ProperName = "Conflict Motivation Table",
                    Description = "Conflict Motivation Table",
                    TableType = TableTypeEnum.ConflictTable,
                    Route = nameof(ConflictTablePage),
                    PageDetailType = typeof(IConflictMotivationTable)
                },
                #endregion
 
                #region Conflict Resolution Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(ConflictResolutionTable),
                    ProperName = "Conflict Resolution Table",
                    Description = "Conflict Resolution Table",
                    TableType = TableTypeEnum.ConflictTable,
                    Route = nameof(ConflictTablePage),
                    PageDetailType = typeof(IConflictResolutionTable)
                },
                #endregion
 
                #region Conflict Subject Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(ConflictSubjectTable),
                    ProperName = "Conflict Subject Table",
                    Description = "Conflict Subject Table",
                    TableType = TableTypeEnum.ConflictTable,
                    Route = nameof(ConflictTablePage),
                    PageDetailType = typeof(IConflictSubjectTable)
                },
                #endregion
 
                #region Conflict Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(ConflictTable),
                    ProperName = "Conflict Table",
                    Description = "Conflict Table",
                    TableType = TableTypeEnum.ConflictTable,
                    Route = nameof(ConflictTablePage),
                    PageDetailType = typeof(IConflictTable)
                },
                #endregion
 
                #region Crime Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(CrimeTable),
                    ProperName = "Crime Table",
                    Description = "Crime Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(ICrimeTable)
                },
                #endregion
 
                #region Influential Associates Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(InfluentialAssociatesTable),
                    ProperName = "Influential Associates Table",
                    Description = "Influential Associates Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IInfluentialAssociatesTable)
                },
                #endregion
 
                #region Major Childhood Event Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(MajorChildhoodEventTable),
                    ProperName = "Major Childhood Event Table",
                    Description = "Major Childhood Event Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IMajorChildhoodEventTable)
                },
                #endregion
 
                #region Nobility Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(NobilityTable),
                    ProperName = "Nobility Table",
                    Description = "Nobility Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(INobilityTable)
                },
                #endregion
 
                #region Profession Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(ProfessionTable),
                    ProperName = "Profession Table",
                    Description = "Profession Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IProfessionTable)
                },
                #endregion
 
                #region Punishment Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(PunishmentTable),
                    ProperName = "Punishment Table",
                    Description = "Punishment Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IPunishmentTable)
                },
                #endregion
 
                #region Relationship with Fellow Adventurer Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(RelationshipwithFellowAdventurerTable),
                    ProperName = "Relationship with Fellow Adventurer Table",
                    Description = "Relationship with Fellow Adventurer Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IRelationshipwithFellowAdventurerTable)
                },
                #endregion
 
                #region Relative Age of Sibling Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(RelativeAgeofSiblingTable),
                    ProperName = "Relative Age of Sibling Table",
                    Description = "Relative Age of Sibling Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IRelativeAgeofSiblingTable)
                },
                #endregion
 
                #region Romantic Relationships Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(RomanticRelationshipsTable),
                    ProperName = "Romantic Relationships Table",
                    Description = "Romantic Relationships Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IRomanticRelationshipsTable)
                },
                #endregion
 
                #region Unusual Homeland Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(UnusualHomelandTable),
                    ProperName = "Unusual Homeland Table",
                    Description = "Unusual Homeland Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IUnusualHomelandTable)
                },
                #endregion
            ];
        }
    }
}
