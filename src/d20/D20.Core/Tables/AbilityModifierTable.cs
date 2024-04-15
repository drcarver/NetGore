using System.Diagnostics.CodeAnalysis;

using D20.Core.Abilities;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core.Tables;

/// <summary>
/// The ability modifier table.  
/// </summary>
public class AbilityModifierTable : GameTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityModifierTable()
    {
        Name = nameof(AbilityModifierTable);
        ProperName = "Ability Modifiers Table";
        TableType = TableTypeEnum.CharacterTable;
    }

    //Table: Ability Modifiers
    //Ability Score Modifier
    //0th
    //1	-5
    //2–3	-4
    //4–5	-3
    //6–7	-2
    //8–9	-1
    //10–11	+0
    //12–13	+1
    //14–15	+2
    //16–17	+3
    //18–19	+4
    //20–21	+5
    //22–23	+6
    //24–25	+7
    //26–27	+8
    //28–29	+9
    //30–31	+10
    /// <summary>
    /// Initialize the game table.  This is a seperate method so we can create a game table for it;s meta properties
    /// with out creating the table.  A bit of optimiation to conserve memeory
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            //1	-5
            new AbilityBonusEntry
            {
                Score = new Range(1, 1),
                Modifier = -5,
             },
            //2–3	-4
            new AbilityBonusEntry
            {
                Score = new Range(2, 3),
                Modifier = -4,
            },
            //4–5	-3
            new AbilityBonusEntry
            {
                Score = new Range(4, 5),
                Modifier = -3,
            },
            //6–7	-2
            new AbilityBonusEntry
            {
                Score = new Range(6, 7),
                Modifier = -2,
            },
            //8–9	-1
            new AbilityBonusEntry
            {
                Score = new Range(8, 9),
                Modifier = -1,
            },
            //10–11	+0
            new AbilityBonusEntry
            {
                Score = new Range(10, 11),
                Modifier = 0,
            },
            //12–13	+1
            new AbilityBonusEntry
            {
                Score = new Range(12, 13),
                Modifier = 1,
            },
            //14–15	+2
            new AbilityBonusEntry
            {
                Score = new Range(14, 15),
                Modifier = 2,
            },
            //16–17	+3
            new AbilityBonusEntry
            {
                Score = new Range(16, 17),
                Modifier = 3,
            },
            //18–19	+4
            new AbilityBonusEntry
            {
                Score = new Range(18, 19),
                Modifier = 4,
            },
            //20–21	+5
            new AbilityBonusEntry
            {
                Score = new Range(20, 21),
                Modifier = 5,
            },
            //22–23	+6
            new AbilityBonusEntry
            {
                Score = new Range(22, 23),
                Modifier = 6,
            },
            //24–25	+7
            new AbilityBonusEntry
            {
                Score = new Range(24, 25),
                Modifier = 7,
            },
            //26–27	+8
            new AbilityBonusEntry
            {
                Score = new Range(26, 27),
                Modifier = 8,
            },
            //28–29	+9
            new AbilityBonusEntry
            {
                Score = new Range(28, 29),
                Modifier = 9,
            },
            //30–31	+10
            new AbilityBonusEntry
            {
                Score = new Range(30, 31),
                Modifier = 10,
            },
        ];
    }
}