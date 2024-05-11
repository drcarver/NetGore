using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables
{
    /// <summary>
    /// Determine your character's alignment
    /// </summary>
    public class AlignmentTable : RandomTable, IAlignmentTable
    {
        /// <summary>
        /// Alignment Table
        /// </summary>
        public AlignmentTable()
        {
            Name = nameof(AlignmentTable);
            ProperName = "Alignment Table";
            DiceSides = 10;
            Description = "A typical creature in the game world has an alignment, which broadly describes its moral and personal attitudes. Alignment is a combination of two factors: one identifies morality (good, evil, or neutral), and the other describes attitudes toward society and order (lawful, chaotic, or neutral). Thus, nine distinct alignments define the possible combinations.";
            TableType = TableTypeEnum.CoreTable;
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method 
        /// so we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region Lawful Good
                    // LG(Lawful Good)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(1, 2),
                        Name = nameof(AlignmentEnum.LawfulGood),
                        ProperName = "Lawful good (LG)",
                        Alignment = AlignmentEnum.LawfulGood,
                        Description =
                            "Lawful good creatures can be counted on to do the right thing as expected by society. Gold dragons, paladins, and most dwarves are lawful good.",
                    },
                    #endregion

                    #region Neutral Good
                    // NG(Neutral Good)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(3, 3),
                        Name = nameof(AlignmentEnum.NeutralGood),
                        ProperName = "Neutral good (NG) ",
                        Alignment = AlignmentEnum.NeutralGood,
                        Description =
                            "Neutral good folk do the best they can to help others according to their needs. Many celestials, some cloud giants, and most gnomes are neutral good.",
                    },
                    #endregion

                    #region Chaotic Good
                    // CG(Chaotic Good)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(4, 4),
                        Name = nameof(AlignmentEnum.ChaoticGood),
                        ProperName = "Chaotic good (CG)",
                        Alignment = AlignmentEnum.ChaoticGood,
                        Description =
                            "Chaotic good creatures act as their conscience directs, with little regard for what others expect. Copper dragons, many elves, and unicorns are chaotic good.",
                    },
                    #endregion

                    #region Lawful Neutral
                    // LN(Lawful Neutral)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(5, 5),
                        Name = nameof(AlignmentEnum.LawfulNeutral),
                        ProperName = "Lawful neutral (LN)",
                        Alignment = AlignmentEnum.LawfulNeutral,
                        Description =
                            "Lawful neutral individuals act in accordance with law, tradition, or personal codes. Many monks and some wizards are lawful neutral.",
                    },
                    #endregion

                    #region Neutral
                    // N(Neutral)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(6, 6),
                        Name = nameof(AlignmentEnum.Neutral),
                        ProperName = "Neutral (N)",
                        Alignment = AlignmentEnum.Neutral,
                        Description =
                            "Neutral is the alignment of those who prefer to steer clear of moral questions and don't take sides, doing what seems best at the time. Lizardfolk, most druids, and many humans are neutral.",
                    },
                    #endregion

                    #region Chaotic Neutral
                    // CN(Chaotic Neutral)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(7, 7),
                        Name = nameof(AlignmentEnum.ChaoticNeutral),
                        ProperName = "Chaotic neutral (CN)",
                        Alignment = AlignmentEnum.ChaoticNeutral,
                        Description =
                            "Chaotic neutral creatures follow their whims, holding their personal freedom above all else. Many barbarians and rogues, and some bards, are chaotic neutral.",
                    },
                    #endregion

                    #region Lawful Evil
                    // LE(Lawful Evil)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(8, 8),
                        Name = nameof(AlignmentEnum.LawfulEvil),
                        ProperName = "Lawful evil (LE)",
                        Alignment = AlignmentEnum.LawfulEvil,
                        Description =
                            "Lawful evil creatures methodically take what they want, within the limits of a code of tradition, loyalty, or order. Devils, blue dragons, and hobgoblins are lawful evil.",
                    },
                    #endregion

                    #region Neutral Evil
                    // NE(Neutral Evil)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(9, 9),
                        Name = nameof(AlignmentEnum.NeutralEvil),
                        ProperName = "Neutral evil (NE)",
                        Alignment = AlignmentEnum.NeutralEvil,
                        Description =
                            "Neutral evil is the alignment of those who do whatever they can get away with, without compassion or qualms. Many drow, some cloud giants, and goblins are neutral evil.",
                    },
                    #endregion

                    #region Chaotic Evil
                    // CE(Chaotic Evil)
                    new AlignmentTableEntryViewModel
                    {
                        Range = new System.Range(10, 10),
                        Name = nameof(AlignmentEnum.ChaoticEvil),
                        ProperName = "Chaotic evil (CE)",
                        Alignment = AlignmentEnum.ChaoticEvil,
                        Description =
                            "Chaotic evil creatures act with arbitrary violence, spurred by their greed, hatred, or bloodlust. Demons, red dragons, and orcs are chaotic evil.",
                    },
                    #endregion
                };
            }
        }
    }
}
