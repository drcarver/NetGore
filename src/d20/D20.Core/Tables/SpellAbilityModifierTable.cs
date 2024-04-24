using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using D20.Core.Abilities;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core.Tables
{
    /// <summary>
    /// The gender table.  
    /// </summary>
    public class SpellAbilityModifierTable : GameTable, ISpellAbilityModifierTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SpellAbilityModifierTable()
        {
            Name = nameof(SpellAbilityModifierTable);
            ProperName = "Ability Modifiers and Bonus Spells Table";
            TableType = TableTypeEnum.CharacterTable;
        }

        //Table: Ability Modifiers and Bonus Spells
        //Ability Score Modifier    Bonus Spells per Day(by Spell Level)
        //0th	1st	2nd	3rd	4th	5th	6th	7th	8th	9th
        //1	-5	Can’t cast spells tied to this ability
        //2–3	-4	Can’t cast spells tied to this ability
        //4–5	-3	Can’t cast spells tied to this ability
        //6–7	-2	Can’t cast spells tied to this ability
        //8–9	-1	Can’t cast spells tied to this ability
        //10–11	+0	—	—	—	—	—	—	—	—	—	—
        //12–13	+1	—	1	—	—	—	—	—	—	—	—
        //14–15	+2	—	1	1	—	—	—	—	—	—	—
        //16–17	+3	—	1	1	1	—	—	—	—	—	—
        //18–19	+4	—	1	1	1	1	—	—	—	—	—
        //20–21	+5	—	2	1	1	1	1	—	—	—	—
        //22–23	+6	—	2	2	1	1	1	1	—	—	—
        //24–25	+7	—	2	2	2	1	1	1	1	—	—
        //26–27	+8	—	2	2	2	2	1	1	1	1	—
        //28–29	+9	—	3	2	2	2	2	1	1	1	1
        //30–31	+10	—	3	3	2	2	2	2	1	1	1
        /// <summary>
        /// Initialize the game table.  This is a separate method 
        /// so we can create a game table for it;s meta properties
        /// with out creating the table.  A bit of optimization to 
        /// conserve memory
        /// </summary>
        public override void InitializeTable()
        {
            if (Table.Count == 0)
            {
                Table = new List<IGameTableEntry>
                {
                    //1	-5	Can’t cast spells tied to this ability
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(1, 1),
                        Modifier = -5,
                        BonusSpells = null,

                    },
                    //2–3	-4	Can’t cast spells tied to this ability
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(2, 3),
                        Modifier = -4,
                        BonusSpells = null,
                    },
                    //4–5	-3	Can’t cast spells tied to this ability
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(4, 5),
                        Modifier = -3,
                        BonusSpells = null,
                    },
                    //6–7	-2	Can’t cast spells tied to this ability
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(6, 7),
                        Modifier = -2,
                        BonusSpells = null,
                    },
                    //8–9	-1	Can’t cast spells tied to this ability
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(8, 9),
                        Modifier = -1,
                        BonusSpells = null,
                    },
                    //10–11	+0	—	—	—	—	—	—	—	—	—	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(10, 11),
                        Modifier = 0,
                        BonusSpells = new int[] {0,0,0,0,0,0,0,0,0 },
                    },
                    //12–13	+1	—	1	—	—	—	—	—	—	—	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(12, 13),
                        Modifier = 1,
                        BonusSpells = new int[] {1,0,0,0,0,0,0,0,0 },
                    },
                    //14–15	+2	—	1	1	—	—	—	—	—	—	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(14, 15),
                        Modifier = 2,
                        BonusSpells = new int[] {1,1,0,0,0,0,0,0,0 },
                    },
                    //16–17	+3	—	1	1	1	—	—	—	—	—	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(16, 17),
                        Modifier = 3,
                        BonusSpells = new int[] {1,1,1,0,0,0,0,0,0 },
                    },
                    //18–19	+4	—	1	1	1	1	—	—	—	—	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(18, 19),
                        Modifier = 4,
                        BonusSpells = new int[] {1,1,1,1,0,0,0,0,0 },
                    },
                    //20–21	+5	—	2	1	1	1	1	—	—	—	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(20, 21),
                        Modifier = 5,
                        BonusSpells = new int[] {2,1,1,1,1,0,0,0,0 },
                    },
                    //22–23	+6	—	2	2	1	1	1	1	—	—	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(22, 23),
                        Modifier = 6,
                        BonusSpells = new int[] {2,2,1,1,1,1,0,0,0},
                    },
                    //24–25	+7	—	2	2	2	1	1	1	1	—	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(24, 25),
                        Modifier = 7,
                        BonusSpells = new int[] {2,2,2,1,1,1,1,0,0},
                    },
                    //26–27	+8	—	2	2	2	2	1	1	1	1	—
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(26, 27),
                        Modifier = 8,
                        BonusSpells = new int[] {2,2,2,2,1,1,1,1,0},
                    },
                    //28–29	+9	—	3	2	2	2	2	1	1	1	1
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(28, 29),
                        Modifier = 9,
                        BonusSpells = new int[] {3,2,2,2,2,1,1,1,1},
                    },
                    //30–31	+10	—	3	3	2	2	2	2	1	1	1
                    new AbilityBonusSpellEntry
                    {
                        Score = new Range(30, 31),
                        Modifier = 10,
                        BonusSpells = new int[] {3,3,2,2,2,1,1,1,1},
                    },
                };
            }
        }
    }
}