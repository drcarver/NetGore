using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Spells.Enum;
using D20.Spells.Interfaces;

namespace D20.Spells.Tables;

public class SpellsBeggingWithATable : NamedTable, ISpellsBeggingWithATable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public SpellsBeggingWithATable()
    {
        Name = nameof(SpellsBeggingWithATable);
        ProperName = "Spells Begging With the Letter A";
        TableType = TableTypeEnum.SpellTable;
        Description =
            "Spell book for all spells begging with the Letter A " +
            "for all spell casters";
    }

    /// <summary>
    /// Initialize the spell table.  This is a separate method so 
    /// we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// optimization to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region Acid Arrow
            new SpellTableEntry
            {
                Name = nameof(SpellEnum.AcidArrow),
                ProperName = "Acid Arrow",
                Level = SpellLevelEnum.SecondLevel,
                SpellType = "evocation",
                CastingTime = "1 action",
                SpellRange = "90 feet",
                SpellComponents = ["V", "S", "M (powdered rhubarb leaf and an adder’s stomach)"],
                SpellDuration = "Instantaneous",
            },
            #endregion
 
            #region Acid Splash
            new SpellTableEntry
            {
                Name = nameof(SpellEnum.AcidSplash),
                ProperName = "Acid Splash",
                Level = SpellLevelEnum.Cantrip,
                SpellType = "Conjuration",
                CastingTime = "1 action",
                SpellRange = "60 feet",
                SpellComponents = ["V", "S"],
                SpellDuration = "Instantaneous",
            },
            #endregion
 
            #region Aid
            new SpellTableEntry
            {
                Name = nameof(SpellEnum.Aid),
                ProperName = "Aid",
                Level = SpellLevelEnum.SecondLevel,
                SpellType = "abjuration",
                CastingTime = "1 action",
                SpellRange = "30 feet",
                SpellComponents = ["V", "S", "M (a tiny strip of white cloth)"],
                SpellDuration = "8 hours",
            },
            #endregion
 
            #region Alarm
            new SpellTableEntry
            {
                Name = nameof(SpellEnum.Alarm),
                ProperName = "Alarm",
                Level = SpellLevelEnum.FirstLevel,
                SpellType = "abjuration (ritual)",
                CastingTime = "1 minute",
                SpellRange = "30 feet",
                SpellComponents = ["V", "S", "M (a tiny bell and a piece of fine silver wire)"],
                SpellDuration = "8 hours",
            },
            #endregion
 
            #region Alter Self
            new SpellTableEntry
            {
                Name = nameof(SpellEnum.AlterSelf),
                ProperName = "Alter Self",
                Level = SpellLevelEnum.SecondLevel,
                SpellType = "transmutation",
                CastingTime = "1 action",
                SpellRange = "Self",
                SpellComponents = ["V", "S"],
                SpellDuration = "Concentration, up to 1 hour",
            },
            #endregion
        ];
    }
}

