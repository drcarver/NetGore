using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;
using D20.Core.Interfaces;

namespace D20.Core.Abilities;

public abstract class AbilityBase : DataObject, IAbilityBase
{
    #region Modifer Table
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
    //32–33	+11	—	3	3	3	2	2	2	2	1	1
    //34–35	+12	—	3	3	3	3	2	2	2	2	1
    //36–37	+13	—	4	3	3	3	3	2	2	2	2
    //38–39	+14	—	4	4	3	3	3	3	2	2	2
    //40–41	+15	—	4	4	4	3	3	3	3	2	2
    //42–43	+16	—	4	4	4	4	3	3	3	3	2
    //44–45	+17	—	5	4	4	4	4	3	3	3	3    /// <summary>
    public List<AbilityModifierTableEntry> ModifierTable { get; private set; } =
    [
        //1	-5	Can’t cast spells tied to this ability
        new AbilityModifierTableEntry
        {
            Score = new Range(1, 1),
            Modifier = -5,
            BonusSpells = null,

        },
        //2–3	-4	Can’t cast spells tied to this ability
        new AbilityModifierTableEntry
        {
            Score = new Range(2, 3),
            Modifier = -4,
            BonusSpells = null,
        },
        //4–5	-3	Can’t cast spells tied to this ability
        new AbilityModifierTableEntry
        {
            Score = new Range(4, 5),
            Modifier = -3,
            BonusSpells = null,
        },
        //6–7	-2	Can’t cast spells tied to this ability
        new AbilityModifierTableEntry
        {
            Score = new Range(6, 7),
            Modifier = -2,
            BonusSpells = null,
        },
        //8–9	-1	Can’t cast spells tied to this ability
        new AbilityModifierTableEntry
        {
            Score = new Range(8, 9),
            Modifier = -1,
            BonusSpells = null,
        },
        //10–11	+0	—	—	—	—	—	—	—	—	—	—
        new AbilityModifierTableEntry
        {
            Score = new Range(10, 11),
            Modifier = 0,
            BonusSpells = [0,0,0,0,0,0,0,0,0],
        },
        //12–13	+1	—	1	—	—	—	—	—	—	—	—
        new AbilityModifierTableEntry
        {
            Score = new Range(12, 13),
            Modifier = 1,
            BonusSpells = [1,0,0,0,0,0,0,0,0],
        },
        //14–15	+2	—	1	1	—	—	—	—	—	—	—
        new AbilityModifierTableEntry
        {
            Score = new Range(14, 15),
            Modifier = 2,
            BonusSpells = [1,1,0,0,0,0,0,0,0],
        },
        //16–17	+3	—	1	1	1	—	—	—	—	—	—
        new AbilityModifierTableEntry
        {
            Score = new Range(16, 17),
            Modifier = 3,
            BonusSpells = [1,1,1,0,0,0,0,0,0],
        },
        //18–19	+4	—	1	1	1	1	—	—	—	—	—
        new AbilityModifierTableEntry
        {
            Score = new Range(18, 19),
            Modifier = 4,
            BonusSpells = [1,1,1,1,0,0,0,0,0],
        },
        //20–21	+5	—	2	1	1	1	1	—	—	—	—
        new AbilityModifierTableEntry
        {
            Score = new Range(20, 21),
            Modifier = 5,
            BonusSpells = [2,1,1,1,1,0,0,0,0],
        },
        //22–23	+6	—	2	2	1	1	1	1	—	—	—
        new AbilityModifierTableEntry
        {
            Score = new Range(22, 23),
            Modifier = 6,
            BonusSpells = [2,2,1,1,1,1,0,0,0],
        },
        //24–25	+7	—	2	2	2	1	1	1	1	—	—
        new AbilityModifierTableEntry
        {
            Score = new Range(24, 25),
            Modifier = 7,
            BonusSpells = [2,2,2,1,1,1,1,0,0],
        },
        //26–27	+8	—	2	2	2	2	1	1	1	1	—
        new AbilityModifierTableEntry
        {
            Score = new Range(26, 27),
            Modifier = 8,
            BonusSpells = [2,2,2,2,1,1,1,1,0],
        },
        //28–29	+9	—	3	2	2	2	2	1	1	1	1
        new AbilityModifierTableEntry
        {
            Score = new Range(28, 29),
            Modifier = 9,
            BonusSpells = [3,2,2,2,2,1,1,1,1],
        },
        //30–31	+10	—	3	3	2	2	2	2	1	1	1
        new AbilityModifierTableEntry
        {
            Score = new Range(30, 31),
            Modifier = 10,
            BonusSpells = [3,3,2,2,2,2,1,1,1],
        },
        //32–33	+11	—	3	3	3	2	2	2	2	1	1
        new AbilityModifierTableEntry
        {
            Score = new Range(32, 33),
            Modifier = 11,
            BonusSpells = [3,3,3,2,2,2,2,1,1],
        },
        //34–35	+12	—	3	3	3	3	2	2	2	2	1
        new AbilityModifierTableEntry
        {
            Score = new Range(34, 35),
            Modifier = 12,
            BonusSpells = [3,3,3,3,2,2,2,2,1],
        },
        //36–37	+13	—	4	3	3	3	3	2	2	2	2
        new AbilityModifierTableEntry
        {
            Score = new Range(36, 37),
            Modifier = 13,
            BonusSpells = [4,3,3,3,3,2,2,2,2],
        },
        //38–39	+14	—	4	4	3	3	3	3	2	2	2
        new AbilityModifierTableEntry
        {
            Score = new Range(38, 39),
            Modifier = 14,
            BonusSpells = [4,4,3,3,3,3,2,2,2],
        },
        //40–41	+15	—	4	4	4	3	3	3	3	2	2
        new AbilityModifierTableEntry
        {
            Score = new Range(40, 41),
            Modifier = 15,
            BonusSpells = [4,4,4,3,3,3,3,2,2],
        },
        //42–43	+16	—	4	4	4	4	3	3	3	3	2
        new AbilityModifierTableEntry
        {
            Score = new Range(42, 43),
            Modifier = 16,
            BonusSpells = [4,4,4,4,3,3,3,3,2],
        },
        //44–45	+17	—	5	4	4	4	4	3	3	3	3    /// <summary>
        new AbilityModifierTableEntry
        {
            Score = new Range(44, 45),
            Modifier = 17,
            BonusSpells = [5,4,4,4,4,3,3,3,3],
        },
    ];
    #endregion

