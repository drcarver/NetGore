using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.Spells.Enum;

namespace GoDungeon.Spells.Tables.Bard
{
    public class BardFirstLevelSpellTable : NamedTable, IBardFirstLevelSpellTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BardFirstLevelSpellTable()
        {
            Name = nameof(BardCantripSpellTable);
            ProperName = "Bard First Level Spells";
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
                    #region Animal Friendship
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.AnimalFriendship),
                        ProperName = "Animal Friendship",
                    },
                    #endregion

                    #region Bane
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Bane),
                        ProperName = "Bane",
                    },
                    #endregion

                    #region Charm Person
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.CharmPerson),
                        ProperName = "Charm Person",
                    },
                    #endregion

                    #region Comprehend Languages
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.ComprehendLanguages),
                        ProperName = "Comprehend Languages",
                    },
                    #endregion

                    #region Cure Wounds
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.CureWounds),
                        ProperName = "Cure Wounds",
                    },
                    #endregion

                    #region Detect Magic
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.DetectMagic),
                        ProperName = "Detect Magic",
                    },
                    #endregion

                    #region Disguise Self
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.DisguiseSelf),
                        ProperName = "Disguise Self",
                    },
                    #endregion

                    #region Faerie Fire
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.FaerieFire),
                        ProperName = "Faerie Fire",
                    },
                    #endregion

                    #region Feather Fall
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.FeatherFall),
                        ProperName = "Feather Fall",
                    },
                    #endregion

                    #region Healing Word
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.HealingWord),
                        ProperName = "Healing Word",
                    },
                    #endregion

                    #region Heroism
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Heroism),
                        ProperName = "Heroism",
                    },
                    #endregion

                    #region Hideous Laughter
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.HideousLaughter),
                        ProperName = "Hideous Laughter",
                    },
                    #endregion

                    #region Identify
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Identify),
                        ProperName = "Identify",
                    },
                    #endregion

                    #region Illusory Script
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.IllusoryScript),
                        ProperName = "Illusory Script",
                    },
                    #endregion

                    #region Longstrider
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Longstrider),
                        ProperName = "Longstrider",
                    },
                    #endregion

                    #region Silent Image
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.SilentImage),
                        ProperName = "Silent Image",
                    },
                    #endregion

                    #region Sleep
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Sleep),
                        ProperName = "Sleep",
                    },
                    #endregion

                    #region Speak with Animals
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.SpeakwithAnimals),
                        ProperName = "Speak with Animals",
                    },
                    #endregion

                    #region Thunderwave
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.Thunderwave),
                        ProperName = "Thunderwave",
                    },
                    #endregion

                    #region Unseen Servant
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(SpellEnum.UnseenServant),
                        ProperName = "Unseen Servant",
                    },
                    #endregion
                };
            }
        }
    }
}
