using System;
using System.Collections.ObjectModel;
using System.Data;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;

using Syncfusion.DocIO.DLS;

namespace GoDungeon.RandomDungeon.Tables
{
    public class AdventureIntroductionTable  : RandomTable, IAdventureIntroductionTable
    {
        /// <summary>
        /// An adventure can begin with a social interaction encounter in which
        /// the adventurers find out what they must do and why.It can start 
        /// with a surprise attack, or with the adventurers coming across 
        /// information by accident.  The best introductions arise naturally 
        /// from the goals and setting of the adventure. Let the entries in the
        /// Adventure Introduction table inspire you.
        /// </summary>
        public AdventureIntroductionTable()
        {
            Name = nameof(AdventureIntroductionTable);
            ProperName = "Adventure Introduction Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 12;
            Description = "An adventure can begin with a social interaction encounter in which the adventurers find out what they must do and why. It can start with a surprise attack, or with the adventurers coming across information by accident. The best introductions arise naturally from the goals and setting of the adventure. Let the entries in the Adventure Introduction table inspire you.";
        }

        //Adventure Introduction Table
        //d20 Talent
        //1 While traveling in the wilderness, the characters
        //fall into a sinkhole that opens beneath their feet,
        //dropping them into the adventure location.
        //2 While traveling in the wilderness, the characters
        //notice the entrance to the adventure location.
        //3 While traveling on a road, the characters are
        //attacked by monsters that flee into the nearby
        //adventure location.
        //4 The adventurers find a map on a dead body. In
        //addition to the map setting up the adventure, the
        //adventure's villain wants the map.
        //5 A mysterious magic item or a cruel villain teleports
        //the characters to the adventure location .
        //6 A stranger approaches the characters in a tavern
        //and urges them toward the adventure location.
        //7 A town or village needs volunteers to go to the
        //adventure location.
        //8 An NPC the characters care about needs them to
        //go to the adventure location.
        //9 An NPC the characters must obey orders them to
        //go to the adventure location.
        //10 An NPC the characters respect asks them to go to
        //the adventure location.
        //11 One night, the characters all dream about entering
        //the adventure location.
        //12 A ghost appears and terrorizes a village. Research
        //reveals that it can be put to rest only by entering the
        //adventure location.
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
                    #region 1 While traveling in the wilderness, the characters fall into a sinkhole that opens beneath their feet, dropping them into the adventure location.
                    //1 While traveling in the wilderness, the characters fall into a sinkhole that opens beneath their feet, dropping them into the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(AdventureIntroductionEnum.WildernessSinkHole),
                        ProperName = "While traveling in the wilderness, the characters fall into a sinkhole that opens beneath their feet, dropping them into the adventure location.",
                        Description = "While traveling in the wilderness, the characters fall into a sinkhole that opens beneath their feet, dropping them into the adventure location."
                    },
                    #endregion

                    #region 2 While traveling in the wilderness, the characters notice the entrance to the adventure location.
                    //2 While traveling in the wilderness, the characters notice the entrance to the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(AdventureIntroductionEnum.WildernessEntrance),
                        ProperName = "While traveling in the wilderness, the characters notice the entrance to the adventure location.",
                        Description = "While traveling in the wilderness, the characters notice the entrance to the adventure location."
                    },
                    #endregion

                    #region 3 While traveling on a road, the characters are attacked by monsters that flee into the nearby adventure location.
                    //3 While traveling on a road, the characters are attacked by monsters that flee into the nearby adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(AdventureIntroductionEnum.RoadAttackedByMonsters),
                        ProperName = "While traveling on a road, the characters are attacked by monsters that flee into the nearby adventure location.",
                        Description = "While traveling on a road, the characters are attacked by monsters that flee into the nearby adventure location."
                    },
                    #endregion

                    #region 4 The adventurers find a map on a dead body. In addition to the map setting up the adventure, the adventure's villain wants the map.
                    //4 The adventurers find a map on a dead body. In addition to the map setting up the adventure, the adventure's villain wants the map.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(AdventureIntroductionEnum.MapOnADeadBody),
                        ProperName = "The adventurers find a map on a dead body. In addition to the map setting up the adventure, the adventure's villain wants the map.",
                        Description = "The adventurers find a map on a dead body. In addition to the map setting up the adventure, the adventure's villain wants the map."
                    },
                    #endregion

                    #region 5 A mysterious magic item or a cruel villain teleports the characters to the adventure location.
                    //5 A mysterious magic item or a cruel villain teleports the characters to the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(AdventureIntroductionEnum.MysteriousMagicItem),
                        ProperName = "A mysterious magic item or a cruel villain teleports the characters to the adventure location.",
                        Description = "A mysterious magic item or a cruel villain teleports the characters to the adventure location."
                    },
                    #endregion

                    #region 6 A stranger approaches the characters in a tavern and urges them toward the adventure location.
                    //6 A stranger approaches the characters in a tavern and urges them toward the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(AdventureIntroductionEnum.StrangerInATavern),
                        ProperName = "A stranger approaches the characters in a tavern and urges them toward the adventure location.",
                        Description = "A stranger approaches the characters in a tavern and urges them toward the adventure location."
                    },
                    #endregion

                    #region 7 A town or village needs volunteers to go to the adventure location.
                    //7 A town or village needs volunteers to go to the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 07),
                        Name = nameof(AdventureIntroductionEnum.VillageNeedsVolunteers),
                        ProperName = "A town or village needs volunteers to go to the adventure location.",
                        Description = "A town or village needs volunteers to go to the adventure location."
                    },
                    #endregion

                    #region 8 An NPC the characters care about needs them to go to the adventure location.
                    //8 An NPC the characters care about needs them to go to the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(AdventureIntroductionEnum.AnNPCNeedsThem),
                        ProperName = "An NPC the characters care about needs them.",
                        Description = "An NPC the characters care about needs them to go to the adventure location."
                    },
                    #endregion

                    #region 9 An NPC the characters must obey orders them to go to the adventure location.
                    //9 An NPC the characters must obey orders them to go to the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(AdventureIntroductionEnum.AnNPCTheyMustObey),
                        ProperName = "An NPC the characters must obey orders.",
                        Description = "An NPC the characters must obey orders them to go to the adventure location."
                    },
                    #endregion

                    #region 10 An NPC the characters respect asks them to go to the adventure location.
                    //10 An NPC the characters respect asks them to go to the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(AdventureIntroductionEnum.AnNPCTheyRespect),
                        ProperName = "An NPC they respect",
                        Description = "An NPC the characters respect asks them to go to the adventure location."
                    },
                    #endregion

                    #region 11 One night, the characters all dream about entering the adventure location.
                    //11 One night, the characters all dream about entering the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(AdventureIntroductionEnum.InADream),
                        ProperName = "The characters all dream about the location.",
                        Description = "One night, the characters all dream about entering the adventure location."
                    },
                    #endregion

                    #region 12 A ghost appears and terrorizes a village. Research reveals that it can be put to rest only by entering the adventure location.
                    //12 A ghost appears and terrorizes a village. Research reveals that it can be put to rest only by entering the adventure location.
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(AdventureIntroductionEnum.AGhostAppears),
                        ProperName = "A ghost appears and terrorizes a village.",
                        Description = "A ghost appears and terrorizes a village. Research reveals that it can be put to rest only by entering the adventure location."
                    },
                    #endregion
                };
            }
        }
    }
}


    