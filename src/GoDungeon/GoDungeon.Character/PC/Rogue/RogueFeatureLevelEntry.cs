using System.Diagnostics.CodeAnalysis;

using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC.Rogue;

public class RogueFeatureLevelEntry : ClassFeatureLevelEntryViewModel, IRogueFeatureLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public RogueFeatureLevelEntry()
    {
    }

    /// <summary>
    /// Beginning at 1st level, you know how to strike subtly
    /// and exploit a foe’s distraction. Once per turn, you can
    /// deal an extra 1d6 damage to one creature you hit
    /// with an attack if you have advantage on the attack
    /// roll.The attack must use a finesse or a ranged
    /// weapon.
    /// </summary>
    public string SneakAttack { get; set; } = "1D6";
}
