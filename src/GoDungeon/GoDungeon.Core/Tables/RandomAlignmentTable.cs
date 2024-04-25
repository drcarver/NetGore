using System;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables
{
    /// <summary>
    /// The gender table.  
    /// </summary>
    public class RandomAlignmentTable : RandomTable, IRandomAlignmentTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RandomAlignmentTable()
        {
            Name = nameof(RandomAlignmentTable);
            ProperName = "Random Table for generating alignment";
            TableType = TableTypeEnum.CoreTable;
            DiceSides = 20;
        }

        /// <summary>
        /// The allowed alignments
        /// </summary>
        public AlignmentFilterEnum AlignmentFilter { get; set; } = AlignmentFilterEnum.NonEvil;

        /// <summary>
        /// Get the random range based on the alignment filter
        /// </summary>
        /// <param name="dice"></param>
        /// <returns>The random alignment</returns>
        public override IRandomTableEntry GetRandomRangeEntry(int dice = 0)
        {
            int dicesides = 0;
            int modifier = 1;
            switch (AlignmentFilter)
            {
                case AlignmentFilterEnum.EvilOnly:
                    dice = 6;
                    break;
                case AlignmentFilterEnum.GoodOnly:
                    dice = 8;
                    modifier = 13;
                    break;
                case AlignmentFilterEnum.NonGood:
                    dice = 12;
                    break;
                case AlignmentFilterEnum.NonEvil:
                    dice = 12;
                    modifier = 6;
                    break;
                case AlignmentFilterEnum.NeutralOnly:
                    dice = 6;
                    modifier = 6;
                    break;
                case AlignmentFilterEnum.AnyChaotic:
                    dice = 6;
                    modifier = 20;
                    break;
                case AlignmentFilterEnum.NonEvilChaotic:
                    dice = 4;
                    modifier = 20;
                    break;
                case AlignmentFilterEnum.AnyLawful:
                    dice = 6;
                    modifier = 26;
                    break;
                case AlignmentFilterEnum.NonEvilLawful:
                    dice = 4;
                    modifier = 26;
                    break;
                case AlignmentFilterEnum.Any:
                    dice = 20;
                    break;
            }
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                return GetRangeEntryByNumber(RandomNumberGenerator.GetInt32(dice) + modifier);
            }
        }

        //d20 Alignment
        //1–2 Chaotic evil
        //3-4 Neutral evil
        //5–6 Lawful evil
        //7-8 Chaotic neutral
        //9-10 Neutral
        //11-12 Lawful neutral
        //13-15 Chaotic good
        //15-17 Neutral good
        //18-20 Lawful good
        /// <summary>
        /// Initialize the game table.  This is a separate method 
        /// so we can create a game table for it;s meta properties
        /// with out creating the table.  A bit of optimization to 
        /// conserve memory
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region Chaotic evil
                    // 1–2 Chaotic evil
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(1, 2),
                        Name = nameof(AlignmentEnum.ChaoticEvil),
                        Description = "Chaotic Evil",
                        Alignment = AlignmentEnum.ChaoticEvil
                    },
                    #endregion

                    #region Neutral evil
                    //3-4 Neutral evil
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(3, 4),
                        Name = nameof(AlignmentEnum.NeutralEvil),
                        Description = "Neutral evil",
                        Alignment = AlignmentEnum.NeutralEvil
                    },
                    #endregion

                    #region Lawful evil
                    //5–6 Lawful evil
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(5, 6),
                        Name = nameof(AlignmentEnum.LawfulEvil),
                        Description = "Lawful evil",
                        Alignment = AlignmentEnum.LawfulEvil
                    },
                    #endregion

                    #region Chaotic neutral
                    //7-8 Chaotic neutral
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(7, 8),
                        Name = nameof(AlignmentEnum.ChaoticNeutral),
                        Description = "Chaotic neutral",
                        Alignment = AlignmentEnum.ChaoticNeutral
                    },
                    #endregion

                    #region Neutral
                    //9-10 Neutral
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(9, 10),
                        Name = nameof(AlignmentEnum.Neutral),
                        Description = "Neutral",
                        Alignment = AlignmentEnum.Neutral
                    },
                    #endregion

                    #region Lawful neutral
                    //11-12 Lawful neutral
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(11, 12),
                        Name = nameof(AlignmentEnum.LawfulNeutral),
                        Description = "Lawful neutral",
                        Alignment = AlignmentEnum.LawfulNeutral
                    },
                    #endregion

                    #region Chaotic good
                    //13-15 Chaotic good
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(13, 15),
                        Name = nameof(AlignmentEnum.ChaoticGood),
                        Description = "Chaotic good",
                        Alignment = AlignmentEnum.ChaoticGood
                    },
                    #endregion

                    #region Neutral good
                    //15-17 Neutral good
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(15, 17),
                        Name = nameof(AlignmentEnum.NeutralGood),
                        Description = "Neutral good",
                        Alignment = AlignmentEnum.NeutralGood
                    },
                    #endregion

                    #region Lawful good
                    //18–20 Lawful good
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(18, 20),
                        Name = nameof(AlignmentEnum.LawfulGood),
                        Description = "Lawful good",
                        Alignment = AlignmentEnum.LawfulGood
                    },
                    #endregion

                    #region Any Chaotic

                    #region Chaotic good
                    //21-22 Chaotic good
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(21, 22),
                        Name = nameof(AlignmentEnum.ChaoticGood),
                        Description = "Chaotic good",
                        Alignment = AlignmentEnum.ChaoticGood
                    },
                    #endregion

                    #region Chaotic neutral
                    //23-24 Chaotic neutral
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(23, 24),
                        Name = nameof(AlignmentEnum.ChaoticNeutral),
                        Description = "Chaotic neutral",
                        Alignment = AlignmentEnum.ChaoticNeutral
                    },
                    #endregion

                    #region Chaotic evil
                    //25-26 Chaotic evil
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(25, 26),
                        Name = nameof(AlignmentEnum.ChaoticEvil),
                        Description = "Chaotic Evil",
                        Alignment = AlignmentEnum.ChaoticEvil
                    },
                    #endregion

                    #endregion

                    #region Any Lawful

                    #region Lawful good
                    //27-28 Lawful good
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(27, 28),
                        Name = nameof(AlignmentEnum.LawfulGood),
                        Description = "Lawful good",
                        Alignment = AlignmentEnum.LawfulGood
                    },
                    #endregion

                    #region Lawful neutral
                    //29-30 Lawful neutral
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(29, 30),
                        Name = nameof(AlignmentEnum.LawfulNeutral),
                        Description = "Lawful neutral",
                        Alignment = AlignmentEnum.LawfulNeutral
                    },
                    #endregion

                    #region Lawful evil
                    //30–31 Lawful evil
                    new AlignmentTableEntryViewModel
                    {
                        Range = new Range(30, 31),
                        Name = nameof(AlignmentEnum.LawfulEvil),
                        Description = "Lawful evil",
                        Alignment = AlignmentEnum.LawfulEvil
                    },
                    #endregion

                    #endregion
                };
            }
        }
    }
}
