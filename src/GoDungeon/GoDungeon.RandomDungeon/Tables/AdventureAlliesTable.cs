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
    /// Adventure Allies
    /// </summary>
    public class AdventureAlliesTable : RandomTable, IAdventureAlliesTable
    {
        /// <summary>
        /// </summary>
        public AdventureAlliesTable()
        {
            Name = nameof(AdventureAlliesTable);
            ProperName = "Adventure Allies";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 12;
            Description = "Adventure Allies";
        }

        //ADVENTURE ALLIES
        //d12 Ally d12
        //1 Skilled adventurer 
        //2 Inexperienced adventurer
        //3 Enthusiastic commoner
        //4 Soldier
        //5 Priest
        //6 Sage
        //7 Revenge seeker
        //8 Raving lunatic
        //9 Celestial ally
        //10 Fey ally
        //11 Disguised monster
        //12 Villain in posing as an ally
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
                    #region 1 Skilled adventurer 
                    //1 Skilled adventurer 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(AdventureAlliesEnum.SkilledAdventurer),
                        ProperName = "Skilled adventurer ",
                        Description = "Skilled adventurer ",
                    },
                    #endregion

                    #region 2 Inexperienced adventurer 
                    //2 Inexperienced adventurer
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(AdventureAlliesEnum.InexperiencedAdventurer),
                        ProperName = "Inexperienced adventurer",
                        Description = "Inexperienced adventurer",
                    },
                    #endregion

                    #region 3 Enthusiastic commoner 
                    //3 Enthusiastic commoner
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(AdventureAlliesEnum.EnthusiasticCommoner),
                        ProperName = "Enthusiastic commoner",
                        Description = "Enthusiastic commoner",
                    },
                    #endregion

                    #region 4 Soldier 
                    //4 Soldier
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(AdventureAlliesEnum.Soldier),
                        ProperName = "Soldier",
                        Description = "Soldier",
                    },
                    #endregion

                    #region 5 Priest 
                    //5 Priest
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(AdventureAlliesEnum.Priest),
                        ProperName = "Priest",
                        Description = "Priest",
                    },
                    #endregion

                    #region 6 Sage 
                    //6 Sage
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(AdventureAlliesEnum.Sage),
                        ProperName = "Sage",
                        Description = "Sage",
                    },
                    #endregion

                    #region 7 Revenge seeker 
                    //7 Revenge seeker
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 07),
                        Name = nameof(AdventureAlliesEnum.RevengeSeeker),
                        ProperName = "Revenge seeker",
                        Description = "Revenge seeker",
                    },
                    #endregion

                    #region 8 Raving lunatic
                    //8 Raving lunatic
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(AdventureAlliesEnum.RavingLunatic),
                        ProperName = "Raving lunatic",
                        Description = "Raving lunatic",
                    },
                    #endregion

                    #region 9 Celestial ally
                    //9 Celestial ally
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(AdventureAlliesEnum.CelestialAlly),
                        ProperName = "Celestial ally",
                        Description = "Celestial ally",
                    },
                    #endregion

                    #region 10 Fey ally
                    //10 Fey ally
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(AdventureAlliesEnum.FeyAlly),
                        ProperName = "Fey ally",
                        Description = "Fey ally",
                    },
                    #endregion

                    #region 11 Disguised monster
                    //11 Disguised monster
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(AdventureAlliesEnum.DisguisedMonster),
                        ProperName = "Disguised monster",
                        Description = "Disguised monster",
                    },
                    #endregion

                    #region 12 Villain in posing as an ally
                    //12 Villain in posing as an ally
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(AdventureAlliesEnum.VillainPosing),
                        ProperName = "Villain in posing as an ally",
                        Description = "Villain in posing as an ally",
                    },
                    #endregion
                };
            }
        }
    }

}
