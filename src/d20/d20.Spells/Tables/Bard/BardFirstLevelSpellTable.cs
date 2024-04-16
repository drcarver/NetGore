using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Spells.Enum;

namespace D20.Spells.Tables.Bard;

public class BardFirstLevelSpellTable : GameTable, IBardFirstLevelSpellTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
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
        Table =
        [
            #region Animal Friendship
            new GameTableEntry
            {
                Name = nameof(SpellEnum.AnimalFriendship),
                ProperName = "Animal Friendship",
            },
            #endregion

            #region Bane
            new GameTableEntry
            {
                Name = nameof(SpellEnum.Bane),
                ProperName = "Bane",
            },
            #endregion

            #region Charm Person
            new GameTableEntry
            {
                Name = nameof(SpellEnum.CharmPerson),
                ProperName = "Charm Person",
            },
            #endregion

            #region Comprehend Languages
            new GameTableEntry
            {
                Name = nameof(SpellEnum.ComprehendLanguages),
                ProperName = "Comprehend Languages",
            },
            #endregion

            #region Cure Wounds
            new GameTableEntry
            {
                Name = nameof(SpellEnum.CureWounds),
                ProperName = "Cure Wounds",
            },
            #endregion

            #region Detect Magic
            new GameTableEntry
            {
                Name = nameof(SpellEnum.DetectMagic),
                ProperName = "Detect Magic",
            },
            #endregion

            #region Disguise Self
            new GameTableEntry
            {
                Name = nameof(SpellEnum.DisguiseSelf),
                ProperName = "Disguise Self",
            },
            #endregion

            #region Faerie Fire
            new GameTableEntry
            {
                Name = nameof(SpellEnum.FaerieFire),
                ProperName = "Faerie Fire",
            },
            #endregion

            #region Feather Fall
            new GameTableEntry
            {
                Name = nameof(SpellEnum.FeatherFall),
                ProperName = "Feather Fall",
            },
            #endregion

            #region Healing Word
            new GameTableEntry
            {
                Name = nameof(SpellEnum.HealingWord),
                ProperName = "Healing Word",
            },
            #endregion

            #region Heroism
            new GameTableEntry
            {
                Name = nameof(SpellEnum.Heroism),
                ProperName = "Heroism",
            },
            #endregion

            #region Hideous Laughter
            new GameTableEntry
            {
                Name = nameof(SpellEnum.HideousLaughter),
                ProperName = "Hideous Laughter",
            },
            #endregion

            #region Identify
            new GameTableEntry
            {
                Name = nameof(SpellEnum.Identify),
                ProperName = "Identify",
            },
            #endregion

            #region Illusory Script
            new GameTableEntry
            {
                Name = nameof(SpellEnum.IllusoryScript),
                ProperName = "Illusory Script",
            },
            #endregion

            #region Longstrider
            new GameTableEntry
            {
                Name = nameof(SpellEnum.Longstrider),
                ProperName = "Longstrider",
            },
            #endregion

            #region Silent Image
            new GameTableEntry
            {
                Name = nameof(SpellEnum.SilentImage),
                ProperName = "Silent Image",
            },
            #endregion

            #region Sleep
            new GameTableEntry
            {
                Name = nameof(SpellEnum.Sleep),
                ProperName = "Sleep",
            },
            #endregion

            #region Speak with Animals
            new GameTableEntry
            {
                Name = nameof(SpellEnum.SpeakwithAnimals),
                ProperName = "Speak with Animals",
            },
            #endregion

            #region Thunderwave
            new GameTableEntry
            {
                Name = nameof(SpellEnum.Thunderwave),
                ProperName = "Thunderwave",
            },
            #endregion

            #region Unseen Servant
            new GameTableEntry
            {
                Name = nameof(SpellEnum.UnseenServant),
                ProperName = "Unseen Servant",
            },
            #endregion
        ];
    }
}
