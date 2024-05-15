using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Tables;

public class MonumentsTable : RandomTable, IMonumentsTable
{
    /// <summary>
    /// In places where civilization rules or once ruled, adventurers might find
    /// monuments built to honor great leaders, gods, and cultures.Use the
    /// Monuments table for inspiration, or randomly roll to determine what
    /// monument the adventurers stumble upon.
    /// </summary>
    public MonumentsTable()
    {
        Name = nameof(MonumentsTable);
        ProperName = "Monuments Table";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 20;
        Description = "In places where civilization rules or once ruled, adventurers might find monuments built to honor great leaders, gods, and cultures. Use the Monuments table for inspiration, or randomly roll to determine what monument the adventurers stumble upon.";
    }

    //MONUMENTS
    //d20 Monument
    //1 Sealed burial mound or pyramid
    //2  Plundered burial mound or pyramid
    //3  Faces carved into a mountainside or cliff
    //4   Giant statues carved out of a mountainside or cliff 
    //5-6  Intact obelisk etched with a warning, historical lore, dedication, or religious iconography
    //7-8  Ruined or toppled obelisk
    //9-10  Intact statue of a person or deity
    //11-13  Ruined or toppled statue of a person or deity
    //14  Great stone wall, intact, with tower fortifications spaced at one-mile intervals
    //15  Great stone wall in ruins
    //16  Great stone arch
    //17  Fountain
    //18  Intact circle of standing stones
    //19  Ruined or toppled circle of standing stones
    //20  Totem pole    
    /// <summary>
    /// Initialize the game table.  This is a separate method so we 
    /// can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        if (Table == null || Table.Count == 0)
        {
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region 1 Sealed burial mound or pyramid
                //1 Sealed burial mound or pyramid
                new RandomTableEntryViewModel
                {
                    Range = new Range(01, 01),
                    Name = nameof(MonumentEnum.SealedBurialMound),
                    ProperName = "Sealed burial mound",
                    Description = "Sealed burial mound or pyramid"
                },
                #endregion

                #region 2  Plundered burial mound or pyramid
                //2  Plundered burial mound or pyramid
                new RandomTableEntryViewModel
                {
                    Range = new Range(02, 02),
                    Name = nameof(MonumentEnum.PlunderedBurialMound),
                    ProperName = "Plundered burial mound",
                    Description = "Plundered burial mound or pyramid"
                },
                #endregion

                #region 3  Faces carved into a mountainside or cliff
                //3  Faces carved into a mountainside or cliff
                new RandomTableEntryViewModel
                {
                    Range = new Range(03, 03),
                    Name = nameof(MonumentEnum.Faces),
                    ProperName = "Faces",
                    Description = "Faces carved into a mountainside or cliff"
                },
                #endregion

                #region 4   Giant statues carved out of a mountainside or cliff
                //4   Giant statues carved out of a mountainside or cliff
                new RandomTableEntryViewModel
                {
                    Range = new Range(04, 04),
                    Name = nameof(MonumentEnum.GiantStatues),
                    ProperName = "Giant statues",
                    Description = "Giant statues carved out of a mountainside or cliff"
                },
                #endregion

                #region 5-6  Intact obelisk etched with a warning, historical lore, dedication, or religious iconography
                //5-6  Intact obelisk etched with a warning, historical lore, dedication, or religious iconography
                new RandomTableEntryViewModel
                {
                    Range = new Range(05, 06),
                    Name = nameof(MonumentEnum.IntactObelisk),
                    ProperName = "Intact obelisk",
                    Description = "Intact obelisk etched with a warning, historical lore, dedication, or religious iconography"
                },
                #endregion

                #region 7-8  Ruined or toppled obelisk
                //7-8  Ruined or toppled obelisk
                new RandomTableEntryViewModel
                {
                    Range = new Range(07, 08),
                    Name = nameof(MonumentEnum.ToppledObelisk),
                    ProperName = "Toppled obelisk",
                    Description = "Ruined or toppled obelisk"
                },
                #endregion

                #region 9-10  Intact statue of a person or deity
                //9-10  Intact statue of a person or deity
                new RandomTableEntryViewModel
                {
                    Range = new Range(09, 10),
                    Name = nameof(MonumentEnum.IntactStatue),
                    ProperName = "Intact statue",
                    Description = "Intact statue of a person or deity"
                },
                #endregion

                #region 11-13  Ruined or toppled statue of a person or deity
                //11-13  Ruined or toppled statue of a person or deity
                new RandomTableEntryViewModel
                {
                    Range = new Range(11, 13),
                    Name = nameof(MonumentEnum.ToppledStatue),
                    ProperName = "Toppled statue",
                    Description = "Ruined or toppled statue of a person or deity"
                },
                #endregion

                #region 14  Great stone wall, intact, with tower fortifications spaced at one-mile intervals
                //14  Great stone wall, intact, with tower fortifications spaced at one-mile intervals
                new RandomTableEntryViewModel
                {
                    Range = new Range(14, 14),
                    Name = nameof(MonumentEnum.IntactGreatStoneWall),
                    ProperName = "Intact Great stone wall",
                    Description = "Great stone wall, intact, with tower fortifications spaced at one-mile intervals"
                },
                #endregion

                #region 15  Great stone wall in ruins
                //15  Great stone wall in ruins
                new RandomTableEntryViewModel
                {
                    Range = new Range(15, 15),
                    Name = nameof(MonumentEnum.RuinedGreatStoneWall),
                    ProperName = "Great stone wall in ruins",
                    Description = "Great stone wall in ruins"
                },
                #endregion

                #region 16  Great stone arch
                //16  Great stone arch
                new RandomTableEntryViewModel
                {
                    Range = new Range(16, 16),
                    Name = nameof(MonumentEnum.GreatStoneArch),
                    ProperName = "Great stone arch",
                    Description = "Great stone arch"
                },
                #endregion

                #region 17  Fountain
                //17  Fountain
                new RandomTableEntryViewModel
                {
                    Range = new Range(17, 17),
                    Name = nameof(MonumentEnum.Fountain),
                    ProperName = "Fountain",
                    Description = "Fountain"
                },
                #endregion

                #region 18  Intact circle of standing stones
                //18  Intact circle of standing stones
                new RandomTableEntryViewModel
                {
                    Range = new Range(18, 18),
                    Name = nameof(MonumentEnum.IntactCircle),
                    ProperName = "Intact circle of standing stones",
                    Description = "Intact circle of standing stones"
                },
                #endregion

                #region 19  Ruined or toppled circle of standing stones
                //19  Ruined or toppled circle of standing stones
                new RandomTableEntryViewModel
                {
                    Range = new Range(19, 19),
                    Name = nameof(MonumentEnum.ToppledCircle),
                    ProperName = "Toppled circle",
                    Description = "Ruined or toppled circle of standing stones"
                },
                #endregion

                #region 20  Totem pole
                //20  Totem pole
                new RandomTableEntryViewModel
                {
                    Range = new Range(20, 20),
                    Name = nameof(MonumentEnum.TotemPole),
                    ProperName = "Totem pole",
                    Description = "Totem pole"
                },
                #endregion
            };
        }
    }
}
