using GoDungeon.Character.Interfaces;

namespace GoDungeon.Character.PC.Rogue
{
    public interface IRogueFeatureLevelEntry : IClassFeatureLevelEntry
    {
        /// <summary>
        /// Beginning at 1st level, you know how to strike subtly
        /// and exploit a foe’s distraction. Once per turn, you can
        /// deal an extra 1d6 damage to one creature you hit
        /// with an attack if you have advantage on the attack
        /// roll.The attack must use a finesse or a ranged
        /// weapon.
        /// </summary>
        string SneakAttack { get; set; }
    }

}
