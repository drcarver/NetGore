using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Abilities;
using NetGore.Core.Base;

namespace NetGore.Core.Models;

/// <summary>
/// Hit points are an abstraction signifying how 
/// robust and healthy a creature is at the current 
/// moment. To determine a creature’s hit points, 
/// roll the dice indicated by its Hit Dice. A 
/// creature gains maximum hit points if its first 
/// Hit Die roll is for a character class level. 
/// Creatures whose first Hit Die comes from an NPC 
/// class or from his race roll their first Hit Die 
/// normally. Wounds subtract hit points, while 
/// healing (both natural and magical) restores 
/// hit points. Some abilities and spells grant 
/// temporary hit points that disappear after a 
/// specific duration. When a creature’s hit points 
/// drop below 0, it becomes unconscious. When a 
/// creature’s hit points reach a negative total 
/// equal to its Constitution score, it dies.
/// </summary>
public class HitPoints : DataObject
{
    /// <summary>
    /// The hit dice for this hit points
    /// </summary>
    public string HitDice = string.Empty;

    /// <summary>
    /// Creature with these Hit points 
    /// </summary>
    public Guid CreatureId { get; }

    /// <summary>
    /// The Hit dice per level
    /// </summary>
    private List<int> LevelDice { set; get; } = [];

    /// <summary>
    /// Modifiers based on the characters constitution
    /// </summary>
    public Constitution Constitution { get; set; }

    /// <summary>
    /// Raging as an example 
    /// </summary>
    public int TemporaryBonus {  get; set; } = 0;

    /// <summary>
    /// The computed hit points with all bonuses
    /// </summary>
    /// <returns>The computed hit points</returns>
    public int HP()
    {
        int hitpoints = TemporaryBonus;
        foreach (var hitpoint in LevelDice)
        {
            hitpoints += hitpoint;
        }
        hitpoints += LevelDice.Count() * Constitution.Score();
        return hitpoints;
    }

    /// <summary>
    /// The constructor
    /// </summary>
    [SetsRequiredMembers]
    public HitPoints(string hitDie, Creature creature) 
    {
        // Save off the hit dice (for example: 1d8)
        HitDice = hitDie;

        // First level is max hit die
        LevelDice.Add(new Dice(hitDie).Sides);

        // Tied to the constitution score and Creature Id
        CreatureId = creature.Id;
        Constitution = creature.Constitution;

        // Description
        Name = "Hit Points";
        Description = "Hit points are an abstraction " +
            "signifying how robust and healthy a " +
            "creature is at the current moment. To " +
            "determine a creature’s hit points, roll " +
            "the dice indicated by its Hit Dice. A " +
            "creature gains maximum hit points if " +
            "its first Hit Die roll is for a " +
            "character class level. Creatures whose " +
            "first Hit Die comes from an NPC class " +
            "or from his race roll their first " +
            "Hit Die normally. Wounds subtract hit " +
            "points, while healing (both natural " +
            "and magical) restores hit points. Some "+
            "abilities and spells grant temporary " +
            "hit points that disappear after a " +
            "specific duration. When a creature’s " +
            "hit points drop below 0, it becomes " +
            "unconscious. When a creature’s hit " +
            "points reach a negative total equal " +
            "to its Constitution score, it dies.";
    }
}
