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
    /// In one sentence, describe the NPC's most distinctive
    /// physical features.You can roll on the NPC Appearance
    /// table or choose a feature that suits the character
    /// </summary>
    public class NPCAppearanceTable : RandomTable, INPCAppearanceTable
    {
        /// <summary>
        /// </summary>
        public NPCAppearanceTable()
        {
            Name = nameof(NPCAppearanceTable);
            ProperName = "NPC Appearance Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 20;
            Description = "In one sentence, describe the NPC's most distinctive physical features. You can roll on the NPC Appearance table or choose a feature that suits the character";
        }

        //NPC APPEARANCE
        //d20 Feature
        //1 Distinctive jewelry: earrings, necklace, circlet,
        //bracelets
        //2 Piercings
        //3 Flamboyant or outlandish clothes
        //4 Formal, clean clothes
        //5 Ragged, dirty clothes
        //6 Pronounced scar
        //7 Missing teeth
        //8 Missing fingers
        //9 Unusual eye color (or two different colors)
        //10 Tattoos
        //11 Birthmark
        //12 Unusual skin color
        //13 Bald
        //14 Braided beard or hair
        //15 Unusual hair color
        //16 Nervous eye twitch
        //17 Distinctive nose
        //18 Distinctive posture (crooked or rigid)
        //19 Exceptionally beautiful
        //20 Exceptionally ugly
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
                    #region 1 Distinctive jewelry: earrings, necklace, circlet, bracelets
                    //1 Distinctive jewelry: earrings, necklace, circlet, bracelets
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(NPCAppearanceEnum.DistinctiveJewelry),
                        ProperName = "Distinctive jewelry",
                        Description = "Distinctive jewelry: earrings, necklace, circlet, bracelets",
                    },
                    #endregion

                    #region 2 Piercings
                    //2 Piercings
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(NPCAppearanceEnum.Piercings),
                        ProperName = "Piercings",
                        Description = "Piercings",
                    },
                    #endregion

                    #region 3 Flamboyant or outlandish clothes
                    //3 Flamboyant or outlandish clothes
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(03, 03),
                        Name = nameof(NPCAppearanceEnum.FlamboyantClothes),
                        ProperName = "Flamboyant clothes",
                        Description = "Flamboyant or outlandish clothes",
                    },
                    #endregion

                    #region 4 Formal, clean clothes
                    //4 Formal, clean clothes
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(04, 04),
                        Name = nameof(NPCAppearanceEnum.FormalClothes),
                        ProperName = "Formal clothes",
                        Description = "Formal, clean clothes",
                    },
                    #endregion

                    #region 5 Ragged, dirty clothes
                    //5 Ragged, dirty clothes
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(NPCAppearanceEnum.RaggedClothes),
                        ProperName = "Ragged clothes",
                        Description = "Ragged, dirty clothes",
                    },
                    #endregion

                    #region 6 Pronounced scar
                    //6 Pronounced scar
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(NPCAppearanceEnum.PronouncedScar),
                        ProperName = "Pronounced scar",
                        Description = "Pronounced scar",
                    },
                    #endregion

                    #region 7 Missing teeth
                    //7 Missing teeth
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(07, 07),
                        Name = nameof(NPCAppearanceEnum.MissingTeeth),
                        ProperName = "Missing teeth",
                        Description = "Missing teeth",
                    },
                    #endregion

                    #region 8 Missing fingers
                    //8 Missing fingers
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(08, 08),
                        Name = nameof(NPCAppearanceEnum.MissingFingers),
                        ProperName = "Missing fingers",
                        Description = "Missing fingers",
                    },
                    #endregion

                    #region 9 Unusual eye color (or two different colors)
                    //9 Unusual eye color (or two different colors)
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(09, 09),
                        Name = nameof(NPCAppearanceEnum.UnusualEyeColor),
                        ProperName = "Unusual eye color",
                        Description = "Unusual eye color (or two different colors)",
                    },
                    #endregion

                    #region 10 Tattoos
                    //10 Tattoos
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(10, 10),
                        Name = nameof(NPCAppearanceEnum.Tattoos),
                        ProperName = "Tattoos",
                        Description = "Tattoos",
                    },
                    #endregion

                    #region 11 Birthmark
                    //11 Birthmark
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(11, 11),
                        Name = nameof(NPCAppearanceEnum.Birthmark),
                        ProperName = "Birthmark",
                        Description = "Birthmark",
                    },
                    #endregion

                    #region 12 Unusual skin color
                    //12 Unusual skin color
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(12, 12),
                        Name = nameof(NPCAppearanceEnum.UnusualSkinColor),
                        ProperName = "Unusual skin color",
                        Description = "Unusual skin color",
                    },
                    #endregion

                    #region 13 Bald
                    //13 Bald
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(13, 13),
                        Name = nameof(NPCAppearanceEnum.Bald),
                        ProperName = "Bald",
                        Description = "Bald",
                    },
                    #endregion

                    #region 14 Braided beard or hair
                    //14 Braided beard or hair
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(14, 14),
                        Name = nameof(NPCAppearanceEnum.BraidedBeard),
                        ProperName = "Braided beard or hair",
                        Description = "Braided beard or hair",
                    },
                    #endregion

                    #region 15 Unusual hair color
                    //15 Unusual hair color
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(15, 15),
                        Name = nameof(NPCAppearanceEnum.UnusualHairColor),
                        ProperName = "Unusual hair color",
                        Description = "Unusual hair color",
                    },
                    #endregion

                    #region 16 Nervous eye twitch
                    //16 Nervous eye twitch
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(16, 16),
                        Name = nameof(NPCAppearanceEnum.NervousEyeTwitch),
                        ProperName = "Nervous eye twitch",
                        Description = "Nervous eye twitch",
                    },
                    #endregion

                    #region 17 Distinctive nose
                    //17 Distinctive nose
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(17, 17),
                        Name = nameof(NPCAppearanceEnum.DistinctiveNose),
                        ProperName = "Distinctive nose",
                        Description = "Distinctive nose",
                    },
                    #endregion

                    #region 18 Distinctive posture (crooked or rigid)
                    //18 Distinctive posture (crooked or rigid)
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(18, 18),
                        Name = nameof(NPCAppearanceEnum.DistinctivePosture),
                        ProperName = "Distinctive posture",
                        Description = "Distinctive posture (crooked or rigid)",
                    },
                    #endregion

                    #region 19 Exceptionally beautiful
                    //19 Exceptionally beautiful
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(19, 19),
                        Name = nameof(NPCAppearanceEnum.ExceptionallyBeautiful),
                        ProperName = "Exceptionally beautiful",
                        Description = "Exceptionally beautiful",
                    },
                    #endregion

                    #region 20 Exceptionally ugly
                    //20 Exceptionally ugly
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(20, 20),
                        Name = nameof(NPCAppearanceEnum.ExceptionallyUgly),
                        ProperName = "Exceptionally ugly",
                        Description = "Exceptionally ugly",
                    },
                    #endregion
                };
            }
        }
    }

}


