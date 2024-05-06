using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables;
using GoDungeon.Background.Tables.Dragonborn;
using GoDungeon.Background.Tables.Dwarf;
using GoDungeon.Background.Tables.Elf;
using GoDungeon.Background.Tables.Gnome;
using GoDungeon.Background.Tables.HalfElf;
using GoDungeon.Core.Enum;
using GoDungeon.MAUI.Background.Interfaces;
using GoDungeon.MAUI.Background.Views;
using GoDungeon.MAUI.Core.ViewModels;

namespace GoDungeon.MAUI.Background.Tables;

public partial class RacialBackgroundMenuTable : MenuTable, IRacialBackgroundMenuTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    public RacialBackgroundMenuTable(IServiceProvider services)
        : base(services)
    {
        Name = nameof(RacialBackgroundMenuTable);
        ProperName = "Racial Background Table Menu";
        Description = "Available Racial Background Tables";
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
                #region Dragonborn Homeland Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(DragonbornHomelandTable),
                    ProperName = "Dragonborn Homeland Table",
                    Description = "Dragonborn Homeland Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IDragonbornHomelandTable)
                },
                #endregion

                #region Dragonborn Parents Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(DragonbornParentsTable),
                    ProperName = "Dragonborn Parents Table",
                    Description = "Dragonborn Parents Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IDragonbornParentsTable)
                },
                #endregion

                #region Dragonborn Siblings Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(DragonbornSiblingsTable),
                    ProperName = "Dragonborn Siblings Table",
                    Description = "Dragonborn Siblings Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IDragonbornSiblingsTable)
                },
                #endregion

                #region Dwarf Homeland Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(DwarfHomelandTable),
                    ProperName = "Dwarf Homeland Table",
                    Description = "Dwarf Homeland Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IDwarfHomelandTable)
                },
                #endregion

                #region Dwarf Parents Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(DwarfParentsTable),
                    ProperName = "Dwarf Parents Table",
                    Description = "Dwarf Parents Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IDwarfParentsTable)
                },
                #endregion

                #region Dwarf Siblings Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(DwarfSiblingsTable),
                    ProperName = "Dwarf Siblings Table",
                    Description = "Dwarf Siblings Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IDwarfSiblingsTable)
                },
                #endregion

                #region Elf Homeland Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(ElfHomelandTable),
                    ProperName = "Elf Homeland Table",
                    Description = "Elf Homeland Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IElfHomelandTable)
                },
                #endregion

                #region Elf Parents Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(ElfParentsTable),
                    ProperName = "Elf Parents Table",
                    Description = "Elf Parents Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IElfParentsTable)
                },
                #endregion

                #region Elf Siblings Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(ElfSiblingsTable),
                    ProperName = "Elf Siblings Table",
                    Description = "Elf Siblings Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IElfSiblingsTable)
                },
                #endregion

                #region Gnome Homeland Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(GnomeHomelandTable),
                    ProperName = "Gnome Homeland Table",
                    Description = "Gnome Homeland Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IGnomeHomelandTable)
                },
                #endregion

                #region Gnome Parents Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(GnomeParentsTable),
                    ProperName = "Gnome Parents Table",
                    Description = "Gnome Parents Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IGnomeParentsTable)
                },
                #endregion

                #region Gnome Siblings Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(GnomeSiblingsTable),
                    ProperName = "Gnome Siblings Table",
                    Description = "Gnome Siblings Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IGnomeSiblingsTable)
                },
                #endregion

                #region HalfElf Homeland Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(HalfElfHomelandTable),
                    ProperName = "HalfElf Homeland Table",
                    Description = "HalfElf Homeland Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IHalfElfHomelandTable)
                },
                #endregion

                #region HalfElf Parents Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(HalfElfParentsTable),
                    ProperName = "HalfElf Parents Table",
                    Description = "HalfElf Parents Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IHalfElfParentsTable)
                },
                #endregion

                #region HalfElf Siblings Table
                new GameNavigationEntryViewModel
                {
                    Name = nameof(HalfElfSiblingsTable),
                    ProperName = "HalfElf Siblings Table",
                    Description = "HalfElf Siblings Table",
                    TableType = TableTypeEnum.BackgroundTable,
                    Route = nameof(BackgroundTablePage),
                    PageDetailType = typeof(IHalfElfSiblingsTable)
                },
                #endregion
            ];
        }
    }
}
