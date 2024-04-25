using System.Collections.ObjectModel;

namespace GoDungeon.Core.Interfaces
{
    public interface IHitPoints
    {
        /// <summary>
        /// The hit dice for this hit points
        /// </summary>
        public string HitDice { get; set; }

        /// <summary>
        /// Creature with these Hit points 
        /// </summary>
        public ICreature Creature { get; set; }

        /// <summary>
        /// The Hit dice per level
        /// </summary>
        public ObservableCollection<int> LevelDice { get; set; }

        /// <summary>
        /// Hit the hit point base (when a creature is created
        /// with a determined number of hit points).
        /// </summary>
        public int HitPointBase { get; set; }

        /// <summary>
        /// Modifiers based on the characters constitution
        /// </summary>
        public IAbilityBase Constitution { get; set; }

        /// <summary>
        /// Raging as an example 
        /// </summary>
        public int TemporaryBonus { get; set; }

        /// <summary>
        /// The computed hit points with all bonuses
        /// </summary>
        /// <returns>The computed hit points</returns>
        public int HP();
    }
}