    /// <summary>
    /// The creature with this ability
    /// </summary>
    public ICreature Creature { get; }

    /// <summary>
    /// The base ability from the total of dice roll
    /// </summary>
    public int BaseAbility { get; private set; }

    /// <summary>
    /// The separate dice rolls
    /// </summary>
    public int[]? Rolls { get; private set; }

    /// <summary>
    /// The abbreviation for the ability
    /// </summary>
    public string Abbreviation { get; protected set; } = string.Empty;

    /// <summary>
    /// Any racial modifiers
    /// </summary>
    public int RacialModifier { get; set; } = 0;

    /// <summary>
    /// Temporary modifiers
    /// </summary>
    public int TemporaryModifier { get; set; } = 0;

    /// <summary>
    /// The reason for the modifier
    /// </summary>
    public string ModifierDescription { get; internal set; } = string.Empty;

    /// <summary>
    /// The ability scores with all modifiers
    /// </summary>
    /// <returns>The current ability score with all modifiers</returns>
    public int Score()
    {
        return BaseAbility
            + RacialModifier
            + GetModifier().Modifier
            + TemporaryModifier;
    }

    /// <summary>
    /// Get the modifier for this ability score from
    /// the ability modifier table
    /// </summary>
    /// <returns>The modifier for this score</returns>
    public AbilityModifierTableEntry GetModifier()
    {
        return ModifierTable.First(t =>
                        t.Score.Start.Value >= Score()
                     && t.Score.End.Value <= Score());
    }

    /// <summary>
    /// Return the Ability as a string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        var retval = Abbreviation + " ";
        for (int i = 0; i < Rolls?.Length; i++)
        {
            retval += $"Dice{i}={Rolls[i]} ";
        }
        // BaseAbility + RacialModifier + TemporaryModifier
        retval += $"BaseAbility({BaseAbility}) + ";
        retval += $"RacialModifier({RacialModifier}) + ";
        retval += $"TemporaryModifier({TemporaryModifier}) = ";
        retval += $"AbilityModifier({GetModifier().Modifier}) = ";
        retval += $" Total({Score()})";
        return retval;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature">The creature that has this ability</param>
    [SetsRequiredMembers]
    public AbilityBase(ICreature creature)
    {
        var dice = new Dice("4d6");
        Rolls = new int[3];
        for (int i = 0; i <= 2; i++)
        {
            Rolls[i] = dice.Rolls[i];
        }
        BaseAbility = Rolls.Sum();
        Creature = creature;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="baseAbility">The ability score.  We are not randomly generating it</param>
    /// <param name="creature">The creature that has this ability</param>
    [SetsRequiredMembers]
    public AbilityBase(int baseAbility, ICreature creature)
        : this(creature)
    {
        Rolls = null;
        BaseAbility = baseAbility;
    }
}
