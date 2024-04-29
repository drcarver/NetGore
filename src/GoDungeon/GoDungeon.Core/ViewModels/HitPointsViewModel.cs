using System.Collections.ObjectModel;
using System.Linq;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Abilities;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
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
    public partial class HitPointsViewModel : DataObjectViewModel, IHitPoints
    {
        /// <summary>
        /// The hit dice for this hit points
        /// </summary>
        [ObservableProperty]
        private string hitDice = string.Empty;

        /// <summary>
        /// Creature with these Hit points 
        /// </summary>
        [ObservableProperty]
        private ICreature creature;

        /// <summary>
        /// The Hit dice per level
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<int> levelDice = new ObservableCollection<int>();

        /// <summary>
        /// Hit the hit point base (when a creature is created
        /// with a determined number of hit points).
        /// </summary>
        [ObservableProperty]
        private int hitPointBase;

        /// <summary>
        /// Modifiers based on the characters constitution
        /// </summary>
        [ObservableProperty]
        private IAbilityBase constitution;

        /// <summary>
        /// Raging as an example 
        /// </summary>
        [ObservableProperty]
        private int temporaryBonus = 0;

        /// <summary>
        /// The computed hit points with all bonuses
        /// </summary>
        /// <returns>The computed hit points</returns>
        public int HP()
        {
            int hitPoints = TemporaryBonus;
            if (LevelDice != null)
            {
                foreach (var hitPoint in LevelDice)
                {
                    hitPoints += hitPoint;
                }
                hitPoints += LevelDice.Count() * Constitution.Score();
            }
            else
            {
                hitPoints += HitPointBase;
            }
            return hitPoints;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public HitPointsViewModel(ICreature creature)
        {
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
                "and magical) restores hit points. Some " +
                "abilities and spells grant temporary " +
                "hit points that disappear after a " +
                "specific duration. When a creature’s " +
                "hit points drop below 0, it becomes " +
                "unconscious. When a creature’s hit " +
                "points reach a negative total equal " +
                "to its Constitution score, it dies.";

            // Tied to the constitution score and Creature Id
            Creature = creature;
            Constitution = creature.Constitution;
        }

        /// <summary>
        /// The constructor
        /// </summary>
        public HitPointsViewModel(string hitDie, ICreature creature)
            : this(creature)
        {
            // Save off the hit dice (for example: 1d8)
            HitDice = hitDie;

            // First level is max hit die
            LevelDice.Add(new Dice(hitDie).Sides);
        }

        /// <summary>
        /// The constructor
        /// </summary>
        public HitPointsViewModel(int hitPoints, ICreature creature)
            : this(creature)
        {
            // Save off the hit dice (for example: 1d8)
            HitPointBase = hitPoints;
            HitDice = string.Empty;
        }
    }
}
