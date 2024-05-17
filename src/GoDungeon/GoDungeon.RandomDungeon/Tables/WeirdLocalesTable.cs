using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.Tables
{
    public class WeirdLocalesTable : RandomTable, IWeirdLocalesTable
    {
        /// <summary>
        /// Weird locales make the fantastic and the supernatural an intrinsic 
        /// part of your wilderness adventures.
        /// </summary>
        public WeirdLocalesTable()
        {
            Name = nameof(WeirdLocalesTable);
            ProperName = "Weird Locales Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "Weird locales make the fantastic and the supernatural an intrinsic part of your wilderness adventures.";
        }

        //WEIRD LOCALES
        //d20 Locale
        //1-2  Dead magic zone(similar to an antimagic field)
        //3   Wild magic zone(roll on the Wild Magic Surge table in the Player's
        //    Handbook whenever a spell is cast within the zone)
        //4  Boulder carved with talking faces
        //5  Crystal cave that mystically answers questions
        //6  Ancient tree containing a trapped spirit
        //7-8  Battlefield where lingering fog occasionally assumes humanoid forms
        //9-10  Permanent portal to another plane of existence
        //11  Wishing well
        //12  Giant crystal shard protruding from the ground
        //13  Wrecked ship, which might be nowhere near water
        //14-15  Haunted hill or barrow mound
        //16  River ferry guided by a skeletal captain
        //17  Field of petrified soldiers or other creatures
        //18  Forest of petrified or awakened trees
        //19  Canyon containing a dragons' graveyard
        //20  Floating earth mote with a tower on it
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
                    #region 1-2  Dead magic zone(similar to an antimagic field)
                    //1-2  Dead magic zone(similar to an antimagic field)
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 02),
                        Name = nameof(WeirdLocalesEnum.DeadMagicZone),
                        ProperName = "Dead magic zone",
                        Description = "Dead magic zone(similar to an antimagic field)"
                    },
                    #endregion

                    #region 3   Wild magic zone(roll on the Wild Magic Surge table in the Player's
                    //3   Wild magic zone(roll on the Wild Magic Surge table in the Player's
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(WeirdLocalesEnum.WildMagicZone),
                        ProperName = "Wild magic zone",
                        Description = "Wild magic zone (roll on the Wild Magic Surge table in the Player's Handbook whenever a spell is cast within the zone)"
                    },
                    #endregion

                    #region 4  Boulder carved with talking faces
                    //4  Boulder carved with talking faces
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(WeirdLocalesEnum.CarvedBoulder),
                        ProperName = "Carved Boulder",
                        Description = "Boulder carved with talking faces"
                    },
                    #endregion

                    #region 5  Crystal cave that mystically answers questions
                    //5  Crystal cave that mystically answers questions
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(WeirdLocalesEnum.CrystalCave),
                        ProperName = "Crystal cave",
                        Description = "Crystal cave that mystically answers questions"
                    },
                    #endregion

                    #region 6  Ancient tree containing a trapped spirit
                    //6  Ancient tree containing a trapped spirit
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(WeirdLocalesEnum.AncientTree),
                        ProperName = "Ancient tree",
                        Description = "Ancient tree containing a trapped spirit"
                    },
                    #endregion

                    #region 7-8  Battlefield where lingering fog occasionally assumes humanoid forms
                    //7-8  Battlefield where lingering fog occasionally assumes humanoid forms
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 08),
                        Name = nameof(WeirdLocalesEnum.Battlefield),
                        ProperName = "Battlefield",
                        Description = "Battlefield where lingering fog occasionally assumes humanoid forms"
                    },
                    #endregion

                    #region 9-10  Permanent portal to another plane of existence
                    //9-10  Permanent portal to another plane of existence
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 10),
                        Name = nameof(WeirdLocalesEnum.PermanentPortal),
                        ProperName = "PermanentPortal",
                        Description = "Permanent portal to another plane of existence"
                    },
                    #endregion

                    #region 11  Wishing well
                    //11  Wishing well
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(WeirdLocalesEnum.WishingWell),
                        ProperName = "Wishing Well",
                        Description = "Wishing well"
                    },
                    #endregion

                    #region 12  Giant crystal shard protruding from the ground
                    //12  Giant crystal shard protruding from the ground
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(WeirdLocalesEnum.GiantCrystal),
                        ProperName = "Giant crystal",
                        Description = "Giant crystal shard protruding from the ground"
                    },
                    #endregion

                    #region 13  Wrecked ship, which might be nowhere near water
                    //13  Wrecked ship, which might be nowhere near water
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(WeirdLocalesEnum.WreckedShip),
                        ProperName = "Wrecked ship",
                        Description = "Wrecked ship, which might be nowhere near water"
                    },
                    #endregion

                    #region 14-15  Haunted hill or barrow mound
                    //14-15  Haunted hill or barrow mound
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 15),
                        Name = nameof(WeirdLocalesEnum.HauntedHill),
                        ProperName = "Haunted hill",
                        Description = "Haunted hill or barrow mound"
                    },
                    #endregion

                    #region 16  River ferry guided by a skeletal captain
                    //16  River ferry guided by a skeletal captain
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(WeirdLocalesEnum.RiverFerry),
                        ProperName = "River ferry",
                        Description = "River ferry guided by a skeletal captain"
                    },
                    #endregion

                    #region 17  Field of petrified soldiers or other creatures
                    //17  Field of petrified soldiers or other creatures
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(WeirdLocalesEnum.PetrifiedSoldiers),
                        ProperName = "Petrified Soldiers",
                        Description = "Field of petrified soldiers or other creatures"
                    },
                    #endregion

                    #region 18  Forest of petrified or awakened trees
                    //18  Forest of petrified or awakened trees
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(WeirdLocalesEnum.PetrifiedTrees),
                        ProperName = "Petrified trees",
                        Description = "Forest of petrified or awakened trees"
                    },
                    #endregion

                    #region 19  Canyon containing a dragons' graveyard
                    //19  Canyon containing a dragons' graveyard
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(WeirdLocalesEnum.DragonsGraveyard),
                        ProperName = "Dragons' Graveyard",
                        Description = "Canyon containing a dragons' graveyard"
                    },
                    #endregion

                    #region 20  Floating earth mote with a tower on it
                    //20  Floating earth mote with a tower on it
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(WeirdLocalesEnum.FloatingEarthMote),
                        ProperName = "Floating earth mote",
                        Description = "20  Floating earth mote with a tower on it"
                    },
                    #endregion
                };
            }
        }
    }
}
