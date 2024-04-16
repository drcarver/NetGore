using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Spells.Enum;

namespace D20.Spells.Tables.Bard;

public class BardCantripSpellTable : GameTable, IBardCantripSpellTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
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
        Table =
        [
            #region Dancing Lights
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.DancingLights),
                ProperName = "Dancing Lights",
            },
            #endregion

            #region Light
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.Light),
                ProperName = "Light",
            },
            #endregion

            #region Mage Hand
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.MageHand),
                ProperName = "Mage Hand",
            },
            #endregion

            #region Mending
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.Mending),
                ProperName = "Mending",
            },
            #endregion

            #region Message
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.Message),
                ProperName = "Message",
            },
            #endregion

            #region Minor Illusion
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.MinorIllusion),
                ProperName = "Minor Illusion",
            },
            #endregion

            #region Prestidigitation
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.Prestidigitation),
                ProperName = "Prestidigitation",
            },
            #endregion

            #region True Strike
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.TrueStrike),
                ProperName = "True Strike",
            },
            #endregion

            #region Vicious Mockery
            new StandardTableEntry
            {
                Name = nameof(SpellEnum.ViciousMockery),
                ProperName = "Vicious Mockery",
            },
            #endregion
        ];
    }
}
