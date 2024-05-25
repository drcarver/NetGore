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
    /// <summary>
    /// Adventure Patrons Table
    /// </summary>
    public class AdventurePatronsTable : RandomTable, IAdventurePatronsTable
    {
        /// <summary>
        /// </summary>
        public AdventurePatronsTable()
        {
            Name = nameof(AdventurePatronsTable);
            ProperName = "Adventure Patrons";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "Adventure Patrons Table";
        }

        //Adventure Patrons
        //d20 Patron d20 Patron
        //1-2 Retired adventurer 
        //3-4 Local ruler 
        //5-6 Military officer 
        //7-8 Temple official family member
        //9-10 Sage 
        //11-12 Respected elder commoner
        //13 Deity or celestial 
        //14 Mysterious fey merchant
        //15 Old friend
        //16 Former teacher
        //17 Parent or other
        //18 Desperate
        //19 Embattled
        //20 Villain posing as a patron
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
                    #region 1-2 Retired adventurer 
                    //1-2 Retired adventurer
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 02),
                        Name = nameof(AdventurePatronEnum.RetiredAdventurer),
                        ProperName = "Retired adventurer",
                        Description = "Retired adventurer",
                    },
                    #endregion

                    #region 3-4 Local ruler 
                    //3-4 Local ruler 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 04),
                        Name = nameof(AdventurePatronEnum.LocalRuler),
                        ProperName = "Local ruler",
                        Description = "Local ruler",
                    },
                    #endregion

                    #region 5-6 Military officer 
                    //5-6 Military officer
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 06),
                        Name = nameof(AdventurePatronEnum.MilitaryOfficer),
                        ProperName = "Military officer",
                        Description = "Military officer",
                    },
                    #endregion

                    #region 7-8 Temple official family member 
                    //7-8 Temple official family member
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 08),
                        Name = nameof(AdventurePatronEnum.TempleOfficial),
                        ProperName = "Temple official",
                        Description = "Temple official family member",
                    },
                    #endregion

                    #region 9-10 Sage 
                    //9-10 Sage
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 10),
                        Name = nameof(AdventurePatronEnum.Sage),
                        ProperName = "Sage",
                        Description = "Sage",
                    },
                    #endregion

                    #region 11-12 Respected elder commoner
                    //11-12 Respected elder commoner
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 12),
                        Name = nameof(AdventurePatronEnum.RespectedElderCommoner),
                        ProperName = "Respected elder commoner",
                        Description = "Respected elder commoner",
                    },
                    #endregion

                    #region 13 Deity or celestial 
                    //13 Deity or celestial 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(AdventurePatronEnum.Deity),
                        ProperName = "Deity",
                        Description = "Deity or celestial",
                    },
                    #endregion

                    #region 14 Mysterious fey merchant 
                    //14 Mysterious fey merchant
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(AdventurePatronEnum.MysteriousFeyMerchant),
                        ProperName = "Mysterious fey",
                        Description = "Mysterious fey merchant",
                    },
                    #endregion

                    #region 15 Old friend 
                    //15 Old friend
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(AdventurePatronEnum.OldFriend),
                        ProperName = "Old friend",
                        Description = "Old friend",
                    },
                    #endregion

                    #region 16 Former teacher 
                    //16 Former teacher
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(AdventurePatronEnum.FormerTeacher),
                        ProperName = "Former teacher",
                        Description = "Former teacher",
                    },
                    #endregion

                    #region 17 Parent or other 
                    //17 Parent or other
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(AdventurePatronEnum.Parent),
                        ProperName = "Parent",
                        Description = "Parent or other",
                    },
                    #endregion

                    #region 18 Desperate 
                    //18 Desperate
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(AdventurePatronEnum.Desperate),
                        ProperName = "Desperate",
                        Description = "Desperate",
                    },
                    #endregion

                    #region 19 Embattled 
                    //19 Embattled
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(AdventurePatronEnum.Embattled),
                        ProperName = "Embattled",
                        Description = "Embattled",
                    },
                    #endregion

                    #region 20 Villain posing as a patron 
                    //20 Villain posing as a patron
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(AdventurePatronEnum.Villain),
                        ProperName = "Villain as patron",
                        Description = "Villain posing as a patron",
                    },
                    #endregion
                };
            }
        }
    }
}

