using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Character.Tables;

/// <summary>
/// It’s said that something wild lurks in the heart of
/// every soul, a space that thrills to the sound of geese
/// calling at night, to the whispering wind through the
/// pines, to the unexpected red of mistletoe on an
/// oak—and it is in this space that the Celtic gods dwell. 
/// They sprang from the brook and stream, their might
/// heightened by the strength of the oak and the beauty
/// of the woodlands and open moor. When the first
/// forester dared put a name to the face seen in the
/// bole of a tree or the voice babbling in a brook, these
/// gods forced themselves into being.
/// <para>
/// The Celtic gods are as often served by druids as by
/// clerics, for they are closely aligned with the forces of
/// nature that druids revere.
/// </para>
/// </summary>
public class CelticDeitiesTable : NamedTable, ICelticDeitiesTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public CelticDeitiesTable()
    {
        Name = nameof(CelticDeitiesTable);
        ProperName = "Celtic Deities";
        TableType = TableTypeEnum.PantheonTable;
        Description =
            "It’s said that something wild lurks in the heart of " +
            "every soul, a space that thrills to the sound of geese " +
            "calling at night, to the whispering wind through the " +
            "pines, to the unexpected red of mistletoe on an " +
            "oak—and it is in this space that the Celtic gods dwell. " +
            "They sprang from the brook and stream, their might " +
            "heightened by the strength of the oak and the beauty " +
            "of the woodlands and open moor. When the first " +
            "forester dared put a name to the face seen in the " +
            "bole of a tree or the voice babbling in a brook, these " +
            "gods forced themselves into being.";
    }


    /// <summary>
    /// Initialize the game table.  This is a seperate method so we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of optimiation to conserve memeory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region The Daghdha
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.TheDaghdha),
                ProperName = "The Daghdha",
                Description = "God of weather and crops.",
                Alignment = AlignmentEnum.ChaoticGood,
                Symbol = "Bubbling cauldron or shield",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Ranger,
                ],
            },
            #endregion

            #region Arawn
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Arawn),
                ProperName = "Arawn",
                Description = "God of life and death",
                Alignment = AlignmentEnum.NeutralEvil,
                Symbol = "Black star on gray background",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Cleric,
                    ClassEnum.Druid,
                    ClassEnum.Fighter,
                    ClassEnum.Rogue,
                    ClassEnum.Ranger,
                    ClassEnum.Warlock,
                ],
            },
            #endregion

            #region Belenus
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Belenus),
                ProperName = "Belenus",
                Description = "God of sun",
                Alignment = AlignmentEnum.NeutralGood,
                Symbol = "Solar disk and standing stones",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Fighter,
                    ClassEnum.Ranger,
                    ClassEnum.Druid
                ],
            },
            #endregion

            #region Brigantia
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Brigantia),
                ProperName = "Brigantia",
                Description = "Goddess of  rivers and livestock",
                Alignment = AlignmentEnum.NeutralGood,
                Symbol = "Footbridge",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Fighter,
                    ClassEnum.Ranger,
                    ClassEnum.Druid,
                    ClassEnum.Warlock,
                    ClassEnum.Wizard,
                ],
            },
            #endregion

            #region Diancecht
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Diancecht),
                ProperName = "Diancecht",
                Description = "God of  medicine and healing",
                Alignment = AlignmentEnum.LawfulGood,
                Symbol = "Crossed oak and mistletoe branches",
                SuggestedClasses =
                [
                    ClassEnum.Paladin,
                    ClassEnum.Monk,
                    ClassEnum.Cleric,
                    ClassEnum.Fighter,
                    ClassEnum.Ranger,
                    ClassEnum.Druid,
                    ClassEnum.Wizard,
                ],
            },
            #endregion

            #region Dunatis
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Dunatis),
                ProperName = "Dunatis",
                Description = "God of  mountains and peaks",
                Alignment = AlignmentEnum.Neutral,
                Symbol = "Red sun-capped mountain peak",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Fighter,
                    ClassEnum.Ranger,
                    ClassEnum.Druid
                ],
            },
            #endregion

            #region Goibhniu
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Goibhniu),
                ProperName = "Goibhniu",
                Description = "God of smiths  and healing",
                Alignment = AlignmentEnum.NeutralGood,
                Symbol = "Giant mallet over sword",
                SuggestedClasses =
                [
                    ClassEnum.Cleric,
                    ClassEnum.Fighter,
                    ClassEnum.Ranger,
                    ClassEnum.Druid,
                    ClassEnum.Warlock,
                    ClassEnum.Wizard,
                ],
            },
            #endregion

            #region Lugh
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Lugh),
                ProperName = "Lugh",
                Description = "god of arts, travel, and commerce",
                Alignment = AlignmentEnum.ChaoticNeutral,
                Symbol = "Pair of long hands",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Bard,
                    ClassEnum.Rogue,
                    ClassEnum.Sorcerer,
                 ],
            },
            #endregion

            #region Manannan mac Lir
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.ManannanmacLir),
                ProperName = "Manannan mac Lir",
                Description = "God of oceans and sea creatures",
                Alignment = AlignmentEnum.LawfulNeutral,
                Symbol = "Wave of white water on green",
                SuggestedClasses =
                [
                    ClassEnum.Monk,
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Sorcerer,
                    ClassEnum.Warlock,
                ],
            },
            #endregion

            #region Math Mathonwy
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.MathMathonwy),
                ProperName = "Math Mathonwy",
                Description = "God of magic",
                Alignment = AlignmentEnum.NeutralEvil,
                Symbol = "Staff",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Fighter,
                    ClassEnum.Ranger,
                    ClassEnum.Rogue,
                    ClassEnum.Sorcerer,
                    ClassEnum.Warlock,
                    ClassEnum.Wizard,
                ],
            },
            #endregion

            #region Morrigan
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Morrigan),
                ProperName = "Morrigan",
                Description = "Goddess of battle",
                Alignment = AlignmentEnum.ChaoticEvil,
                Symbol = "Two crossed spears",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Fighter,
                    ClassEnum.Ranger,
                    ClassEnum.Rogue,
                    ClassEnum.Sorcerer,
                    ClassEnum.Warlock,
                    ClassEnum.Wizard,
                ],
            },
            #endregion

            #region Nuada
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Nuada),
                ProperName = "Nuada",
                Description = "God of War",
                Alignment = AlignmentEnum.Neutral,
                Symbol = "Silver hand on black background",
                SuggestedClasses =
                [
                    ClassEnum.Barbarian,
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Fighter,
                    ClassEnum.Ranger,
                    ClassEnum.Rogue,
                ],
            },
            #endregion

            #region Oghma
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Oghma),
                ProperName = "Oghma",
                Description = "God of speech and writing",
                Alignment = AlignmentEnum.NeutralGood,
                Symbol = "Unfurled scroll",
                SuggestedClasses =
                [
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Sorcerer,
                    ClassEnum.Warlock,
                    ClassEnum.Wizard,
                ],
            },
            #endregion

            #region Silvanus
            new DeityTableEntry
            {
                Name = nameof(CelticDeitiesEnum.Silvanus),
                ProperName = "Silvanus",
                Description = "God of nature and forests",
                Alignment = AlignmentEnum.Neutral,
                Symbol = "Summer oak tree",
                SuggestedClasses =
                [
                    ClassEnum.Bard,
                    ClassEnum.Cleric,
                    ClassEnum.Druid,
                    ClassEnum.Barbarian,
                    ClassEnum.Fighter,
                    ClassEnum.Sorcerer,
                    ClassEnum.Warlock,
                    ClassEnum.Wizard,
                ],
            },
            #endregion
        ];
    }
}
