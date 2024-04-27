using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.Spells.Enum;

namespace GoDungeon.Spells.Tables.Bard
{
    public class BardCantripSpellTable : NamedTable, IBardCantripSpellTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BardCantripSpellTable()
        {
            Name = nameof(BardCantripSpellTable);
            ProperName = "Bard CanTrip Spells";
            TableType = TableTypeEnum.SpellTable;
            Description =
                "Bards have a talent for song and story, and they " +
                "come to their careers by developing this talent " +
                "as they pick up on a smattering of other skills.";
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method so 
        /// we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region Dancing Lights
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.DancingLights),
                        ProperName = "Dancing Lights",
                    },
                    #endregion

                    #region Light
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Light),
                        ProperName = "Light",
                    },
                    #endregion

                    #region Mage Hand
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.MageHand),
                        ProperName = "Mage Hand",
                    },
                    #endregion

                    #region Mending
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Mending),
                        ProperName = "Mending",
                    },
                    #endregion

                    #region Message
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Message),
                        ProperName = "Message",
                    },
                    #endregion

                    #region Minor Illusion
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.MinorIllusion),
                        ProperName = "Minor Illusion",
                    },
                    #endregion

                    #region Prestidigitation
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Prestidigitation),
                        ProperName = "Prestidigitation",
                    },
                    #endregion

                    #region True Strike
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.TrueStrike),
                        ProperName = "True Strike",
                    },
                    #endregion

                    #region Vicious Mockery
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.ViciousMockery),
                        ProperName = "Vicious Mockery",
                    },
                    #endregion
                };
            }
        }
    }
}
