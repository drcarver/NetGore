using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Tables;

/// <summary>
/// </summary>
public class DungeonHistoryTable : RandomTable, IDungeonHistoryTable
{
    /// <summary>
    /// In most cases, the original architects of a dungeon are long gone, and the 
    /// question of what happened to them can help shape the dungeon's current state.
    /// The Dungeon History table notes key events that can transform a site from 
    /// its original purpose into a dungeon for adventurers to explore. Particularly 
    /// old dungeons can have a history that consists of multiple events, each of 
    /// which transformed the site in some way.
    /// </summary>
    public DungeonHistoryTable()
    {
        Name = nameof(DungeonHistoryTable);
        ProperName = "Dungeon History Table";
        TableType = TableTypeEnum.RandomDungeonTable;
        DiceSides = 20;
        Description =
            "In most cases, the original architects of a dungeon are long gone, and the question of what happened to them can help shape the dungeon's current state. The Dungeon History table notes key events that can transform a site from its original purpose into a dungeon for adventurers to explore. Particularly old dungeons can have a history that consists of multiple events, each of which transformed the site in some way.";
    }

    //DUNGEON HISTORY
    //d20 Key Event
    //1-3  Abandoned by creators
    //4  Abandoned due to plague
    //5-8  Conquered by invaders
    //9-10  Creators destroyed by attacking raiders
    //11  Creators destroyed by discovery made within the site
    //12  Creators destroyed by internal conflict
    //13   Creators destroyed by magical catastrophe
    //14-15  Creators destroyed by natural disaster
    //16  Location cursed by the gods and shunned
    //17-18  Original creator still in control
    //19  Overrun by planar creatures
    //20  Site of a great miracle
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
                #region 1-3  Abandoned by creators
                //1-3  Abandoned by creators
                new RandomTableEntryViewModel
                {
                    Range = new Range(01, 03),
                    Name = nameof(DungeonHistoryEnum.Abandoned),
                    ProperName = "Abandoned",
                    Description = "Abandoned by creators"
                },
                #endregion

                #region 4  Abandoned due to plague
                //4  Abandoned due to plague
                new RandomTableEntryViewModel
                {
                    Range = new Range(04, 04),
                    Name = nameof(DungeonHistoryEnum.Plague),
                    ProperName = "Plague",
                    Description = "Abandoned due to plague"
                },
                #endregion

                #region 5-8  Conquered by invaders
                //5-8  Conquered by invaders
                new RandomTableEntryViewModel
                {
                    Range = new Range(05, 08),
                    Name = nameof(DungeonHistoryEnum.Conquered),
                    ProperName = "Conquered",
                    Description = "Conquered by invaders"
                },
                #endregion

                #region 9-10  Creators destroyed by attacking raiders
                //9-10  Creators destroyed by attacking raiders
                new RandomTableEntryViewModel
                {
                    Range = new Range(09, 10),
                    Name = nameof(DungeonHistoryEnum.Raiders),
                    ProperName = "Destroyed by raiders",
                    Description = "Creators destroyed by attacking raiders"
                },
                #endregion

                #region 11  Creators destroyed by discovery made within the site
                //11  Creators destroyed by discovery made within the site
                new RandomTableEntryViewModel
                {
                    Range = new Range(11, 11),
                    Name = nameof(DungeonHistoryEnum.Discovery),
                    ProperName = "Creators destroyed by discovery",
                    Description = "Creators destroyed by discovery made within the site"
                },
                #endregion

                #region 12  Creators destroyed by internal conflict
                //12  Creators destroyed by internal conflict
                new RandomTableEntryViewModel
                {
                    Range = new Range(12, 12),
                    Name = nameof(DungeonHistoryEnum.InternalConflict),
                    ProperName = "Internal conflict",
                    Description = "Creators destroyed by internal conflict"
                },
                #endregion

                #region 13   Creators destroyed by magical catastrophe
                //13   Creators destroyed by magical catastrophe
                new RandomTableEntryViewModel
                {
                    Range = new Range(13, 13),
                    Name = nameof(DungeonHistoryEnum.MagicalCatastrophe),
                    ProperName = "Magical catastrophe",
                    Description = "Creators destroyed by magical catastrophe"
                },
                #endregion

                #region 14-15  Creators destroyed by natural disaster
                //14-15  Creators destroyed by natural disaster
                new RandomTableEntryViewModel
                {
                    Range = new Range(14, 15),
                    Name = nameof(DungeonHistoryEnum.NaturalDisaster),
                    ProperName = "Natural disaster",
                    Description = "Creators destroyed by natural disaster"
                },
                #endregion

                #region 16  Location cursed by the gods and shunned
                //16  Location cursed by the gods and shunned
                new RandomTableEntryViewModel
                {
                    Range = new Range(16, 16),
                    Name = nameof(DungeonHistoryEnum.Cursed),
                    ProperName = "Location cursed",
                    Description = "Location cursed by the gods and shunned"
                },
                #endregion

                #region 17-18  Original creator still in control
                //17-18  Original creator still in control
                new RandomTableEntryViewModel
                {
                    Range = new Range(17, 18),
                    Name = nameof(DungeonHistoryEnum.OriginalCreator),
                    ProperName = "Original creator",
                    Description = "Original creator still in control"
                },
                #endregion

                #region 19  Overrun by planar creatures
                //19  Overrun by planar creatures
                new RandomTableEntryViewModel
                {
                    Range = new Range(19, 19),
                    Name = nameof(DungeonHistoryEnum.Overrun),
                    ProperName = "Overrun",
                    Description = "Overrun by planar creatures"
                },
                #endregion

                #region 20  Site of a great miracle
                //20  Site of a great miracle
                new RandomTableEntryViewModel
                {
                    Range = new Range(20, 20),
                    Name = nameof(DungeonHistoryEnum.GreatMiracle),
                    ProperName = "Great miracle",
                    Description = "Site of a great miracle"
                },
                #endregion
            };
        }
    }
}


