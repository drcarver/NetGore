using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Tables
{
    /// <summary>
    /// Misc.Acrobatics Modifiers
    /// </summary>
    public class AcrobaticsModifierTable : NamedTable, IAcrobaticsModifiersTable
    {
        /// <summary>
        /// Alignment Table
        /// </summary>
        public AcrobaticsModifierTable()
        {
            Name = nameof(AcrobaticsModifierTable);
            ProperName = "Misc. Acrobatics Modifiers";
            Description = "The following modifiers apply to all Acrobatics skill checks. The modifiers stack with one another, but only the most severe modifier for any given condition applies.";
            TableType = TableTypeEnum.CoreTable;
        }

        //Table: Misc.Acrobatics Modifiers
        //Acrobatics Modifiers    DC Modifier
        //Lightly Obstructed(gravel, sand)   +2
        //Severely Obstructed(cavern, rubble)    +5
        //Slightly Slippery(wet) +2
        //Severely Slippery(icy) +5
        //Slightly Sloped(<45°)  +2
        //Severely Sloped(>45°)  +5
        //Slightly Unsteady(boat in rough water) +2
        //Mildly Unsteady(boat in a storm)   +5
        //Severely Unsteady(earthquake)  +10
        //Move at full speed on narrow or uneven surfaces	+51
        //1 This does not apply to checks made to jump.
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
                    #region Lightly Obstructed(gravel, sand)   +2
                    //Lightly Obstructed(gravel, sand)   +2
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.LightlyObstructed),
                        ProperName = "Lightly Obstructed(gravel, sand)",
                        DifficultyCheckModifier = 2,
                    },
                    #endregion

                    #region Severely Obstructed(cavern, rubble)    +5
                    //Severely Obstructed(cavern, rubble)    +5
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.SeverelyObstructed),
                        ProperName = "Severely Obstructed(cavern, rubble)",
                        DifficultyCheckModifier = 5,
                    },
                    #endregion

                    #region Slightly Slippery(wet) +2
                    //Slightly Slippery(wet) +2
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.SlightlySlippery),
                        ProperName = "Slightly Slippery(wet)",
                        DifficultyCheckModifier = 2,
                    },
                    #endregion

                    #region Severely Slippery(icy) +5
                    //Severely Slippery(icy) +5
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.SeverelySlippery),
                        ProperName = "Severely Slippery(icy)",
                        DifficultyCheckModifier = 5,
                    },
                    #endregion

                    #region Slightly Sloped(<45°)  +2
                    //Slightly Sloped(<45°)  +2
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.SlightlySloped),
                        ProperName = "Slightly Sloped(<45°)",
                        DifficultyCheckModifier = 2,
                    },
                    #endregion

                    #region Severely Sloped(>45°)  +5
                    //Severely Sloped(>45°)  +5
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.SeverelySloped),
                        ProperName = "Severely Sloped(>45°)",
                        DifficultyCheckModifier = 5,
                    },
                    #endregion

                    #region Slightly Unsteady(boat in rough water) +2
                    //Slightly Unsteady(boat in rough water) +2
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.SlightlyUnsteady),
                        ProperName = "Slightly Unsteady(boat in rough water)",
                        DifficultyCheckModifier = 2,
                    },
                    #endregion

                    #region Mildly Unsteady(boat in a storm)   +5
                    //Mildly Unsteady(boat in a storm)   +5
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.MildlyUnsteady),
                        ProperName = "Mildly Unsteady (boat in a storm)",
                        DifficultyCheckModifier = 5,
                    },
                    #endregion

                    #region Severely Unsteady(earthquake)  +10
                    //Severely Unsteady(earthquake)  +10
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.SeverelyUnsteady),
                        ProperName = "Severely Unsteady (earthquake)",
                        DifficultyCheckModifier = 10,
                    },
                    #endregion

                    #region Move at full speed on narrow or uneven surfaces	+5
                    //Move at full speed on narrow or uneven surfaces	+5
                    new AcrobaticsModifierViewModel
                    {
                        Name = nameof(AcrobaticsModifiersEnum.MoveAtFullSpeedOnNarrowOrUnevenSurfaces),
                        ProperName = "Move at full speed on narrow or uneven surfaces",
                        DifficultyCheckModifier = 5,
                        Description =
                            "Move at full speed on narrow or uneven " +
                            "surfaces.  This does not apply to checks " +
                            "made to jump."
                    },
                    #endregion
                } ;
            }
        }
    }
}
